namespace Hotel.View
{
    partial class FrTamu
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
            this.txtNamaTamu = new System.Windows.Forms.TextBox();
            this.txtKTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNo_Hp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnSimpanDataTamu = new System.Windows.Forms.Button();
            this.lvlDataTamu = new System.Windows.Forms.ListView();
            this.btnCariKamar = new System.Windows.Forms.Button();
            this.txtCariKamar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Tamu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KTP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Hp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // txtNamaTamu
            // 
            this.txtNamaTamu.Location = new System.Drawing.Point(76, 100);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(442, 26);
            this.txtNamaTamu.TabIndex = 4;
            // 
            // txtKTP
            // 
            this.txtKTP.Location = new System.Drawing.Point(76, 167);
            this.txtKTP.Name = "txtKTP";
            this.txtKTP.Size = new System.Drawing.Size(277, 26);
            this.txtKTP.TabIndex = 5;
            this.txtKTP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(649, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtNo_Hp
            // 
            this.txtNo_Hp.Location = new System.Drawing.Point(649, 100);
            this.txtNo_Hp.Name = "txtNo_Hp";
            this.txtNo_Hp.Size = new System.Drawing.Size(277, 26);
            this.txtNo_Hp.TabIndex = 8;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(76, 234);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(496, 26);
            this.txtAlamat.TabIndex = 9;
            // 
            // btnSimpanDataTamu
            // 
            this.btnSimpanDataTamu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSimpanDataTamu.Location = new System.Drawing.Point(76, 292);
            this.btnSimpanDataTamu.Name = "btnSimpanDataTamu";
            this.btnSimpanDataTamu.Size = new System.Drawing.Size(180, 45);
            this.btnSimpanDataTamu.TabIndex = 10;
            this.btnSimpanDataTamu.Text = " Tambah";
            this.btnSimpanDataTamu.UseVisualStyleBackColor = false;
            this.btnSimpanDataTamu.Click += new System.EventHandler(this.btnSimpanDataTamu_Click);
            // 
            // lvlDataTamu
            // 
            this.lvlDataTamu.HideSelection = false;
            this.lvlDataTamu.Location = new System.Drawing.Point(76, 353);
            this.lvlDataTamu.Name = "lvlDataTamu";
            this.lvlDataTamu.Size = new System.Drawing.Size(931, 242);
            this.lvlDataTamu.TabIndex = 11;
            this.lvlDataTamu.UseCompatibleStateImageBehavior = false;
            // 
            // btnCariKamar
            // 
            this.btnCariKamar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCariKamar.Location = new System.Drawing.Point(857, 301);
            this.btnCariKamar.Name = "btnCariKamar";
            this.btnCariKamar.Size = new System.Drawing.Size(150, 39);
            this.btnCariKamar.TabIndex = 12;
            this.btnCariKamar.Text = "Search";
            this.btnCariKamar.UseVisualStyleBackColor = false;
            // 
            // txtCariKamar
            // 
            this.txtCariKamar.Location = new System.Drawing.Point(592, 310);
            this.txtCariKamar.Name = "txtCariKamar";
            this.txtCariKamar.Size = new System.Drawing.Size(259, 26);
            this.txtCariKamar.TabIndex = 13;
            // 
            // FrTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 655);
            this.Controls.Add(this.txtCariKamar);
            this.Controls.Add(this.btnCariKamar);
            this.Controls.Add(this.lvlDataTamu);
            this.Controls.Add(this.btnSimpanDataTamu);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNo_Hp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKTP);
            this.Controls.Add(this.txtNamaTamu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrTamu";
            this.Text = "FrTamu";
            this.Load += new System.EventHandler(this.FrTamu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaTamu;
        private System.Windows.Forms.TextBox txtKTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNo_Hp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnSimpanDataTamu;
        private System.Windows.Forms.ListView lvlDataTamu;
        private System.Windows.Forms.Button btnCariKamar;
        private System.Windows.Forms.TextBox txtCariKamar;
    }
}