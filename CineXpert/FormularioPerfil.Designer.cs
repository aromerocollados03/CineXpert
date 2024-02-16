namespace CineXpert
{
    partial class FormularioPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPerfil));
            picboxFotoUsuario = new PictureBox();
            btnActualizarFoto = new Button();
            lbCorreo = new Label();
            lbUsuario = new Label();
            lbApellidos = new Label();
            lbNombre = new Label();
            txbCorreo = new TextBox();
            txbUsuario = new TextBox();
            txbApellidos = new TextBox();
            txbNombre = new TextBox();
            cmbProvincia = new ComboBox();
            lbProvincia = new Label();
            lbEdad = new Label();
            numudEdad = new NumericUpDown();
            btnConfirmar = new Button();
            btnVolver = new Button();
            linklbCambiarContrasena = new LinkLabel();
            btCerrarSesion = new Button();
            lbCerrarSesion = new Label();
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numudEdad).BeginInit();
            SuspendLayout();
            // 
            // picboxFotoUsuario
            // 
            picboxFotoUsuario.BorderStyle = BorderStyle.Fixed3D;
            picboxFotoUsuario.Location = new Point(16, 80);
            picboxFotoUsuario.Name = "picboxFotoUsuario";
            picboxFotoUsuario.Size = new Size(247, 252);
            picboxFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxFotoUsuario.TabIndex = 2;
            picboxFotoUsuario.TabStop = false;
            // 
            // btnActualizarFoto
            // 
            btnActualizarFoto.BackColor = Color.Transparent;
            btnActualizarFoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnActualizarFoto.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarFoto.ForeColor = Color.Black;
            btnActualizarFoto.Location = new Point(33, 338);
            btnActualizarFoto.Name = "btnActualizarFoto";
            btnActualizarFoto.Size = new Size(211, 40);
            btnActualizarFoto.TabIndex = 3;
            btnActualizarFoto.Text = "+ Actualizar Foto";
            btnActualizarFoto.UseVisualStyleBackColor = false;
            btnActualizarFoto.Click += btnActualizarFoto_Click;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(315, 224);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(157, 28);
            lbCorreo.TabIndex = 35;
            lbCorreo.Text = "Correo electrónico";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(315, 154);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(164, 28);
            lbUsuario.TabIndex = 34;
            lbUsuario.Text = "Nombre de usuario";
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellidos.Location = new Point(315, 84);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(84, 28);
            lbApellidos.TabIndex = 33;
            lbApellidos.Text = "Apellidos";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(315, 14);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(75, 28);
            lbNombre.TabIndex = 32;
            lbNombre.Text = "Nombre";
            // 
            // txbCorreo
            // 
            txbCorreo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCorreo.Location = new Point(315, 255);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(267, 36);
            txbCorreo.TabIndex = 31;
            // 
            // txbUsuario
            // 
            txbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbUsuario.Location = new Point(315, 185);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(267, 36);
            txbUsuario.TabIndex = 30;
            // 
            // txbApellidos
            // 
            txbApellidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbApellidos.Location = new Point(315, 115);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(267, 36);
            txbApellidos.TabIndex = 29;
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNombre.Location = new Point(315, 45);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(267, 36);
            txbNombre.TabIndex = 28;
            // 
            // cmbProvincia
            // 
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "A Coruña", "Álava", "Albacete", "Alicante", "Almería", "Asturias", "Ávila", "Badajoz", "Baleares", "Barcelona", "Burgos", "Cáceres", "Cádiz", "Cantabria", "Castellón", "Ciudad Real", "Córdoba", "Cuenca", "Girona", "Granada", "Guadalajara", "Gipuzkoa", "Huelva", "Huesca", "Jaén", "La Rioja", "Las Palmas", "León", "Lérida", "Lugo", "Madrid", "Málaga", "Murcia", "Navarra", "Ourense", "Palencia", "Pontevedra", "Salamanca", "Segovia", "Sevilla", "Soria", "Tarragona", "Santa Cruz de Tenerife", "Teruel", "Toledo", "Valencia", "Valladolid", "Vizcaya", "Zamora", "Zaragoza" });
            cmbProvincia.Location = new Point(315, 317);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(136, 31);
            cmbProvincia.TabIndex = 39;
            // 
            // lbProvincia
            // 
            lbProvincia.AutoSize = true;
            lbProvincia.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProvincia.Location = new Point(315, 294);
            lbProvincia.Name = "lbProvincia";
            lbProvincia.Size = new Size(87, 28);
            lbProvincia.TabIndex = 38;
            lbProvincia.Text = "Provincia";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEdad.Location = new Point(315, 351);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(54, 28);
            lbEdad.TabIndex = 37;
            lbEdad.Text = "Edad";
            // 
            // numudEdad
            // 
            numudEdad.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numudEdad.Location = new Point(317, 382);
            numudEdad.Name = "numudEdad";
            numudEdad.ReadOnly = true;
            numudEdad.Size = new Size(134, 30);
            numudEdad.TabIndex = 36;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Transparent;
            btnConfirmar.BackgroundImage = (Image)resources.GetObject("btnConfirmar.BackgroundImage");
            btnConfirmar.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(686, 376);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(71, 62);
            btnConfirmar.TabIndex = 40;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
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
            btnVolver.Location = new Point(597, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(60, 58);
            btnVolver.TabIndex = 41;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // linklbCambiarContrasena
            // 
            linklbCambiarContrasena.AutoSize = true;
            linklbCambiarContrasena.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklbCambiarContrasena.LinkColor = Color.Blue;
            linklbCambiarContrasena.Location = new Point(53, 384);
            linklbCambiarContrasena.Name = "linklbCambiarContrasena";
            linklbCambiarContrasena.Size = new Size(172, 28);
            linklbCambiarContrasena.TabIndex = 42;
            linklbCambiarContrasena.TabStop = true;
            linklbCambiarContrasena.Text = "Cambiar contraseña";
            linklbCambiarContrasena.LinkClicked += linklbCambiarContrasena_LinkClicked;
            // 
            // btCerrarSesion
            // 
            btCerrarSesion.BackColor = Color.Transparent;
            btCerrarSesion.BackgroundImage = (Image)resources.GetObject("btCerrarSesion.BackgroundImage");
            btCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btCerrarSesion.FlatAppearance.BorderSize = 0;
            btCerrarSesion.FlatStyle = FlatStyle.Flat;
            btCerrarSesion.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCerrarSesion.ForeColor = Color.White;
            btCerrarSesion.Location = new Point(16, 12);
            btCerrarSesion.Name = "btCerrarSesion";
            btCerrarSesion.Size = new Size(49, 52);
            btCerrarSesion.TabIndex = 43;
            btCerrarSesion.UseVisualStyleBackColor = false;
            btCerrarSesion.Click += btCerrarSesion_Click;
            // 
            // lbCerrarSesion
            // 
            lbCerrarSesion.AutoSize = true;
            lbCerrarSesion.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCerrarSesion.Location = new Point(71, 27);
            lbCerrarSesion.Name = "lbCerrarSesion";
            lbCerrarSesion.Size = new Size(117, 28);
            lbCerrarSesion.TabIndex = 44;
            lbCerrarSesion.Text = "Cerrar sesión";
            // 
            // FormularioPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCerrarSesion);
            Controls.Add(btCerrarSesion);
            Controls.Add(linklbCambiarContrasena);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbProvincia);
            Controls.Add(lbProvincia);
            Controls.Add(lbEdad);
            Controls.Add(numudEdad);
            Controls.Add(lbCorreo);
            Controls.Add(lbUsuario);
            Controls.Add(lbApellidos);
            Controls.Add(lbNombre);
            Controls.Add(txbCorreo);
            Controls.Add(txbUsuario);
            Controls.Add(txbApellidos);
            Controls.Add(txbNombre);
            Controls.Add(btnActualizarFoto);
            Controls.Add(picboxFotoUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormularioPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPerfil";
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numudEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picboxFotoUsuario;
        private Button btnActualizarFoto;
        private Label lbCorreo;
        private Label lbUsuario;
        private Label lbApellidos;
        private Label lbNombre;
        private TextBox txbCorreo;
        private TextBox txbUsuario;
        private TextBox txbApellidos;
        private TextBox txbNombre;
        private ComboBox cmbProvincia;
        private Label lbProvincia;
        private Label lbEdad;
        private NumericUpDown numudEdad;
        private Button btnConfirmar;
        private Button btnVolver;
        private LinkLabel linklbCambiarContrasena;
        private Button btCerrarSesion;
        private Label lbCerrarSesion;
    }
}