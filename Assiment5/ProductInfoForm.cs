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
    
    public partial class ProductInfoForm : Form
    {
        

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {


            textBox1.Text = SelectForm.numero;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



            using (dollarcomputersEntities a = new dollarcomputersEntities())
            {
                int f = Convert.ToInt32(SelectForm.numero);

                IQueryable<product> objtonombre = from q in a.products
                                                  where q.productID == f
                                                  select q;
                List<product> lista = objtonombre.ToList();

                var nombre = lista[0];

                textBox21.Text = nombre.condition;
                textBox20.Text = Convert.ToString( nombre.cost);
                textBox19.Text = nombre.platform;
                textBox18.Text = nombre.OS;
                textBox16.Text = nombre.manufacturer;
                textBox17.Text = nombre.model;
                textBox15.Text = nombre.RAM_size;
                textBox12.Text = nombre.screensize;
                textBox7.Text = nombre.HDD_size;
                textBox14.Text = nombre.CPU_brand;
                textBox11.Text = nombre.CPU_number;
                textBox8.Text = nombre.GPU_Type;
                textBox13.Text = nombre.CPU_type;
                textBox10.Text = nombre.CPU_speed;
                textBox9.Text = nombre.webcam;
                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdenForm ordenForm = new OrdenForm();
            ordenForm.Show();
            this.Hide();
        }
    }
}
