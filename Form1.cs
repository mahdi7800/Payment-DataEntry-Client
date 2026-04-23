using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string customerId = textBoxCustomerID.Text;
            string amounttext = textBoxAmount.Text;

            if (ValidateInput(customerId, amounttext))
            {


                decimal amount = decimal.Parse(amounttext);



                DateTime payDate = dateTimePickerPaymentDate.Value;
                string result = " ";

                SqlConnection cn = new SqlConnection();

                cn.ConnectionString = "Data Source=DESKTOP-FJN1R7B;Initial Catalog=Northwind;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "usp_CutomerPayment";
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PaymentDate", payDate);

                SqlParameter sqlP = new SqlParameter("@Resualt", SqlDbType.NVarChar, 200);

                sqlP.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(sqlP);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    result = sqlP.Value.ToString();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    result = " عملیات با خطا اجرا شد" + ex.Message;
                }


                MessageBox.Show(result.ToString());
            }

        }

        private bool ValidateInput(string customerId , string amount)
        {
           if(customerId.Length == 0)
            {
              MessageBox.Show("لطفا ادی مشتری را وارد کنید");
                return false;
            }

            if (amount.Length == 0)
            {

                MessageBox.Show("لصفا قیمت پرداخت شده را وارد کنید");
                return false;

            }
            return true;
                
        }
    }
}
