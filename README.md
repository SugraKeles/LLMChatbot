# 🤖 Gemini AI Desktop Chatbot

![C#](https://img.shields.io/badge/Language-C%23-blue)
![Platform](https://img.shields.io/badge/Platform-Windows_Forms-purple)
![API](https://img.shields.io/badge/AI-Google_Gemini-orange)
![License](https://img.shields.io/badge/License-MIT-green)

C# Windows Forms kullanılarak geliştirilmiş, Google'ın güçlü **Gemini 1.5 Flash** (veya 2.5) modelini kullanan modern bir masaüstü sohbet uygulamasıdır. Standart metin kutuları yerine, WhatsApp/Discord benzeri **"Chat Bubbles" (Konuşma Baloncukları)** tasarımı kullanılarak kullanıcı deneyimi iyileştirilmiştir.

## 🌟 Özellikler

* **Yapay Zeka Entegrasyonu:** Google Gemini API ile hızlı ve akıllı cevaplar.
* **Modern Arayüz:** `RichTextBox` yerine dinamik olarak oluşturulan paneller ile modern sohbet baloncukları tasarımı.
* **Asenkron Yapı:** `async/await` yapısı sayesinde arayüz donmadan akıcı bir deneyim.
* **JSON İşleme:** `Newtonsoft.Json` kütüphanesi ile API veri trafiği yönetimi.
* **Renkli Tasarım:** Kullanıcı ve Bot mesajları için özelleştirilmiş renk ayrımları.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Framework:** .NET (Windows Forms)
* **Kütüphaneler:** * `System.Net.Http` (API İstekleri için)
    * `Newtonsoft.Json` (JSON Serileştirme için)
* **API:** Google Gemini API (Generative Language)

## 🚀 Kurulum ve Çalıştırma

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/SugraKeles/LLMChatbot.git](https://github.com/SugraKeles/LLMChatbot.git)
    ```

2.  **Visual Studio ile Açın:**
    `.sln` uzantılı dosyayı Visual Studio 2022 (veya benzeri) ile açın.

3.  **Gerekli Paketleri Yükleyin:**
    NuGet Package Manager konsolunu açın ve aşağıdaki komutu çalıştırın:
    ```bash
    Install-Package Newtonsoft.Json
    ```

4.  **API Anahtarını Ekleyin:**
    * [Google AI Studio](https://aistudio.google.com/) adresinden ücretsiz bir API anahtarı alın.
    * `Form1.cs` dosyasını açın.
    * `ApiKey` değişkenine kendi anahtarınızı yapıştırın:
    ```csharp
    private const string ApiKey = "BURAYA_KENDI_API_ANAHTARINIZI_YAZIN";
    ```

5.  **Başlatın:**
    Projeyi derleyin ve `F5` tuşu ile çalıştırın.

## ⚠️ Önemli Not

Bu proje eğitim amaçlı geliştirilmiştir. API anahtarınızı GitHub'a `commit` **etmemeye** özen gösterin. Prodüksiyon ortamında API anahtarlarını "Environment Variables" (Ortam Değişkenleri) üzerinden okumanız tavsiye edilir.

## 🤝 Katkıda Bulunma

1.  Bu repoyu Fork'layın.
2.  Yeni bir özellik dalı (branch) oluşturun (`git checkout -b feature/YeniOzellik`).
3.  Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`).
4.  Dalınızı Push edin (`git push origin feature/YeniOzellik`).
5.  Bir Pull Request oluşturun.

## 📄 Lisans

Bu proje [MIT](LICENSE) lisansı altında lisanslanmıştır.
