namespace CineXpert
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            picboxLogo = new PictureBox();
            linklbOlvidarContraseña = new LinkLabel();
            chbMostrarPasswd = new CheckBox();
            btnIniciarSesion = new Button();
            btnRegistrarse = new Button();
            txbPassword = new TextBox();
            txbUsuario = new TextBox();
            lbInicioSesion = new Label();
            lbUsuario = new Label();
            lbPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // picboxLogo
            // 
            picboxLogo.Image = (Image)resources.GetObject("picboxLogo.Image");
            picboxLogo.Location = new Point(284, 26);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(163, 142);
            picboxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxLogo.TabIndex = 16;
            picboxLogo.TabStop = false;
            // 
            // linklbOlvidarContraseña
            // 
            linklbOlvidarContraseña.AutoSize = true;
            linklbOlvidarContraseña.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklbOlvidarContraseña.LinkColor = Color.Blue;
            linklbOlvidarContraseña.Location = new Point(253, 378);
            linklbOlvidarContraseña.Name = "linklbOlvidarContraseña";
            linklbOlvidarContraseña.Size = new Size(247, 28);
            linklbOlvidarContraseña.TabIndex = 15;
            linklbOlvidarContraseña.TabStop = true;
            linklbOlvidarContraseña.Text = "¿Has olvidado tu contraseña?";
            linklbOlvidarContraseña.LinkClicked += linklbOlvidarContraseña_LinkClicked;
            // 
            // chbMostrarPasswd
            // 
            chbMostrarPasswd.AutoSize = true;
            chbMostrarPasswd.BackColor = Color.Transparent;
            chbMostrarPasswd.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbMostrarPasswd.ForeColor = Color.Black;
            chbMostrarPasswd.Location = new Point(515, 266);
            chbMostrarPasswd.Name = "chbMostrarPasswd";
            chbMostrarPasswd.Size = new Size(190, 32);
            chbMostrarPasswd.TabIndex = 14;
            chbMostrarPasswd.Text = "Mostrar Contraseña";
            chbMostrarPasswd.UseVisualStyleBackColor = false;
            chbMostrarPasswd.CheckedChanged += chbMostrarPasswd_CheckedChanged;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Transparent;
            btnIniciarSesion.BackgroundImage = Properties.Resources.Login_Button_PNG_Download_Image;
            btnIniciarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(400, 313);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(129, 62);
            btnIniciarSesion.TabIndex = 13;
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.Transparent;
            btnRegistrarse.BackgroundImage = Properties.Resources.boton_registrarse;
            btnRegistrarse.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(253, 324);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(129, 40);
            btnRegistrarse.TabIndex = 12;
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbPassword.Location = new Point(297, 264);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.ScrollBars = ScrollBars.Horizontal;
            txbPassword.Size = new Size(203, 36);
            txbPassword.TabIndex = 11;
            // 
            // txbUsuario
            // 
            txbUsuario.Cursor = Cursors.IBeam;
            txbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbUsuario.Location = new Point(297, 215);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(203, 36);
            txbUsuario.TabIndex = 10;
            // 
            // lbInicioSesion
            // 
            lbInicioSesion.AutoSize = true;
            lbInicioSesion.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInicioSesion.ForeColor = Color.Black;
            lbInicioSesion.Location = new Point(189, 165);
            lbInicioSesion.Name = "lbInicioSesion";
            lbInicioSesion.Size = new Size(378, 47);
            lbInicioSesion.TabIndex = 9;
            lbInicioSesion.Text = "Inicia Sesión en CineXpert";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(219, 218);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(72, 28);
            lbUsuario.TabIndex = 17;
            lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(189, 267);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(102, 28);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Contraseña";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPassword);
            Controls.Add(lbUsuario);
            Controls.Add(picboxLogo);
            Controls.Add(linklbOlvidarContraseña);
            Controls.Add(chbMostrarPasswd);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnRegistrarse);
            Controls.Add(txbPassword);
            Controls.Add(txbUsuario);
            Controls.Add(lbInicioSesion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineXpert";
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picboxLogo;
        private LinkLabel linklbOlvidarContraseña;
        private CheckBox chbMostrarPasswd;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;
        private TextBox txbPassword;
        private TextBox txbUsuario;
        private Label lbInicioSesion;
        private NumericUpDown numericUpDown1;
        private Label lbUsuario;
        private Label lbPassword;
    }
}
