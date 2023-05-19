namespace ARAÇ_KİRALAMA_OTOMASYON
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cachedRaporArac1 = new ARAÇ_KİRALAMA_OTOMASYON.CachedRaporArac();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(37, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 116);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageIndex = 8;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(926, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 91);
            this.button5.TabIndex = 7;
            this.button5.Text = "Envanter Raporları";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "510-5109047_free-icons-png-insurance-sales-icon.png");
            this.ımageList1.Images.SetKeyName(1, "54657-200.png");
            this.ımageList1.Images.SetKeyName(2, "contract-icon-agreement-deal-vector-id1164760173.jpg");
            this.ımageList1.Images.SetKeyName(3, "çıkış.PNG");
            this.ımageList1.Images.SetKeyName(4, "istockphoto-842424774-612x612.jpg");
            this.ımageList1.Images.SetKeyName(5, "istockphoto-1152255200-612x612.jpg");
            this.ımageList1.Images.SetKeyName(6, "listeleme.PNG");
            this.ımageList1.Images.SetKeyName(7, "calculator-vector-icon-on-transparent-background-calculator-icon-vector-id1013496" +
        "754.jpg");
            this.ımageList1.Images.SetKeyName(8, "depositphotos_60052087-stock-illustration-printer-icon-on-white-background.jpg");
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.ImageIndex = 7;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(634, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 91);
            this.button6.TabIndex = 5;
            this.button6.Text = "Kiralama İşlemleri";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageIndex = 6;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(375, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 91);
            this.button4.TabIndex = 3;
            this.button4.Text = "Araç     İşlemleri";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(86, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 91);
            this.button3.TabIndex = 1;
            this.button3.Text = "Müşteri İşlemleri";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageIndex = 3;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(1108, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 79);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(93, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Araç Kayıt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(163, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri Ekleme";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 682);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLEM SAYFASI";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button5;
        private CachedRaporArac cachedRaporArac1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

