using _4thsemprj1.Extensions;
using _4thsemprj1.Models;
using Dapper;
using System;
using System.Collections;
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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            Load += Teacher_Load;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            AttachEventListeners();
            LoadTeachers();
        }

        private void AttachEventListeners()
        {
            searchbtn.Click += searchbtn_Click;
            tcrgridview.CellClick += tcrgridview_CellClick;
        }

        private void Tcrgridview_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            //get connection

            var conn = Connection.GetDbConnection();

            var search = searchtxt.Text.ValueOrNull();


            //define query
            var query = "SELECT * FROM `teacher` where (@Search is null) or (ID = @Search) or (FirstName = @Search) or (LastName = @Search) " +
                "or (Email = @Search) or (ContactNumber = @Search) or (Gender = @Search);";

            var teachers = conn.Query<TeacherModel>(query, new
            {
                Search = search,
            });
            tcrgridview.DataSource = teachers;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var addtcr = new Addtcr();
            this.Hide();
            addtcr.ShowDialog();
            LoadTeachers();
            Show();
        }

        public TeacherModel _selectedTeacher;
        private void tcrgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedTeacher = (TeacherModel) tcrgridview.CurrentRow?.DataBoundItem;
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            if (_selectedTeacher == null)
            {
                MessageBox.Show("Please select a Teacher.");
                LoadTeachers();
                return;
            }
            var Updtcr = new updtcr(_selectedTeacher);
            this.Hide();
            Updtcr.ShowDialog();
            Show();
            LoadTeachers();
        }

        

        private void dltbtn_Click(object sender, EventArgs e)
        {
            if(_selectedTeacher == null)
            {
                MessageBox.Show("No Row selected.");
                LoadTeachers();
                return;
            }
            else
            {
                var conn = Connection.GetDbConnection();
                var query = "delete from `teacher` where ID = @Id";
                conn.Execute(query, new
                {
                    Id = _selectedTeacher.Id,
                });
                LoadTeachers();
                MessageBox.Show("Deleted");
                
            }
        }

        private void tcrgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tcrcoursebtn_Click(object sender, EventArgs e)
        {
            if (_selectedTeacher == null)
            {
                MessageBox.Show("Please select a Teacher.");
                LoadTeachers();
                return;
            }
            var tcrcourse = new TeacherCourse(_selectedTeacher);
            this.Hide();
            tcrcourse.ShowDialog();
            Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
