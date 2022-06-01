namespace CafeOtomasyon
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
            this.siparisgroupBox = new System.Windows.Forms.GroupBox();
            this.lblkolaucreti = new System.Windows.Forms.Label();
            this.lblkahveucreti = new System.Windows.Forms.Label();
            this.lblcayucreti = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kolaSayisilabel = new System.Windows.Forms.Label();
            this.kolalabel = new System.Windows.Forms.Label();
            this.kolaartıbutton = new System.Windows.Forms.Button();
            this.kolaeksinbutton = new System.Windows.Forms.Button();
            this.kahveSayisiLabel = new System.Windows.Forms.Label();
            this.kahvelabel = new System.Windows.Forms.Label();
            this.kahveartıbutton = new System.Windows.Forms.Button();
            this.kahveeksibutton = new System.Windows.Forms.Button();
            this.caySayisiLabel = new System.Windows.Forms.Label();
            this.caylabel = new System.Windows.Forms.Label();
            this.cayartıbutton = new System.Windows.Forms.Button();
            this.cayeksibutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltoplamucret = new System.Windows.Forms.Label();
            this.btnsiparisver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siparisgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisgroupBox
            // 
            this.siparisgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siparisgroupBox.Controls.Add(this.label1);
            this.siparisgroupBox.Controls.Add(this.btnsiparisver);
            this.siparisgroupBox.Controls.Add(this.lbltoplamucret);
            this.siparisgroupBox.Controls.Add(this.lblkolaucreti);
            this.siparisgroupBox.Controls.Add(this.lblkahveucreti);
            this.siparisgroupBox.Controls.Add(this.lblcayucreti);
            this.siparisgroupBox.Controls.Add(this.dataGridView1);
            this.siparisgroupBox.Controls.Add(this.kolaSayisilabel);
            this.siparisgroupBox.Controls.Add(this.kolalabel);
            this.siparisgroupBox.Controls.Add(this.kolaartıbutton);
            this.siparisgroupBox.Controls.Add(this.kolaeksinbutton);
            this.siparisgroupBox.Controls.Add(this.kahveSayisiLabel);
            this.siparisgroupBox.Controls.Add(this.kahvelabel);
            this.siparisgroupBox.Controls.Add(this.kahveartıbutton);
            this.siparisgroupBox.Controls.Add(this.kahveeksibutton);
            this.siparisgroupBox.Controls.Add(this.caySayisiLabel);
            this.siparisgroupBox.Controls.Add(this.caylabel);
            this.siparisgroupBox.Controls.Add(this.cayartıbutton);
            this.siparisgroupBox.Controls.Add(this.cayeksibutton);
            this.siparisgroupBox.Location = new System.Drawing.Point(12, 12);
            this.siparisgroupBox.Name = "siparisgroupBox";
            this.siparisgroupBox.Size = new System.Drawing.Size(1558, 243);
            this.siparisgroupBox.TabIndex = 0;
            this.siparisgroupBox.TabStop = false;
            this.siparisgroupBox.Text = "Sipariş";
            // 
            // lblkolaucreti
            // 
            this.lblkolaucreti.AutoSize = true;
            this.lblkolaucreti.Location = new System.Drawing.Point(234, 122);
            this.lblkolaucreti.Name = "lblkolaucreti";
            this.lblkolaucreti.Size = new System.Drawing.Size(18, 20);
            this.lblkolaucreti.TabIndex = 18;
            this.lblkolaucreti.Text = "0";
            // 
            // lblkahveucreti
            // 
            this.lblkahveucreti.AutoSize = true;
            this.lblkahveucreti.Location = new System.Drawing.Point(234, 78);
            this.lblkahveucreti.Name = "lblkahveucreti";
            this.lblkahveucreti.Size = new System.Drawing.Size(18, 20);
            this.lblkahveucreti.TabIndex = 17;
            this.lblkahveucreti.Text = "0";
            // 
            // lblcayucreti
            // 
            this.lblcayucreti.AutoSize = true;
            this.lblcayucreti.Location = new System.Drawing.Point(234, 34);
            this.lblcayucreti.Name = "lblcayucreti";
            this.lblcayucreti.Size = new System.Drawing.Size(18, 20);
            this.lblcayucreti.TabIndex = 16;
            this.lblcayucreti.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1273, 163);
            this.dataGridView1.TabIndex = 15;
            // 
            // kolaSayisilabel
            // 
            this.kolaSayisilabel.AutoSize = true;
            this.kolaSayisilabel.Location = new System.Drawing.Point(112, 122);
            this.kolaSayisilabel.Name = "kolaSayisilabel";
            this.kolaSayisilabel.Size = new System.Drawing.Size(18, 20);
            this.kolaSayisilabel.TabIndex = 14;
            this.kolaSayisilabel.Text = "0";
            // 
            // kolalabel
            // 
            this.kolalabel.AutoSize = true;
            this.kolalabel.Location = new System.Drawing.Point(66, 122);
            this.kolalabel.Name = "kolalabel";
            this.kolalabel.Size = new System.Drawing.Size(40, 20);
            this.kolalabel.TabIndex = 13;
            this.kolalabel.Text = "Kola";
            // 
            // kolaartıbutton
            // 
            this.kolaartıbutton.Location = new System.Drawing.Point(150, 113);
            this.kolaartıbutton.Name = "kolaartıbutton";
            this.kolaartıbutton.Size = new System.Drawing.Size(36, 38);
            this.kolaartıbutton.TabIndex = 12;
            this.kolaartıbutton.Text = "+";
            this.kolaartıbutton.UseVisualStyleBackColor = true;
            this.kolaartıbutton.Click += new System.EventHandler(this.kolaartıbutton_Click);
            // 
            // kolaeksinbutton
            // 
            this.kolaeksinbutton.Location = new System.Drawing.Point(192, 113);
            this.kolaeksinbutton.Name = "kolaeksinbutton";
            this.kolaeksinbutton.Size = new System.Drawing.Size(36, 38);
            this.kolaeksinbutton.TabIndex = 11;
            this.kolaeksinbutton.Text = "-";
            this.kolaeksinbutton.UseVisualStyleBackColor = true;
            this.kolaeksinbutton.Click += new System.EventHandler(this.kolaeksinbutton_Click);
            // 
            // kahveSayisiLabel
            // 
            this.kahveSayisiLabel.AutoSize = true;
            this.kahveSayisiLabel.Location = new System.Drawing.Point(112, 78);
            this.kahveSayisiLabel.Name = "kahveSayisiLabel";
            this.kahveSayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.kahveSayisiLabel.TabIndex = 10;
            this.kahveSayisiLabel.Text = "0";
            // 
            // kahvelabel
            // 
            this.kahvelabel.AutoSize = true;
            this.kahvelabel.Location = new System.Drawing.Point(53, 78);
            this.kahvelabel.Name = "kahvelabel";
            this.kahvelabel.Size = new System.Drawing.Size(53, 20);
            this.kahvelabel.TabIndex = 9;
            this.kahvelabel.Text = "Kahve";
            // 
            // kahveartıbutton
            // 
            this.kahveartıbutton.Location = new System.Drawing.Point(150, 69);
            this.kahveartıbutton.Name = "kahveartıbutton";
            this.kahveartıbutton.Size = new System.Drawing.Size(36, 38);
            this.kahveartıbutton.TabIndex = 8;
            this.kahveartıbutton.Text = "+";
            this.kahveartıbutton.UseVisualStyleBackColor = true;
            this.kahveartıbutton.Click += new System.EventHandler(this.kahveartıbutton_Click);
            // 
            // kahveeksibutton
            // 
            this.kahveeksibutton.Location = new System.Drawing.Point(192, 69);
            this.kahveeksibutton.Name = "kahveeksibutton";
            this.kahveeksibutton.Size = new System.Drawing.Size(36, 38);
            this.kahveeksibutton.TabIndex = 7;
            this.kahveeksibutton.Text = "-";
            this.kahveeksibutton.UseVisualStyleBackColor = true;
            this.kahveeksibutton.Click += new System.EventHandler(this.kahveeksibutton_Click);
            // 
            // caySayisiLabel
            // 
            this.caySayisiLabel.AutoSize = true;
            this.caySayisiLabel.Location = new System.Drawing.Point(112, 34);
            this.caySayisiLabel.Name = "caySayisiLabel";
            this.caySayisiLabel.Size = new System.Drawing.Size(18, 20);
            this.caySayisiLabel.TabIndex = 6;
            this.caySayisiLabel.Text = "0";
            // 
            // caylabel
            // 
            this.caylabel.AutoSize = true;
            this.caylabel.Location = new System.Drawing.Point(70, 34);
            this.caylabel.Name = "caylabel";
            this.caylabel.Size = new System.Drawing.Size(36, 20);
            this.caylabel.TabIndex = 5;
            this.caylabel.Text = "Çay";
            // 
            // cayartıbutton
            // 
            this.cayartıbutton.Location = new System.Drawing.Point(150, 25);
            this.cayartıbutton.Name = "cayartıbutton";
            this.cayartıbutton.Size = new System.Drawing.Size(36, 38);
            this.cayartıbutton.TabIndex = 4;
            this.cayartıbutton.Text = "+";
            this.cayartıbutton.UseVisualStyleBackColor = true;
            this.cayartıbutton.Click += new System.EventHandler(this.cayartıbutton_Click);
            // 
            // cayeksibutton
            // 
            this.cayeksibutton.Location = new System.Drawing.Point(192, 25);
            this.cayeksibutton.Name = "cayeksibutton";
            this.cayeksibutton.Size = new System.Drawing.Size(36, 38);
            this.cayeksibutton.TabIndex = 3;
            this.cayeksibutton.Text = "-";
            this.cayeksibutton.UseVisualStyleBackColor = true;
            this.cayeksibutton.Click += new System.EventHandler(this.cayeksibutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(954, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "SIFIRLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1052, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "SİPARİŞİ TAMAMLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbltoplamucret
            // 
            this.lbltoplamucret.AutoSize = true;
            this.lbltoplamucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamucret.Location = new System.Drawing.Point(941, 176);
            this.lbltoplamucret.Name = "lbltoplamucret";
            this.lbltoplamucret.Size = new System.Drawing.Size(24, 25);
            this.lbltoplamucret.TabIndex = 19;
            this.lbltoplamucret.Text = "0";
            // 
            // btnsiparisver
            // 
            this.btnsiparisver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparisver.Location = new System.Drawing.Point(70, 157);
            this.btnsiparisver.Name = "btnsiparisver";
            this.btnsiparisver.Size = new System.Drawing.Size(158, 65);
            this.btnsiparisver.TabIndex = 20;
            this.btnsiparisver.Text = "sipariş ver";
            this.btnsiparisver.UseVisualStyleBackColor = true;
            this.btnsiparisver.Click += new System.EventHandler(this.btnsiparisver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(780, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Toplam Ücret";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.siparisgroupBox);
            this.MaximumSize = new System.Drawing.Size(1600, 360);
            this.MinimumSize = new System.Drawing.Size(1600, 360);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siparisgroupBox.ResumeLayout(false);
            this.siparisgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox siparisgroupBox;
        private System.Windows.Forms.Label kolaSayisilabel;
        private System.Windows.Forms.Label kolalabel;
        private System.Windows.Forms.Button kolaartıbutton;
        private System.Windows.Forms.Button kolaeksinbutton;
        private System.Windows.Forms.Label kahveSayisiLabel;
        private System.Windows.Forms.Label kahvelabel;
        private System.Windows.Forms.Button kahveartıbutton;
        private System.Windows.Forms.Button kahveeksibutton;
        private System.Windows.Forms.Label caySayisiLabel;
        private System.Windows.Forms.Label caylabel;
        private System.Windows.Forms.Button cayartıbutton;
        private System.Windows.Forms.Button cayeksibutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblkolaucreti;
        private System.Windows.Forms.Label lblkahveucreti;
        private System.Windows.Forms.Label lblcayucreti;
        private System.Windows.Forms.Label lbltoplamucret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsiparisver;
    }
}

