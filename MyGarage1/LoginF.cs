using Microsoft.AspNetCore.Rewrite.Internal;
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
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
            ChoseF f = new ChoseF();
            f.Show();
            //    DataService ds = new DataService();
            //    string username = user_tb.Text;
            //    string pass = pass_tb.Text;

            //    if (ds.LoginU(username))
            //    {
            //        //if (ds.LoginP(pass, username))
            //        //{
            //        this.Close();
            //        ChoseF f = new ChoseF();
            //        f.Show();
            //    }
            //    else
            //        MessageBox.Show("UserName or Password are not correct !!");
            //    }
            //    //else
            //    //    MessageBox.Show("UserName or Password are not correct !!");
            //}

            //private void pictureBox1_Click(object sender, EventArgs e)
            //        {
            //            //this.Close();
            //        }
        }
    }
}

