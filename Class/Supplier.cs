using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project6
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactEmail { get; set; }

        public static List<Supplier> SuppliersList = new List<Supplier>();

        public static void AddSupplier(Supplier supplier)
        {
            SuppliersList.Add(supplier);
        }

        public static List<Supplier> GetAllSuppliers()
        {
            return SuppliersList;
        }

        public static void UpdateSupplier(int index, Supplier updated)
        {
            if (index >= 0 && index < SuppliersList.Count)
                SuppliersList[index] = updated;
        }

        public static void DeleteSupplier(int index)
        {
            if (index >= 0 && index < SuppliersList.Count)
                SuppliersList.RemoveAt(index);
        }

        public void SendRestockRequest(int productId, int quantity)
        {
            Console.WriteLine($"Restock for Product {productId} (x{quantity}) to {SupplierName} ({ContactEmail})");
        }

        public void GetAvailableProducts()
        {
            Console.WriteLine($"Available products for {SupplierName}: Product A (10 pcs), Product B (5 pcs)");
        }

        public static void InitSuppliers()
        {
            try
            {
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.Get_all_supplier"; // your stored procedure name
                SQL_CON SC = new SQL_CON();
                SqlDataReader rdr = SC.execute_query(c);

                SuppliersList = new List<Supplier>();

                while (rdr.Read())
                {
                    Supplier s = new Supplier
                    {
                        SupplierId = rdr.GetValue(0).ToString(),
                        SupplierName = rdr.GetValue(1).ToString(),
                        ContactEmail = rdr.GetValue(2).ToString()
                    };

                    SuppliersList.Add(s);
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error while loading suppliers:\n" + ex.Message);
            }
        }



    }
}
