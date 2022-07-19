namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridViewTabla = new System.Windows.Forms.DataGridView();
            this.labelNumCliente = new System.Windows.Forms.Label();
            this.textBoxNumCliente = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxUltimoPedido = new System.Windows.Forms.TextBox();
            this.labelUltimoPedido = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUltimoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewTabla
            // 
            this.GridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNumCliente,
            this.ColumnNombre,
            this.ColumnDireccion,
            this.ColumnTelefono,
            this.ColumnUltimoPedido});
            this.GridViewTabla.Location = new System.Drawing.Point(12, 136);
            this.GridViewTabla.Name = "GridViewTabla";
            this.GridViewTabla.Size = new System.Drawing.Size(548, 226);
            this.GridViewTabla.TabIndex = 0;
            // 
            // labelNumCliente
            // 
            this.labelNumCliente.AutoSize = true;
            this.labelNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCliente.Location = new System.Drawing.Point(15, 13);
            this.labelNumCliente.Name = "labelNumCliente";
            this.labelNumCliente.Size = new System.Drawing.Size(93, 20);
            this.labelNumCliente.TabIndex = 1;
            this.labelNumCliente.Text = "# de Cliente";
            // 
            // textBoxNumCliente
            // 
            this.textBoxNumCliente.Location = new System.Drawing.Point(14, 40);
            this.textBoxNumCliente.Name = "textBoxNumCliente";
            this.textBoxNumCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumCliente.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(124, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(125, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(236, 40);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(237, 13);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(75, 20);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Direccion";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(346, 40);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(347, 13);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxUltimoPedido
            // 
            this.textBoxUltimoPedido.Location = new System.Drawing.Point(459, 40);
            this.textBoxUltimoPedido.Name = "textBoxUltimoPedido";
            this.textBoxUltimoPedido.Size = new System.Drawing.Size(100, 20);
            this.textBoxUltimoPedido.TabIndex = 10;
            // 
            // labelUltimoPedido
            // 
            this.labelUltimoPedido.AutoSize = true;
            this.labelUltimoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoPedido.Location = new System.Drawing.Point(460, 13);
            this.labelUltimoPedido.Name = "labelUltimoPedido";
            this.labelUltimoPedido.Size = new System.Drawing.Size(103, 20);
            this.labelUltimoPedido.TabIndex = 9;
            this.labelUltimoPedido.Text = "UltimoPedido";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(14, 87);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 31);
            this.buttonAgregar.TabIndex = 11;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(236, 87);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(100, 31);
            this.buttonConsultar.TabIndex = 13;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(346, 87);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 31);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(459, 87);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(100, 31);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(124, 87);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(100, 31);
            this.buttonModificar.TabIndex = 12;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 30;
            // 
            // ColumnNumCliente
            // 
            this.ColumnNumCliente.HeaderText = "#deCliente";
            this.ColumnNumCliente.Name = "ColumnNumCliente";
            this.ColumnNumCliente.Width = 70;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            this.ColumnDireccion.Width = 150;
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            this.ColumnTelefono.Width = 75;
            // 
            // ColumnUltimoPedido
            // 
            this.ColumnUltimoPedido.HeaderText = "UltimoPedido";
            this.ColumnUltimoPedido.Name = "ColumnUltimoPedido";
            this.ColumnUltimoPedido.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 374);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxUltimoPedido);
            this.Controls.Add(this.labelUltimoPedido);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNumCliente);
            this.Controls.Add(this.labelNumCliente);
            this.Controls.Add(this.GridViewTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewTabla;
        private System.Windows.Forms.Label labelNumCliente;
        private System.Windows.Forms.TextBox textBoxNumCliente;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxUltimoPedido;
        private System.Windows.Forms.Label labelUltimoPedido;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUltimoPedido;
    }
}

