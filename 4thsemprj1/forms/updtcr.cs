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
    public partial class updtcr : Form
    {
        private readonly TeacherModel _teacher;
        public updtcr(TeacherModel teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            Load += Updtcr_Load;
        }

        private void Updtcr_Load(object sender, EventArgs e)
        {
            LoadUpdTeacher();
        }

        public void LoadUpdTeacher()
        {
            fNametxt.Text = _teacher.FirstName;
            lNametxt.Text = _teacher.LastName;
            addresstxt.Text = _teacher.Address;
            dobtxt.Text = _teacher.DOB.ToString();
            emailtxt.Text = _teacher.Email;
            cNumbertxt.Text = _teacher.ContactNumber;
            gendertxt.Text = _teacher.Gender;

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var fName = fNametxt.Text;
            var lName = lNametxt.Text;
            var address = addresstxt.Text;
            var dob = dobtxt.Value;
            var email = emailtxt.Text;
            var cNumber = cNumbertxt.Text;
            var gender = gendertxt.Text;


            //get connection

            var conn = Connection.GetDbConnection();

            //define query

            var query = "UPDATE `teacher` SET `FirstName` = @FName, `LastName` = @LName, `Address` = @Address, `DOB` = @DOB, `Email` = @Email, `ContactNumber` = @CNumber," +
                " `Gender` = @Gender WHERE `teacher`.`ID` = @id;";

            conn.Execute(query, new
            {
                FName = fName,
                LName = lName,
                Address = address,
                DOB = dob,
                Email = email,
                CNumber = cNumber,
                Gender = gender,

                id = _teacher.Id,
            });

            MessageBox.Show("Information Updated");

            clearfunction();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearfunction();
        }

        public void clearfunction()
        {
            fNametxt.Clear();
            lNametxt.Clear();
            addresstxt.Clear();
            dobtxt.Value = DateTime.Now;
            emailtxt.Clear();
            cNumbertxt.Clear();
            gendertxt.SelectedValue = null;
            fNametxt.Focus();
        }
    }
}
