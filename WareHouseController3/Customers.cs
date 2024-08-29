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
    public partial class Customers : Form
    {
        CustomerDal _customerDal = new CustomerDal();
        public Customers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addCustomerName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            addAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addContact.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void LoadCustomers()
        {
            var result = _customerDal.GetAll();
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addSupplierbtn_Click(object sender, EventArgs e)
        {
            if (!InputValidator.ValidateString(addCustomerName.Text.ToLower(), out string customername)) ;
            if (!InputValidator.ValidateString(addAddress.Text.ToLower(), out string customeraddress)) ;
            if (!InputValidator.ValidateString(addContact.Text.ToLower(), out string customerphone)) ;
            _customerDal.AddNew(new Customer
            {
                Name = customername,
                Address = customeraddress,
                ContactInfo = customerphone
            });
            LoadCustomers();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var entity = _customerDal.GetAll().FirstOrDefault(p => p.Name == addCustomerName.Text.ToLower());
            entity.Name = addCustomerName.Text.ToLower();
            entity.Address = addAddress.Text.ToLower();
            entity.ContactInfo = addContact.Text.ToLower();
            _customerDal.Update(entity);
            LoadCustomers();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var entity = _customerDal.GetAll().FirstOrDefault(p => p.Name == addCustomerName.Text.ToLower());
            _customerDal.Delete(entity);
            LoadCustomers();
        }

        private void searchSupplier_TextChanged(object sender, EventArgs e)
        {
            var result = _customerDal.GetAll().Where(p => p.Name.Contains(searchCustomer.Text.ToLower())).ToList();
            dataGridView1.DataSource = result;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            var result = _customerDal.GetAll();
            dataGridView1.DataSource = result;
        }
    }
}
