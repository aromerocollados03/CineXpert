namespace CineXpert
{
    partial class FormularioRecuperacionPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRecuperacionPassword));
            lbUsuario = new Label();
            txbCorreo = new TextBox();
            lbTitulo = new Label();
            lbCorreo = new Label();
            txbNombreUsuario = new TextBox();
            btnConfirmarCambio = new Button();
            lbConfirmacionPasswd = new Label();
            txbPasswordNueva = new TextBox();
            lbPasswordNueva = new Label();
            txbConfirmacionPasswd = new TextBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(94, 88);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(164, 28);
            lbUsuario.TabIndex = 19;
            lbUsuario.Text = "Nombre de usuario";
            // 
            // txbCorreo
            // 
            txbCorreo.Cursor = Cursors.IBeam;
            txbCorreo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCorreo.Location = new Point(264, 127);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(203, 36);
            txbCorreo.TabIndex = 2;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(146, 22);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(288, 43);
            lbTitulo.TabIndex = 20;
            lbTitulo.Text = "Cambio de contraseña";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(101, 130);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(157, 28);
            lbCorreo.TabIndex = 22;
            lbCorreo.Text = "Correo electrónico";
            // 
            // txbNombreUsuario
            // 
            txbNombreUsuario.Cursor = Cursors.IBeam;
            txbNombreUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNombreUsuario.Location = new Point(264, 85);
            txbNombreUsuario.Name = "txbNombreUsuario";
            txbNombreUsuario.Size = new Size(203, 36);
            txbNombreUsuario.TabIndex = 1;
            // 
            // btnConfirmarCambio
            // 
            btnConfirmarCambio.BackColor = Color.Green;
            btnConfirmarCambio.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarCambio.ForeColor = Color.White;
            btnConfirmarCambio.Location = new Point(187, 269);
            btnConfirmarCambio.Name = "btnConfirmarCambio";
            btnConfirmarCambio.Size = new Size(203, 43);
            btnConfirmarCambio.TabIndex = 5;
            btnConfirmarCambio.Text = "Cambiar Contraseña";
            btnConfirmarCambio.UseVisualStyleBackColor = false;
            btnConfirmarCambio.Click += btnConfirmarCambio_Click;
            // 
            // lbConfirmacionPasswd
            // 
            lbConfirmacionPasswd.AutoSize = true;
            lbConfirmacionPasswd.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConfirmacionPasswd.Location = new Point(70, 214);
            lbConfirmacionPasswd.Name = "lbConfirmacionPasswd";
            lbConfirmacionPasswd.Size = new Size(188, 28);
            lbConfirmacionPasswd.TabIndex = 27;
            lbConfirmacionPasswd.Text = "Confirmar contraseña";
            // 
            // txbPasswordNueva
            // 
            txbPasswordNueva.Cursor = Cursors.IBeam;
            txbPasswordNueva.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbPasswordNueva.Location = new Point(264, 169);
            txbPasswordNueva.Name = "txbPasswordNueva";
            txbPasswordNueva.Size = new Size(203, 36);
            txbPasswordNueva.TabIndex = 3;
            // 
            // lbPasswordNueva
            // 
            lbPasswordNueva.AutoSize = true;
            lbPasswordNueva.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPasswordNueva.Location = new Point(101, 172);
            lbPasswordNueva.Name = "lbPasswordNueva";
            lbPasswordNueva.Size = new Size(154, 28);
            lbPasswordNueva.TabIndex = 25;
            lbPasswordNueva.Text = "Nueva contraseña";
            // 
            // txbConfirmacionPasswd
            // 
            txbConfirmacionPasswd.Cursor = Cursors.IBeam;
            txbConfirmacionPasswd.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbConfirmacionPasswd.Location = new Point(264, 211);
            txbConfirmacionPasswd.Name = "txbConfirmacionPasswd";
            txbConfirmacionPasswd.Size = new Size(203, 36);
            txbConfirmacionPasswd.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.BackgroundImage = (Image)resources.GetObject("btnVolver.BackgroundImage");
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(25, 20);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(46, 43);
            btnVolver.TabIndex = 6;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormularioRecuperacionPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 335);
            Controls.Add(btnVolver);
            Controls.Add(lbConfirmacionPasswd);
            Controls.Add(txbPasswordNueva);
            Controls.Add(lbPasswordNueva);
            Controls.Add(txbConfirmacionPasswd);
            Controls.Add(btnConfirmarCambio);
            Controls.Add(lbCorreo);
            Controls.Add(txbNombreUsuario);
            Controls.Add(lbTitulo);
            Controls.Add(lbUsuario);
            Controls.Add(txbCorreo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(625, 374);
            MinimumSize = new Size(625, 374);
            Name = "FormularioRecuperacionPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRecuperacionPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private TextBox txbCorreo;
        private Label lbTitulo;
        private Label lbCorreo;
        private TextBox txbNombreUsuario;
        private Button btnConfirmarCambio;
        private Label lbConfirmacionPasswd;
        private TextBox txbPasswordNueva;
        private Label lbPasswordNueva;
        private TextBox txbConfirmacionPasswd;
        private Button btnVolver;
    }
}