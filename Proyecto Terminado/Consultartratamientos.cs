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
    public partial class Consultartratamientos : Form
    {
        public Consultartratamientos(){ InitializeComponent();}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){ }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            //manejo de excepciones
            try {
                String query = "select codigo_tratamiento,descripcion_tratamiento,codigo_medico,nombre_medico from";
                query += "((scott.toma NATURAL JOIN scott.TRATAMIENTO)NATURAL JOIN scott.prescribe)NATURAL JOIN scott.Medico ";
                query += " Where num_identificacion_paciente= :id";
                Conexion.get_cmd().CommandText = query;
                Conexion.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                Conexion.get_cmd().Parameters.Add("id", txt_identificacion.Text);

                //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
                //***si se quiere en un dataset
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());


                if (reader.Read()){
                    DataSet set = new DataSet();
                    set.Tables.Add("Tabla");
                    adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                    this.dataGridView1.DataSource = set;
                    this.dataGridView1.DataMember = "Tabla";
                    this.dataGridView1.Refresh();
                    this.dataGridView1.Columns[0].HeaderText = "Código de Tratamiento";
                    this.dataGridView1.Columns[1].HeaderText = "Descripción del Tratamiento";
                    this.dataGridView1.Columns[2].HeaderText = "Código Médico";
                    this.dataGridView1.Columns[3].HeaderText = "Nombre del Médico";
                    c.Close();
                }else {
                    MessageBox.Show("No hay consultas registradas");
                    c.Close();
                }

            }catch{                
                MessageBox.Show("Error en la consulta, contacte al administrador del sistema");
                c.Close();
            }
        }

        private void Consultartratamientos_Load(object sender, EventArgs e){}

        private void button2_Click(object sender, EventArgs e){ this.Close(); }
    }
}
