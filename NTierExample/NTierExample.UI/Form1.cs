using NTierExample.ORM.Entity;
using NTierExample.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierExample.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Products.getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product entity = new Product();
            entity.ProductName = txtProductName.Text;
            entity.UnitPrice = nudPrice.Value;
            entity.UnitsInStock = (short)nudStock.Value;
            if (!Products.Add(entity))
                MessageBox.Show("Ürün Eklenemedi");

            //ekledikten sonra listelemeyi yeniden yapıyoruz.
            dataGridView1.DataSource = Products.getList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            Product deleted = new Product();
            deleted.ProductID = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
            if (!Products.Delete(deleted))
                MessageBox.Show("Ürün Silenemedi");

            dataGridView1.DataSource = Products.getList();
        }
    }
}
