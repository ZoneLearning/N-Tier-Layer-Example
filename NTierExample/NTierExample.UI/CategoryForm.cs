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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ListAgain();
        }

        private void ListAgain()
        {
            dataGridView1.DataSource = Categories.getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category entity = new Category();
            entity.CategoryName = txtCategoryName.Text;
            entity.Description = txtDescription.Text;
            if (!Categories.Add(entity))
                MessageBox.Show("Kategori eklenemedi.");

            ListAgain();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Category deleted = new Category();
            deleted.CategoryID = (int)dataGridView1.CurrentRow.Cells["CategoryID"].Value;

            if (!Categories.Delete(deleted))
                MessageBox.Show("Kategori silinemedi.");

            ListAgain();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category updated = new Category();
            updated.CategoryName = txtCategoryName.Text;
            updated.Description = txtDescription.Text;
            updated.CategoryID = (int)txtCategoryName.Tag;

            if (!Categories.Update(updated))
                MessageBox.Show("Kategori güncellenemedi.");

            ListAgain();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtCategoryName.Tag = dataGridView1.CurrentRow.Cells["CategoryID"].Value;

        }
    }
}
