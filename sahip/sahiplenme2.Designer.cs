
namespace projeclab
{
    partial class sahiplenme2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ccinsiyet = new System.Windows.Forms.ComboBox();
            this.tad = new System.Windows.Forms.TextBox();
            this.tsoyad = new System.Windows.Forms.TextBox();
            this.tyas = new System.Windows.Forms.TextBox();
            this.radres = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bkaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ccins = new System.Windows.Forms.ComboBox();
            this.byenile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bsil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(336, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cins:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(338, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(311, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cinsiyet:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ccinsiyet
            // 
            this.ccinsiyet.BackColor = System.Drawing.Color.PeachPuff;
            this.ccinsiyet.FormattingEnabled = true;
            this.ccinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Dişi"});
            this.ccinsiyet.Location = new System.Drawing.Point(381, 77);
            this.ccinsiyet.Name = "ccinsiyet";
            this.ccinsiyet.Size = new System.Drawing.Size(121, 21);
            this.ccinsiyet.TabIndex = 8;
            // 
            // tad
            // 
            this.tad.BackColor = System.Drawing.Color.PeachPuff;
            this.tad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tad.Location = new System.Drawing.Point(70, 25);
            this.tad.Name = "tad";
            this.tad.Size = new System.Drawing.Size(198, 20);
            this.tad.TabIndex = 11;
            this.tad.TextChanged += new System.EventHandler(this.tad_TextChanged);
            this.tad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tad_KeyPress);
            // 
            // tsoyad
            // 
            this.tsoyad.BackColor = System.Drawing.Color.PeachPuff;
            this.tsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsoyad.Location = new System.Drawing.Point(70, 64);
            this.tsoyad.Name = "tsoyad";
            this.tsoyad.Size = new System.Drawing.Size(198, 20);
            this.tsoyad.TabIndex = 13;
            this.tsoyad.TextChanged += new System.EventHandler(this.tsoyad_TextChanged);
            this.tsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsoyad_KeyPress);
            // 
            // tyas
            // 
            this.tyas.BackColor = System.Drawing.Color.PeachPuff;
            this.tyas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tyas.Location = new System.Drawing.Point(381, 48);
            this.tyas.MaxLength = 3;
            this.tyas.Name = "tyas";
            this.tyas.Size = new System.Drawing.Size(106, 20);
            this.tyas.TabIndex = 15;
            this.tyas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tyas_KeyPress);
            // 
            // radres
            // 
            this.radres.BackColor = System.Drawing.Color.PeachPuff;
            this.radres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radres.Location = new System.Drawing.Point(71, 103);
            this.radres.Name = "radres";
            this.radres.Size = new System.Drawing.Size(198, 104);
            this.radres.TabIndex = 16;
            this.radres.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 138);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(786, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // bkaydet
            // 
            this.bkaydet.BackColor = System.Drawing.Color.Silver;
            this.bkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bkaydet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bkaydet.Location = new System.Drawing.Point(444, 241);
            this.bkaydet.Name = "bkaydet";
            this.bkaydet.Size = new System.Drawing.Size(121, 23);
            this.bkaydet.TabIndex = 18;
            this.bkaydet.Text = "Kaydet";
            this.bkaydet.UseVisualStyleBackColor = false;
            this.bkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefon:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ccins
            // 
            this.ccins.BackColor = System.Drawing.Color.PeachPuff;
            this.ccins.FormattingEnabled = true;
            this.ccins.Items.AddRange(new object[] {
            "Kedi:Tekir",
            "Kedi:British",
            "Kedi:İran Kedisi",
            "Kedi:Maine Coon",
            "Kedi:Munchkin",
            "Kedi:Ankara Kedisi",
            "Kedi:Singapura",
            "Kedi:Toyger",
            "Köpek:Dogo Argentino",
            "Köpek:Alman Çoban Köpeği",
            "Köpek:Buldog",
            "Köpek:Pug",
            "Köpek:Doberman",
            "Köpek:Basenji",
            "Köpek:İran Çoban"});
            this.ccins.Location = new System.Drawing.Point(381, 21);
            this.ccins.Name = "ccins";
            this.ccins.Size = new System.Drawing.Size(121, 21);
            this.ccins.TabIndex = 21;
            // 
            // byenile
            // 
            this.byenile.BackColor = System.Drawing.Color.Silver;
            this.byenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.byenile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.byenile.Location = new System.Drawing.Point(605, 241);
            this.byenile.Name = "byenile";
            this.byenile.Size = new System.Drawing.Size(121, 23);
            this.byenile.TabIndex = 22;
            this.byenile.Text = "Yenile";
            this.byenile.UseVisualStyleBackColor = false;
            this.byenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(8, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsil
            // 
            this.bsil.BackColor = System.Drawing.Color.Silver;
            this.bsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bsil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bsil.Location = new System.Drawing.Point(89, 268);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(78, 23);
            this.bsil.TabIndex = 25;
            this.bsil.Text = "Sil";
            this.bsil.UseVisualStyleBackColor = false;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::projeclab.Properties.Resources.istockphoto_1249679431_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(381, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // mtel
            // 
            this.mtel.BackColor = System.Drawing.Color.PeachPuff;
            this.mtel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtel.Location = new System.Drawing.Point(71, 217);
            this.mtel.MaxLength = 10;
            this.mtel.Name = "mtel";
            this.mtel.Size = new System.Drawing.Size(113, 20);
            this.mtel.TabIndex = 27;
            this.mtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtel_KeyPress);
            // 
            // sahiplenme2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 446);
            this.Controls.Add(this.mtel);
            this.Controls.Add(this.bsil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.byenile);
            this.Controls.Add(this.ccins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bkaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radres);
            this.Controls.Add(this.tyas);
            this.Controls.Add(this.tsoyad);
            this.Controls.Add(this.tad);
            this.Controls.Add(this.ccinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sahiplenme2";
            this.Text = "sahiplenme2";
            this.Load += new System.EventHandler(this.sahiplenme2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ccinsiyet;
        private System.Windows.Forms.TextBox tad;
        private System.Windows.Forms.TextBox tsoyad;
        private System.Windows.Forms.TextBox tyas;
        private System.Windows.Forms.RichTextBox radres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bkaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ccins;
        private System.Windows.Forms.Button byenile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mtel;
    }
}