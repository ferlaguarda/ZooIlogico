namespace BackOffice
{
    partial class Principal
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
            this.msUsuarios = new System.Windows.Forms.MenuStrip();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnimales = new System.Windows.Forms.ToolStripMenuItem();
            this.miMantenimientoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.miMantenimientoAnimales = new System.Windows.Forms.ToolStripMenuItem();
            this.msUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // msUsuarios
            // 
            this.msUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuarios,
            this.tsmiAnimales});
            this.msUsuarios.Location = new System.Drawing.Point(0, 0);
            this.msUsuarios.Name = "msUsuarios";
            this.msUsuarios.Size = new System.Drawing.Size(800, 24);
            this.msUsuarios.TabIndex = 1;
            this.msUsuarios.Text = "menuStrip1";
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMantenimientoUsuarios});
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(64, 20);
            this.tsmiUsuarios.Text = "Usuarios";
            // 
            // tsmiAnimales
            // 
            this.tsmiAnimales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMantenimientoAnimales});
            this.tsmiAnimales.Name = "tsmiAnimales";
            this.tsmiAnimales.Size = new System.Drawing.Size(68, 20);
            this.tsmiAnimales.Text = "Animales";
            // 
            // miMantenimientoUsuarios
            // 
            this.miMantenimientoUsuarios.Name = "miMantenimientoUsuarios";
            this.miMantenimientoUsuarios.Size = new System.Drawing.Size(180, 22);
            this.miMantenimientoUsuarios.Text = "Mantenimiento";
            this.miMantenimientoUsuarios.Click += new System.EventHandler(this.miMantenimientoUsuarios_Click);
            // 
            // miMantenimientoAnimales
            // 
            this.miMantenimientoAnimales.Name = "miMantenimientoAnimales";
            this.miMantenimientoAnimales.Size = new System.Drawing.Size(180, 22);
            this.miMantenimientoAnimales.Text = "Mantenimiento";
            this.miMantenimientoAnimales.Click += new System.EventHandler(this.miMantenimientoAnimales_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msUsuarios);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msUsuarios;
            this.Name = "Principal";
            this.Text = "Form3";
            this.msUsuarios.ResumeLayout(false);
            this.msUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem miMantenimientoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnimales;
        private System.Windows.Forms.ToolStripMenuItem miMantenimientoAnimales;
    }
}