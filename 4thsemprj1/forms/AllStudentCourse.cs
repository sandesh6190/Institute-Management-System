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
    public partial class AllStudentCourse : Form
    {
        public AllStudentCourse()
        {
            InitializeComponent();
            Load += AllStudentCourse_Load;
        }

        private void AllStudentCourse_Load(object sender, EventArgs e)
        {
            LoadAllStudentCourse();

        }

        public void LoadAllStudentCourse()
        {

            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT sc.Id, s.FirstName FirstName, s.LastName LastName, c.CourseName CourseName, sc.JoinDate JoinDate FROM `student_course` sc inner join student s on sc.StudentId = s.ID
                INNER JOIN course c on sc.CourseId = c.ID;";

                var studentCourses = conn.Query<StudentCourseModel>(query, new
                {

                });

                stdcoursegridview.DataSource = studentCourses;
            }
        }

        private void stdcoursegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var search = searchtxt.Text.ValueOrNull();

            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT sc.Id Id, s.FirstName FirstName, s.LastName LastName, c.CourseName CourseName, sc.JoinDate JoinDate FROM `student_course` sc inner join student s on sc.StudentId = s.ID
                INNER JOIN course c on sc.CourseId = c.ID where (@Search is null) or (sc.Id = @Search) or (s.FirstName = @Search) or (s.LastName = @Search) or (c.CourseName = @Search) or (sc.JoinDate = @Search);";

                var studentCourses = conn.Query<StudentCourseModel>(query, new
                {
                    Search = search,
                });

                stdcoursegridview.DataSource = studentCourses;
            }
        }
    }
}
