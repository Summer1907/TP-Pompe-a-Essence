using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Fuel : UserControl
    {
        CodeCb f4 = new CodeCb();
        ChoixFuel f5 = new ChoixFuel();

        public delegate void delegateClickFuel(string touche);
        public event delegateClickFuel ClickFuel;

        public Fuel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClickFuel != null)
            {
                ClickFuel(((Button)sender).Text);
            }
            f4.Show();
            f5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClickFuel != null)
            {
                ClickFuel(((Button)sender).Text);
            }
            f4.Show();
            f5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ClickFuel != null)
            {
                ClickFuel(((Button)sender).Text);
            }
            f4.Show();
            f5.Hide();
        }

    }
}
