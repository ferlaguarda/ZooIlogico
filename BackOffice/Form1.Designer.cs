namespace BackOffice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.cboTipoAnimal = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblSonido = new System.Windows.Forms.Label();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.lblTipoAlimentacion = new System.Windows.Forms.Label();
            this.txtSonido = new System.Windows.Forms.TextBox();
            this.cboTipoAlimentacion = new System.Windows.Forms.ComboBox();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.grbDatosAnimal = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BtnVerDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grbDatosAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registro de animal";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Location = new System.Drawing.Point(17, 79);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(38, 16);
            this.lblTipoAnimal.TabIndex = 3;
            this.lblTipoAnimal.Text = "Tipo:";
            // 
            // cboTipoAnimal
            // 
            this.cboTipoAnimal.FormattingEnabled = true;
            this.cboTipoAnimal.Items.AddRange(new object[] {
            "Indefinido",
            "Mamifero",
            "Ave",
            "Pez",
            "Reptil",
            "Insecto"});
            this.cboTipoAnimal.Location = new System.Drawing.Point(123, 76);
            this.cboTipoAnimal.Name = "cboTipoAnimal";
            this.cboTipoAnimal.Size = new System.Drawing.Size(273, 24);
            this.cboTipoAnimal.TabIndex = 4;
            this.cboTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cboTipoAnimal_SelectedIndexChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(435, 40);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(16, 119);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(60, 16);
            this.lblEspecie.TabIndex = 6;
            this.lblEspecie.Text = "Especie:";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(17, 161);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(42, 16);
            this.lblRaza.TabIndex = 7;
            this.lblRaza.Text = "Raza:";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(123, 161);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(273, 22);
            this.txtRaza.TabIndex = 8;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(123, 119);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(273, 22);
            this.txtEspecie.TabIndex = 9;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(533, 35);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 10;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSonido
            // 
            this.lblSonido.AutoSize = true;
            this.lblSonido.Location = new System.Drawing.Point(435, 79);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(53, 16);
            this.lblSonido.TabIndex = 13;
            this.lblSonido.Text = "Sonido:";
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Location = new System.Drawing.Point(435, 161);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(62, 16);
            this.lblAlimento.TabIndex = 12;
            this.lblAlimento.Text = "Alimento:";
            // 
            // lblTipoAlimentacion
            // 
            this.lblTipoAlimentacion.AutoSize = true;
            this.lblTipoAlimentacion.Location = new System.Drawing.Point(435, 119);
            this.lblTipoAlimentacion.Name = "lblTipoAlimentacion";
            this.lblTipoAlimentacion.Size = new System.Drawing.Size(92, 16);
            this.lblTipoAlimentacion.TabIndex = 11;
            this.lblTipoAlimentacion.Text = "Tipo alimento:";
            // 
            // txtSonido
            // 
            this.txtSonido.Location = new System.Drawing.Point(533, 73);
            this.txtSonido.Name = "txtSonido";
            this.txtSonido.Size = new System.Drawing.Size(273, 22);
            this.txtSonido.TabIndex = 15;
            // 
            // cboTipoAlimentacion
            // 
            this.cboTipoAlimentacion.FormattingEnabled = true;
            this.cboTipoAlimentacion.Items.AddRange(new object[] {
            "Indefinido",
            "Herviboro",
            "Carnivoro",
            "Insectivoro",
            "Omnivoro"});
            this.cboTipoAlimentacion.Location = new System.Drawing.Point(533, 116);
            this.cboTipoAlimentacion.Name = "cboTipoAlimentacion";
            this.cboTipoAlimentacion.Size = new System.Drawing.Size(273, 24);
            this.cboTipoAlimentacion.TabIndex = 14;
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(533, 158);
            this.txtAlimento.Multiline = true;
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(273, 160);
            this.txtAlimento.TabIndex = 16;
            // 
            // grbDatosAnimal
            // 
            this.grbDatosAnimal.Controls.Add(this.txtAlimento);
            this.grbDatosAnimal.Controls.Add(this.lblNombre);
            this.grbDatosAnimal.Controls.Add(this.txtSonido);
            this.grbDatosAnimal.Controls.Add(this.txtNombre);
            this.grbDatosAnimal.Controls.Add(this.cboTipoAlimentacion);
            this.grbDatosAnimal.Controls.Add(this.lblTipoAnimal);
            this.grbDatosAnimal.Controls.Add(this.lblSonido);
            this.grbDatosAnimal.Controls.Add(this.cboTipoAnimal);
            this.grbDatosAnimal.Controls.Add(this.lblAlimento);
            this.grbDatosAnimal.Controls.Add(this.lblEdad);
            this.grbDatosAnimal.Controls.Add(this.lblTipoAlimentacion);
            this.grbDatosAnimal.Controls.Add(this.lblEspecie);
            this.grbDatosAnimal.Controls.Add(this.nudEdad);
            this.grbDatosAnimal.Controls.Add(this.lblRaza);
            this.grbDatosAnimal.Controls.Add(this.txtEspecie);
            this.grbDatosAnimal.Controls.Add(this.txtRaza);
            this.grbDatosAnimal.Location = new System.Drawing.Point(43, 65);
            this.grbDatosAnimal.Name = "grbDatosAnimal";
            this.grbDatosAnimal.Size = new System.Drawing.Size(869, 343);
            this.grbDatosAnimal.TabIndex = 17;
            this.grbDatosAnimal.TabStop = false;
            this.grbDatosAnimal.Text = "Datos animal";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(197, 428);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(139, 43);
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(392, 428);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 43);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnVerDatos
            // 
            this.BtnVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDatos.Location = new System.Drawing.Point(592, 428);
            this.BtnVerDatos.Name = "BtnVerDatos";
            this.BtnVerDatos.Size = new System.Drawing.Size(139, 43);
            this.BtnVerDatos.TabIndex = 20;
            this.BtnVerDatos.Text = "Ver datos";
            this.BtnVerDatos.UseVisualStyleBackColor = true;
            this.BtnVerDatos.Click += new System.EventHandler(this.BtnVerDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 502);
            this.Controls.Add(this.BtnVerDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.grbDatosAnimal);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de animales";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grbDatosAnimal.ResumeLayout(false);
            this.grbDatosAnimal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.ComboBox cboTipoAnimal;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblSonido;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.Label lblTipoAlimentacion;
        private System.Windows.Forms.TextBox txtSonido;
        private System.Windows.Forms.ComboBox cboTipoAlimentacion;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.GroupBox grbDatosAnimal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button BtnVerDatos;
    }
}

