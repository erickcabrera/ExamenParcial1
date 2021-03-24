namespace SistemaInventario
{
    partial class FormTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrabajadores));
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
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DUI: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIT: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AFP: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seguro: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pago por día:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Numero de télefono: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tipo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(64, 24);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(271, 56);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdireccion.MaxLength = 140;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 15;
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(272, 80);
            this.txtpago.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(100, 20);
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
            this.cbtipo.Location = new System.Drawing.Point(271, 144);
            this.cbtipo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(100, 21);
            this.cbtipo.TabIndex = 18;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Location = new System.Drawing.Point(26, 204);
            this.fechanacimiento.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.fechanacimiento.MaxDate = new System.DateTime(2021, 3, 24, 0, 0, 0, 0);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.TabIndex = 19;
            this.fechanacimiento.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.fechanacimiento_DateSelected);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(229, 204);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(74, 23);
            this.btnagregar.TabIndex = 20;
            this.btnagregar.Text = "Agregar ";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(326, 204);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(74, 23);
            this.btnborrar.TabIndex = 22;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(418, 31);
            this.dgvmostrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(427, 268);
            this.dgvmostrar.TabIndex = 23;
            this.dgvmostrar.Click += new System.EventHandler(this.dgvmostrar_Click);
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(64, 51);
            this.txtdui.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdui.Mask = "00000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(100, 20);
            this.txtdui.TabIndex = 24;
            this.txtdui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(64, 85);
            this.txtnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnit.Mask = "0000-000000-000-0";
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(100, 20);
            this.txtnit.TabIndex = 25;
            this.txtnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnit.Click += new System.EventHandler(this.txtnit_Click);
            // 
            // txtafp
            // 
            this.txtafp.Location = new System.Drawing.Point(67, 115);
            this.txtafp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtafp.Mask = "000000000000";
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(100, 20);
            this.txtafp.TabIndex = 26;
            this.txtafp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtafp.ValidatingType = typeof(int);
            this.txtafp.Click += new System.EventHandler(this.txtafp_Click);
            // 
            // txtseguro
            // 
            this.txtseguro.Location = new System.Drawing.Point(271, 26);
            this.txtseguro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtseguro.MaxLength = 20;
            this.txtseguro.Name = "txtseguro";
            this.txtseguro.Size = new System.Drawing.Size(100, 20);
            this.txtseguro.TabIndex = 14;
            this.txtseguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtseguro_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(271, 110);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 27;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttelefono.Click += new System.EventHandler(this.txttelefono_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(326, 248);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(74, 20);
            this.txtArchivo.TabIndex = 28;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Nombre archivo:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(536, 321);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 30;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(644, 321);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 31;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FormTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 378);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtArchivo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.FormTrabajadores_Load);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
    }
}