using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MyGarage1.Classes;
using System.Media;
using static MyGarage1.Classes.Vechile;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyGarage1
{
    public partial class ChoseF : Form
    {

        public static string[] lines;  // array for reading the loadgame
        public ChoseF()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.Close();
            NewForm f = new NewForm();
            f.Show();
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
