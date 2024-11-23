namespace ExamenADONET
{
    partial class frmMenu
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
            btnFrmCrear = new Button();
            btnFrmBuscar = new Button();
            btnFrmActualizar = new Button();
            btnFrmEliminar = new Button();
            SuspendLayout();
            // 
            // btnFrmCrear
            // 
            btnFrmCrear.Location = new Point(94, 37);
            btnFrmCrear.Name = "btnFrmCrear";
            btnFrmCrear.Size = new Size(158, 57);
            btnFrmCrear.TabIndex = 0;
            btnFrmCrear.Text = "Crear";
            btnFrmCrear.UseVisualStyleBackColor = true;
            btnFrmCrear.Click += btnFrmCrear_Click;
            // 
            // btnFrmBuscar
            // 
            btnFrmBuscar.Location = new Point(94, 116);
            btnFrmBuscar.Name = "btnFrmBuscar";
            btnFrmBuscar.Size = new Size(158, 57);
            btnFrmBuscar.TabIndex = 1;
            btnFrmBuscar.Text = "Buscar";
            btnFrmBuscar.UseVisualStyleBackColor = true;
            btnFrmBuscar.Click += btnFrmBuscar_Click;
            // 
            // btnFrmActualizar
            // 
            btnFrmActualizar.Location = new Point(94, 197);
            btnFrmActualizar.Name = "btnFrmActualizar";
            btnFrmActualizar.Size = new Size(158, 57);
            btnFrmActualizar.TabIndex = 2;
            btnFrmActualizar.Text = "Actualizar";
            btnFrmActualizar.UseVisualStyleBackColor = true;
            btnFrmActualizar.Click += btnFrmActualizar_Click;
            // 
            // btnFrmEliminar
            // 
            btnFrmEliminar.Location = new Point(94, 281);
            btnFrmEliminar.Name = "btnFrmEliminar";
            btnFrmEliminar.Size = new Size(158, 57);
            btnFrmEliminar.TabIndex = 3;
            btnFrmEliminar.Text = "Eliminar";
            btnFrmEliminar.UseVisualStyleBackColor = true;
            btnFrmEliminar.Click += btnFrmEliminar_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 378);
            Controls.Add(btnFrmEliminar);
            Controls.Add(btnFrmActualizar);
            Controls.Add(btnFrmBuscar);
            Controls.Add(btnFrmCrear);
            Name = "frmMenu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmCrear;
        private Button btnFrmBuscar;
        private Button btnFrmActualizar;
        private Button btnFrmEliminar;
    }
}