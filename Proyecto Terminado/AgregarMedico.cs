using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class AgregarMedico : Form
    {
        public AgregarMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //establece la conexión
            Conexion c = new Conexion();

            //hacemos la comexión 
            string insertar = "Insert into scott.medico (identificacion,tipo_id,codigo_medico,nombre_medico,horario_medico,id_medico_supervisor,tipo_id_supervisor,tipo_categoria,salario)";
            insertar += "values(:id, :tipo_id, :cod_med, :nom, :hor, :supervisor, :tip_super, :tip_cat, :sal)";      
            //validamos que nos inyecten SQL                  
            Conexion.get_cmd().CommandText = insertar;
            Conexion.get_cmd().CommandType = CommandType.Text;
            Conexion.get_cmd().Parameters.Add("id", txt_id.Text);
            Conexion.get_cmd().Parameters.Add("tipo_id", comboBox1.SelectedItem);
            Conexion.get_cmd().Parameters.Add("cod_med", txt_codicoM.Tex);
            Conexion.get_cmd().Parameters.Add("nom", txt_nombre.Text);
            Conexion.get_cmd().Parameters.Add("hor", cmb_horario.SelectedItem);
            Conexion.get_cmd().Parameters.Add("supervisor", txt_codsup.Text);
            Conexion.get_cmd().Parameters.Add("tip_super", Bx_tipo_id_sup.SelectedItem);
            Conexion.get_cmd().Parameters.Add("tip_cat", txt_tipo.Text);
            Conexion.get_cmd().Parameters.Add("sal", txt_salario.Text);
            

            try //hacemos la inserción de la sentencia
            {
                Conexion.get_cmd().ExecuteNonQuery();
                MessageBox.Show("Médico registrado correctamente" );
                c.Close();
            }catch { MessageBox.Show("No fue posible hacer el registro, consulte al administrador del sistema");}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarMedico_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
