namespace HotelReservasi.View
{
    partial class ReservationForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvgReservation = new System.Windows.Forms.DataGridView();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.DateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtRoomTR = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtRoomNR = new System.Windows.Forms.TextBox();
            this.txtNameR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Check Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Check In";
            // 
            // dvgReservation
            // 
            this.dvgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReservation.Location = new System.Drawing.Point(386, 37);
            this.dvgReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgReservation.Name = "dvgReservation";
            this.dvgReservation.RowHeadersWidth = 62;
            this.dvgReservation.Size = new System.Drawing.Size(705, 636);
            this.dvgReservation.TabIndex = 27;
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.Location = new System.Drawing.Point(206, 557);
            this.btnDeleteR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(112, 35);
            this.btnDeleteR.TabIndex = 26;
            this.btnDeleteR.Text = "Delete";
            this.btnDeleteR.UseVisualStyleBackColor = true;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(56, 557);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(112, 35);
            this.btnAddReservation.TabIndex = 25;
            this.btnAddReservation.Text = "Reservasi";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tipe Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "No Kamar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nama";
            // 
            // DateCheckOut
            // 
            this.DateCheckOut.Location = new System.Drawing.Point(56, 486);
            this.DateCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateCheckOut.Name = "DateCheckOut";
            this.DateCheckOut.Size = new System.Drawing.Size(298, 26);
            this.DateCheckOut.TabIndex = 20;
            // 
            // DateCheckIn
            // 
            this.DateCheckIn.Location = new System.Drawing.Point(56, 406);
            this.DateCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateCheckIn.Name = "DateCheckIn";
            this.DateCheckIn.Size = new System.Drawing.Size(298, 26);
            this.DateCheckIn.TabIndex = 19;
            // 
            // txtRoomTR
            // 
            this.txtRoomTR.Location = new System.Drawing.Point(49, 246);
            this.txtRoomTR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomTR.Name = "txtRoomTR";
            this.txtRoomTR.Size = new System.Drawing.Size(148, 26);
            this.txtRoomTR.TabIndex = 18;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(49, 326);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(236, 26);
            this.txtHarga.TabIndex = 17;
            // 
            // txtRoomNR
            // 
            this.txtRoomNR.Location = new System.Drawing.Point(49, 163);
            this.txtRoomNR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNR.Name = "txtRoomNR";
            this.txtRoomNR.Size = new System.Drawing.Size(148, 26);
            this.txtRoomNR.TabIndex = 16;
            // 
            // txtNameR
            // 
            this.txtNameR.Location = new System.Drawing.Point(49, 74);
            this.txtNameR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameR.Name = "txtNameR";
            this.txtNameR.Size = new System.Drawing.Size(300, 26);
            this.txtNameR.TabIndex = 15;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 707);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dvgReservation);
            this.Controls.Add(this.btnDeleteR);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateCheckOut);
            this.Controls.Add(this.DateCheckIn);
            this.Controls.Add(this.txtRoomTR);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtRoomNR);
            this.Controls.Add(this.txtNameR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dvgReservation;
        private System.Windows.Forms.Button btnDeleteR;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateCheckOut;
        private System.Windows.Forms.DateTimePicker DateCheckIn;
        private System.Windows.Forms.TextBox txtRoomTR;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtRoomNR;
        private System.Windows.Forms.TextBox txtNameR;
    }
}