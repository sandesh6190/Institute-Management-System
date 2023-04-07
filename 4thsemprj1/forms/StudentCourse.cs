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
    public partial class StudentCourse : Form
    {
        private readonly StudentModel _student;
        public StudentCourse(StudentModel student)
        {
            InitializeComponent();
            _student = student;
            Load += StudentCourse_Load;
        }

        private void StudentCourse_Load(object sender, EventArgs e)
        {
            //AttachEventListeners();
            LoadStudentCourse();
            LoadCourseList();
        }

        private void LoadCourseList()
        {
            using(var conn = Connection.GetDbConnection())
            {
                var query = "SELECT * FROM `course`";

                var courses = conn.Query<CourseModel>(query);

                courseComboBox.DataSource = courses;
                courseComboBox.DisplayMember = nameof(CourseModel.CourseName);
                courseComboBox.ValueMember = nameof(CourseModel.ID);
            }
        }

        public void LoadStudentCourse()
        {
            stdIdtxt.Text = _student.Id;
            fNametxt.Text = _student.FirstName;
            lNametxt.Text = _student.LastName;
            addresstxt.Text = _student.Address;
            dobtxt.Text = _student.DOB.ToString();
            emailtxt.Text = _student.Email;
            cNumbertxt.Text = _student.ContactNumber;
            gendertxt.Text = _student.Gender;

            using(var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT sc.Id, s.FirstName FirstName, s.LastName LastName, c.CourseName CourseName, sc.JoinDate JoinDate FROM `student_course` sc inner join student s on sc.StudentId = s.ID
                INNER JOIN course c on sc.CourseId = c.ID where sc.StudentId = @studentId";

                var studentCourses = conn.Query<StudentCourseModel>(query, new
                {
                    studentId = _student.Id
                });

                stdcoursegridview.DataSource = studentCourses;
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            
            //get connection
            var conn = Connection.GetDbConnection();

            var courseId = courseComboBox.SelectedValue;

            //define query
            var query = @"INSERT INTO `student_course` (`Id`, `StudentId`, `CourseId`, `JoinDate`) VALUES (NULL, @StudentId, @CourseId, @JoinDate);";

            conn.Execute(query, new
            {
                StudentId = _student.Id,
                CourseId = courseId,
                JoinDate = DateTime.Now
            });
            MessageBox.Show("Course Added");
            LoadStudentCourse();
        }
    }
}
