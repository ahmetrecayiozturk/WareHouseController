using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            /*
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ispaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            isunpaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            borcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            orderid.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tedarikciismii.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            urunismii.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            paidAmountt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            */
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
            dataGridView1.Columns["Name"].HeaderText = "Müşteri İsimi";
            dataGridView1.Columns["Address"].HeaderText = "Müşteri Adres";
            dataGridView1.Columns["ContactInfo"].HeaderText = "Müşteri İletişim";
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
            MessageBox.Show("MÜŞTERİ EKLENDİ");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var entity = _customerDal.GetAll().FirstOrDefault(p => p.Name == addCustomerName.Text.ToLower());
            entity.Name = addCustomerName.Text.ToLower();
            entity.Address = addAddress.Text.ToLower();
            entity.ContactInfo = addContact.Text.ToLower();
            _customerDal.Update(entity);
            LoadCustomers();
            MessageBox.Show("MÜŞTERİ GÜNCELLENDİ");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var entity = _customerDal.GetAll().FirstOrDefault(p => p.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (entity == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }
            if (entity != null)
            {
                _customerDal.Delete(entity);

            }
            LoadCustomers();
            /*
            var entity = _customerDal.GetAll().FirstOrDefault(p => p.Name == addCustomerName.Text.ToLower());
            if(entity != null)
            {
                _customerDal.Delete(entity);
                MessageBox.Show("MÜŞTERİ SİLİNDİ");
                LoadCustomers();
            }
            else
            {
                MessageBox.Show("MÜŞTERİ SEÇİNİZ");
            }
            //_customerDal.Delete(entity);
            //LoadCustomers();
            //MessageBox.Show("MÜŞTERİ SİLİNDİ");
            */
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
