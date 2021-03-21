﻿namespace SistemaInventario
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblruta = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción del artículo:";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(102, 69);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtexistencia.MaxLength = 4;
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(39, 20);
            this.txtexistencia.TabIndex = 2;
            this.txtexistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexistencia_KeyPress);
            // 
            // txtpcompra
            // 
            this.txtpcompra.Location = new System.Drawing.Point(346, 19);
            this.txtpcompra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtpcompra.MaxLength = 7;
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Size = new System.Drawing.Size(38, 20);
            this.txtpcompra.TabIndex = 3;
            this.txtpcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpcompra_KeyPress);
            // 
            // txtpventa
            // 
            this.txtpventa.Location = new System.Drawing.Point(346, 62);
            this.txtpventa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtpventa.MaxLength = 7;
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Size = new System.Drawing.Size(38, 20);
            this.txtpventa.TabIndex = 4;
            this.txtpventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpventa_KeyPress);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(22, 469);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(74, 23);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(244, 175);
            this.dgvmostrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmostrar.Size = new System.Drawing.Size(451, 142);
            this.dgvmostrar.TabIndex = 9;
            this.dgvmostrar.Click += new System.EventHandler(this.dgvmostrar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(549, 16);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(146, 96);
            this.txtdescripcion.TabIndex = 5;
            this.txtdescripcion.Text = "";
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Location = new System.Drawing.Point(103, 469);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(74, 23);
            this.btnborrar.TabIndex = 9;
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
            this.btncargar.Location = new System.Drawing.Point(42, 412);
            this.btncargar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(95, 28);
            this.btncargar.TabIndex = 6;
            this.btncargar.Text = "Subir imagen";
            this.btncargar.UseVisualStyleBackColor = false;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 288);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 26);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(39, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo:";
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Location = new System.Drawing.Point(42, 107);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(35, 13);
            this.lblruta.TabIndex = 16;
            this.lblruta.Text = "label6";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(620, 415);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 35;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(515, 415);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 34;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nombre archivo:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(339, 339);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(74, 20);
            this.txtArchivo.TabIndex = 32;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 519);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_form_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}