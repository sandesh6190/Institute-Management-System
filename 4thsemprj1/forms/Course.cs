using _4thsemprj1.Extensions;
using _4thsemprj1.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4thsemprj1.forms
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            Load += Course_Load;

        }

        private void Course_Load(object sender, EventArgs e)
        {
            AttachEventListener();
            LoadCourse();
        }

        public void AttachEventListener()
        {
            btnSubmit.Click += btnSubmit_Click;
            stdcoursegridview.CellClick += Stdcoursegridview_CellClick;
        }

        private CourseModel _selectedCourse;
        private void Stdcoursegridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCourse = (CourseModel)stdcoursegridview.CurrentRow?.DataBoundItem;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoadCourse();
        }
        public void LoadCourse()
        {
            //get connection

            var conn = Connection.GetDbConnection();

            var search = searchtxt.Text.ValueOrNull();

            //define query
            var query = "SELECT c.*, (select count(*) from student_course sc WHERE sc.CourseId = c.ID) No_Of_Student FROM `course` c where (@Search is null) or (ID = @Search) or(CourseName = @Search) or (MinimumTime = @Search)" +
                "or (MaximumTime = @Search) or (ActualFee = @Search);";

            //var query2 = "SELECT COUNT (*) FROM `student_course` where `student_course`.`CourseId` == `course`.ID;";


            var courses = conn.Query<CourseModel>(query, new
            {
                Search = search,
            });
            stdcoursegridview.DataSource = courses;

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var newform = new AddCourse();
            this.Hide();
            newform.ShowDialog();
            Show();
            LoadCourse();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            if (_selectedCourse == null)
            {
                MessageBox.Show("Please select a Course.");
                LoadCourse();
                return;
            }
            var newform = new updcourse(_selectedCourse);
            this.Hide();
            newform.ShowDialog();
            Show();
            LoadCourse();
        }

        
        
        private void dltbtn_Click(object sender, EventArgs e)
        {
            if (_selectedCourse == null)
            {
                MessageBox.Show("Nothing is selected");
                LoadCourse();
                return;
            }
            else
            {
                var conn = Connection.GetDbConnection();
                var query = "delete from `course` where ID = @Id;";
                conn.Execute(query, new
                {
                    Id = _selectedCourse.ID,
                });
                LoadCourse();
                MessageBox.Show("Deleted");
            }
        }

        private void stdcoursebtn_Click(object sender, EventArgs e)
        {
            var newform = new AllStudentCourse();
            this.Hide();
            newform.ShowDialog();
            Show();
            LoadCourse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new AllTeacherCourse();
            this.Hide();
            newform.ShowDialog();
            Show();
            LoadCourse();
        }
    }
}
