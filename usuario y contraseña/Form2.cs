using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace usuario_y_contraseña
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.sistema' Puede moverla o quitarla según sea necesario.
            this.sistemaTableAdapter.Fill(this.usuarioDataSet.sistema);

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection conexion_access = new OleDbConnection();

                conexion_access.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\usuario.mdb;Persist Security Info=False";
                conexion_access.Open();
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM sistema", conexion_access);

                DataSet resultado = new DataSet();
                consulta.Fill(resultado);
                foreach (DataRow registro in resultado.Tables[0].Rows)

                {
                    if ((txtusuario.Text == registro["nombre"].ToString()) && (txtcontraseña.Text ==
                    registro["clave"].ToString()))
                    {
                        //llamando formulario principal llamado menu
                        fmenu fm = new fmenu();
                        fm.Show(); //abrir menu
                        this.Hide();//ocultar el formulario de login

                        conexion_access.Close();

                    }
                } //Cierre de ciclo for
            } //Cierre de Try
              //Si la conexion falla muestra mensaje de error
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtusuario.Focus();
                //Finalizando la conexión
            }
           

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }
       

    }
    }
   