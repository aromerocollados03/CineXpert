namespace CineXpert
{
    partial class FormularioRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioRegistro));
            btnVolverRegistro = new Button();
            picboxFotoUsuario = new PictureBox();
            btnAñadirFoto = new Button();
            txbNombre = new TextBox();
            txbApellidos = new TextBox();
            txbUsuario = new TextBox();
            txbCorreo = new TextBox();
            txbPassword = new TextBox();
            txbConfPassword = new TextBox();
            btnConfirmarRegistro = new Button();
            numudEdad = new NumericUpDown();
            lbEdad = new Label();
            lbProvincia = new Label();
            cmbProvincia = new ComboBox();
            chbMostrarPasswd = new CheckBox();
            lbNombre = new Label();
            lbApellidos = new Label();
            lbUsuario = new Label();
            lbCorreo = new Label();
            lbPasswd = new Label();
            lbConfirmarPasswd = new Label();
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numudEdad).BeginInit();
            SuspendLayout();
            // 
            // btnVolverRegistro
            // 
            btnVolverRegistro.BackColor = Color.Transparent;
            btnVolverRegistro.BackgroundImage = Properties.Resources._61449;
            btnVolverRegistro.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverRegistro.FlatAppearance.BorderSize = 0;
            btnVolverRegistro.FlatStyle = FlatStyle.Flat;
            btnVolverRegistro.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverRegistro.ForeColor = SystemColors.Control;
            btnVolverRegistro.Location = new Point(28, 15);
            btnVolverRegistro.Name = "btnVolverRegistro";
            btnVolverRegistro.Size = new Size(61, 53);
            btnVolverRegistro.TabIndex = 0;
            btnVolverRegistro.UseVisualStyleBackColor = false;
            btnVolverRegistro.Click += btnVolverRegistro_Click;
            // 
            // picboxFotoUsuario
            // 
            picboxFotoUsuario.BorderStyle = BorderStyle.Fixed3D;
            picboxFotoUsuario.Location = new Point(28, 108);
            picboxFotoUsuario.Name = "picboxFotoUsuario";
            picboxFotoUsuario.Size = new Size(195, 192);
            picboxFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxFotoUsuario.TabIndex = 1;
            picboxFotoUsuario.TabStop = false;
            // 
            // btnAñadirFoto
            // 
            btnAñadirFoto.BackColor = Color.Transparent;
            btnAñadirFoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnAñadirFoto.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadirFoto.ForeColor = Color.Black;
            btnAñadirFoto.Location = new Point(49, 313);
            btnAñadirFoto.Name = "btnAñadirFoto";
            btnAñadirFoto.Size = new Size(154, 40);
            btnAñadirFoto.TabIndex = 2;
            btnAñadirFoto.Text = "+ Añadir Foto";
            btnAñadirFoto.UseVisualStyleBackColor = false;
            btnAñadirFoto.Click += btnAñadirFoto_Click;
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbNombre.Location = new Point(434, 22);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(267, 36);
            txbNombre.TabIndex = 3;
            // 
            // txbApellidos
            // 
            txbApellidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbApellidos.Location = new Point(434, 64);
            txbApellidos.Name = "txbApellidos";
            txbApellidos.Size = new Size(267, 36);
            txbApellidos.TabIndex = 4;
            // 
            // txbUsuario
            // 
            txbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbUsuario.Location = new Point(434, 106);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(267, 36);
            txbUsuario.TabIndex = 5;
            // 
            // txbCorreo
            // 
            txbCorreo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbCorreo.Location = new Point(434, 148);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(267, 36);
            txbCorreo.TabIndex = 6;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbPassword.Location = new Point(434, 190);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(267, 36);
            txbPassword.TabIndex = 7;
            // 
            // txbConfPassword
            // 
            txbConfPassword.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbConfPassword.Location = new Point(434, 232);
            txbConfPassword.Name = "txbConfPassword";
            txbConfPassword.PasswordChar = '*';
            txbConfPassword.Size = new Size(267, 36);
            txbConfPassword.TabIndex = 8;
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.BackColor = Color.Green;
            btnConfirmarRegistro.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfirmarRegistro.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarRegistro.ForeColor = Color.Transparent;
            btnConfirmarRegistro.Location = new Point(521, 398);
            btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            btnConfirmarRegistro.Size = new Size(267, 40);
            btnConfirmarRegistro.TabIndex = 9;
            btnConfirmarRegistro.Text = "Confirmar registro";
            btnConfirmarRegistro.UseVisualStyleBackColor = false;
            btnConfirmarRegistro.Click += btnConfirmarRegistro_Click;
            // 
            // numudEdad
            // 
            numudEdad.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numudEdad.Location = new Point(434, 356);
            numudEdad.Name = "numudEdad";
            numudEdad.ReadOnly = true;
            numudEdad.Size = new Size(134, 30);
            numudEdad.TabIndex = 18;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEdad.Location = new Point(370, 356);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(54, 28);
            lbEdad.TabIndex = 19;
            lbEdad.Text = "Edad";
            // 
            // lbProvincia
            // 
            lbProvincia.AutoSize = true;
            lbProvincia.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProvincia.Location = new Point(340, 313);
            lbProvincia.Name = "lbProvincia";
            lbProvincia.Size = new Size(87, 28);
            lbProvincia.TabIndex = 20;
            lbProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincia.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "A Coruña", "Álava", "Albacete", "Alicante", "Almería", "Asturias", "Ávila", "Badajoz", "Baleares", "Barcelona", "Burgos", "Cáceres", "Cádiz", "Cantabria", "Castellón", "Ciudad Real", "Córdoba", "Cuenca", "Girona", "Granada", "Guadalajara", "Gipuzkoa", "Huelva", "Huesca", "Jaén", "La Rioja", "Las Palmas", "León", "Lérida", "Lugo", "Madrid", "Málaga", "Murcia", "Navarra", "Ourense", "Palencia", "Pontevedra", "Salamanca", "Segovia", "Sevilla", "Soria", "Tarragona", "Santa Cruz de Tenerife", "Teruel", "Toledo", "Valencia", "Valladolid", "Vizcaya", "Zamora", "Zaragoza" });
            cmbProvincia.Location = new Point(434, 312);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(136, 31);
            cmbProvincia.TabIndex = 21;
            // 
            // chbMostrarPasswd
            // 
            chbMostrarPasswd.AutoSize = true;
            chbMostrarPasswd.BackColor = Color.Transparent;
            chbMostrarPasswd.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbMostrarPasswd.ForeColor = Color.Black;
            chbMostrarPasswd.Location = new Point(435, 274);
            chbMostrarPasswd.Name = "chbMostrarPasswd";
            chbMostrarPasswd.Size = new Size(187, 32);
            chbMostrarPasswd.TabIndex = 22;
            chbMostrarPasswd.Text = "Mostrar contraseña";
            chbMostrarPasswd.UseVisualStyleBackColor = false;
            chbMostrarPasswd.CheckedChanged += chbMostrarPasswd_CheckedChanged;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(351, 26);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(75, 28);
            lbNombre.TabIndex = 24;
            lbNombre.Text = "Nombre";
            // 
            // lbApellidos
            // 
            lbApellidos.AutoSize = true;
            lbApellidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellidos.Location = new Point(340, 68);
            lbApellidos.Name = "lbApellidos";
            lbApellidos.Size = new Size(84, 28);
            lbApellidos.TabIndex = 25;
            lbApellidos.Text = "Apellidos";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(262, 109);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(164, 28);
            lbUsuario.TabIndex = 26;
            lbUsuario.Text = "Nombre de usuario";
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(270, 151);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(157, 28);
            lbCorreo.TabIndex = 27;
            lbCorreo.Text = "Correo electrónico";
            // 
            // lbPasswd
            // 
            lbPasswd.AutoSize = true;
            lbPasswd.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPasswd.Location = new Point(325, 194);
            lbPasswd.Name = "lbPasswd";
            lbPasswd.Size = new Size(102, 28);
            lbPasswd.TabIndex = 28;
            lbPasswd.Text = "Contraseña";
            // 
            // lbConfirmarPasswd
            // 
            lbConfirmarPasswd.AutoSize = true;
            lbConfirmarPasswd.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConfirmarPasswd.Location = new Point(240, 235);
            lbConfirmarPasswd.Name = "lbConfirmarPasswd";
            lbConfirmarPasswd.Size = new Size(188, 28);
            lbConfirmarPasswd.TabIndex = 29;
            lbConfirmarPasswd.Text = "Confirmar contraseña\r\n";
            // 
            // FormularioRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(lbConfirmarPasswd);
            Controls.Add(lbPasswd);
            Controls.Add(lbCorreo);
            Controls.Add(lbUsuario);
            Controls.Add(lbApellidos);
            Controls.Add(lbNombre);
            Controls.Add(chbMostrarPasswd);
            Controls.Add(cmbProvincia);
            Controls.Add(lbProvincia);
            Controls.Add(lbEdad);
            Controls.Add(numudEdad);
            Controls.Add(btnConfirmarRegistro);
            Controls.Add(txbConfPassword);
            Controls.Add(txbPassword);
            Controls.Add(txbCorreo);
            Controls.Add(txbUsuario);
            Controls.Add(txbApellidos);
            Controls.Add(txbNombre);
            Controls.Add(btnAñadirFoto);
            Controls.Add(picboxFotoUsuario);
            Controls.Add(btnVolverRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormularioRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioRegistro";
            ((System.ComponentModel.ISupportInitialize)picboxFotoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numudEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverRegistro;
        private PictureBox picboxFotoUsuario;
        private Button btnAñadirFoto;
        private TextBox txbNombre;
        private TextBox txbApellidos;
        private TextBox txbUsuario;
        private TextBox txbCorreo;
        private TextBox txbPassword;
        private TextBox txbConfirmarPassword;
        private Button btnConfirmarRegistro;
        private NumericUpDown numudEdad;
        private Label lbEdad;
        private Label lbProvincia;
        private ComboBox cmbProvincia;
        private CheckBox chbMostrarPasswd;
        private Label lbNombre;
        private Label lbApellidos;
        private Label lbUsuario;
        private Label lbCorreo;
        private Label lbPasswd;
        private Label lbConfirmarPasswd;
        private TextBox txbConfPassword;
    }
}