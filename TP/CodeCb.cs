using System.Windows.Forms;

namespace TP
{
    public partial class CodeCb : Form
    {

        public CodeCb()
        {
            InitializeComponent();

            pavNum1.ClickBtn += PavNum1_ClickBtn;

        }

        private void PavNum1_ClickBtn(string touche)
        {
            // label2.Text = touche;
        }

    }
}
