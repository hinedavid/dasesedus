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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
            this.show_medico();
        }

        private void Medico_Load(object sender, EventArgs e)
        {

        }

         public void show_medico()
        {
            Conexion c = new Conexion();
            try
            {
                String query = "select * from scott.Medico";
                
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                //c.get_cmd().Parameters.Add("id", txt_identificacion.Text);

                //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
                //***si se quiere en un dataset
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());


                if (reader.Read())
                {
                    DataSet set = new DataSet();
                    set.Tables.Add("Tabla");
                    adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                    this.dataGridView1.DataSource = set;
                    this.dataGridView1.DataMember = "Tabla";
                    this.dataGridView1.Refresh();
                    this.dataGridView1.Columns[0].HeaderText = "Identificacion";
                    this.dataGridView1.Columns[1].HeaderText = "tipo Id";
                    this.dataGridView1.Columns[2].HeaderText = "Código Médico";
                    this.dataGridView1.Columns[3].HeaderText = "Nombre Médico";
                    this.dataGridView1.Columns[4].HeaderText = "Horario Mèdico";
                    this.dataGridView1.Columns[5].HeaderText = "id Supervisor";
                    this.dataGridView1.Columns[6].HeaderText = "tipo id";
                    this.dataGridView1.Columns[7].HeaderText = "Categoría";
                    this.dataGridView1.Columns[8].HeaderText = "Salario";
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
   }
}
