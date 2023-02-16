using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal.GetAll();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwPrd.DataSource = _productDal;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = textBoxName.Text,
                UnitPrice = Convert.ToDecimal(textBoxUnitPrice.Text),
                StockAmount = Convert.ToInt32(textBoxStockAmount.Text)

            });
            dgwPrd.DataSource = _productDal;
            MessageBox.Show("Eklendi!");
        }

        private void buttonUptade_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwPrd.CurrentRow.Cells[0].Value),
                Name = textboxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(textBoxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(textBoxStockAmountUpdate.Text)
            });
            dgwPrd.DataSource = _productDal;
            MessageBox.Show("Güncellendi");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNameUpdate.Text = dgwPrd.CurrentRow.Cells[1].Value.ToString();
            textBoxUnitPriceUpdate.Text = dgwPrd.CurrentRow.Cells[2].Value.ToString();
            textBoxStockAmountUpdate.Text = dgwPrd.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id=Convert.ToInt32(dgwPrd.CurrentRow.Cells[0].Value)
            });
            dgwPrd.DataSource = _productDal;
            MessageBox.Show("Silindi!");
        }
    }
}
