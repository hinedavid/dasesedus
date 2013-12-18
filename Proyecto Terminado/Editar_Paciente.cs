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
    public partial class Editar_Paciente : Form
    {
        string id_paciente;
        paciente p = new paciente();
        public Editar_Paciente(string identificacion)
        {
            InitializeComponent();
            cargarDatos(identificacion);
            id_paciente = identificacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            //hacemos la comexión 
            string update = "update Paciente ";
            update += "set num_identificacion_paciente= :id, tipo_identificacion= :tid, nombre_paciente= :npaciente, fdenac_paciente= :fnacimiento,direccion_paciente = :dpaciente ";
            update += "Where num_identificacion_paciente= :idp";
            //validamos que nos inyecten SQL                  
            c.get_cmd().CommandText = update;
            c.get_cmd().CommandType = CommandType.Text;
            c.get_cmd().Parameters.Add("id", txt_identificacion.Text);
            c.get_cmd().Parameters.Add("tid", cmb_tipo.SelectedItem);
            c.get_cmd().Parameters.Add("npaciente", txt_nombre.Text);
            c.get_cmd().Parameters.Add("fnacimiento", txt_fecha.Text);
            c.get_cmd().Parameters.Add("dpaciente", txt_dir.Text);
            c.get_cmd().Parameters.Add("idp", id_paciente);


            try //hacemos la inserción de la sentencia
            {
                c.get_cmd().ExecuteNonQuery();
                MessageBox.Show("Paciente actualizado correctamente");
                c.Close();
            }
            catch { MessageBox.Show("No fue posible hacer el registro, consulte al administrador del sistema"); }
            
            this.Close();
            
        }

        private void cargarDatos(string cedula)
        {
            Conexion c = new Conexion();
            try
            {
                String query = "select * from scott.paciente where num_identificacion_paciente= :id";
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                c.get_cmd().Parameters.Add("id", cedula);

                //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
                //***si se quiere en un dataset
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());


                if (reader.Read())
                {
                    txt_identificacion.Text = reader[0].ToString();
                    cmb_tipo.Text = (reader[1].ToString());
                    txt_nombre.Text = (reader[2].ToString());
                    txt_fecha.Text = (reader[3].ToString());
                    txt_dir.Text = (reader[4].ToString());
                    /*DataSet set = new DataSet();
                    set.Tables.Add("Tabla");
                    adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                    this.dataGridView1.DataSource = set;
                    this.dataGridView1.DataMember = "Tabla";
                    this.dataGridView1.Refresh();
                    this.dataGridView1.Columns[0].HeaderText = "Identificacion";
                    this.dataGridView1.Columns[1].HeaderText = "tipo Id";
                    this.dataGridView1.Columns[2].HeaderText = "Nombre";
                    this.dataGridView1.Columns[3].HeaderText = "Fecha de Naciemiento";
                    this.dataGridView1.Columns[4].HeaderText = "Dirección*/
                    c.Close();

                }
                else
                {
                    MessageBox.Show("No hay consultas registradas");
                    c.Close();
                }

            }
            catch
            {
                MessageBox.Show("Error en la consulta, contacte al administrador del sistema");
                c.Close();
            }
        }

        private void Editar_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
