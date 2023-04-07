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
    public partial class AllTeacherCourse : Form
    {
        public AllTeacherCourse()
        {
            InitializeComponent();
            Load += AllTeacherCourse_Load;
        }

        private void AllTeacherCourse_Load(object sender, EventArgs e)
        {
            LoadAllTeacherCourse();
        }

        public void LoadAllTeacherCourse()
        {
            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT tc.ID ID, t.FirstName FirstName, t.LastName LastName, c.CourseName CourseName, tc.Join_Date Join_Date FROM `teacher_course` tc inner join teacher t on tc.Teacher_Id = t.ID
                INNER JOIN course c on tc.Course_Id = c.ID;";

                var teacherCourses = conn.Query<TeacherCourseModel>(query, new
                {

                });

                tcrcoursegridview.DataSource = teacherCourses;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var search = searchtxt.Text.ValueOrNull();

            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT tc.ID ID, t.FirstName FirstName, t.LastName LastName, c.CourseName CourseName, tc.Join_Date Join_Date FROM `teacher_course` tc inner join teacher t on tc.Teacher_Id = t.ID
                INNER JOIN course c on tc.Course_Id = c.ID where (@Search is null) or (tc.ID = @Search) or (t.FirstName = @Search) or (t.LastName = @Search) or (c.CourseName = @Search) or (tc.Join_Date = @Search);";

                var teacherCourses = conn.Query<TeacherCourseModel>(query, new
                {
                    Search = search,
                });

                tcrcoursegridview.DataSource = teacherCourses;
            }
        }
    }
}
