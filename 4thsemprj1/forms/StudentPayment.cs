using _4thsemprj1.Models;
using Dapper;
using Org.BouncyCastle.Asn1.BC;
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
    public partial class StudentPayment : Form
    {
        private readonly StudentModel _student;
        public StudentPayment(StudentModel student)
        {
            InitializeComponent();
            _student = student;
            Load += Payment_Load;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadPayment();
        }

        
        public void LoadPayment()
        {
            stdIdtxt.Text = _student.Id;
            fNametxt.Text = _student.FirstName;
            lNametxt.Text = _student.LastName;
            addresstxt.Text = _student.Address;
            dobtxt.Text = _student.DOB.ToString();
            emailtxt.Text = _student.Email;
            cNumbertxt.Text = _student.ContactNumber;
            gendertxt.Text = _student.Gender;

            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT sp.Id, s.FirstName FirstName, s.LastName LastName, sp.Payment_Amt PaidAmt, sp.Payment_Date Date FROM `student_payment` sp inner join `student` s on sp.Student_Id = s.ID
                 where sp.Student_Id = @studentId;";

                var studentPayment = conn.Query<StudentPaymentModel>(query, new
                {
                    studentId = _student.Id
                });

                stdpaymentgridview.DataSource = studentPayment;
            }
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            //get connection
            var conn = Connection.GetDbConnection();

            var payment = amttxt.Text;

            //define query
            var query = @"INSERT INTO `student_payment` (`ID`, `Student_Id`, `Payment_Amt`, `Payment_Date`) VALUES (NULL, @StudentId, @Payment, @Date);";

            conn.Execute(query, new
            {
                StudentId = _student.Id,
                Payment = payment,
                Date = DateTime.Now,
            });
            MessageBox.Show("Amount Paid");
            LoadPayment();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
