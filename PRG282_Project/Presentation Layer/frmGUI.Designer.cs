
namespace PRG282_Project
{
    partial class frmGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.dgvDisplayStudentData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNav = new System.Windows.Forms.GroupBox();
            this.btnToLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBackToTop = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.gbCRUD = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbSearchForStudent = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.pbCloseApp = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentData)).BeginInit();
            this.gbNav.SuspendLayout();
            this.gbCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.AutoSize = true;
            this.lblUserLoggedIn.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoggedIn.Location = new System.Drawing.Point(924, 12);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(56, 13);
            this.lblUserLoggedIn.TabIndex = 2;
            this.lblUserLoggedIn.Text = "Aisheel";
            // 
            // dgvDisplayStudentData
            // 
            this.dgvDisplayStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStudentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDisplayStudentData.Location = new System.Drawing.Point(22, 82);
            this.dgvDisplayStudentData.Name = "dgvDisplayStudentData";
            this.dgvDisplayStudentData.RowTemplate.Height = 35;
            this.dgvDisplayStudentData.Size = new System.Drawing.Size(941, 302);
            this.dgvDisplayStudentData.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StudentNumber";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Image";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DOB";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Address";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ModuleCodes";
            this.Column9.Name = "Column9";
            // 
            // gbNav
            // 
            this.gbNav.Controls.Add(this.btnToLast);
            this.gbNav.Controls.Add(this.btnNext);
            this.gbNav.Controls.Add(this.btnBackToTop);
            this.gbNav.Controls.Add(this.btnPrevious);
            this.gbNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbNav.Location = new System.Drawing.Point(12, 390);
            this.gbNav.Name = "gbNav";
            this.gbNav.Size = new System.Drawing.Size(960, 65);
            this.gbNav.TabIndex = 4;
            this.gbNav.TabStop = false;
            this.gbNav.Text = "Navigation";
            // 
            // btnToLast
            // 
            this.btnToLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.btnToLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLast.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLast.Location = new System.Drawing.Point(637, 15);
            this.btnToLast.Name = "btnToLast";
            this.btnToLast.Size = new System.Drawing.Size(75, 40);
            this.btnToLast.TabIndex = 21;
            this.btnToLast.Text = ">>";
            this.btnToLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(531, 15);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBackToTop
            // 
            this.btnBackToTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.btnBackToTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToTop.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToTop.Location = new System.Drawing.Point(240, 15);
            this.btnBackToTop.Name = "btnBackToTop";
            this.btnBackToTop.Size = new System.Drawing.Size(75, 40);
            this.btnBackToTop.TabIndex = 19;
            this.btnBackToTop.Text = "<<";
            this.btnBackToTop.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(223)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(347, 15);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 40);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // gbCRUD
            // 
            this.gbCRUD.Controls.Add(this.button1);
            this.gbCRUD.Controls.Add(this.btnDelete);
            this.gbCRUD.Controls.Add(this.tbSearchForStudent);
            this.gbCRUD.Controls.Add(this.btnUpdate);
            this.gbCRUD.Controls.Add(this.lblSearch);
            this.gbCRUD.Controls.Add(this.btnRead);
            this.gbCRUD.Controls.Add(this.btnCreate);
            this.gbCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCRUD.Location = new System.Drawing.Point(12, 461);
            this.gbCRUD.Name = "gbCRUD";
            this.gbCRUD.Size = new System.Drawing.Size(960, 70);
            this.gbCRUD.TabIndex = 5;
            this.gbCRUD.TabStop = false;
            this.gbCRUD.Text = "CRUD Operations and Search";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Niagara Engraved", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(791, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 46);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbSearchForStudent
            // 
            this.tbSearchForStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchForStudent.Location = new System.Drawing.Point(418, 28);
            this.tbSearchForStudent.Name = "tbSearchForStudent";
            this.tbSearchForStudent.Size = new System.Drawing.Size(100, 20);
            this.tbSearchForStudent.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(637, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 46);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(365, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(82)))));
            this.btnRead.FlatAppearance.BorderSize = 2;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(193, 16);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(137, 46);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(223)))));
            this.btnCreate.FlatAppearance.BorderSize = 2;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Niagara Engraved", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(33, 16);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 46);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::PRG282_Project.Properties.Resources.Logout;
            this.pbLogout.Location = new System.Drawing.Point(458, 3);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(27, 28);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 43;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // pbCloseApp
            // 
            this.pbCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseApp.Image = global::PRG282_Project.Properties.Resources.CloseApp;
            this.pbCloseApp.Location = new System.Drawing.Point(489, 3);
            this.pbCloseApp.Name = "pbCloseApp";
            this.pbCloseApp.Size = new System.Drawing.Size(29, 28);
            this.pbCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseApp.TabIndex = 42;
            this.pbCloseApp.TabStop = false;
            this.pbCloseApp.Click += new System.EventHandler(this.pbCloseApp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PRG282_Project.Properties.Resources.GUI_Profile;
            this.pictureBox2.Location = new System.Drawing.Point(884, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.bc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 540);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbCloseApp);
            this.Controls.Add(this.gbCRUD);
            this.Controls.Add(this.gbNav);
            this.Controls.Add(this.dgvDisplayStudentData);
            this.Controls.Add(this.lblUserLoggedIn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 579);
            this.MinimumSize = new System.Drawing.Size(1000, 579);
            this.Name = "frmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System";
            this.Load += new System.EventHandler(this.frmGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentData)).EndInit();
            this.gbNav.ResumeLayout(false);
            this.gbCRUD.ResumeLayout(false);
            this.gbCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.DataGridView dgvDisplayStudentData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox gbNav;
        private System.Windows.Forms.GroupBox gbCRUD;
        private System.Windows.Forms.Button btnToLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBackToTop;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearchForStudent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pbCloseApp;
        private System.Windows.Forms.PictureBox pbLogout;
    }
}