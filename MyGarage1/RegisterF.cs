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
    public partial class RegisterF : Form
    {
        public RegisterF()
        {
            InitializeComponent();
        }
        public static bool checkStr(string s)   // func that validate password (one digit at least)
        {
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] > '0') && (s[i] < '9'))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoginF f = new LoginF();
            //if (!checkStr(pass_tb.Text))
            //MessageBox.Show("Password must contain at last one digit :) ");

            //try { 
            //DataService dataService = new DataService();

            //string username = this.user_tb.Text;
            //string passWord = this.pass_tb.Text;
            //string name = this.name_tb.Text;
            //string email = this.mail_tb.Text;
            //if ((username != "") && (passWord != "") && (name != "") && (email != ""))
            //    dataService.AddDetails(username, passWord, name, email);
            //    this.Close();
            //    f.Show();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //this.Close();
            //LoginF f = new LoginF();
            //f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
