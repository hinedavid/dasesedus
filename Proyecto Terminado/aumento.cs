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
    public partial class aumento : Form
    {
        public aumento()
        {
            InitializeComponent();
            this.Salarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir la conexión
            Conexion c = new Conexion();
            string insertar = "begin scott.salarioAumentar (:aumento); END;";
            //evitar inyección código SQL
            c.get_cmd().CommandText = insertar;
            c.get_cmd().CommandType = CommandType.Text;
            c.get_cmd().Parameters.Add("aumento", txt_aumento.Text);

            try{
                c.get_cmd().ExecuteNonQuery();
                c.Close();
                this.Salarios();               
            } catch {
                MessageBox.Show("No fue posible realizar la operación, consulte al administrador del sistema");
                c.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salarios()
        {

                //abrir la conexión
                Conexion c = new Conexion();
                try
                {
                 String query = "select identificacion,nombre_medico,codigo_medico,salario from scott.Medico";
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;

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
                    this.dataGridView1.Columns[0].HeaderText = "Identificación";
                    this.dataGridView1.Columns[1].HeaderText = "Nombre";
                    this.dataGridView1.Columns[2].HeaderText = "Código Médico";
                    this.dataGridView1.Columns[3].HeaderText = "Salario";
                    c.Close();
                    
                }
                else {
                    MessageBox.Show("No hay salarios resgistrados");
                    c.Close();
                }

            }

            catch
            {
                MessageBox.Show("No fue posible realizar la operación, consulte al administrador del sistema");
                c.Close();
            }
        }
    }
}
