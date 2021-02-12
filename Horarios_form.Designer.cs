namespace ExamenParcial1
{
    partial class Horarios_form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdtrabajo = new System.Windows.Forms.Label();
            this.cbtlunes = new System.Windows.Forms.CheckBox();
            this.cbtmartes = new System.Windows.Forms.CheckBox();
            this.cbtmiercoles = new System.Windows.Forms.CheckBox();
            this.cbtjueves = new System.Windows.Forms.CheckBox();
            this.cbtviernes = new System.Windows.Forms.CheckBox();
            this.cbtsabado = new System.Windows.Forms.CheckBox();
            this.cbtdomingo = new System.Windows.Forms.CheckBox();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(708, 300);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(832, 300);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajador: ";
            // 
            // lbdtrabajo
            // 
            this.lbdtrabajo.AutoSize = true;
            this.lbdtrabajo.Location = new System.Drawing.Point(41, 94);
            this.lbdtrabajo.Name = "lbdtrabajo";
            this.lbdtrabajo.Size = new System.Drawing.Size(122, 16);
            this.lbdtrabajo.TabIndex = 1;
            this.lbdtrabajo.Text = "Días que trabaja:";
            // 
            // cbtlunes
            // 
            this.cbtlunes.AutoSize = true;
            this.cbtlunes.Location = new System.Drawing.Point(168, 94);
            this.cbtlunes.Name = "cbtlunes";
            this.cbtlunes.Size = new System.Drawing.Size(65, 20);
            this.cbtlunes.TabIndex = 3;
            this.cbtlunes.Text = "Lunes";
            this.cbtlunes.UseVisualStyleBackColor = true;
            this.cbtlunes.Click += new System.EventHandler(this.cbtlunes_Click);
            // 
            // cbtmartes
            // 
            this.cbtmartes.AutoSize = true;
            this.cbtmartes.Location = new System.Drawing.Point(249, 94);
            this.cbtmartes.Name = "cbtmartes";
            this.cbtmartes.Size = new System.Drawing.Size(72, 20);
            this.cbtmartes.TabIndex = 4;
            this.cbtmartes.Text = "Martes";
            this.cbtmartes.UseVisualStyleBackColor = true;
            this.cbtmartes.Click += new System.EventHandler(this.cbtmartes_Click);
            // 
            // cbtmiercoles
            // 
            this.cbtmiercoles.AutoSize = true;
            this.cbtmiercoles.Location = new System.Drawing.Point(336, 94);
            this.cbtmiercoles.Name = "cbtmiercoles";
            this.cbtmiercoles.Size = new System.Drawing.Size(88, 20);
            this.cbtmiercoles.TabIndex = 5;
            this.cbtmiercoles.Text = "Miercoles";
            this.cbtmiercoles.UseVisualStyleBackColor = true;
            this.cbtmiercoles.Click += new System.EventHandler(this.cbtmiercoles_Click);
            // 
            // cbtjueves
            // 
            this.cbtjueves.AutoSize = true;
            this.cbtjueves.Location = new System.Drawing.Point(168, 141);
            this.cbtjueves.Name = "cbtjueves";
            this.cbtjueves.Size = new System.Drawing.Size(72, 20);
            this.cbtjueves.TabIndex = 6;
            this.cbtjueves.Text = "Jueves";
            this.cbtjueves.UseVisualStyleBackColor = true;
            this.cbtjueves.Click += new System.EventHandler(this.cbtjueves_Click);
            // 
            // cbtviernes
            // 
            this.cbtviernes.AutoSize = true;
            this.cbtviernes.Location = new System.Drawing.Point(257, 141);
            this.cbtviernes.Name = "cbtviernes";
            this.cbtviernes.Size = new System.Drawing.Size(75, 20);
            this.cbtviernes.TabIndex = 7;
            this.cbtviernes.Text = "Viernes";
            this.cbtviernes.UseVisualStyleBackColor = true;
            this.cbtviernes.Click += new System.EventHandler(this.cbtViernes_Click);
            // 
            // cbtsabado
            // 
            this.cbtsabado.AutoSize = true;
            this.cbtsabado.Location = new System.Drawing.Point(347, 141);
            this.cbtsabado.Name = "cbtsabado";
            this.cbtsabado.Size = new System.Drawing.Size(76, 20);
            this.cbtsabado.TabIndex = 8;
            this.cbtsabado.Text = "Sábado";
            this.cbtsabado.UseVisualStyleBackColor = true;
            this.cbtsabado.Click += new System.EventHandler(this.cbtsabado_Click);
            // 
            // cbtdomingo
            // 
            this.cbtdomingo.AutoSize = true;
            this.cbtdomingo.Location = new System.Drawing.Point(168, 186);
            this.cbtdomingo.Name = "cbtdomingo";
            this.cbtdomingo.Size = new System.Drawing.Size(82, 20);
            this.cbtdomingo.TabIndex = 9;
            this.cbtdomingo.Text = "Domingo";
            this.cbtdomingo.UseVisualStyleBackColor = true;
            this.cbtdomingo.Click += new System.EventHandler(this.cbtdomingo_Click);
            // 
            // cbx
            // 
            this.cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(177, 30);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(159, 24);
            this.cbx.TabIndex = 17;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(157, 230);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 29);
            this.btnagregar.TabIndex = 18;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(291, 230);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(99, 29);
            this.btnborrar.TabIndex = 19;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(450, 30);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(458, 247);
            this.dgvmostrar.TabIndex = 20;
            this.dgvmostrar.Click += new System.EventHandler(this.dgvmostrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Horarios_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 359);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.cbtdomingo);
            this.Controls.Add(this.cbtsabado);
            this.Controls.Add(this.cbtviernes);
            this.Controls.Add(this.cbtjueves);
            this.Controls.Add(this.cbtmiercoles);
            this.Controls.Add(this.cbtmartes);
            this.Controls.Add(this.cbtlunes);
            this.Controls.Add(this.lbdtrabajo);
            this.Controls.Add(this.label1);
            this.Name = "Horarios_form";
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.Horarios_form_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbdtrabajo, 0);
            this.Controls.SetChildIndex(this.cbtlunes, 0);
            this.Controls.SetChildIndex(this.cbtmartes, 0);
            this.Controls.SetChildIndex(this.cbtmiercoles, 0);
            this.Controls.SetChildIndex(this.cbtjueves, 0);
            this.Controls.SetChildIndex(this.cbtviernes, 0);
            this.Controls.SetChildIndex(this.cbtsabado, 0);
            this.Controls.SetChildIndex(this.cbtdomingo, 0);
            this.Controls.SetChildIndex(this.cbx, 0);
            this.Controls.SetChildIndex(this.btnagregar, 0);
            this.Controls.SetChildIndex(this.btnborrar, 0);
            this.Controls.SetChildIndex(this.dgvmostrar, 0);
            this.Controls.SetChildIndex(this.btnmenu, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbdtrabajo;
        private System.Windows.Forms.CheckBox cbtlunes;
        private System.Windows.Forms.CheckBox cbtmartes;
        private System.Windows.Forms.CheckBox cbtmiercoles;
        private System.Windows.Forms.CheckBox cbtjueves;
        private System.Windows.Forms.CheckBox cbtviernes;
        private System.Windows.Forms.CheckBox cbtsabado;
        private System.Windows.Forms.CheckBox cbtdomingo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.DataGridView dgvmostrar;
        public System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}