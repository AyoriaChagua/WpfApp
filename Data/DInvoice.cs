using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DInvoice
    {
        static string StringConnect = "Data Source=LAB1504-09\\SQLEXPRESS;Initial Catalog=lab08;User ID = tecsup; Password=123456";

        public List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            using (SqlConnection conn = new SqlConnection(StringConnect))
            {
                conn.Open();
                string query = "GetInvoices";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                invoices.Add(new Invoice
                                {
                                    Invoice_id = Convert.ToInt32(reader["invoice_id"]),
                                    Customer_id = Convert.ToInt32(reader["customer_id"]),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Total = Convert.ToDecimal(reader["total"]),
                                    Active = Convert.ToBoolean(reader["active"])
                                });
                            }
                        }
                    }
                }
                conn.Close();
            }
            return invoices;
        }
    }
}
