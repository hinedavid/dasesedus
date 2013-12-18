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
    public partial class Consultarsubordinados : Form
    {
        public Consultarsubordinados(){ InitializeComponent();}

        private void button2_Click(object sender, EventArgs e){ this.Close();}

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            //manejo de excepciones
            try {
                String query = "select identificacion, tipo_id, codigo_medico, nombre_medico from scott.Medico Where id_medico_supervisor= :id";
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                c.get_cmd().Parameters.Add("id", txt_identificacion.Text);

                //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
                //***si se quiere en un dataset
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());
                if (reader.Read()){                    
                    DataSet set = new DataSet();
                    set.Tables.Add("Tabla");
                    adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                    this.dataGridView1.DataSource = set;
                    this.dataGridView1.DataMember = "Tabla";
                    this.dataGridView1.Refresh();
                    this.dataGridView1.Columns[0].HeaderText = "Identificación";
                    this.dataGridView1.Columns[1].HeaderText = "Tipo Identificación";
                    this.dataGridView1.Columns[2].HeaderText = "Còdigo Mèdico";
                    this.dataGridView1.Columns[3].HeaderText = "Nombre del Mèdico";
                    c.Close();

                }else { 
                    MessageBox.Show("No hay consultas registradas");
                    c.Close();
                }
            }catch{                
                MessageBox.Show("soy el catch");
                c.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}
    }
}
