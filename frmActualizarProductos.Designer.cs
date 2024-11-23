namespace ExamenADONET
{
    partial class frmActualizarProductos
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
            btnBuscarProducto = new Button();
            label1 = new Label();
            txtIDProducto = new TextBox();
            Producto = new GroupBox();
            btnActualizarProducto = new Button();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Producto.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(375, 20);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(94, 29);
            btnBuscarProducto.TabIndex = 0;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Producto:";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(140, 17);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 27);
            txtIDProducto.TabIndex = 2;
            // 
            // Producto
            // 
            Producto.Controls.Add(btnActualizarProducto);
            Producto.Controls.Add(txtStock);
            Producto.Controls.Add(txtPrecio);
            Producto.Controls.Add(txtNombre);
            Producto.Controls.Add(label4);
            Producto.Controls.Add(label3);
            Producto.Controls.Add(label2);
            Producto.Location = new Point(43, 70);
            Producto.Name = "Producto";
            Producto.Size = new Size(426, 236);
            Producto.TabIndex = 3;
            Producto.TabStop = false;
            Producto.Text = "Producto:";
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.Location = new Point(313, 182);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(94, 29);
            btnActualizarProducto.TabIndex = 6;
            btnActualizarProducto.Text = "Actualizar";
            btnActualizarProducto.UseVisualStyleBackColor = true;
            btnActualizarProducto.Click += btnActualizarProducto_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(114, 122);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(293, 27);
            txtStock.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(114, 83);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(293, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 27);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 125);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 90);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // frmActualizarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 314);
            Controls.Add(Producto);
            Controls.Add(txtIDProducto);
            Controls.Add(label1);
            Controls.Add(btnBuscarProducto);
            Name = "frmActualizarProductos";
            Text = "Actualizar Producto";
            Producto.ResumeLayout(false);
            Producto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarProducto;
        private Label label1;
        private TextBox txtIDProducto;
        private GroupBox Producto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnActualizarProducto;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
    }
}