using System;
using System.Data.SqlClient; // חשוב!
using System.Windows.Forms; // עבור ההודעות!
using System.Data;

namespace Project6
{
    class SQL_CON
    {
        SqlConnection conn;
        string Username = "surujon";

        public SQL_CON()
        {
            conn = new SqlConnection(
                "Data Source=dbdesign.database.windows.net;" +
                "Initial Catalog=G6;" +
                "Persist Security Info=True;" +
                "User ID=" + Username + "@bgufbm.onmicrosoft.com;" +
                "Password=Mis18331;" +
                "Authentication=\"Active Directory Password\"");
        }

        public void execute_non_query(SqlCommand cmd)
        {
            try
            {
                this.conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public SqlDataReader execute_query(SqlCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}