namespace WindowsFormsApplication1
{
    partial class AgregarMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codsup = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codicoM = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bx_tipo_id_sup = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_id_sup = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Identificación Supervisor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 500);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(232, 46);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.MaxLength = 9;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(148, 26);
            this.txt_id.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(232, 171);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(355, 26);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_codsup
            // 
            this.txt_codsup.Location = new System.Drawing.Point(232, 352);
            this.txt_codsup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_codsup.MaxLength = 9;
            this.txt_codsup.Name = "txt_codsup";
            this.txt_codsup.Size = new System.Drawing.Size(148, 26);
            this.txt_codsup.TabIndex = 10;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(232, 495);
            this.txt_tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tipo.MaxLength = 10;
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(148, 26);
            this.txt_tipo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 661);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código_Médico";
            // 
            // txt_codicoM
            // 
            this.txt_codicoM.Location = new System.Drawing.Point(232, 226);
            this.txt_codicoM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_codicoM.MaxLength = 10;
            this.txt_codicoM.Name = "txt_codicoM";
            this.txt_codicoM.Size = new System.Drawing.Size(148, 26);
            this.txt_codicoM.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "ced",
            "res"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ced",
            "res"});
            this.comboBox1.Location = new System.Drawing.Point(232, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Bx_tipo_id_sup
            // 
            this.Bx_tipo_id_sup.AutoCompleteCustomSource.AddRange(new string[] {
            "ced",
            "res"});
            this.Bx_tipo_id_sup.FormattingEnabled = true;
            this.Bx_tipo_id_sup.Items.AddRange(new object[] {
            "ced",
            "res"});
            this.Bx_tipo_id_sup.Location = new System.Drawing.Point(232, 432);
            this.Bx_tipo_id_sup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bx_tipo_id_sup.Name = "Bx_tipo_id_sup";
            this.Bx_tipo_id_sup.Size = new System.Drawing.Size(148, 28);
            this.Bx_tipo_id_sup.TabIndex = 17;
            // 
            // lbl_tipo_id_sup
            // 
            this.lbl_tipo_id_sup.AutoSize = true;
            this.lbl_tipo_id_sup.Location = new System.Drawing.Point(44, 443);
            this.lbl_tipo_id_sup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_id_sup.Name = "lbl_tipo_id_sup";
            this.lbl_tipo_id_sup.Size = new System.Drawing.Size(136, 20);
            this.lbl_tipo_id_sup.TabIndex = 18;
            this.lbl_tipo_id_sup.Text = "tipo_identificación";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Location = new System.Drawing.Point(48, 569);
            this.lbl_salario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(55, 20);
            this.lbl_salario.TabIndex = 19;
            this.lbl_salario.Text = "salario";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(232, 563);
            this.txt_salario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_salario.MaxLength = 10;
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(148, 26);
            this.txt_salario.TabIndex = 20;
            // 
            // cmb_horario
            // 
            this.cmb_horario.AutoCompleteCustomSource.AddRange(new string[] {
            "ced",
            "res"});
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.cmb_horario.Location = new System.Drawing.Point(232, 295);
            this.cmb_horario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(148, 28);
            this.cmb_horario.TabIndex = 21;
            // 
            // AgregarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 737);
            this.Controls.Add(this.cmb_horario);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_tipo_id_sup);
            this.Controls.Add(this.Bx_tipo_id_sup);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_codicoM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_codsup);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Médico";
            this.Load += new System.EventHandler(this.AgregarMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codsup;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codicoM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Bx_tipo_id_sup;
        private System.Windows.Forms.Label lbl_tipo_id_sup;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.ComboBox cmb_horario;
    }
}