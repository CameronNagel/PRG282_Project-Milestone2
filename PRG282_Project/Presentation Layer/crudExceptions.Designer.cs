
namespace PRG282_Project.PresentationLayer
{
    partial class crudExceptions
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDeleteRecord = new System.Windows.Forms.Label();
            this.btnYES = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.caution_CRUD;
            this.pictureBox1.Location = new System.Drawing.Point(174, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.pictureBox2.Image = global::PRG282_Project.Properties.Resources.loading_bar1;
            this.pictureBox2.Location = new System.Drawing.Point(-18, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // lblDeleteRecord
            // 
            this.lblDeleteRecord.AutoSize = true;
            this.lblDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.lblDeleteRecord.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteRecord.ForeColor = System.Drawing.Color.Coral;
            this.lblDeleteRecord.Location = new System.Drawing.Point(97, 86);
            this.lblDeleteRecord.Name = "lblDeleteRecord";
            this.lblDeleteRecord.Size = new System.Drawing.Size(207, 26);
            this.lblDeleteRecord.TabIndex = 29;
            this.lblDeleteRecord.Text = "Are you sure you want to \r\ndelete this record?\r\n";
            this.lblDeleteRecord.Visible = false;
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnYES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnYES.FlatAppearance.BorderSize = 2;
            this.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYES.Font = new System.Drawing.Font("Niagara Engraved", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.ForeColor = System.Drawing.Color.White;
            this.btnYES.Location = new System.Drawing.Point(136, 124);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(49, 39);
            this.btnYES.TabIndex = 31;
            this.btnYES.Text = "Yes";
            this.btnYES.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnNo.FlatAppearance.BorderSize = 2;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Niagara Engraved", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(204, 124);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(49, 39);
            this.btnNo.TabIndex = 32;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.lblUpdate.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Coral;
            this.lblUpdate.Location = new System.Drawing.Point(97, 86);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(207, 26);
            this.lblUpdate.TabIndex = 33;
            this.lblUpdate.Text = "Are you sure you want to \r\nupdate this record?\r\n";
            this.lblUpdate.Visible = false;
            // 
            // crudExceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 216);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.lblDeleteRecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(393, 255);
            this.MinimumSize = new System.Drawing.Size(393, 255);
            this.Name = "crudExceptions";
            this.Text = "crudExceptions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeleteRecord;
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblUpdate;
    }
}