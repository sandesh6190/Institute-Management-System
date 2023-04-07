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
using System.Xml.Linq;

namespace _4thsemprj1.forms
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            var course = crsNametxt.Text;
            var minTime = minTimetxt.Text;
            var maxTime = maxTimetxt.Text;
            var actualFee = actualFeetxt.Text;

            //get connection

            var conn = Connection.GetDbConnection();

            //define query
            var query = "INSERT INTO `course` (`ID`, `CourseName`, `MinimumTime`, `MaximumTime`, `ActualFee`) " +
                "VALUES (NULL, @CName, @MinTime, @MaxTime, @ActualFee);";

            //Execution
            conn.Execute(query, new
            {
                CName = course,
                MinTime = minTime,
                MaxTime = maxTime,
                ActualFee = actualFee,
            });

            MessageBox.Show("Course Added");

            crsNametxt.Clear();
            minTimetxt.Clear();
            maxTimetxt.Clear();
            actualFeetxt.Clear();
            crsNametxt.Focus();

            return;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            crsNametxt.Clear();
            minTimetxt.Clear();
            maxTimetxt.Clear();
            actualFeetxt.Clear();
            crsNametxt.Focus();
        }
    }
}
