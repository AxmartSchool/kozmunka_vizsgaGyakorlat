
namespace kozmunka
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ujTanulo = new System.Windows.Forms.Button();
            this.dgv_tanulok = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_adatmodositas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_adatok = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_teljesitettOrak = new System.Windows.Forms.TextBox();
            this.tb_megvanAz50 = new System.Windows.Forms.TextBox();
            this.tb_Nev = new System.Windows.Forms.TextBox();
            this.tb_evfolyam = new System.Windows.Forms.TextBox();
            this.tb_osztaly = new System.Windows.Forms.TextBox();
            this.cv_evismetlo = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evfolyam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osztaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evismetlo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tanulok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kozossegi Szolgalat";
            // 
            // btn_ujTanulo
            // 
            this.btn_ujTanulo.Location = new System.Drawing.Point(555, 12);
            this.btn_ujTanulo.Name = "btn_ujTanulo";
            this.btn_ujTanulo.Size = new System.Drawing.Size(233, 21);
            this.btn_ujTanulo.TabIndex = 1;
            this.btn_ujTanulo.Text = "Uj tanulo felvetele";
            this.btn_ujTanulo.UseVisualStyleBackColor = true;
            this.btn_ujTanulo.Click += new System.EventHandler(this.btn_ujTanulo_Click);
            // 
            // dgv_tanulok
            // 
            this.dgv_tanulok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tanulok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nev,
            this.Evfolyam,
            this.Osztaly,
            this.Evismetlo});
            this.dgv_tanulok.Location = new System.Drawing.Point(17, 53);
            this.dgv_tanulok.MultiSelect = false;
            this.dgv_tanulok.Name = "dgv_tanulok";
            this.dgv_tanulok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tanulok.Size = new System.Drawing.Size(771, 204);
            this.dgv_tanulok.TabIndex = 2;
            this.dgv_tanulok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tanulok_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kivalasztott gyermek adatainak modositasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Evfolyam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oszyaly";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Evismetlo";
            // 
            // btn_adatmodositas
            // 
            this.btn_adatmodositas.Location = new System.Drawing.Point(16, 432);
            this.btn_adatmodositas.Name = "btn_adatmodositas";
            this.btn_adatmodositas.Size = new System.Drawing.Size(208, 23);
            this.btn_adatmodositas.TabIndex = 8;
            this.btn_adatmodositas.Text = "Adatok modositasa";
            this.btn_adatmodositas.UseVisualStyleBackColor = true;
            this.btn_adatmodositas.Click += new System.EventHandler(this.btn_adatmodositas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kivalasztott tanulo kozossegi szolgalati adatai:";
            // 
            // rtb_adatok
            // 
            this.rtb_adatok.Location = new System.Drawing.Point(459, 303);
            this.rtb_adatok.Name = "rtb_adatok";
            this.rtb_adatok.Size = new System.Drawing.Size(329, 73);
            this.rtb_adatok.TabIndex = 11;
            this.rtb_adatok.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Teljesitett orak osszesen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Megvan az 50?";
            // 
            // tb_teljesitettOrak
            // 
            this.tb_teljesitettOrak.Location = new System.Drawing.Point(610, 392);
            this.tb_teljesitettOrak.Name = "tb_teljesitettOrak";
            this.tb_teljesitettOrak.Size = new System.Drawing.Size(178, 20);
            this.tb_teljesitettOrak.TabIndex = 14;
            // 
            // tb_megvanAz50
            // 
            this.tb_megvanAz50.Location = new System.Drawing.Point(610, 432);
            this.tb_megvanAz50.Name = "tb_megvanAz50";
            this.tb_megvanAz50.Size = new System.Drawing.Size(178, 20);
            this.tb_megvanAz50.TabIndex = 15;
            // 
            // tb_Nev
            // 
            this.tb_Nev.Location = new System.Drawing.Point(135, 306);
            this.tb_Nev.Name = "tb_Nev";
            this.tb_Nev.Size = new System.Drawing.Size(178, 20);
            this.tb_Nev.TabIndex = 16;
            // 
            // tb_evfolyam
            // 
            this.tb_evfolyam.Location = new System.Drawing.Point(135, 334);
            this.tb_evfolyam.Name = "tb_evfolyam";
            this.tb_evfolyam.Size = new System.Drawing.Size(178, 20);
            this.tb_evfolyam.TabIndex = 17;
            // 
            // tb_osztaly
            // 
            this.tb_osztaly.Location = new System.Drawing.Point(135, 363);
            this.tb_osztaly.Name = "tb_osztaly";
            this.tb_osztaly.Size = new System.Drawing.Size(178, 20);
            this.tb_osztaly.TabIndex = 18;
            // 
            // cv_evismetlo
            // 
            this.cv_evismetlo.FormattingEnabled = true;
            this.cv_evismetlo.Items.AddRange(new object[] {
            "Nem",
            "Igen"});
            this.cv_evismetlo.Location = new System.Drawing.Point(135, 392);
            this.cv_evismetlo.Name = "cv_evismetlo";
            this.cv_evismetlo.Size = new System.Drawing.Size(178, 21);
            this.cv_evismetlo.TabIndex = 19;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nev
            // 
            this.Nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nev.HeaderText = "Nev";
            this.Nev.Name = "Nev";
            // 
            // Evfolyam
            // 
            this.Evfolyam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Evfolyam.HeaderText = "Evfolyam";
            this.Evfolyam.Name = "Evfolyam";
            // 
            // Osztaly
            // 
            this.Osztaly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Osztaly.HeaderText = "Osztaly";
            this.Osztaly.Name = "Osztaly";
            // 
            // Evismetlo
            // 
            this.Evismetlo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Evismetlo.HeaderText = "Evismetlo";
            this.Evismetlo.Name = "Evismetlo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.cv_evismetlo);
            this.Controls.Add(this.tb_osztaly);
            this.Controls.Add(this.tb_evfolyam);
            this.Controls.Add(this.tb_Nev);
            this.Controls.Add(this.tb_megvanAz50);
            this.Controls.Add(this.tb_teljesitettOrak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_adatok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_adatmodositas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_tanulok);
            this.Controls.Add(this.btn_ujTanulo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "kozossegi";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tanulok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ujTanulo;
        private System.Windows.Forms.DataGridView dgv_tanulok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_adatmodositas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_adatok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_teljesitettOrak;
        private System.Windows.Forms.TextBox tb_megvanAz50;
        private System.Windows.Forms.TextBox tb_Nev;
        private System.Windows.Forms.TextBox tb_evfolyam;
        private System.Windows.Forms.TextBox tb_osztaly;
        private System.Windows.Forms.ComboBox cv_evismetlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evfolyam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osztaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evismetlo;
    }
}

