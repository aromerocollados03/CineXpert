namespace CineXpert
{
    partial class CompPersContenido
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompPersContenido));
            btnEliminar = new Button();
            picboxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxImagen).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Location = new Point(69, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(26, 25);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "\r\n";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // picboxImagen
            // 
            picboxImagen.BackColor = Color.LightGray;
            picboxImagen.BackgroundImageLayout = ImageLayout.Stretch;
            picboxImagen.Location = new Point(0, 0);
            picboxImagen.Name = "picboxImagen";
            picboxImagen.Size = new Size(95, 110);
            picboxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxImagen.TabIndex = 0;
            picboxImagen.TabStop = false;
            picboxImagen.Click += picboxImagen_Click;
            // 
            // CompPersContenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnEliminar);
            Controls.Add(picboxImagen);
            Name = "CompPersContenido";
            Size = new Size(95, 110);
            ((System.ComponentModel.ISupportInitialize)picboxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEliminar;
        private PictureBox picboxImagen;
    }
}
