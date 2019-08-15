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
        public string numero= "";

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {


            textBox1.Text = SelectForm.numero;

            
        }

    }
}
