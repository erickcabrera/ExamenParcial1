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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_form));
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
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Location = new System.Drawing.Point(36, 286);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(74, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(20, 12);
            this.lv1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(206, 254);
            this.lv1.TabIndex = 1;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.Click += new System.EventHandler(this.lv1_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremover.Location = new System.Drawing.Point(131, 286);
            this.btnremover.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(79, 23);
            this.btnremover.TabIndex = 2;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(20, 331);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(198, 106);
            this.txtdescripcion.TabIndex = 4;
            this.txtdescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Costo repuestos:";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(374, 331);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.ReadOnly = true;
            this.txtcosto.Size = new System.Drawing.Size(47, 20);
            this.txtcosto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor mano obra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(374, 403);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(48, 20);
            this.txttotal.TabIndex = 12;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(374, 290);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ReadOnly = true;
            this.txtcantidad.Size = new System.Drawing.Size(47, 20);
            this.txtcantidad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad repuestos:";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Location = new System.Drawing.Point(454, 323);
            this.btningresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(92, 34);
            this.btningresar.TabIndex = 15;
            this.btningresar.Text = "Ingresar factura";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(248, 12);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(320, 254);
            this.dgv.TabIndex = 16;
            // 
            // txtmanoobra
            // 
            this.txtmanoobra.Location = new System.Drawing.Point(374, 364);
            this.txtmanoobra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtmanoobra.Name = "txtmanoobra";
            this.txtmanoobra.Size = new System.Drawing.Size(48, 20);
            this.txtmanoobra.TabIndex = 17;
            this.txtmanoobra.TextChanged += new System.EventHandler(this.txtmanoobra_TextChanged);
            // 
            // btnverfacturas
            // 
            this.btnverfacturas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnverfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverfacturas.Location = new System.Drawing.Point(454, 378);
            this.btnverfacturas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnverfacturas.Name = "btnverfacturas";
            this.btnverfacturas.Size = new System.Drawing.Size(91, 34);
            this.btnverfacturas.TabIndex = 18;
            this.btnverfacturas.Text = "Ver facturas";
            this.btnverfacturas.UseVisualStyleBackColor = false;
            this.btnverfacturas.Click += new System.EventHandler(this.btnverfacturas_Click);
            // 
            // Factura_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 498);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Factura_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Factura_form_Load);
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