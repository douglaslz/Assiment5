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
    public partial class OrdenForm : Form
    {
        public OrdenForm()
        {
            InitializeComponent();
        }

        private void OrdenForm_Load(object sender, EventArgs e)
        {
            

            using (dollarcomputersEntities a = new dollarcomputersEntities())
            {
                int f = Convert.ToInt32(SelectForm.numero);

                IQueryable<product> objtonombre = from q in a.products
                                                  where q.productID == f
                                                  select q;
                List<product> lista = objtonombre.ToList();

                var nombre = lista[0];
                double withtax = Convert.ToDouble(nombre.cost);
                textBox1.Text = nombre.condition;
                textBox6.Text = Convert.ToString(withtax * 1.13);
                textBox7.Text = Convert.ToString(withtax * 0.13);
                textBox2.Text = Convert.ToString(nombre.cost);
                textBox4.Text = nombre.platform;
                textBox5.Text = nombre.manufacturer;
                textBox3.Text = nombre.model;
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.screensize);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.RAM_size);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.CPU_brand);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.CPU_type);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.CPU_number);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.CPU_speed);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.HDD_size);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.GPU_Type);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.webcam);
                listBox1.Items.Add("");
                listBox1.Items.Add(nombre.OS);
                listBox1.Items.Add("");


                try
                {
                    string ruta = @"C:\Users\DouglasEnriqueLoaiza\source\repos\Assiment5\Assiment5\Assiment5\Images\%variable%.jpg".Replace("%variable%", (nombre.manufacturer).Replace(" ", ""));
                    pictureBox1.Image = System.Drawing.Image.FromFile(ruta);
                }
                catch
                {
                    string ruta = @"C:\Users\DouglasEnriqueLoaiza\source\repos\Assiment5\Assiment5\Assiment5\Images\NB.jpg";
                    pictureBox1.Image = System.Drawing.Image.FromFile(ruta);
                }

                
                
                
        
            

            }

        }

        private void OrderBackButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void OrderFinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks purchase. Your order will be processed in 7-10 business days.", "Message");
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }
    }
}
