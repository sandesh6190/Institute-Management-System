namespace _4thsemprj1.forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.Studentbtn = new System.Windows.Forms.Button();
            this.teacherbtn = new System.Windows.Forms.Button();
            this.paymentbtn = new System.Windows.Forms.Button();
            this.coursebtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(273, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTITUTE MANAGEMENT SYSTEM";
            // 
            // Studentbtn
            // 
            this.Studentbtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentbtn.ForeColor = System.Drawing.Color.Red;
            this.Studentbtn.Image = ((System.Drawing.Image)(resources.GetObject("Studentbtn.Image")));
            this.Studentbtn.Location = new System.Drawing.Point(139, 126);
            this.Studentbtn.Name = "Studentbtn";
            this.Studentbtn.Size = new System.Drawing.Size(307, 218);
            this.Studentbtn.TabIndex = 8;
            this.Studentbtn.Text = "STUDENT";
            this.Studentbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Studentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Studentbtn.UseVisualStyleBackColor = true;
            this.Studentbtn.Click += new System.EventHandler(this.Studentbtn_Click);
            // 
            // teacherbtn
            // 
            this.teacherbtn.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.teacherbtn.ForeColor = System.Drawing.Color.Red;
            this.teacherbtn.Image = ((System.Drawing.Image)(resources.GetObject("teacherbtn.Image")));
            this.teacherbtn.Location = new System.Drawing.Point(627, 126);
            this.teacherbtn.Name = "teacherbtn";
            this.teacherbtn.Size = new System.Drawing.Size(307, 218);
            this.teacherbtn.TabIndex = 9;
            this.teacherbtn.Text = "TEACHER";
            this.teacherbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.teacherbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.teacherbtn.UseVisualStyleBackColor = true;
            this.teacherbtn.Click += new System.EventHandler(this.teacherbtn_Click);
            // 
            // paymentbtn
            // 
            this.paymentbtn.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.paymentbtn.ForeColor = System.Drawing.Color.Red;
            this.paymentbtn.Image = ((System.Drawing.Image)(resources.GetObject("paymentbtn.Image")));
            this.paymentbtn.Location = new System.Drawing.Point(627, 385);
            this.paymentbtn.Name = "paymentbtn";
            this.paymentbtn.Size = new System.Drawing.Size(307, 218);
            this.paymentbtn.TabIndex = 11;
            this.paymentbtn.Text = "PAYMENT";
            this.paymentbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paymentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.paymentbtn.UseVisualStyleBackColor = true;
            this.paymentbtn.Click += new System.EventHandler(this.paymentbtn_Click);
            // 
            // coursebtn
            // 
            this.coursebtn.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.coursebtn.ForeColor = System.Drawing.Color.Red;
            this.coursebtn.Image = ((System.Drawing.Image)(resources.GetObject("coursebtn.Image")));
            this.coursebtn.Location = new System.Drawing.Point(139, 385);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Size = new System.Drawing.Size(307, 218);
            this.coursebtn.TabIndex = 12;
            this.coursebtn.Text = "COURSE";
            this.coursebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coursebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.coursebtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(899, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 108);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1210, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.coursebtn);
            this.Controls.Add(this.paymentbtn);
            this.Controls.Add(this.teacherbtn);
            this.Controls.Add(this.Studentbtn);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Studentbtn;
        private System.Windows.Forms.Button teacherbtn;
        private System.Windows.Forms.Button paymentbtn;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}