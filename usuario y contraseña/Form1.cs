using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usuario_y_contraseña
{
    public partial class fmenu : Form
    {

        // Crear la variable…….para la conexión
        public OleDbConnection miconcexion;
        public string usuario_modificar;
        public fmenu()
        {
            //Crear cadena de conexion a la base
            miconcexion = new
                   OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\usuario.mdb;Persist Security Info=False");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            txtusuario.Enabled = false;
            txtcontraseña.Enabled = false;
            comboBox1.Enabled = false;


            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.sistema' Puede moverla o quitarla según sea necesario.
            this.sistemaTableAdapter.Fill(this.usuarioDataSet.sistema);

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MoveFirst();

        }

        private void btnanterio_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MovePrevious();

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MoveNext();

        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            this.sistemaBindingSource.MoveLast();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            txtusuario.Enabled = true;
            txtcontraseña.Enabled = true;
            comboBox1.Enabled = true;
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            txtusuario.Focus();
            btnnuevo.Visible = false;
            btnguardar.Visible = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconcexion.Open();
                eliminar.Connection = miconcexion;
                eliminar.CommandType = CommandType.Text;
                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" +
                txtusuario.Text.ToString() + "'";

                eliminar.ExecuteNonQuery();
                this.sistemaBindingSource.MoveNext();
                miconcexion.Close();
                //Mensaje que se guardo correctamente
                MessageBox.Show("Usuario eliminado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario); 
                this.sistemaBindingSource.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtcontraseña.Enabled = true;
            comboBox1.Enabled = true;
            txtusuario.Focus();
            btnmodificar.Visible = false;
            btnactualizar.Visible = true;
            usuario_modificar = txtusuario.Text.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Flogin frprincipal = new Flogin();

            this.Hide();
            frprincipal.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand guardar = new OleDbCommand();
                miconcexion.Open();
                guardar.Connection = miconcexion;
                guardar.CommandType = CommandType.Text;
                guardar.CommandText = "INSERT INTO `sistema` (`nombre`, `clave`, `nivel`) VALUES('" + txtusuario.Text.ToString() + "', '" +
                 txtcontraseña.Text.ToString() + "','" + comboBox1.Text.ToString() + "')";

                guardar.ExecuteNonQuery();
                miconcexion.Close();
                btnnuevo.Visible = true;
                btnguardar.Visible = false;
                //Desabilitar campos, se activan al crear nuevo registro
                txtusuario.Enabled = false;
                txtcontraseña.Enabled = false;
                comboBox1.Enabled = false;
                btnnuevo.Focus();
                //Mensaje que se guardo correctamente
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.sistemaTableAdapter.Fill(this.usuarioDataSet.sistema);
                this.sistemaBindingSource.MoveLast();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }




        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {


                OleDbCommand actualizar = new OleDbCommand();
                miconcexion.Open();
                actualizar.Connection = miconcexion;
                actualizar.CommandType = CommandType.Text;
                string nombre = txtusuario.Text.ToString();
                string clave = txtcontraseña.Text.ToString();
                string nivel = comboBox1.Text;
                //Podemos actualizar todos los campos de una vez
                actualizar.CommandText = "UPDATE sistema SET nombre = '" + nombre + "',clave = '" + clave + "', nivel = '" + nivel + "' WHERE nombre = '" +
usuario_modificar + "'";

                actualizar.ExecuteNonQuery();
                miconcexion.Close();
                btnmodificar.Visible = true;
                btnactualizar.Visible = false;
                txtusuario.Enabled = false;
                txtcontraseña.Enabled = false;
                comboBox1.Enabled = false;
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}