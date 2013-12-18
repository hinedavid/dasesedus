using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {


        nuevaconsulta snc = new nuevaconsulta();
        public Principal()
        {
            
            
            
            InitializeComponent();
            
            this.label2.Text = Login.get_user();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
      
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Login.tipoU() == "2"){
                btn_consultar_subordinado.Visible = false;
                btn_aumento_salario.Visible = false;
                btn_auditar.Visible = false;
                btn_agregar_medico.Visible = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarMedico A = new AgregarMedico();
            A.Show();
        }

        private void btn_nueva_consulta_Click(object sender, EventArgs e)
        {
            nuevaconsulta snc = new nuevaconsulta();
            snc.Show();
            
            
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            auditarConsultas C = new auditarConsultas();
            C.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultartratamientos C = new Consultartratamientos();
            C.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Consultarsubordinados C = new Consultarsubordinados();
            C.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aumento a = new aumento();
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            paciente p = new paciente();
            p.Show();
        }

        private void btn_medico_Click(object sender, EventArgs e)
        {
            Medico m = new Medico();
            m.Show();
        }
    }
}
