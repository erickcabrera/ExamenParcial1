namespace ExamenParcial1
{
    partial class Planilla_form
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
            this.cbx = new System.Windows.Forms.ComboBox();
            this.calendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.calendar2 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.txtdiastrabajados = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(796, 723);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(924, 723);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dias trabajados: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inicio de periodo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fin de periodo:";
            // 
            // cbx
            // 
            this.cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(143, 20);
            this.cbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(159, 24);
            this.cbx.TabIndex = 5;
            this.cbx.DropDownClosed += new System.EventHandler(this.cbx_DropDownClosed);
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(48, 169);
            this.calendar1.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.calendar1.Name = "calendar1";
            this.calendar1.TabIndex = 6;
            this.calendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar1_DateSelected);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(328, 43);
            this.dgvmostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(664, 647);
            this.dgvmostrar.TabIndex = 9;
            this.dgvmostrar.Click += new System.EventHandler(this.dgvmostrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(42, 655);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 34);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(174, 654);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(105, 36);
            this.btnborrar.TabIndex = 11;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // calendar2
            // 
            this.calendar2.Location = new System.Drawing.Point(48, 451);
            this.calendar2.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.calendar2.Name = "calendar2";
            this.calendar2.TabIndex = 8;
            this.calendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar2_DateSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pago por dia:";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(143, 74);
            this.txtpago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpago.MaxLength = 4;
            this.txtpago.Name = "txtpago";
            this.txtpago.ReadOnly = true;
            this.txtpago.Size = new System.Drawing.Size(59, 23);
            this.txtpago.TabIndex = 14;
            this.txtpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdiastrabajados
            // 
            this.txtdiastrabajados.Location = new System.Drawing.Point(174, 365);
            this.txtdiastrabajados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdiastrabajados.MaxLength = 2;
            this.txtdiastrabajados.Name = "txtdiastrabajados";
            this.txtdiastrabajados.Size = new System.Drawing.Size(51, 23);
            this.txtdiastrabajados.TabIndex = 15;
            this.txtdiastrabajados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Planilla_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 777);
            this.Controls.Add(this.txtdiastrabajados);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.calendar2);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Planilla_form";
            this.Text = "Planilla_form";
            this.Load += new System.EventHandler(this.Planilla_form_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbx, 0);
            this.Controls.SetChildIndex(this.calendar1, 0);
            this.Controls.SetChildIndex(this.calendar2, 0);
            this.Controls.SetChildIndex(this.dgvmostrar, 0);
            this.Controls.SetChildIndex(this.btnagregar, 0);
            this.Controls.SetChildIndex(this.btnborrar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtpago, 0);
            this.Controls.SetChildIndex(this.txtdiastrabajados, 0);
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
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.MonthCalendar calendar1;
        private System.Windows.Forms.DataGridView dgvmostrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.MonthCalendar calendar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.TextBox txtdiastrabajados;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}