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
    public partial class tratamento : Form
    {
        string cedula;
        string tipo;
        string cedulaMed;
        string tipomed;
        public tratamento(string cedula1, string tipo1,string cedulaM,string tipoM)
        {
            InitializeComponent();
            cedula = cedula1;
            tipo = tipo1;
            cedulaMed = cedulaM;
            lbl_codigo_medico.Text = cedulaM;
            lbl_asegurado.Text = cedula1;
            tipomed = tipoM;
        }

        private void Form5_Load(object sender, EventArgs e){}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void button1_Click(object sender, EventArgs e){}

        private void label_cantidad_Click(object sender, EventArgs e){}

        private void lbl_codigo_medico_Click(object sender, EventArgs e){}

        private void btn_cancelar_Click(object sender, EventArgs e){ this.Close();}

        private void btn_aceptar_Click(object sender, EventArgs e){
            //abrir conexión
            Conexion c = new Conexion();
            string insertar = "Insert into scott.tratamiento (descripcion_tratamiento) values( :descrip)";
            Conexion.get_cmd().CommandText = insertar;
            Conexion.get_cmd().CommandType = CommandType.Text;
            //evitamos inyección SQL
            Conexion.get_cmd().Parameters.Add("descrip", txt_descripcion.Text);

            try{ 
                Conexion.get_cmd().ExecuteNonQuery();             
            }catch{
                MessageBox.Show("Error al registrar el tratamiento, consulte al administrador del sistema");}
            try {
                String query = "select MAX(codigo_tratamiento) from scott.tratamiento ";
                Conexion.get_cmd().CommandText = query;
                Conexion.get_cmd().CommandType = CommandType.Text;
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
                //***si se quiere en un dataset
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());
                 if (reader.Read()){
                     string cod_tratamiento = reader[0].ToString();
                     insertar = "Insert into scott.toma (num_identificacion_paciente,tipo_identificacion,codigo_tratamiento)";
                     insertar += "values( :id, :tip , : trata )"; 

                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;
                     //evitamos inyección SQL
                     Conexion.get_cmd().Parameters.Add("id", cedula);
                     Conexion.get_cmd().Parameters.Add("tip", tipo);
                     Conexion.get_cmd().Parameters.Add("trata", cod_tratamiento);

                     try{
                         Conexion.get_cmd().ExecuteNonQuery();                        
                     }catch{ MessageBox.Show("soy el catch de tratamiento");}

                     insertar = "Insert into scott.prescribe(identificacion,tipo_id,codigo_tratamiento) values( :ced, :tipo_ced, :trat)";                      
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;
                     //evitamos inyección SQL
                     Conexion.get_cmd().Parameters.Add("ced", cedulaMed);
                     Conexion.get_cmd().Parameters.Add("tipo_ced", tipomed);
                     Conexion.get_cmd().Parameters.Add("trat", cod_tratamiento);

                     try
                     {
                         Conexion.get_cmd().ExecuteNonQuery();
                        // MessageBox.Show("insertado correctamente en la tabla tratamiento");
                         c.Close();
                     }

                     catch
                     {
                         MessageBox.Show("Error de regsitro, consulte al administrador del sistema");
                         c.Close(); // cerramos la conección
                     }
                  }           
            }
             catch
             {
                 MessageBox.Show("Error de regsitro, consulte al administrador del sistema");
                 c.Close(); // cerramos la conección
             }
            
            this.Close();
   }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

}
}