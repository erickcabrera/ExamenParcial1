namespace ExamenParcial1
{
    partial class Inventario_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtpcompra = new System.Windows.Forms.TextBox();
            this.txtpventa = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btncargar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(745, 588);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(866, 588);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción del artículo:";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(137, 23);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtexistencia.MaxLength = 4;
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(87, 23);
            this.txtexistencia.TabIndex = 4;
            this.txtexistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexistencia_KeyPress);
            // 
            // txtpcompra
            // 
            this.txtpcompra.Location = new System.Drawing.Point(137, 73);
            this.txtpcompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpcompra.MaxLength = 7;
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Size = new System.Drawing.Size(50, 23);
            this.txtpcompra.TabIndex = 5;
            this.txtpcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpcompra_KeyPress);
            // 
            // txtpventa
            // 
            this.txtpventa.Location = new System.Drawing.Point(137, 126);
            this.txtpventa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpventa.MaxLength = 7;
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Size = new System.Drawing.Size(50, 23);
            this.txtpventa.TabIndex = 6;
            this.txtpventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa_KeyPress);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(30, 577);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 28);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(240, 42);
            this.dgvmostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(718, 521);
            this.dgvmostrar.TabIndex = 9;
            this.dgvmostrar.Click += new System.EventHandler(this.dgvmostrar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(19, 213);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(194, 117);
            this.txtdescripcion.TabIndex = 10;
            this.txtdescripcion.Text = "";
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(137, 577);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(99, 28);
            this.btnborrar.TabIndex = 11;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // btncargar
            // 
            this.btncargar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncargar.Enabled = false;
            this.btncargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargar.Location = new System.Drawing.Point(56, 507);
            this.btncargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(127, 34);
            this.btncargar.TabIndex = 12;
            this.btncargar.Text = "Subir imagen";
            this.btncargar.UseVisualStyleBackColor = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 354);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inventario_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtpventa);
            this.Controls.Add(this.txtpcompra);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inventario_form";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_form_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtexistencia, 0);
            this.Controls.SetChildIndex(this.txtpcompra, 0);
            this.Controls.SetChildIndex(this.txtpventa, 0);
            this.Controls.SetChildIndex(this.btnagregar, 0);
            this.Controls.SetChildIndex(this.dgvmostrar, 0);
            this.Controls.SetChildIndex(this.txtdescripcion, 0);
            this.Controls.SetChildIndex(this.btnborrar, 0);
            this.Controls.SetChildIndex(this.btncargar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnmenu, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.TextBox txtpcompra;
        private System.Windows.Forms.TextBox txtpventa;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvmostrar;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}