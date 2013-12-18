using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;



    public class Login
    {
        private static string user;
        private static string pass;
        private static bool success;
        private static string tipo;
        //private static OracleCommand cmd;

        public Login(string login_user,string login_pass, Conexion c)
        {
            user = login_user;
            pass = login_pass;           
            

            try {     

                String query = "select usuario,passwd,tipo from scott.USUARIO Where usuario=  :user1 And passwd= :pass1 ";
                c.get_cmd().CommandText = query;
                c.get_cmd().CommandType = CommandType.Text;
                c.get_cmd().Parameters.Add("user1", user);
                c.get_cmd().Parameters.Add("pass1", pass);
               
                //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = c.get_cmd().ExecuteReader();
               
                //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(c.get_cmd());
                DataSet set = new DataSet();
                
                set.Tables.Add("Tabla");
                adapter.Fill(set, "tabla");  //llena el conjunto con la respuesta de la consulta
                //this.dataGridView1.DataSource = set;
                // this.dataGridView1.DataMember = "usuario";
                //this.dataGridView1.Refresh();
               DataRow DR;
                DR = set.Tables["tabla"].Rows[0];
                if ((user == DR[0].ToString()) && (pass == DR[1].ToString()))
                {
                    tipo = DR["tipo"].ToString();
                    success = true;
        
                }
                else { MessageBox.Show("Usuario o Contraseña incorrecta"); }          
                                                                                                                                    
            } catch { MessageBox.Show("Error de conexión con la base de datos"); }

        }


        public static string get_user()
        {

            return user;
        }

        public static bool Success()
        {

            return success;
        }
        public static string tipoU()
        {

            return tipo;
        }
    }

