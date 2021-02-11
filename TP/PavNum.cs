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

    public partial class PavNum : UserControl
    {
        //CodeCb code = new CodeCb();
        //Accueil accueil = new Accueil();
        public delegate void delegateClickBtn(string touche);
        public event delegateClickBtn ClickBtn;


        public PavNum()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           if (ClickBtn != null)
            {
                ClickBtn(((Button)sender).Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  if (ClickBtn != null)
          //  {
          //      ClickBtn(((Button)sender).Text);
          //  }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /// if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button14_Click(object sender, EventArgs e)
        {
           // if (ClickBtn != null)
           // {
           //     ClickBtn(((Button)sender).Text);
           // }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // code.Close();
           //accueil.Show();
        }
    }
}
