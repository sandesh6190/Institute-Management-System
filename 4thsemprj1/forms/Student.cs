using _4thsemprj1.Extensions;
using _4thsemprj1.Models;
using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Google.Protobuf;

namespace _4thsemprj1.forms
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            Load += Student_Load;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            AttachEventListeners();
            LoadStudents();
        }

        private void AttachEventListeners()
        {
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            //get connection

            var conn = Connection.GetDbConnection();

            var search = searchtxt.Text.ValueOrNull();

            //define query
            var query = "SELECT * FROM `student` where (@Search is null) or (ID = @Search) or(FirstName = @Search) or (LastName = @Search)" +
                "or (Address = @Search) or (Email = @Search) or (ContactNumber = @Search) or (Gender = @Search);";

            var students = conn.Query<StudentModel>(query, new
            {
                Search = search,
            });
            stdgridview.DataSource = students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addstd = new Addstd();
            this.Hide();
            addstd.ShowDialog();
            Show();
            LoadStudents();
        }

        private void stdgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }

        private void Student_Load_1(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please select a student");
                LoadStudents();
                return;
            }
            var Updstd = new updstd(_selectedStudent);
            this.Hide();
            Updstd.ShowDialog();
            Show();
            LoadStudents();
        }

        private StudentModel _selectedStudent;

        private void stdgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            _selectedStudent =  (StudentModel) stdgridview.CurrentRow?.DataBoundItem;

        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Nothing is selected");
                LoadStudents();
                return;
            }
            else
            {
                var conn = Connection.GetDbConnection();
                var query = "delete from `student` where ID = @Id";
                conn.Execute(query, new
                {
                    Id = _selectedStudent.Id,
                });
                LoadStudents();
                MessageBox.Show("Deleted");
            }
        }

        private void stdcrsbtn_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please select a student");
                LoadStudents();
                return;
            }
            var stdcourse = new StudentCourse(_selectedStudent);
            this.Hide();
            stdcourse.ShowDialog();
            Show();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please select a student");
                LoadStudents();
                return;
            }
            var stdpayment = new StudentPayment(_selectedStudent);
            this.Hide();
            stdpayment.ShowDialog();
            Show();
        }
    }
}
