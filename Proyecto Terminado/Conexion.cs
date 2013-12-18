using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;


     public  class Conexion
    {
        
        private static bool success;
        private  OracleCommand cmd = new OracleCommand();
        OracleConnection conn;

        //constructor de la clase conexión
        public Conexion() {
            //String de conexiòn
            String connString ="User id=scott;Password=oracle;Data Source=orcl;";
            conn = new OracleConnection(connString);        
            cmd.Connection = conn;
            //manejo de excepciones
            try{
               //intenta abrir la base de datos
                conn.Open();
                success = true;
            } catch{
                success = false;
                MessageBox.Show("Imposible acceder a la base de datos");
            } 
        }

         //retorna la la condiciòn de apertura de la base
         public static bool Success() { return success; }

         public   OracleCommand get_cmd() { return cmd; }

         public void Close() { conn.Close(); }        
    }

