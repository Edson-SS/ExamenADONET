namespace ExamenADONET
{
    partial class frmEliminarProductos
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
            btnEliminar = new Button();
            label1 = new Label();
            txtIDProducto = new TextBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(328, 31);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Producto:";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(129, 33);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 27);
            txtIDProducto.TabIndex = 2;
            // 
            // frmEliminarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 73);
            Controls.Add(txtIDProducto);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Name = "frmEliminarProductos";
            Text = "frmEliminarProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Label label1;
        private TextBox txtIDProducto;
    }
}