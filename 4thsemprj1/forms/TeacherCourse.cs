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
    public partial class TeacherCourse : Form
    {
        public readonly TeacherModel _teacher;
        public TeacherCourse(TeacherModel teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            Load += TeacherCourse_Load;
        }

        private void TeacherCourse_Load(object sender, EventArgs e)
        {
            LoadCourseList();
            LoadTeacherCourse();
        }

        public void LoadCourseList()
        {
            using (var conn = Connection.GetDbConnection())
            {
                var query = "SELECT * FROM `course`";

                var courses = conn.Query<CourseModel>(query);

                courseComboBox.DataSource = courses;
                courseComboBox.DisplayMember = nameof(CourseModel.CourseName);
                courseComboBox.ValueMember = nameof(CourseModel.ID);
            }
        }

        public void LoadTeacherCourse()
        {
            tcrIdtxt.Text = _teacher.Id;
            fNametxt.Text = _teacher.FirstName;
            lNametxt.Text = _teacher.LastName;
            addresstxt.Text = _teacher.Address;
            dobtxt.Text = _teacher.DOB.ToString();
            emailtxt.Text = _teacher.Email;
            cNumbertxt.Text = _teacher.ContactNumber;
            gendertxt.Text = _teacher.Gender;


            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT tc.Id, t.FirstName FirstName, t.LastName LastName, c.CourseName CourseName, tc.Join_Date Join_Date FROM `teacher_course` tc inner join teacher t on tc.Teacher_Id = t.ID
                INNER JOIN course c on tc.Course_Id = c.ID where tc.Teacher_Id = @teacherId";

                var teacherCourses = conn.Query<TeacherCourseModel>(query, new
                {
                    teacherId = _teacher.Id
                });

                tcrcoursegridview.DataSource = teacherCourses;
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var conn = Connection.GetDbConnection();

            var courseId = courseComboBox.SelectedValue;

            //define query
            var query = @"INSERT INTO `teacher_course` (`ID`, `Teacher_Id`, `Course_Id`, `Join_Date`) VALUES (NULL, @TeacherId, @CourseId, @JoinDate);";

            conn.Execute(query, new
            {
                TeacherId = _teacher.Id,
                CourseId = courseId,
                JoinDate = DateTime.Now,
            });
            MessageBox.Show("Course Added");
            LoadTeacherCourse();
        }

        private void lNametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
