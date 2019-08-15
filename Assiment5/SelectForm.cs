using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment5
{
    public partial class SelectForm : Form
    {
        public static string numero = "";

        public SelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartForm starform = new StartForm();
            starform.Show();
            this.Hide();
        }
            
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarcomputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarcomputersDataSet.products);
            // TODO: This line of code loads data into the 'cHARJDDataSet.TBCH_BOOKS' table. You can move, or remove it, as needed.
            this.tBCH_BOOKSTableAdapter.Fill(this.cHARJDDataSet.TBCH_BOOKS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            DataGridViewRow seletedrow = dataGridView1.Rows[index];
            textBox1.Text = seletedrow.Cells[2].Value.ToString() + seletedrow.Cells[3].Value.ToString() + String.Format(" Price at:  {0:C}", seletedrow.Cells[1].Value.ToString());
            numero = seletedrow.Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            
            this.Hide();
        }
    }
}
