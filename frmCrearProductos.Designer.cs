namespace ExamenADONET
{
    partial class frmCrearProductos
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            btnCrearProducto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 87);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(293, 27);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 90);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(124, 135);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(293, 27);
            txtStock.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 138);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Stock:";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(274, 191);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(143, 29);
            btnCrearProducto.TabIndex = 6;
            btnCrearProducto.Text = "Crear";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // frmCrearProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 246);
            Controls.Add(btnCrearProducto);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmCrearProductos";
            Text = "frmCrearProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private Button btnCrearProducto;
    }
}