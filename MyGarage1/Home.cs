using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGarage1.Classes;

namespace MyGarage1
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ChoseF f = new ChoseF();
            f.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Instructions f = new Instructions();
            f.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
