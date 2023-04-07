namespace _4thsemprj1.forms
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stdgridview = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            this.std = new System.Windows.Forms.Label();
            this.stdcrsbtn = new System.Windows.Forms.Button();
            this.paymentbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stdgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.addbtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.addbtn.Location = new System.Drawing.Point(0, 149);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(189, 42);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "ADMISSION";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.MinimumSize = new System.Drawing.Size(192, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 565);
            this.label1.TabIndex = 3;
            // 
            // stdgridview
            // 
            this.stdgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stdgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stdgridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.stdgridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.stdgridview.Location = new System.Drawing.Point(190, 74);
            this.stdgridview.Name = "stdgridview";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stdgridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stdgridview.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.stdgridview.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.stdgridview.RowTemplate.Height = 24;
            this.stdgridview.Size = new System.Drawing.Size(977, 493);
            this.stdgridview.TabIndex = 4;
            this.stdgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stdgridview_CellClick);
            this.stdgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stdgridview_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(165, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 5;
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(683, 21);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(201, 28);
            this.searchtxt.TabIndex = 8;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(904, 21);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 29);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.updbtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.updbtn.Location = new System.Drawing.Point(0, 211);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(189, 42);
            this.updbtn.TabIndex = 9;
            this.updbtn.Text = "UPDATE";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.dltbtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.dltbtn.Location = new System.Drawing.Point(-1, 401);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(190, 42);
            this.dltbtn.TabIndex = 10;
            this.dltbtn.Text = "DELETE";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // std
            // 
            this.std.AutoSize = true;
            this.std.BackColor = System.Drawing.SystemColors.HotTrack;
            this.std.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.std.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std.Location = new System.Drawing.Point(210, 23);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(142, 30);
            this.std.TabIndex = 11;
            this.std.Text = "STUDENTS";
            // 
            // stdcrsbtn
            // 
            this.stdcrsbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.stdcrsbtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdcrsbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.stdcrsbtn.Location = new System.Drawing.Point(0, 275);
            this.stdcrsbtn.Name = "stdcrsbtn";
            this.stdcrsbtn.Size = new System.Drawing.Size(189, 42);
            this.stdcrsbtn.TabIndex = 14;
            this.stdcrsbtn.Text = "STUDENT COURSE";
            this.stdcrsbtn.UseVisualStyleBackColor = false;
            this.stdcrsbtn.Click += new System.EventHandler(this.stdcrsbtn_Click);
            // 
            // paymentbtn
            // 
            this.paymentbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.paymentbtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.paymentbtn.Location = new System.Drawing.Point(0, 336);
            this.paymentbtn.Name = "paymentbtn";
            this.paymentbtn.Size = new System.Drawing.Size(189, 42);
            this.paymentbtn.TabIndex = 15;
            this.paymentbtn.Text = "PAYMENT";
            this.paymentbtn.UseVisualStyleBackColor = false;
            this.paymentbtn.Click += new System.EventHandler(this.paymentbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 109);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1170, 597);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.paymentbtn);
            this.Controls.Add(this.stdcrsbtn);
            this.Controls.Add(this.std);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.stdgridview);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.stdgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stdgridview;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox searchtxt;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Label std;
        private System.Windows.Forms.Button stdcrsbtn;
        private System.Windows.Forms.Button paymentbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}