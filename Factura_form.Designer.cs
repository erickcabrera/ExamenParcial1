namespace ExamenParcial1
{
    partial class Factura_form
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.btnremover = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtmanoobra = new System.Windows.Forms.TextBox();
            this.btnverfacturas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(555, 558);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(667, 558);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(48, 352);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 28);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(27, 15);
            this.lv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(274, 312);
            this.lv1.TabIndex = 1;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.Click += new System.EventHandler(this.lv1_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Location = new System.Drawing.Point(175, 352);
            this.btnremover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(105, 28);
            this.btnremover.TabIndex = 2;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(27, 407);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(262, 130);
            this.txtdescripcion.TabIndex = 4;
            this.txtdescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Costo repuestos:";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(499, 407);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.ReadOnly = true;
            this.txtcosto.Size = new System.Drawing.Size(61, 23);
            this.txtcosto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor mano obra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(498, 496);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(62, 23);
            this.txttotal.TabIndex = 12;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(499, 357);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ReadOnly = true;
            this.txtcantidad.Size = new System.Drawing.Size(61, 23);
            this.txtcantidad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad repuestos:";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Location = new System.Drawing.Point(605, 398);
            this.btningresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(122, 42);
            this.btningresar.TabIndex = 15;
            this.btningresar.Text = "Ingresar factura";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(331, 15);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(427, 313);
            this.dgv.TabIndex = 16;
            // 
            // txtmanoobra
            // 
            this.txtmanoobra.Location = new System.Drawing.Point(498, 448);
            this.txtmanoobra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmanoobra.Name = "txtmanoobra";
            this.txtmanoobra.Size = new System.Drawing.Size(62, 23);
            this.txtmanoobra.TabIndex = 17;
            this.txtmanoobra.TextChanged += new System.EventHandler(this.txtmanoobra_TextChanged);
            // 
            // btnverfacturas
            // 
            this.btnverfacturas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnverfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverfacturas.Location = new System.Drawing.Point(606, 465);
            this.btnverfacturas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnverfacturas.Name = "btnverfacturas";
            this.btnverfacturas.Size = new System.Drawing.Size(121, 42);
            this.btnverfacturas.TabIndex = 18;
            this.btnverfacturas.Text = "Ver facturas";
            this.btnverfacturas.UseVisualStyleBackColor = false;
            this.btnverfacturas.Click += new System.EventHandler(this.btnverfacturas_Click);
            // 
            // Factura_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 613);
            this.Controls.Add(this.btnverfacturas);
            this.Controls.Add(this.txtmanoobra);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btnagregar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Factura_form";
            this.Text = "Factura_form";
            this.Load += new System.EventHandler(this.Factura_form_Load);
            this.Controls.SetChildIndex(this.btnagregar, 0);
            this.Controls.SetChildIndex(this.lv1, 0);
            this.Controls.SetChildIndex(this.btnremover, 0);
            this.Controls.SetChildIndex(this.txtdescripcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtcosto, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txttotal, 0);
            this.Controls.SetChildIndex(this.txtcantidad, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btningresar, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.txtmanoobra, 0);
            this.Controls.SetChildIndex(this.btnverfacturas, 0);
            this.Controls.SetChildIndex(this.btnmenu, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtmanoobra;
        private System.Windows.Forms.Button btnverfacturas;
    }
}