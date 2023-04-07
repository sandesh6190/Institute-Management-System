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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Studentbtn_Click(object sender, EventArgs e)
        {
            var student = new Student();
            this.Hide();
            student.ShowDialog();
            Show();
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            this.Hide();
            teacher.ShowDialog();
            Show();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            var course = new Course();
            this.Hide();
            course.ShowDialog();
            Show();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            var newform = new PaymentDetails();
            this.Hide();
            newform.ShowDialog();
            Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
