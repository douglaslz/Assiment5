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
    public partial class SplashScreen : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashScreen startform = new SplashScreen();
            startform.CenterToScreen();
            // TODO: This line of code loads data into the 'booksDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.booksDataSet.Titles);
            // TODO: This line of code loads data into the 'bloggingDataSet.Blogs' table. You can move, or remove it, as needed.
            this.blogsTableAdapter.Fill(this.bloggingDataSet.Blogs);

            timer.Interval = 3000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            StartForm startform = new StartForm();
            startform.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
