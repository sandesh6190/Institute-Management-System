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
    public partial class updstd : Form
    {
        private readonly StudentModel _student;
        public updstd(StudentModel student)
        {
            InitializeComponent();
            _student = student;
            Load += Updstd_Load;
        }

        private void Updstd_Load(object sender, EventArgs e)
        {
            Loadupdstd();
        }

        public void Loadupdstd()
        {
            fNametxt.Text = _student.FirstName;
            lNametxt.Text = _student.LastName;
            addresstxt.Text = _student.Address;
            dobtxt.Text = _student.DOB.ToString();
            emailtxt.Text = _student.Email;
            cNumbertxt.Text = _student.ContactNumber;
            gendertxt.Text = _student.Gender;
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

            var query = @"UPDATE `student` SET `FirstName` = @FName, `LastName` = @LName, `Address` = @Address, `DOB` = @DOB, `Email` = @Email, `ContactNumber` = @CNumber,"+ 
                "`Gender` = @Gender WHERE `student`.`ID` = @id;";

            conn.Execute(query, new
            {
                FName = fName,
                LName = lName,
                Address = address,
                DOB = dob,
                Email = email,
                CNumber = cNumber,
                Gender = gender,

                id = _student.Id,
            });

            MessageBox.Show("Information Updated");

            clearfunction();
            return;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
        private void updstd_Load(object sender, EventArgs e)
        {

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
