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
    public partial class paciente : Form
    {
        String identificacion;
        public paciente()
        {
            InitializeComponent();
            this.show_paciente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow fila = this.dataGridView1.CurrentRow;
            identificacion = Convert.ToString(fila.Cells[0].Value);
            Editar_Paciente p = new Editar_Paciente(identificacion);
            p.Show();
            this.show_paciente();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void show_paciente()
        {
            Conexion c = new Conexion();
            try
            {
                String query = "select * from scott.paciente";
                
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
                    this.dataGridView1.Columns[2].HeaderText = "Nombre";
                    this.dataGridView1.Columns[3].HeaderText = "Fecha de Naciemiento";
                    this.dataGridView1.Columns[4].HeaderText = "Dirección";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
