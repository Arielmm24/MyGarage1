using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGarage1.Classes;

namespace MyGarage1
{
    public partial class Loading : Form
    {
       public Timer clock = new Timer();
        public Loading()
        {
            InitializeComponent();
            
            clock.Interval = (1000 * 6); // sec for timer
            clock.Start();
            clock.Tick += new EventHandler(loadingT_Tick);
            SoundPlayer sp = new SoundPlayer(@"C:\Users\אריאל\source\repos\MyGarage1\MyGarage1\Resources\sounds\imSpeed.wav");
            sp.Play();
        }
        private void loadingT_Tick(object sender, EventArgs e)    // represent the op after timer clock ends
        {
            if(sender==clock)
            {
                clock.Stop();
                Hide();
                Home f = new Home();
                f.ShowDialog();
                Close();   
            }
        }
    }
}
