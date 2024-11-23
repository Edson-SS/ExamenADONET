namespace ExamenADONET
{
    partial class frmBuscarProductos
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
            dgvProducto = new DataGridView();
            btnBuscarProducto = new Button();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(46, 77);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(854, 342);
            dgvProducto.TabIndex = 0;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(806, 25);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(94, 29);
            btnBuscarProducto.TabIndex = 1;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(119, 22);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(318, 27);
            txtNombreProducto.TabIndex = 3;
            // 
            // frmBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Controls.Add(btnBuscarProducto);
            Controls.Add(dgvProducto);
            Name = "frmBuscarProductos";
            Text = "frmBuscarProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducto;
        private Button btnBuscarProducto;
        private Label label1;
        private TextBox txtNombreProducto;
    }
}