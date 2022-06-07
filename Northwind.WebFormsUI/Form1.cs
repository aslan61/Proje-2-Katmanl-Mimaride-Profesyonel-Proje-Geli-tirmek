using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.Concrete.EntityFramework;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxcategory.DataSource = _categoryService.GetAll();
            cbxcategory.DisplayMember = "CategoryName";
            cbxcategory.ValueMember = "CategoryID";

            cbxkategoriadı.DataSource = _categoryService.GetAll();
            cbxkategoriadı.DisplayMember = "CategoryName";
            cbxkategoriadı.ValueMember = "CategoryID";

            cbxkategoriadı2.DataSource = _categoryService.GetAll();
            cbxkategoriadı2.DisplayMember = "CategoryName";
            cbxkategoriadı2.ValueMember = "CategoryID";
        }   

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxcategory.SelectedValue));
            }
            catch 
            {

            }
            
        }

        private void tbxname_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxname.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByName(tbxname.Text);
            }
            else
            {
                LoadProducts();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt16(cbxkategoriadı.SelectedValue),
                    ProductName = tbxürünadı.Text,
                    QuantityPerUnit = tbxbirimadeti.Text,
                    UnitPrice = Convert.ToDecimal(tbxfiyat.Text),
                    UnitsInStock = Convert.ToInt16(tbxstokadeti.Text)
                });
                MessageBox.Show("Ürün Kaydedildi!");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxürünadı2.Text,
                    CategoryId = Convert.ToInt32(cbxkategoriadı2.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxstokadeti2.Text),
                    QuantityPerUnit = tbxbirimadeti2.Text,
                    UnitPrice = Convert.ToDecimal(tbxfiyat2.Text)
                });
                MessageBox.Show("Ürün Güncellendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxürünadı2.Text = row.Cells[1].Value.ToString();
            cbxkategoriadı2.SelectedValue = row.Cells[2].Value.ToString();
            tbxstokadeti2.Text = row.Cells[5].Value.ToString();
            tbxbirimadeti2.Text = row.Cells[4].Value.ToString();
            tbxfiyat2.Text = row.Cells[3].Value.ToString();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow!=null)
            {
                
                try
                {
                    _productService.Delete(new Product { ProductId = Convert.ToInt16(dgwProduct.CurrentRow.Cells[0].Value) });
                    MessageBox.Show("Ürün Silindi!");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    
                }
            } 

        }
    }
}
