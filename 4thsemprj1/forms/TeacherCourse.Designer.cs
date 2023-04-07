namespace _4thsemprj1.forms
{
    partial class TeacherCourse
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
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.tcrIdtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.tcrcoursegridview = new System.Windows.Forms.DataGridView();
            this.dobtxt = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gendertxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cNumbertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lNametxt = new System.Windows.Forms.TextBox();
            this.fNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tcrcoursegridview)).BeginInit();
            this.SuspendLayout();
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(1058, 247);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(142, 35);
            this.courseComboBox.TabIndex = 94;
            // 
            // tcrIdtxt
            // 
            this.tcrIdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcrIdtxt.Location = new System.Drawing.Point(53, 100);
            this.tcrIdtxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.tcrIdtxt.Name = "tcrIdtxt";
            this.tcrIdtxt.Size = new System.Drawing.Size(228, 30);
            this.tcrIdtxt.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 90;
            this.label8.Text = "Teacher ID";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.DarkOrange;
            this.submitbtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.submitbtn.Location = new System.Drawing.Point(1058, 294);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(142, 42);
            this.submitbtn.TabIndex = 89;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // tcrcoursegridview
            // 
            this.tcrcoursegridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tcrcoursegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tcrcoursegridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.tcrcoursegridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tcrcoursegridview.Location = new System.Drawing.Point(288, 134);
            this.tcrcoursegridview.Name = "tcrcoursegridview";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tcrcoursegridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tcrcoursegridview.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.tcrcoursegridview.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tcrcoursegridview.RowTemplate.Height = 24;
            this.tcrcoursegridview.Size = new System.Drawing.Size(764, 406);
            this.tcrcoursegridview.TabIndex = 88;
            // 
            // dobtxt
            // 
            this.dobtxt.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobtxt.Location = new System.Drawing.Point(53, 333);
            this.dobtxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(228, 30);
            this.dobtxt.TabIndex = 87;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 306);
            this.label10.MinimumSize = new System.Drawing.Size(228, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 30);
            this.label10.TabIndex = 86;
            this.label10.Text = "Date Of Birth";
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(53, 275);
            this.addresstxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(228, 30);
            this.addresstxt.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 247);
            this.label9.MinimumSize = new System.Drawing.Size(228, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 30);
            this.label9.TabIndex = 84;
            this.label9.Text = "Address";
            // 
            // gendertxt
            // 
            this.gendertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertxt.FormattingEnabled = true;
            this.gendertxt.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendertxt.Location = new System.Drawing.Point(54, 510);
            this.gendertxt.MinimumSize = new System.Drawing.Size(228, 0);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(228, 30);
            this.gendertxt.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(402, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 34);
            this.label7.TabIndex = 82;
            this.label7.Text = "TEACHER COURSE";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(54, 390);
            this.emailtxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(228, 30);
            this.emailtxt.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 366);
            this.label2.MinimumSize = new System.Drawing.Size(228, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 30);
            this.label2.TabIndex = 80;
            this.label2.Text = "Email";
            // 
            // cNumbertxt
            // 
            this.cNumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNumbertxt.Location = new System.Drawing.Point(54, 455);
            this.cNumbertxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.cNumbertxt.Name = "cNumbertxt";
            this.cNumbertxt.Size = new System.Drawing.Size(228, 30);
            this.cNumbertxt.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1082, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 486);
            this.label5.MinimumSize = new System.Drawing.Size(228, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 30);
            this.label5.TabIndex = 77;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 431);
            this.label6.MinimumSize = new System.Drawing.Size(228, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 30);
            this.label6.TabIndex = 76;
            this.label6.Text = "Contact Number";
            // 
            // lNametxt
            // 
            this.lNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNametxt.Location = new System.Drawing.Point(53, 216);
            this.lNametxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.lNametxt.Name = "lNametxt";
            this.lNametxt.Size = new System.Drawing.Size(228, 30);
            this.lNametxt.TabIndex = 75;
            this.lNametxt.TextChanged += new System.EventHandler(this.lNametxt_TextChanged);
            // 
            // fNametxt
            // 
            this.fNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNametxt.Location = new System.Drawing.Point(53, 159);
            this.fNametxt.MinimumSize = new System.Drawing.Size(228, 30);
            this.fNametxt.Name = "fNametxt";
            this.fNametxt.Size = new System.Drawing.Size(228, 30);
            this.fNametxt.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 192);
            this.label3.MinimumSize = new System.Drawing.Size(228, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 30);
            this.label3.TabIndex = 73;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 131);
            this.label1.MinimumSize = new System.Drawing.Size(228, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 72;
            this.label1.Text = "First Name";
            // 
            // TeacherCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1292, 604);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.tcrIdtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.tcrcoursegridview);
            this.Controls.Add(this.dobtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gendertxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cNumbertxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lNametxt);
            this.Controls.Add(this.fNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "TeacherCourse";
            this.Text = "TeacherCourse";
            ((System.ComponentModel.ISupportInitialize)(this.tcrcoursegridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.TextBox tcrIdtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.DataGridView tcrcoursegridview;
        private System.Windows.Forms.DateTimePicker dobtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox gendertxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cNumbertxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lNametxt;
        private System.Windows.Forms.TextBox fNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}