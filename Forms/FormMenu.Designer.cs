namespace ExamenParcial1
{
    partial class Menú
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
            this.btntrabajadores = new System.Windows.Forms.Button();
            this.btnplanillas = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.btnhorarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntrabajadores
            // 
            this.btntrabajadores.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btntrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrabajadores.Location = new System.Drawing.Point(52, 41);
            this.btntrabajadores.Name = "btntrabajadores";
            this.btntrabajadores.Size = new System.Drawing.Size(112, 42);
            this.btntrabajadores.TabIndex = 0;
            this.btntrabajadores.Text = "Trabajadores";
            this.btntrabajadores.UseVisualStyleBackColor = false;
            this.btntrabajadores.Click += new System.EventHandler(this.btntrabajadores_Click);
            // 
            // btnplanillas
            // 
            this.btnplanillas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnplanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplanillas.Location = new System.Drawing.Point(185, 41);
            this.btnplanillas.Name = "btnplanillas";
            this.btnplanillas.Size = new System.Drawing.Size(103, 42);
            this.btnplanillas.TabIndex = 1;
            this.btnplanillas.Text = "Planillas";
            this.btnplanillas.UseVisualStyleBackColor = false;
            this.btnplanillas.Click += new System.EventHandler(this.btnplanillas_Click);
            // 
            // btninventario
            // 
            this.btninventario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventario.Location = new System.Drawing.Point(312, 41);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(98, 42);
            this.btninventario.TabIndex = 2;
            this.btninventario.Text = "Inventario";
            this.btninventario.UseVisualStyleBackColor = false;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // btnhorarios
            // 
            this.btnhorarios.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnhorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhorarios.Location = new System.Drawing.Point(52, 111);
            this.btnhorarios.Name = "btnhorarios";
            this.btnhorarios.Size = new System.Drawing.Size(112, 34);
            this.btnhorarios.TabIndex = 3;
            this.btnhorarios.Text = "Horarios";
            this.btnhorarios.UseVisualStyleBackColor = false;
            this.btnhorarios.Click += new System.EventHandler(this.btnhorarios_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(308, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Facturas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(367, 183);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(86, 25);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnhorarios);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.btnplanillas);
            this.Controls.Add(this.btntrabajadores);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Menú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menú_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntrabajadores;
        private System.Windows.Forms.Button btnplanillas;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button btnhorarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsalir;
    }
}