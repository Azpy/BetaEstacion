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

        void resettxt()
        {
            txtNombre.Text = "";
            txtMatricula.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            rdbInvitado.Checked = false;
            cmbPreferencia.SelectedIndex = 0;
        }
        BaseDeDatos bd = new BaseDeDatos();
        int val_inv, cons_id;
        string res_id, mat_busq,id_user,sel_ind, sel_inv;
        Boolean val_invb;

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
            val_inv = rdbInvitado.Checked ? 1 : 0;
            string registrar = "insert into usuarios(mat_usuario,nombre,preferencia,invitado) values("+ txtMatricula.Text +",'"+ txtNombre.Text + "'," + cmbPreferencia.SelectedIndex +","+ val_inv + ")";
            
            if (bd.executecommand(registrar))
            {
                string cons_id = "SELECT idusuario FROM usuarios WHERE idusuario = (SELECT MAX(idusuario) from usuarios)";
                res_id = bd.selectstring(cons_id);
                string auto = "insert into autos(modelo_auto,matricula_auto,idusuario) values('" + txtModelo.Text + "','" + txtPlaca.Text + "', " + res_id + ")";
                if (bd.executecommand(auto)) { 
                    MessageBox.Show("Registro agregado correctamente");
                    resettxt();
                }
                else
                {
                    MessageBox.Show("Error al agregar registro");
                }
            }
            resettxt();
            dataGridView1.DataSource = bd.SelectDataTable("select mat_usuario,nombre, modelo_auto,matricula_auto from usuarios U, autos A  where U.idusuario = A.idusuario");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmControl control = new FrmControl();
            control.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas salir de la aplicación?", "Estacionamiento de FIME",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtMatricula.Text != "") { 
                mat_busq = txtMatricula.Text;
                txtMatricula.Text = bd.selectstring("select mat_usuario from usuarios where mat_usuario =" + mat_busq + "");
                if (txtMatricula.Text == "")
                {
                    MessageBox.Show("No se encontraron coincidencias");
                    resettxt();
                }
                else
                {
                    txtNombre.Text = bd.selectstring("select nombre from usuarios where mat_usuario =" + mat_busq + "");
                    sel_ind = bd.selectstring("select preferencia from usuarios where mat_usuario =" + mat_busq + "");
                    cmbPreferencia.SelectedIndex = Convert.ToInt16(sel_ind);
                    id_user = bd.selectstring("select idusuario from usuarios where mat_usuario= " + mat_busq + "");
                    txtModelo.Text = bd.selectstring("select modelo_auto from autos where idusuario = " + id_user + "");
                    txtPlaca.Text = bd.selectstring("select matricula_auto from autos where idusuario = " + id_user + "");

                    sel_inv = bd.selectstring("select invitado from usuarios where mat_usuario =" + mat_busq + "");
                    if (sel_inv == "0")
                    {
                        val_invb = false;
                        rdbInvitado.Checked = val_invb;
                    }
                    else
                    {
                        val_invb = true;
                        rdbInvitado.Checked = val_invb;
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar matricula");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "")
            {
                if (MessageBox.Show("Deseas eliminar el registro con Matricula: " + txtMatricula.Text + "", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mat_busq = txtMatricula.Text;
                    string cons_id = "select idusuario from usuarios where mat_usuario =" + mat_busq + "";
                    res_id = bd.selectstring(cons_id);
                    string eliminar = "delete from usuarios where mat_usuario =" + mat_busq + "";
                    if (bd.executecommand(eliminar))
                    {
                        string elim_auto = "delete from autos where idusuario =" + res_id + "";
                        if (bd.executecommand(elim_auto))
                        {
                            MessageBox.Show("Registro borrado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error al borrar registro");
                            resettxt();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar matricula");
            }
            resettxt();
            dataGridView1.DataSource = bd.SelectDataTable("select mat_usuario,nombre, modelo_auto,matricula_auto from usuarios U, autos A  where U.idusuario = A.idusuario");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            val_inv = rdbInvitado.Checked ? 1 : 0;
            mat_busq = txtMatricula.Text;
            string modificar = "update usuarios set  nombre = '" + txtNombre.Text + "', preferencia = " + cmbPreferencia.SelectedIndex + ", invitado = " + val_inv + " where mat_usuario ="+ mat_busq +"";
            if (bd.executecommand(modificar))
            {
                string cons_id = "select idusuario from usuarios where mat_usuario =" + mat_busq + "";
                res_id = bd.selectstring(cons_id);
                string modif_auto = "update autos set modelo_auto = '" + txtModelo.Text + "', matricula_auto = '" + txtPlaca.Text + "' where idusuario = " + res_id + "";
                if (bd.executecommand(modif_auto))
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    txtNombre.Text = "";
                    txtMatricula.Text = "";
                    txtModelo.Text = "";
                    txtPlaca.Text = "";
                    rdbInvitado.Checked = false;
                    cmbPreferencia.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error al modificar registro");
                    resettxt();
                }
            }
            dataGridView1.DataSource = bd.SelectDataTable("select mat_usuario,nombre, modelo_auto,matricula_auto from usuarios U, autos A  where U.idusuario = A.idusuario");
        }
    }
}
