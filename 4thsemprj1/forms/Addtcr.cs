﻿using Dapper;
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
    public partial class Addtcr : Form
    {
        public Addtcr()
        {
            InitializeComponent();
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

            var query = "INSERT INTO `teacher` (`ID`, `FirstName`, `LastName`, `Address`, `DOB`, `Email`, `ContactNumber`, `Gender`)" +
                " VALUES (NULL, @FName, @LName, @Address, @DOB, @Email, @CNumber, @Gender);";

            conn.Execute(query, new
            {
                FName = fName,
                LName = lName,
                Address = address,
                DOB = dob,
                Email = email,
                CNumber = cNumber,
                Gender = gender,
            });

            MessageBox.Show("Registration Complete");

            clearfunction();
            return;
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
