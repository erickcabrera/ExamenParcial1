namespace ExamenParcial1
{
    partial class Trabajadores_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.fechanacimiento = new System.Windows.Forms.MonthCalendar();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.txtnit = new System.Windows.Forms.MaskedTextBox();
            this.txtafp = new System.Windows.Forms.MaskedTextBox();
            this.txtseguro = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(919, 397);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(1029, 397);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DUI: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIT: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "AFP: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seguro: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pago por día:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Numero de télefono: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tipo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(85, 29);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 23);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(361, 69);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdireccion.MaxLength = 140;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(132, 23);
            this.txtdireccion.TabIndex = 15;
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(362, 98);
            this.txtpago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(132, 23);
            this.txtpago.TabIndex = 16;
            this.txtpago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpago_KeyPress);
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Trabajador",
            "Secretari@",
            "Auxiliar"});
            this.cbtipo.Location = new System.Drawing.Point(361, 177);
            this.cbtipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(132, 24);
            this.cbtipo.TabIndex = 18;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Location = new System.Drawing.Point(34, 251);
            this.fechanacimiento.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.TabIndex = 19;
            this.fechanacimiento.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.fechanacimiento_DateSelected);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(287, 251);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 28);
            this.btnagregar.TabIndex = 20;
            this.btnagregar.Text = "Agregar ";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(416, 251);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(99, 28);
            this.btnborrar.TabIndex = 22;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(539, 41);
            this.dgvmostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(569, 330);
            this.dgvmostrar.TabIndex = 23;
            this.dgvmostrar.Click += new System.EventHandler(this.dgvmostrar_Click);
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(85, 63);
            this.txtdui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdui.Mask = "00000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(132, 23);
            this.txtdui.TabIndex = 24;
            this.txtdui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdui.Click += new System.EventHandler(this.txtdui_Click);
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(85, 105);
            this.txtnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnit.Mask = "0000-000000-000-0";
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(132, 23);
            this.txtnit.TabIndex = 25;
            this.txtnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnit.Click += new System.EventHandler(this.txtnit_Click);
            // 
            // txtafp
            // 
            this.txtafp.Location = new System.Drawing.Point(89, 142);
            this.txtafp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtafp.Mask = "000000000000";
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(132, 23);
            this.txtafp.TabIndex = 26;
            this.txtafp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtafp.ValidatingType = typeof(int);
            this.txtafp.Click += new System.EventHandler(this.txtafp_Click);
            // 
            // txtseguro
            // 
            this.txtseguro.Location = new System.Drawing.Point(361, 32);
            this.txtseguro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtseguro.MaxLength = 20;
            this.txtseguro.Name = "txtseguro";
            this.txtseguro.Size = new System.Drawing.Size(132, 23);
            this.txtseguro.TabIndex = 14;
            this.txtseguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtseguro_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(361, 135);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(132, 23);
            this.txttelefono.TabIndex = 27;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.Click += new System.EventHandler(this.txttelefono_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Trabajadores_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 457);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtafp);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txtdui);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.fechanacimiento);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtseguro);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Trabajadores_form";
            this.Text = "Gerente_Platform";
            this.Load += new System.EventHandler(this.Gerente_Platform_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.txtseguro, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            this.Controls.SetChildIndex(this.txtpago, 0);
            this.Controls.SetChildIndex(this.cbtipo, 0);
            this.Controls.SetChildIndex(this.fechanacimiento, 0);
            this.Controls.SetChildIndex(this.btnagregar, 0);
            this.Controls.SetChildIndex(this.btnborrar, 0);
            this.Controls.SetChildIndex(this.dgvmostrar, 0);
            this.Controls.SetChildIndex(this.txtdui, 0);
            this.Controls.SetChildIndex(this.txtnit, 0);
            this.Controls.SetChildIndex(this.txtafp, 0);
            this.Controls.SetChildIndex(this.txttelefono, 0);
            this.Controls.SetChildIndex(this.btnmenu, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.MonthCalendar fechanacimiento;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.DataGridView dgvmostrar;
        private System.Windows.Forms.MaskedTextBox txtdui;
        private System.Windows.Forms.MaskedTextBox txtnit;
        private System.Windows.Forms.MaskedTextBox txtafp;
        private System.Windows.Forms.TextBox txtseguro;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}