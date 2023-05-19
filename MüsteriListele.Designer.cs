namespace ARAÇ_KİRALAMA_OTOMASYON
{
    partial class MüsteriListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAİL = new System.Windows.Forms.TextBox();
            this.btnÇIKIŞ = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEKLE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTELEFON = new System.Windows.Forms.Label();
            this.txtADSOYAD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtADRES = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(70, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "E-Mail:";
            // 
            // txtMAİL
            // 
            this.txtMAİL.BackColor = System.Drawing.Color.SkyBlue;
            this.txtMAİL.Location = new System.Drawing.Point(167, 180);
            this.txtMAİL.Name = "txtMAİL";
            this.txtMAİL.Size = new System.Drawing.Size(178, 22);
            this.txtMAİL.TabIndex = 25;
            // 
            // btnÇIKIŞ
            // 
            this.btnÇIKIŞ.BackColor = System.Drawing.Color.SkyBlue;
            this.btnÇIKIŞ.ImageIndex = 0;
            this.btnÇIKIŞ.ImageList = this.ımageList1;
            this.btnÇIKIŞ.Location = new System.Drawing.Point(258, 228);
            this.btnÇIKIŞ.Name = "btnÇIKIŞ";
            this.btnÇIKIŞ.Size = new System.Drawing.Size(87, 69);
            this.btnÇIKIŞ.TabIndex = 24;
            this.btnÇIKIŞ.Text = "Çıkış:";
            this.btnÇIKIŞ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnÇIKIŞ.UseVisualStyleBackColor = false;
            this.btnÇIKIŞ.Click += new System.EventHandler(this.btnÇIKIŞ_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "png-transparent-computer-icons-cancel-angle-logo-symmetry-thumbnail.png");
            this.ımageList1.Images.SetKeyName(1, "png-transparent-delete-button-line-diagram-vector-image-transparent-background-fr" +
        "ee-stock-images-delete-icon-thumbnail.png");
            this.ımageList1.Images.SetKeyName(2, "png-transparent-renew-refresh-reload-repeat-sync-update-pinpoint-action-icon-thum" +
        "bnail.png");
            this.ımageList1.Images.SetKeyName(3, "png-transparent-computer-icons-add-button-logo-number-add-button-thumbnail.png");
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEKLE.ImageIndex = 2;
            this.btnEKLE.ImageList = this.ımageList1;
            this.btnEKLE.Location = new System.Drawing.Point(167, 228);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(85, 69);
            this.btnEKLE.TabIndex = 23;
            this.btnEKLE.Text = "Güncelle:";
            this.btnEKLE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(70, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adres:";
            // 
            // txtTELEFON
            // 
            this.txtTELEFON.AutoSize = true;
            this.txtTELEFON.BackColor = System.Drawing.Color.Transparent;
            this.txtTELEFON.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTELEFON.Location = new System.Drawing.Point(59, 123);
            this.txtTELEFON.Name = "txtTELEFON";
            this.txtTELEFON.Size = new System.Drawing.Size(86, 25);
            this.txtTELEFON.TabIndex = 21;
            this.txtTELEFON.Text = "Telefon:";
            // 
            // txtADSOYAD
            // 
            this.txtADSOYAD.AutoSize = true;
            this.txtADSOYAD.BackColor = System.Drawing.Color.Transparent;
            this.txtADSOYAD.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtADSOYAD.Location = new System.Drawing.Point(27, 95);
            this.txtADSOYAD.Name = "txtADSOYAD";
            this.txtADSOYAD.Size = new System.Drawing.Size(114, 25);
            this.txtADSOYAD.TabIndex = 20;
            this.txtADSOYAD.Text = "AD SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "TC:";
            // 
            // txtADRES
            // 
            this.txtADRES.BackColor = System.Drawing.Color.SkyBlue;
            this.txtADRES.Location = new System.Drawing.Point(167, 152);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(178, 22);
            this.txtADRES.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox4.Location = new System.Drawing.Point(167, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 22);
            this.textBox4.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox2.Location = new System.Drawing.Point(167, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 22);
            this.textBox2.TabIndex = 16;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTC.Location = new System.Drawing.Point(167, 68);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(178, 22);
            this.txtTC.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(167, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 24;
            this.button1.Text = "SİL:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(830, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "TC ARA:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.Location = new System.Drawing.Point(935, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(410, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Çift Tıklayarak Güncelleme Yapabilirsiniz.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(167, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 60);
            this.button2.TabIndex = 30;
            this.button2.Text = "EKLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MüsteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 610);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMAİL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnÇIKIŞ);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTELEFON);
            this.Controls.Add(this.txtADSOYAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtADRES);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MüsteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüsteriListele";
            this.Load += new System.EventHandler(this.MüsteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMAİL;
        private System.Windows.Forms.Button btnÇIKIŞ;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTELEFON;
        private System.Windows.Forms.Label txtADSOYAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtADRES;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}