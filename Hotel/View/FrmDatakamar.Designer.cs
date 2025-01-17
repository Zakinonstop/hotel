namespace Hotel.View
{
    partial class FrmDatakamar
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
            this.txtNoKamar = new System.Windows.Forms.TextBox();
            this.txtHargakamar = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSimpanDatakamar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.cbTypeKamar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Kamar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNoKamar
            // 
            this.txtNoKamar.Location = new System.Drawing.Point(151, 93);
            this.txtNoKamar.Name = "txtNoKamar";
            this.txtNoKamar.Size = new System.Drawing.Size(100, 26);
            this.txtNoKamar.TabIndex = 17;
            // 
            // txtHargakamar
            // 
            this.txtHargakamar.Location = new System.Drawing.Point(151, 190);
            this.txtHargakamar.Name = "txtHargakamar";
            this.txtHargakamar.Size = new System.Drawing.Size(253, 26);
            this.txtHargakamar.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Terpakai"});
            this.cbStatus.Location = new System.Drawing.Point(151, 143);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(179, 28);
            this.cbStatus.TabIndex = 7;
            // 
            // btnSimpanDatakamar
            // 
            this.btnSimpanDatakamar.Location = new System.Drawing.Point(42, 256);
            this.btnSimpanDatakamar.Name = "btnSimpanDatakamar";
            this.btnSimpanDatakamar.Size = new System.Drawing.Size(114, 42);
            this.btnSimpanDatakamar.TabIndex = 18;
            this.btnSimpanDatakamar.Text = "Simpan";
            this.btnSimpanDatakamar.UseVisualStyleBackColor = true;
            this.btnSimpanDatakamar.Click += new System.EventHandler(this.btnSimpanDatakamar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(194, 256);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(114, 42);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Selesai";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // cbTypeKamar
            // 
            this.cbTypeKamar.FormattingEnabled = true;
            this.cbTypeKamar.Items.AddRange(new object[] {
            "King Bed",
            "Single Bed",
            "Twin Bed"});
            this.cbTypeKamar.Location = new System.Drawing.Point(151, 40);
            this.cbTypeKamar.Name = "cbTypeKamar";
            this.cbTypeKamar.Size = new System.Drawing.Size(179, 28);
            this.cbTypeKamar.TabIndex = 20;
            // 
            // FrmDatakamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.cbTypeKamar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpanDatakamar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtHargakamar);
            this.Controls.Add(this.txtNoKamar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDatakamar";
            this.Text = "FrmDatakamar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoKamar;
        private System.Windows.Forms.TextBox txtHargakamar;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSimpanDatakamar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ComboBox cbTypeKamar;
    }
}