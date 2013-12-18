namespace WindowsFormsApplication1
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_nueva_consulta = new System.Windows.Forms.Button();
            this.btn_auditar = new System.Windows.Forms.Button();
            this.btm_tratamiento_pacientes = new System.Windows.Forms.Button();
            this.btn_consultar_subordinado = new System.Windows.Forms.Button();
            this.btn_agregar_medico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aumento_salario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_medico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nueva_consulta
            // 
            this.btn_nueva_consulta.Location = new System.Drawing.Point(46, 98);
            this.btn_nueva_consulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nueva_consulta.Name = "btn_nueva_consulta";
            this.btn_nueva_consulta.Size = new System.Drawing.Size(153, 69);
            this.btn_nueva_consulta.TabIndex = 0;
            this.btn_nueva_consulta.Text = "Nueva Consulta";
            this.btn_nueva_consulta.UseVisualStyleBackColor = true;
            this.btn_nueva_consulta.Click += new System.EventHandler(this.btn_nueva_consulta_Click);
            // 
            // btn_auditar
            // 
            this.btn_auditar.Location = new System.Drawing.Point(368, 98);
            this.btn_auditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_auditar.Name = "btn_auditar";
            this.btn_auditar.Size = new System.Drawing.Size(149, 69);
            this.btn_auditar.TabIndex = 2;
            this.btn_auditar.Text = "Auditar Consulta";
            this.btn_auditar.UseVisualStyleBackColor = true;
            this.btn_auditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btm_tratamiento_pacientes
            // 
            this.btm_tratamiento_pacientes.Location = new System.Drawing.Point(525, 232);
            this.btm_tratamiento_pacientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btm_tratamiento_pacientes.Name = "btm_tratamiento_pacientes";
            this.btm_tratamiento_pacientes.Size = new System.Drawing.Size(161, 76);
            this.btm_tratamiento_pacientes.TabIndex = 3;
            this.btm_tratamiento_pacientes.Text = "Tratamientos por Paciente";
            this.btm_tratamiento_pacientes.UseVisualStyleBackColor = true;
            this.btm_tratamiento_pacientes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_consultar_subordinado
            // 
            this.btn_consultar_subordinado.Location = new System.Drawing.Point(525, 98);
            this.btn_consultar_subordinado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultar_subordinado.Name = "btn_consultar_subordinado";
            this.btn_consultar_subordinado.Size = new System.Drawing.Size(161, 69);
            this.btn_consultar_subordinado.TabIndex = 4;
            this.btn_consultar_subordinado.Text = "Consultar Subordinados";
            this.btn_consultar_subordinado.UseVisualStyleBackColor = true;
            this.btn_consultar_subordinado.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_agregar_medico
            // 
            this.btn_agregar_medico.Location = new System.Drawing.Point(46, 232);
            this.btn_agregar_medico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_agregar_medico.Name = "btn_agregar_medico";
            this.btn_agregar_medico.Size = new System.Drawing.Size(153, 76);
            this.btn_agregar_medico.TabIndex = 5;
            this.btn_agregar_medico.Text = "Agregar Médico";
            this.btn_agregar_medico.UseVisualStyleBackColor = true;
            this.btn_agregar_medico.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(129, 20);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 20);
            this.label_user.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_aumento_salario
            // 
            this.btn_aumento_salario.Location = new System.Drawing.Point(368, 232);
            this.btn_aumento_salario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_aumento_salario.Name = "btn_aumento_salario";
            this.btn_aumento_salario.Size = new System.Drawing.Size(149, 76);
            this.btn_aumento_salario.TabIndex = 9;
            this.btn_aumento_salario.Text = "Aumento de salario";
            this.btn_aumento_salario.UseVisualStyleBackColor = true;
            this.btn_aumento_salario.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 69);
            this.button1.TabIndex = 10;
            this.button1.Text = "Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_medico
            // 
            this.btn_medico.Location = new System.Drawing.Point(207, 232);
            this.btn_medico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_medico.Name = "btn_medico";
            this.btn_medico.Size = new System.Drawing.Size(153, 76);
            this.btn_medico.TabIndex = 11;
            this.btn_medico.Text = "Médico";
            this.btn_medico.UseVisualStyleBackColor = true;
            this.btn_medico.Click += new System.EventHandler(this.btn_medico_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 408);
            this.Controls.Add(this.btn_medico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_aumento_salario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consultar_subordinado);
            this.Controls.Add(this.btm_tratamiento_pacientes);
            this.Controls.Add(this.btn_auditar);
            this.Controls.Add(this.btn_nueva_consulta);
            this.Controls.Add(this.btn_agregar_medico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDUS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nueva_consulta;
        private System.Windows.Forms.Button btn_auditar;
        private System.Windows.Forms.Button btm_tratamiento_pacientes;
        private System.Windows.Forms.Button btn_consultar_subordinado;
        private System.Windows.Forms.Button btn_agregar_medico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aumento_salario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_medico;

    }
}

