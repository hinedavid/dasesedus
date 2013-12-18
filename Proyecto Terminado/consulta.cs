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
    public partial class consulta : Form
    {
        string tipo;
        string cod_medico;
        string cedula;
        string tipo_ids;

        public consulta(string id_paciente)
        {
            InitializeComponent();
            this.label11.Text = id_paciente;
            cedula = id_paciente;
            this.consultas(id_paciente, Login.get_user());

        }

        private void Form3_Load(object sender, EventArgs e){ }

        private void label3_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e){ }

        private void txt_nasegurado_TextChanged(object sender, EventArgs e){ }

        private void button1_Click(object sender, EventArgs e) {
            
           
        }

        private void button2_Click(object sender, EventArgs e) {
            tratamento F5 = new tratamento(cedula,tipo,Login.get_user(),tipo_ids);
            F5.Show();

        }

        private void label11_Click(object sender, EventArgs e){ }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){ }

        private void lbl_codigo_medico_Click(object sender, EventArgs e){ }

        private void consultas(string id_paciente,string id_medico) {

            
             //manejo de excepciones
            try {
                //intenta abrir la base de datos
                Conexion c = new Conexion();
                String query = "select codigo_medico,tipo_id,nombre_paciente,fdenac_paciente,tipo_identificacion from scott.Medico,scott.Paciente";
                query += "where num_identificacion_paciente= :id  And identificacion= :medico ";
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                c.get_cmd().Parameters.Add("id", id_paciente);
                c.get_cmd().Parameters.Add("medico", id_medico);
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
                 //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());               
                 
                 if (reader.Read()){
                     lbl_codigo_medico.Text = reader[0].ToString();
                     cod_medico = reader[0].ToString();
                     tipo_ids = reader[1].ToString();
                     lbl_nombre_paciente.Text = reader[2].ToString();
                     DateTime FecActual = DateTime.Now;                    
                     DateTime FecPas = Convert.ToDateTime(reader[3].ToString());
                     lbl_edad.Text = Convert.ToString(FecActual.Year - FecPas.Year);
                     tipo = reader[4].ToString();
                     DataSet set = new DataSet();
                     set.Tables.Add("Tabla");
                     adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                     c.Close();                  
                 }else{
                    MessageBox.Show("No existen registros de consultas del paciente"); 
                    c.Close();
                 }
            }catch { MessageBox.Show("Error al realizar la consulta, por favor comunicarse con el administrador de la base de datos");}
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e){ }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            string hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            //abre la conexiòn
            Conexion c = new Conexion();
            try{                
                string insertar = "Insert into scott.Consulta(fecha_consulta,hora_consulta) values(:fec, :hor )";                     
                c.get_cmd().CommandText = insertar;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                c.get_cmd().Parameters.Add("fec", fecha);
                c.get_cmd().Parameters.Add("hor", hora);
                c.get_cmd().ExecuteNonQuery();
               // MessageBox.Show("insertado correctamente");

                insertar = "Insert into scott.diagnostico (descripcion_diagnostico,fecha) values(:des, :fec)";               
                c.get_cmd().CommandText = insertar;
                c.get_cmd().CommandType = CommandType.Text;
                //evitamos inyección SQL
                c.get_cmd().Parameters.Add("des", txt_descripcion.Text);
                c.get_cmd().Parameters.Add("fec", fecha);
                
                try{
                    c.get_cmd().ExecuteNonQuery();
                  //  MessageBox.Show("insertado correctamente en la tabla diagnostico");
                } catch { MessageBox.Show("Error al ingresar el diagnostico, consulte al administrador del sistema");}

                
                try {               
                    String query = "select MAX(codigo_consulta), MAX(codigo_diagnostico) from scott.consulta,scott.diagnostico ";
                    c.get_cmd().CommandText = query;
                    c.get_cmd().CommandType = CommandType.Text;
                    //****Ejecutamos la consulta mediante un DataReader de Oracle
                    OracleDataReader reader = c.get_cmd().ExecuteReader();
                    //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                    OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());
                    if (reader.Read()){
                        //     lbl_codigo_medico.Text = reader[0].ToString();
                        string cod_consulta = reader[0].ToString();
                        string cod_diagnostico = reader[1].ToString();                   
                        // MessageBox.Show("codigos consulta y diagnostico :"+ cod_consulta +","+cod_diagnostico);

                        insertar = "Insert into scott.genera (codigo_diagnostico,codigo_consulta) values( :diag, :consul )";                         
                        c.get_cmd().CommandText = insertar;
                        c.get_cmd().CommandType = CommandType.Text;
                        //evitamos inyección SQL
                        c.get_cmd().Parameters.Add("diag", cod_diagnostico);
                        c.get_cmd().Parameters.Add("consul", cod_consulta);

                        try { c.get_cmd().ExecuteNonQuery(); }


                        catch { MessageBox.Show("Error al registrar el diagnóstico, consulte al administrador del sistema"); }

                        insertar = "Insert into scott.participa (num_identificacion_paciente,tipo_identificacion,codigo_consulta,identificacion,tipo_id)";
                        insertar += "values(:id, :tip, :consulta, :id_me, :id_tipo)";
                        
                        c.get_cmd().CommandText = insertar;
                        c.get_cmd().CommandType = CommandType.Text;
                        //evitamos inyección SQL
                        c.get_cmd().Parameters.Add("id", cedula);
                        c.get_cmd().Parameters.Add("tip", tipo);
                        c.get_cmd().Parameters.Add("consulta", cod_consulta);
                        c.get_cmd().Parameters.Add("id_me", Login.get_user());
                        c.get_cmd().Parameters.Add("id_tipo", tipo_ids);
                         try
                         {
                             c.get_cmd().ExecuteNonQuery();
                             c.Close();
                         }

                         catch{
                             MessageBox.Show("Error en registro, consulte al administrador del sistema");
                             c.Close();
                         }
          
                    } else {MessageBox.Show("No hay consultas registradas"); }

                }
                catch { MessageBox.Show("Error en registro, consulte al administrador del sistema"); }

            }
            catch { MessageBox.Show("Error en registro, consulte al administrador del sistema"); }

            this.Close();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
