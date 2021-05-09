
namespace kozmunka
{
    partial class UjTanuloFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_rogzit = new System.Windows.Forms.Button();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_osztaly = new System.Windows.Forms.TextBox();
            this.cb_evfolyam = new System.Windows.Forms.ComboBox();
            this.cb_evismetlo = new System.Windows.Forms.ComboBox();
            this.lbl_hiba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evfolyam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osztaly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evismetlo";
            // 
            // btn_rogzit
            // 
            this.btn_rogzit.Location = new System.Drawing.Point(32, 261);
            this.btn_rogzit.Name = "btn_rogzit";
            this.btn_rogzit.Size = new System.Drawing.Size(218, 23);
            this.btn_rogzit.TabIndex = 4;
            this.btn_rogzit.Text = "Rogzites";
            this.btn_rogzit.UseVisualStyleBackColor = true;
            this.btn_rogzit.Click += new System.EventHandler(this.btn_rogzit_Click);
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(121, 43);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_nev.TabIndex = 5;
            // 
            // tb_osztaly
            // 
            this.tb_osztaly.Location = new System.Drawing.Point(121, 118);
            this.tb_osztaly.Name = "tb_osztaly";
            this.tb_osztaly.Size = new System.Drawing.Size(100, 20);
            this.tb_osztaly.TabIndex = 6;
            // 
            // cb_evfolyam
            // 
            this.cb_evfolyam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_evfolyam.FormattingEnabled = true;
            this.cb_evfolyam.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cb_evfolyam.Location = new System.Drawing.Point(121, 81);
            this.cb_evfolyam.Name = "cb_evfolyam";
            this.cb_evfolyam.Size = new System.Drawing.Size(100, 21);
            this.cb_evfolyam.TabIndex = 7;
            // 
            // cb_evismetlo
            // 
            this.cb_evismetlo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_evismetlo.FormattingEnabled = true;
            this.cb_evismetlo.Items.AddRange(new object[] {
            "Nem",
            "Igen"});
            this.cb_evismetlo.Location = new System.Drawing.Point(121, 151);
            this.cb_evismetlo.Name = "cb_evismetlo";
            this.cb_evismetlo.Size = new System.Drawing.Size(100, 21);
            this.cb_evismetlo.TabIndex = 8;
            // 
            // lbl_hiba
            // 
            this.lbl_hiba.AutoSize = true;
            this.lbl_hiba.Location = new System.Drawing.Point(29, 185);
            this.lbl_hiba.Name = "lbl_hiba";
            this.lbl_hiba.Size = new System.Drawing.Size(0, 13);
            this.lbl_hiba.TabIndex = 9;
            // 
            // UjTanuloFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 296);
            this.Controls.Add(this.lbl_hiba);
            this.Controls.Add(this.cb_evismetlo);
            this.Controls.Add(this.cb_evfolyam);
            this.Controls.Add(this.tb_osztaly);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.btn_rogzit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UjTanuloFrm";
            this.Text = "UjTanuloFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_rogzit;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_osztaly;
        private System.Windows.Forms.ComboBox cb_evfolyam;
        private System.Windows.Forms.ComboBox cb_evismetlo;
        private System.Windows.Forms.Label lbl_hiba;
    }
}