using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeN
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
      

        private void btCalcular_Click(object sender, EventArgs e)
        {
            
            {
                int i = 0;

                int a = 5;

                int res = (i+a);

                for ( i = 0; i != 3; i++)
                {
                    Console.WriteLine(i + a);
                    MessageBox.Show("o valor é:",i+a);
                }

                return i + a;
                





            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
