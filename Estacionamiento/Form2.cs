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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBEstacionamientoDataSet.cajones' Puede moverla o quitarla según sea necesario.
            this.cajonesTableAdapter.Fill(this.dBEstacionamientoDataSet.cajones);

        }
    }
}
