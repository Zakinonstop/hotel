namespace Hotel.View
{
    partial class datakamar
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
            this.lvlKamar = new System.Windows.Forms.ListView();
            this.btnTamabahkamar = new System.Windows.Forms.Button();
            this.btnEditKamar = new System.Windows.Forms.Button();
            this.btnChekin = new System.Windows.Forms.Button();
            this.btnCariKamar = new System.Windows.Forms.Button();
            this.txtDataKamar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvlKamar
            // 
            this.lvlKamar.HideSelection = false;
            this.lvlKamar.Location = new System.Drawing.Point(27, 72);
            this.lvlKamar.Name = "lvlKamar";
            this.lvlKamar.Size = new System.Drawing.Size(944, 391);
            this.lvlKamar.TabIndex = 26;
            this.lvlKamar.UseCompatibleStateImageBehavior = false;
            // 
            // btnTamabahkamar
            // 
            this.btnTamabahkamar.Location = new System.Drawing.Point(27, 487);
            this.btnTamabahkamar.Name = "btnTamabahkamar";
            this.btnTamabahkamar.Size = new System.Drawing.Size(122, 33);
            this.btnTamabahkamar.TabIndex = 27;
            this.btnTamabahkamar.Text = "Tambah";
            this.btnTamabahkamar.UseVisualStyleBackColor = true;
            this.btnTamabahkamar.Click += new System.EventHandler(this.btnTamabahkamar_Click);
            // 
            // btnEditKamar
            // 
            this.btnEditKamar.Location = new System.Drawing.Point(173, 487);
            this.btnEditKamar.Name = "btnEditKamar";
            this.btnEditKamar.Size = new System.Drawing.Size(122, 33);
            this.btnEditKamar.TabIndex = 28;
            this.btnEditKamar.Text = "Edit";
            this.btnEditKamar.UseVisualStyleBackColor = true;
            this.btnEditKamar.Click += new System.EventHandler(this.btnEditKamar_Click);
            // 
            // btnChekin
            // 
            this.btnChekin.Location = new System.Drawing.Point(328, 487);
            this.btnChekin.Name = "btnChekin";
            this.btnChekin.Size = new System.Drawing.Size(122, 33);
            this.btnChekin.TabIndex = 29;
            this.btnChekin.Text = "Hapus";
            this.btnChekin.UseVisualStyleBackColor = true;
            this.btnChekin.Click += new System.EventHandler(this.btnChekin_Click);
            // 
            // btnCariKamar
            // 
            this.btnCariKamar.Location = new System.Drawing.Point(839, 23);
            this.btnCariKamar.Name = "btnCariKamar";
            this.btnCariKamar.Size = new System.Drawing.Size(122, 33);
            this.btnCariKamar.TabIndex = 30;
            this.btnCariKamar.Text = "Search";
            this.btnCariKamar.UseVisualStyleBackColor = true;
            this.btnCariKamar.Click += new System.EventHandler(this.btnCariKamar_Click);
            // 
            // txtDataKamar
            // 
            this.txtDataKamar.Location = new System.Drawing.Point(454, 23);
            this.txtDataKamar.Multiline = true;
            this.txtDataKamar.Name = "txtDataKamar";
            this.txtDataKamar.Size = new System.Drawing.Size(356, 30);
            this.txtDataKamar.TabIndex = 31;
            // 
            // datakamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 544);
            this.Controls.Add(this.txtDataKamar);
            this.Controls.Add(this.btnCariKamar);
            this.Controls.Add(this.btnChekin);
            this.Controls.Add(this.btnEditKamar);
            this.Controls.Add(this.btnTamabahkamar);
            this.Controls.Add(this.lvlKamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "datakamar";
            this.Text = "datakamar";
            this.Load += new System.EventHandler(this.datakamar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvlKamar;
        private System.Windows.Forms.Button btnTamabahkamar;
        private System.Windows.Forms.Button btnEditKamar;
        private System.Windows.Forms.Button btnChekin;
        private System.Windows.Forms.Button btnCariKamar;
        private System.Windows.Forms.TextBox txtDataKamar;
    }
}