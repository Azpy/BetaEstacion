using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class FrmEstacionamiento : Form
    {
        public FrmEstacionamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmControl control = new FrmControl();
            control.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistro reg = new FrmRegistro();
            reg.Show();
            this.Hide();
        }
    }
}
