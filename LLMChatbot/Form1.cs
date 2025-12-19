using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http; 
using Newtonsoft.Json; 

namespace LLMChatbot
{
    public partial class Form1 : Form
    {
        // BURAYA KENDİ GOOGLE API KEY'İNİ YAPIŞTIR
        private const string ApiKey = "AIzaSyAJq5o0WS9yglAxkyWh0YbbmiVynA4ssJs";

        // Google Gemini API URL'si (Model: gemini-1.5-flash)
        private const string ApiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key=";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Gönder_button1_Click(object sender, EventArgs e)
        {
            string userMessage = txtMesaj.Text.Trim();
            if (string.IsNullOrEmpty(userMessage)) return;

            // 1. Kullanıcı mesajını ekrana yaz
            AppendChatText("Sen: " + userMessage, Color.DarkGreen);

            // Arayüzü hazırla
            txtMesaj.Clear();
            Gönder_button1.Enabled = false;
            Gönder_button1.Text = "Yazıyor...";

            try
            {
                // 2. Gemini API'den cevap al
                string botResponse = await GetGeminiResponse(userMessage);

                // 3. Bot cevabını ekrana yaz
                AppendChatText("Gemini: " + botResponse, Color.DarkSlateGray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Gönder_button1.Enabled = true;
                Gönder_button1.Text = "Gönder";
                txtMesaj.Focus();
            }
        }

       // Gemini API'ye İstek Atan Fonksiyon
        private async Task<string> GetGeminiResponse(string message)
        {
            using (HttpClient client = new HttpClient())
            {
                // Gemini için veri yapısını oluşturuyoruz
                var requestData = new GeminiRequest
                {
                    contents = new List<Content>
                    {
                        new Content
                        {
                            parts = new List<Part>
                            {
                                new Part { text = message }
                            }
                        }
                    }
                };

                // JSON'a çevir
                string jsonContent = JsonConvert.SerializeObject(requestData);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // URL'in sonuna API Key eklenir
                string fullUrl = ApiUrl + ApiKey;

                // İsteği Gönder (POST)
                var response = await client.PostAsync(fullUrl, httpContent);

                string responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API Hatası: {response.StatusCode} - {responseString}");
                }

                // Gelen cevabı çözümle (Deserialize)
                var responseData = JsonConvert.DeserializeObject<GeminiResponse>(responseString);

                // Cevap metnini ayıkla ve döndür
                // Gemini cevabı candidates -> content -> parts -> text yolunda saklar
                if (responseData.candidates != null && responseData.candidates.Count > 0)
                {
                    return responseData.candidates[0].content.parts[0].text;
                }

                return "Boş cevap döndü.";
            }
        }

        // Ekrana Yazı Yazma Fonksiyonu
        private void AppendChatText(string text, Color color)
        {
            ChatHistory_richTextBox1.SelectionStart = ChatHistory_richTextBox1.TextLength;
            ChatHistory_richTextBox1.SelectionLength = 0;
            ChatHistory_richTextBox1.SelectionColor = color;
            ChatHistory_richTextBox1.AppendText(text + "\n\n");
            ChatHistory_richTextBox1.ScrollToCaret();
        }

        private void txtMesaj_TextChanged(object sender, EventArgs e)
        {

        }
    }



    // --- GEMINI İÇİN GEREKLİ SINIFLAR (VERİ YAPILARI) ---

    public class GeminiRequest
    {
        public List<Content> contents { get; set; }
    }

    public class Content
    {
        public List<Part> parts { get; set; }
    }

    public class Part
    {
        public string text { get; set; }
    }

    public class GeminiResponse
    {
        public List<Candidate> candidates { get; set; }
    }

    public class Candidate
    {
        public Content content { get; set; }
    }
}
