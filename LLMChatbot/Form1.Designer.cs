namespace LLMChatbot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChatHistory_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.Gönder_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatHistory_richTextBox1
            // 
            this.ChatHistory_richTextBox1.BackColor = System.Drawing.Color.Honeydew;
            this.ChatHistory_richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatHistory_richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChatHistory_richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.ChatHistory_richTextBox1.Name = "ChatHistory_richTextBox1";
            this.ChatHistory_richTextBox1.ReadOnly = true;
            this.ChatHistory_richTextBox1.Size = new System.Drawing.Size(800, 344);
            this.ChatHistory_richTextBox1.TabIndex = 0;
            this.ChatHistory_richTextBox1.Text = "";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMesaj.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMesaj.Location = new System.Drawing.Point(0, 376);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(642, 62);
            this.txtMesaj.TabIndex = 1;
            this.txtMesaj.TextChanged += new System.EventHandler(this.txtMesaj_TextChanged);
            // 
            // Gönder_button1
            // 
            this.Gönder_button1.BackColor = System.Drawing.Color.LawnGreen;
            this.Gönder_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gönder_button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gönder_button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Gönder_button1.Location = new System.Drawing.Point(668, 388);
            this.Gönder_button1.Name = "Gönder_button1";
            this.Gönder_button1.Size = new System.Drawing.Size(106, 39);
            this.Gönder_button1.TabIndex = 2;
            this.Gönder_button1.Text = "Gönder";
            this.Gönder_button1.UseVisualStyleBackColor = false;
            this.Gönder_button1.Click += new System.EventHandler(this.Gönder_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gönder_button1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.ChatHistory_richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatHistory_richTextBox1;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button Gönder_button1;
    }
}

