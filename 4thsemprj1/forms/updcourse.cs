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
    public partial class updcourse : Form
    {
        private readonly CourseModel _course;
        public updcourse(CourseModel course)
        {
            InitializeComponent();
            _course = course;
            Load += Updcourse_Load;
        }

        private void Updcourse_Load(object sender, EventArgs e)
        {
            LoadUpdCourse();
        }

        public void LoadUpdCourse()
        {
            crsNametxt.Text = _course.CourseName;
            minTimetxt.Text = _course.MinimumTime;
            maxTimetxt.Text = _course.MaximumTime;
            actualFeetxt.Text = _course.ActualFee;
            crsNametxt.Focus();


        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            var CRSNAME = crsNametxt.Text;
            var MINTIME = minTimetxt.Text;
            var MAXTIME = maxTimetxt.Text;
            var ACTUALFEE = actualFeetxt.Text;

            //get connection

            var conn = Connection.GetDbConnection();

            //define query

            var query = "UPDATE `course` SET `CourseName` = @courseName, `MinimumTime` = @minimumTime, `MaximumTime` = @maximumTime, " +
                " `ActualFee` = @actualFee WHERE (`course`.`ID` = @id);";

            conn.Execute(query, new
            {
                courseName = CRSNAME,
                minimumTime = MINTIME,
                maximumTime = MAXTIME,
                actualFee = ACTUALFEE,

                id = _course.ID,
            });

            MessageBox.Show("Information Updated");

            clearfunction();
        }

        public void clearfunction()
        {
            crsNametxt.Clear();
            minTimetxt.Clear();
            maxTimetxt.Clear();
            actualFeetxt.Clear();
            crsNametxt.Focus();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearfunction();
        }
    }
}
