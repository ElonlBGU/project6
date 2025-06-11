using System;
using System.Linq;
using System.Windows.Forms;

namespace Project6
{
    public partial class MangeSuppliers : Form
    {
        private int selectedIndex = 0;

        public MangeSuppliers()
        {
            InitializeComponent();
        }

        private void MangeSuppliers_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier newSupplier = new Supplier
                {
                    SupplierId = txtSupplierId.Text,
                    SupplierName = txtSupplierName.Text,
                    ContactEmail = txtContactEmail.Text
                };

                Supplier.AddSupplier(newSupplier);
                RefreshGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
               Supplier updated = new Supplier
                {
                    SupplierId = txtSupplierId.Text,
                    SupplierName = txtSupplierName.Text,
                    ContactEmail = txtContactEmail.Text
                };

                Supplier.UpdateSupplier(selectedIndex, updated);
                RefreshGrid();
                ClearInputs();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
                Supplier.DeleteSupplier(selectedIndex);
                RefreshGrid();
                ClearInputs();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < Supplier.GetAllSuppliers().Count)
                {
                    selectedIndex = e.RowIndex;
                    var selected = Supplier.GetAllSuppliers()[selectedIndex];

                    txtSupplierId.Text = selected.SupplierId.ToString();
                    txtSupplierName.Text = selected.SupplierName;
                    txtContactEmail.Text = selected.ContactEmail;
                }
                else
                {
                    selectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }


        private void RefreshGrid()
        {
            // Temporarily detach event to prevent firing while updating data
            dataGridView1.CellClick -= dataGridView1_CellClick;

            // Rebind safely
            var listCopy = Supplier.GetAllSuppliers().ToList(); // make a safe copy
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listCopy;

            // Reattach event
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Reset selection state
            selectedIndex = -1;
        }


        private void ClearInputs()
        {
            txtSupplierId.Clear();
            txtSupplierName.Clear();
            txtContactEmail.Clear();
            selectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblSupplierName_Click(object sender, EventArgs e)
        {

        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
