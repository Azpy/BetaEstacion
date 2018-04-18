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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }


        BaseDeDatos bd = new BaseDeDatos();

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBEstacionamientoDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            
            dataGridView1.DataSource = bd.SelectDataTable("select mat_usuario,nombre, modelo_auto,matricula_auto from usuarios U, autos A  where U.idusuario = A.idusuario");
            cmbPreferencia.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string registrar = "insert into usuarios(mat_usuario,nombre,preferencia,invitado) values("+ txtMatricula.Text +",'"+ txtNombre.Text + "'," + 0 +","+ 0 + ")";
            string auto = "insert into autos(modelo_auto,matricula_auto,idusuario) values('" + txtModelo.Text + "','" + txtPlaca.Text + "', " + 8 + ")";
            
            if (bd.executecommand(registrar))
            {
                MessageBox.Show("Registro agregado correctamente");
            }
            else {
                MessageBox.Show("Error al agregar");
            }
            if (bd.executecommand(auto))
            {
                MessageBox.Show("Registro agregado correctamente");
            }
            else
            {
                MessageBox.Show("Error al agregar auto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmControl control = new FrmControl();
            control.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEstacionamiento est = new FrmEstacionamiento();
            est.Show();
            this.Hide();
        }
    }
}
