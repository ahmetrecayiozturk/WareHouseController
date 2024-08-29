using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    public partial class Suppliers : Form
    {
        SupplierDal _supplierDal = new SupplierDal();
        public Suppliers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addSupplierName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addContact.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void LoadSuppliers() 
        {
            var result = _supplierDal.GetAll();
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();

        }

        private void addSupplierName_TextChanged(object sender, EventArgs e)
        {
        }

        private void addSupplierbtn_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(addSupplierName.Text.ToLower(), out string suppliername)) ;
            if (!InputValidator.ValidateString(addAddress.Text.ToLower(), out string supplieraddress)) ;
            if (!InputValidator.ValidateString(addContact.Text.ToLower(), out string supplierphone)) ;
            _supplierDal.AddNew(new Supplier
            {
                Name = suppliername,
                Address = supplieraddress,
                ContactInfo = supplierphone
            });
            LoadSuppliers();
        }

        private void updateSupplierbtn_Click(object sender, EventArgs e)
        {
            var entity = _supplierDal.GetAll().FirstOrDefault(p => p.Name == addSupplierName.Text.ToLower());
            entity.Name = addSupplierName.Text.ToLower();
            entity.Address = addAddress.Text.ToLower();
            entity.ContactInfo = addContact.Text.ToLower();
            _supplierDal.Update(entity);
            LoadSuppliers();
        }

        private void deleteSupplierbtn_Click(object sender, EventArgs e)
        {
            var entity = _supplierDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            _supplierDal.Delete(entity);
            LoadSuppliers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var result = _supplierDal.GetAll().Where(p => p.Name.Contains(searchSupplier.Text)).ToList();
            dataGridView1.DataSource = result;

        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            var result = _supplierDal.GetAll();
            dataGridView1.DataSource = result;
        }
    }
}
