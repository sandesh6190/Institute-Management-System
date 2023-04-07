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
    public partial class PaymentDetails : Form
    {
        public PaymentDetails()
        {
            InitializeComponent();
            Load += PaymentDetails_Load;
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            LoadPaymentDetails();
        }

        public void LoadPaymentDetails()
        {
            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT sp.Id, s.FirstName FirstName, s.LastName LastName, sp.Payment_Amt PaidAmt, sp.Payment_Date Date FROM `student_payment` sp inner join `student` s on sp.Student_Id = s.ID";

                var Payment = conn.Query<StudentPaymentModel>(query, new
                {

                });

                paymentgridview.DataSource = Payment;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var search = searchtxt.Text.ValueOrNull();

            using (var conn = Connection.GetDbConnection())
            {
                var query = @"SELECT sp.Id, s.FirstName FirstName, s.LastName LastName, sp.Payment_Amt PaidAmt, sp.Payment_Date Date FROM `student_payment` sp inner join `student` s on sp.Student_Id = s.ID
                 where  (@Search is null) or (sp.Id = @Search) or(s.FirstName = @Search) or (LastName = @Search) or (sp.Payment_Date = @Search);";

                var studentPayment = conn.Query<StudentPaymentModel>(query, new
                {
                    Search = search,
                });

                paymentgridview.DataSource = studentPayment;
            }
        }
    }
}
