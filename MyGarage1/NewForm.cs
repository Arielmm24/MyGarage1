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
using System.Media;
using static MyGarage1.Classes.Vechile;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace MyGarage1
{

    public partial class NewForm : Form
    {
        public NewForm()
        {

            InitializeComponent();
        }
        SoundPlayer sp;
        Point p = new Point();
        public static string[] lines;
        FamilyCar famCar = new FamilyCar(1234);
        SportCar sportC = new SportCar(2345);
        Truck tr = new Truck(4444);
        MiniCar miniC = new MiniCar(1500);
        
        

        private void NewForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Create your dream garage :) ");
            
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cordination: = " + Cursor.Position);   show cordination for every mouseClick
        }

        private void save_btn_Click(object sender, EventArgs e)   // save button
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter tw = new StreamWriter(fs);

                tw.Write(car1_cpbx.Visible.ToString() + '\n' + car1_cpbx.Location.X + '\n' + car1_cpbx.Location.Y + '\n');
                tw.Write(car1_cpbx2.Visible.ToString() + '\n' + car1_cpbx2.Location.X + '\n' + car1_cpbx2.Location.Y + '\n');
                tw.Write(car2_cpbx.Visible.ToString() + '\n' + car2_cpbx.Location.X + '\n' + car2_cpbx.Location.Y + '\n');
                tw.Write(car2_cpbx2.Visible.ToString() + '\n' + car2_cpbx2.Location.X + '\n' + car2_cpbx2.Location.Y + '\n');
                tw.Write(minicar_cpbx.Visible.ToString() + '\n' + minicar_cpbx.Location.X + '\n' + minicar_cpbx.Location.Y + '\n');
                tw.Write(sport1_cpbx.Visible.ToString() + '\n' + sport1_cpbx.Location.X + '\n' + sport1_cpbx.Location.Y + '\n');
                tw.Write(sport1_cpbx2.Visible.ToString() + '\n' + sport1_cpbx2.Location.X + '\n' + sport1_cpbx2.Location.Y + '\n');
                tw.Write(sport2_cpbx.Visible.ToString() + '\n' + sport2_cpbx.Location.X + '\n' + sport2_cpbx.Location.Y + '\n');
                tw.Write(truck1_cpbx.Visible.ToString() + '\n' + truck1_cpbx.Location.X + '\n' + truck1_cpbx.Location.Y + '\n');
                tw.Write(truck1_cpbx2.Visible.ToString() + '\n' + truck1_cpbx2.Location.X + '\n' + truck1_cpbx2.Location.Y + '\n');
                tw.Write(truck2_cpbx.Visible.ToString() + '\n' + truck2_cpbx.Location.X + '\n' + truck2_cpbx.Location.Y + '\n');

                noise_tb.Text = "File Save Successfully";
                Random r = new Random();
                noise_tb.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
                tw.Close();
            }

        }
        private void btn_load_Click(object sender, EventArgs e)    // load button
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string a = ofd.FileName;       // save xml file path

                XmlTextReader xtr = new XmlTextReader(a);

                lines = File.ReadAllLines(a);

                // cancel all object that was created
                car1_cpbx.Visible = false;
                car1_cpbx2.Visible = false;
                car2_cpbx.Visible = false;
                car2_cpbx2.Visible = false;
                minicar_cpbx.Visible = false;
                sport1_cpbx.Visible = false;
                sport1_cpbx2.Visible = false;
                sport2_cpbx.Visible = false;
                truck1_cpbx.Visible = false;
                truck1_cpbx2.Visible = false;
                truck2_cpbx.Visible = false;

                Point p1 = new Point();
                // read from the xml file the current visible and Location for all cpb
                car1_cpbx.Visible = bool.Parse(lines[0]);
                p1.X = Int32.Parse(lines[1]);
                p1.Y = Int32.Parse(lines[2]);
                car1_cpbx.Location = p1;

                car1_cpbx2.Visible = bool.Parse(lines[3]);
                p1.X = Int32.Parse(lines[4]);
                p1.Y = Int32.Parse(lines[5]);
                car1_cpbx2.Location = p1;

                car2_cpbx.Visible = bool.Parse(lines[6]);
                p1.X = Int32.Parse(lines[7]);
                p1.Y = Int32.Parse(lines[8]);
                car2_cpbx.Location = p1;

                car2_cpbx2.Visible = bool.Parse(lines[9]);
                p1.X = Int32.Parse(lines[10]);
                p1.Y = Int32.Parse(lines[11]);
                car2_cpbx2.Location = p1;

                minicar_cpbx.Visible = bool.Parse(lines[12]);
                p1.X = Int32.Parse(lines[13]);
                p1.Y = Int32.Parse(lines[14]);
                minicar_cpbx.Location = p1;

                sport1_cpbx.Visible = bool.Parse(lines[15]);
                p1.X = Int32.Parse(lines[16]);
                p1.Y = Int32.Parse(lines[17]);
                sport1_cpbx.Location = p1;

                sport1_cpbx2.Visible = bool.Parse(lines[18]);
                p1.X = Int32.Parse(lines[19]);
                p1.Y = Int32.Parse(lines[20]);
                sport1_cpbx2.Location = p1;

                sport2_cpbx.Visible = bool.Parse(lines[21]);
                p1.X = Int32.Parse(lines[22]);
                p1.Y = Int32.Parse(lines[23]);
                sport2_cpbx.Location = p1;

                truck1_cpbx.Visible = bool.Parse(lines[24]);
                p1.X = Int32.Parse(lines[25]);
                p1.Y = Int32.Parse(lines[26]);
                truck1_cpbx.Location = p1;

                truck1_cpbx2.Visible = bool.Parse(lines[27]);
                p1.X = Int32.Parse(lines[28]);
                p1.Y = Int32.Parse(lines[29]);
                truck1_cpbx2.Location = p1;

                truck2_cpbx.Visible = bool.Parse(lines[30]);
                p1.X = Int32.Parse(lines[31]);
                p1.Y = Int32.Parse(lines[32]);
                truck2_cpbx.Location = p1;

            }
        }

        private void plus1_btn_Click(object sender, EventArgs e)
        {
            if (!car1_cpbx.Visible)
                car1_cpbx.Visible = true;
            else
                if (!car1_cpbx2.Visible)
                car1_cpbx2.Visible = true;
            else
                MessageBox.Show("You can only add 2 cars from this type to your garage ! :) ");
        }

        private void plus2_btn_Click(object sender, EventArgs e)
        {
            if (!sport1_cpbx.Visible)
                sport1_cpbx.Visible = true;
            else
              if (!sport1_cpbx2.Visible)
                sport1_cpbx2.Visible = true;
            else
                MessageBox.Show("You can only add 2 cars from this type to your garage ! :) ");
        }

        private void plus3_btn_Click(object sender, EventArgs e)
        {
            if (!minicar_cpbx.Visible)
                minicar_cpbx.Visible = true;
            else
                MessageBox.Show("You can only add 1 car from this type to your garage ! :) ");
        }

        private void plus4_btn_Click(object sender, EventArgs e)
        {
            if (!truck2_cpbx.Visible)
                truck2_cpbx.Visible = true;
            else
                MessageBox.Show("You can only add 1 car from this type to your garage ! :) ");
        }
        private void plus5_btn_Click(object sender, EventArgs e)
        {
            if (!truck1_cpbx.Visible)
                truck1_cpbx.Visible = true;
            else
                if (!truck1_cpbx2.Visible)
                truck1_cpbx2.Visible = true;
            else
                MessageBox.Show("You can only add 2 cars from this type to your garage ! :) ");
        }

        private void plus6_btn_Click(object sender, EventArgs e)
        {
            if (!car2_cpbx.Visible)
                car2_cpbx.Visible = true;
            else
                if (!car2_cpbx2.Visible)
                car2_cpbx2.Visible = true;
            else
                MessageBox.Show("You can only add 2 cars from this type to your garage ! :) ");
        }

        private void plus7_btn_Click(object sender, EventArgs e)
        {
            if (!sport2_cpbx.Visible)
                sport2_cpbx.Visible = true;
            else
                MessageBox.Show("You can only add 1 car from this type to your garage ! :) ");
        }

        private void car1_cpbx_Click(object sender, EventArgs e)     // menu opens after click on first car(yellow)
        {
            //Point p = new Point();
            if (!listBox1.Visible)
                listBox1.Visible = true;
            else
                listBox1.Visible = false;
            p.X = car1_cpbx.Location.X + 80;
            p.Y = car1_cpbx.Location.Y;
            listBox1.Location = p;
            if (!car1_cpbx.Visible)
                listBox1.Visible = false;
        }
        private void car1_cpbx2_Click(object sender, EventArgs e)
        {

            //Point p = new Point();
            if (!listBox1.Visible)
                listBox1.Visible = true;
            else
                listBox1.Visible = false;
            p.X = car1_cpbx2.Location.X + 80;
            p.Y = car1_cpbx2.Location.Y;
            listBox1.Location = p;
        }
        private void listBox1_Visibility(object sender , MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if ((!car1_cpbx.Visible)|| (!car1_cpbx2.Visible))
                    listBox1.Visible = false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // close the listbox if one of the next obejct was deleted
            if ((!car1_cpbx.Visible) || (!car1_cpbx2.Visible)|| (!car2_cpbx.Visible)|| (!car2_cpbx2.Visible))
                listBox1.Visible = false;

            famCar.setStorge(10);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    noise_tb.Text = famCar.Horn();
                    break;
                case 1:
                    noise_tb.Text = famCar.fixTime();
                    break;
                case 2:
                    noise_tb.Text = "Storge amount : " + famCar.getStorge();
                    break;
                default:
                    break;
            } 
            Random r = new Random();
            noise_tb.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);

        }

        private void sport1_cpbx_Click(object sender, EventArgs e)
        {
            //Point p = new Point();
            if (!listBox2.Visible)
                listBox2.Visible = true;
            else
                listBox2.Visible = false;
            p.X = sport1_cpbx.Location.X + 80;
            p.Y = sport1_cpbx.Location.Y;
            listBox2.Location = p;
            if (!sport1_cpbx.Visible)
                listBox2.Visible = false;

        }

        private void sport1_cpbx2_Click(object sender, EventArgs e)
        {
            //Point p = new Point();
            if (!listBox2.Visible)
                listBox2.Visible = true;
            else
                listBox2.Visible = false;
            p.X = sport1_cpbx2.Location.X + 80;
            p.Y = sport1_cpbx2.Location.Y;
            listBox2.Location = p;
            if (!sport1_cpbx2.Visible)
                listBox2.Visible = false;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // close the listbox if one of the next obejct was deleted
            if ((!sport1_cpbx.Visible) || (!sport1_cpbx2.Visible)|| (!sport2_cpbx.Visible))
                listBox2.Visible = false;


            sportC.setVengine(2000);
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    noise_tb.Text = sportC.Horn();
                    break;
                case 1:
                    noise_tb.Text = sportC.fixTime();
                    break;
                case 2:
                    noise_tb.Text = sportC.getVengine()+ " samak";
                    break;
                case 3:
                    sp = new SoundPlayer(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\sounds\mustang-SF.wav");
                    sp.Play();
                    noise_tb.Text = "Start Engine";
                    break;
                default:
                    break;
            }
            Random r = new Random();
            noise_tb.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        private void minicar_cpbx_Click(object sender, EventArgs e)
        {
            //Point p = new Point();
            if(!listBox3.Visible)
                listBox3.Visible = true;
            else
                listBox3.Visible = false;
            p.X = minicar_cpbx.Location.X + 80;
            p.Y = minicar_cpbx.Location.Y;
            listBox3.Location = p;
            if (!minicar_cpbx.Visible)
                listBox3.Visible = false;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // close the listbox if one of the next obejct was deleted
            if (!minicar_cpbx.Visible)
                listBox3.Visible = false;


            miniC.setFuel(124);
            switch (listBox3.SelectedIndex)
            {
                case 0:
                    noise_tb.Text = miniC.Horn();
                    break;
                case 1:
                    noise_tb.Text = miniC.fixTime();
                    break;
                case 2:
                    noise_tb.Text = "Fuel amount : " + miniC.getFuel();
                    break;
                default:
                    break;
            }
            Random r = new Random();
            noise_tb.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        private void truck2_cpbx_Click(object sender, EventArgs e)
        {
            //Point p = new Point();
            if (!listBox4.Visible)
                listBox4.Visible = true;
            else
                listBox4.Visible = false;
            p.X = truck2_cpbx.Location.X + 80;
            p.Y = truck2_cpbx.Location.Y;
            listBox4.Location = p;
            if (!truck2_cpbx.Visible)
                listBox4.Visible = false;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // close the listbox if one of the next obejct was deleted
            if ((!truck1_cpbx.Visible) || (!truck1_cpbx2.Visible) || (!truck2_cpbx.Visible))
                listBox4.Visible = false;


            tr.setRole("Garbage truck");
            switch (listBox4.SelectedIndex)
            {
                case 0:
                    noise_tb.Text = tr.Horn();
                    break;
                case 1:
                    noise_tb.Text = tr.fixTime();
                    break;
                case 2:
                    noise_tb.Text = "" + tr.getRole();  
                    break;
                default:
                    break;
            }
            Random r = new Random();
            noise_tb.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        private void truck1_cpbx2_Click(object sender, EventArgs e)
        {
            if (!listBox4.Visible)
                listBox4.Visible = true;
            else
                listBox4.Visible = false;
            p.X = truck1_cpbx2.Location.X + 80;
            p.Y = truck1_cpbx2.Location.Y;
            listBox4.Location = p;
            if (!truck1_cpbx2.Visible)
                listBox4.Visible = false;
        }

        private void truck1_cpbx_Click(object sender, EventArgs e)
        {
            if (!listBox4.Visible)
                listBox4.Visible = true;
            else
                listBox4.Visible = false;
            p.X = truck1_cpbx.Location.X + 80;
            p.Y = truck1_cpbx.Location.Y;
            listBox4.Location = p;
            if (!truck1_cpbx.Visible)
                listBox4.Visible = false;
        }

        private void car2_cpbx2_Click(object sender, EventArgs e)
        {
            if (!listBox1.Visible) 
                listBox1.Visible = true;
            else
                listBox1.Visible = false;
            p.X = car2_cpbx2.Location.X + 80;
            p.Y = car2_cpbx2.Location.Y;
            listBox1.Location = p;
            if (!car2_cpbx2.Visible)
                listBox1.Visible = false;
        }

        private void car2_cpbx_Click(object sender, EventArgs e)
        {
            if (!listBox1.Visible)
                listBox1.Visible = true;
            else
                listBox1.Visible = false;
            p.X = car2_cpbx.Location.X + 80;
            p.Y = car2_cpbx.Location.Y;
            listBox1.Location = p;
            if (!car2_cpbx.Visible)
                listBox1.Visible = false;
        }

        private void sport2_cpbx_Click(object sender, EventArgs e)
        {
            if (!listBox2.Visible)
                listBox2.Visible = true;
            else
                listBox2.Visible = false;
            p.X = sport2_cpbx.Location.X + 80;
            p.Y = sport2_cpbx.Location.Y;
            listBox2.Location = p;
                if (!sport2_cpbx.Visible)
                listBox2.Visible = false;
        }


        // Mouse Hover by tooltip for all car kinds
        private void car1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Yellow Family Car", car1);
        }

        private void car2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Red Sport Car", car2);
        }

        private void car3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Blue Mini Car", car3);
        }

        private void truck1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("White Truck", truck1);
        }

        private void truck2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Blue Truck", truck2);
        }

        private void car5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Red Family Car", car5);
        }

        private void car6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Black & White Sport Car", car6);
        }
    }
}
