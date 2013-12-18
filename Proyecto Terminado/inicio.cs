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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
             String user = this.txt_user.Text;
             String pass = this.txt_password.Text;            
             Conexion c = new Conexion();
             //verifica que la conexiòn se haya establecido
            if (Conexion.Success()) {
                //verifica que los datos del login sean correctos
                Login L = new Login(user, pass);
                if (Login.Success())
                {
                    Principal F1 = new Principal();
                    F1.Show();
                    this.Hide();
                    //se cierra la conexión
                    c.Close();
                }
                else { MessageBox.Show("Contaseña inválida"); }

            }
            else { MessageBox.Show("Imposible conectar a la base de datos"); }
        }   
 
        private void btn_cancel_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void txt_user_TextChanged(object sender, EventArgs e) {    }
        }
}
