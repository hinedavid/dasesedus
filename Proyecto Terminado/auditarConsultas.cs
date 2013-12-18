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
    public partial class auditarConsultas : Form
    {
        public auditarConsultas()
        {
            InitializeComponent();
        }

        private void auditarConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //abrimos la conexión
            Conexion c = new Conexion();
             //manejo de excepciones
            try {
                //Hacemos la consulta                
                
                String query = "select num_identificacion_paciente,nombre_paciente,nombre_medico,codigo_medico from ((scott.Participa NATURAL JOIN scott.CONSULTA) NATURAL JOIN scott.Paciente )NATURAL JOIN scott.Medico Where identificacion= :id And fecha_consulta= :consulta";
                //evitamos la inyección de código sql
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                c.get_cmd().Parameters.Add("id", txt_codigo_medico.Text);
                c.get_cmd().Parameters.Add("consulta", date_consulta.Text);
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());
                
                 if (reader.Read()) {
                     //Si la consulta fue exitosa, se cargan los datos en el datagrid                
                     DataSet set = new DataSet();
                     set.Tables.Add("Tabla");
                     adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                     this.dataGridView1.DataSource = set;
                     this.dataGridView1.DataMember = "Tabla";
                     this.dataGridView1.Refresh();
                     this.dataGridView1.Columns[0].HeaderText = "Nombre paciente";
                     this.dataGridView1.Columns[1].HeaderText = "Identificaciòn paciente";
                     this.dataGridView1.Columns[2].Visible = false;
                     this.dataGridView1.Columns[3].Visible = false;                                          
                     //cerrar la conexión
                     c.Close();        
              } else {
                     MessageBox.Show("No hay consultas registradas");
                     //cerrar la conexiòn
                     c.Close();
              }

    
            } catch {                
                MessageBox.Show("Error al intentar consultar, comuniquese con el administrador del sistema");
                //cerrar la conexiòn
                c.Close();
            }                    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
