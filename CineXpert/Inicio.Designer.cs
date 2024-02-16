namespace CineXpert
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnBorrar = new Button();
            btnAnadir = new Button();
            panelHeader = new Panel();
            picboxBuscar = new PictureBox();
            picboxFotoPerfil = new PictureBox();
            txbBuscar = new TextBox();
            picboxLogo = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            flayoutPeliculas = new FlowLayoutPanel();
            lbPeliculas = new Label();
            lbSeries = new Label();
            flayoutSeries = new FlowLayoutPanel();
            lbMensaje = new Label();
            picboxFlecha = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxFotoPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxFlecha).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Transparent;
            btnBorrar.BackgroundImage = (Image)resources.GetObject("btnBorrar.BackgroundImage");
            btnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = Color.Transparent;
            btnBorrar.Location = new Point(15, 393);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(50, 45);
            btnBorrar.TabIndex = 18;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAnadir
            // 
            btnAnadir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnadir.BackColor = Color.Transparent;
            btnAnadir.BackgroundImage = (Image)resources.GetObject("btnAnadir.BackgroundImage");
            btnAnadir.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnadir.FlatAppearance.BorderSize = 0;
            btnAnadir.FlatStyle = FlatStyle.Flat;
            btnAnadir.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnadir.ForeColor = Color.White;
            btnAnadir.Location = new Point(713, 393);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(50, 45);
            btnAnadir.TabIndex = 19;
            btnAnadir.UseVisualStyleBackColor = false;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.Controls.Add(picboxBuscar);
            panelHeader.Controls.Add(picboxFotoPerfil);
            panelHeader.Controls.Add(txbBuscar);
            panelHeader.Controls.Add(picboxLogo);
            panelHeader.Location = new Point(12, 6);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(776, 62);
            panelHeader.TabIndex = 22;
            // 
            // picboxBuscar
            // 
            picboxBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picboxBuscar.Image = (Image)resources.GetObject("picboxBuscar.Image");
            picboxBuscar.Location = new Point(476, 19);
            picboxBuscar.Name = "picboxBuscar";
            picboxBuscar.Size = new Size(23, 23);
            picboxBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBuscar.TabIndex = 21;
            picboxBuscar.TabStop = false;
            // 
            // picboxFotoPerfil
            // 
            picboxFotoPerfil.BorderStyle = BorderStyle.Fixed3D;
            picboxFotoPerfil.Location = new Point(3, 3);
            picboxFotoPerfil.Name = "picboxFotoPerfil";
            picboxFotoPerfil.Size = new Size(50, 56);
            picboxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxFotoPerfil.TabIndex = 20;
            picboxFotoPerfil.TabStop = false;
            picboxFotoPerfil.Click += picboxFotoPerfil_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txbBuscar.Location = new Point(505, 19);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(268, 23);
            txbBuscar.TabIndex = 18;
            txbBuscar.TextChanged += txbBuscar_TextChanged;
            // 
            // picboxLogo
            // 
            picboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picboxLogo.Image = (Image)resources.GetObject("picboxLogo.Image");
            picboxLogo.Location = new Point(319, 0);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(90, 62);
            picboxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxLogo.TabIndex = 17;
            picboxLogo.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // flayoutPeliculas
            // 
            flayoutPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flayoutPeliculas.AutoScroll = true;
            flayoutPeliculas.FlowDirection = FlowDirection.TopDown;
            flayoutPeliculas.Location = new Point(12, 109);
            flayoutPeliculas.Name = "flayoutPeliculas";
            flayoutPeliculas.Size = new Size(776, 112);
            flayoutPeliculas.TabIndex = 23;
            // 
            // lbPeliculas
            // 
            lbPeliculas.AutoSize = true;
            lbPeliculas.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPeliculas.Location = new Point(12, 78);
            lbPeliculas.Name = "lbPeliculas";
            lbPeliculas.Size = new Size(80, 28);
            lbPeliculas.TabIndex = 25;
            lbPeliculas.Text = "Películas";
            // 
            // lbSeries
            // 
            lbSeries.AutoSize = true;
            lbSeries.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSeries.Location = new Point(12, 239);
            lbSeries.Name = "lbSeries";
            lbSeries.Size = new Size(58, 28);
            lbSeries.TabIndex = 26;
            lbSeries.Text = "Series";
            lbSeries.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flayoutSeries
            // 
            flayoutSeries.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flayoutSeries.AutoScroll = true;
            flayoutSeries.FlowDirection = FlowDirection.TopDown;
            flayoutSeries.Location = new Point(12, 270);
            flayoutSeries.Name = "flayoutSeries";
            flayoutSeries.Size = new Size(776, 112);
            flayoutSeries.TabIndex = 24;
            // 
            // lbMensaje
            // 
            lbMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMensaje.Location = new Point(231, 406);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(311, 21);
            lbMensaje.TabIndex = 27;
            lbMensaje.Text = "No tienes nada añadido, pulsa aquí para empezar";
            // 
            // picboxFlecha
            // 
            picboxFlecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picboxFlecha.Image = (Image)resources.GetObject("picboxFlecha.Image");
            picboxFlecha.Location = new Point(548, 394);
            picboxFlecha.Name = "picboxFlecha";
            picboxFlecha.Size = new Size(144, 44);
            picboxFlecha.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxFlecha.TabIndex = 22;
            picboxFlecha.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picboxFlecha);
            Controls.Add(lbMensaje);
            Controls.Add(flayoutSeries);
            Controls.Add(lbSeries);
            Controls.Add(lbPeliculas);
            Controls.Add(flayoutPeliculas);
            Controls.Add(panelHeader);
            Controls.Add(btnAnadir);
            Controls.Add(btnBorrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "Inicio";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxFotoPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxFlecha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBorrar;
        private Button btnAnadir;
        private Panel panelHeader;
        private PictureBox picboxLogo;
        private TextBox txbBuscar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox picboxSearch;
        private FlowLayoutPanel flayoutPeliculas;
        private Label lbPeliculas;
        private PictureBox picboxFotoPerfil;
        private PictureBox picboxBuscar;
        private Label lbSeries;
        private FlowLayoutPanel flayoutSeries;
        private Label lbMensaje;
        private PictureBox picboxFlecha;
    }
}