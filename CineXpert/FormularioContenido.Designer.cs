namespace CineXpert
{
    partial class FormularioContenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioContenido));
            btnVolver = new Button();
            txbTitulo = new TextBox();
            picboxImagen = new PictureBox();
            btnAnadirImagen = new Button();
            lbTipo = new Label();
            cboxTipo = new ComboBox();
            lbGenero = new Label();
            cboxGenero = new ComboBox();
            lbFechaEstreno = new Label();
            datetimeFechaEstreno = new DateTimePicker();
            lbDescripcion = new Label();
            richtxbDescripcion = new RichTextBox();
            btnAnadir = new Button();
            ((System.ComponentModel.ISupportInitialize)picboxImagen).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.BackgroundImage = Properties.Resources._61449;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(24, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(57, 50);
            btnVolver.TabIndex = 3;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txbTitulo
            // 
            txbTitulo.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbTitulo.Location = new Point(231, 23);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(465, 50);
            txbTitulo.TabIndex = 4;
            txbTitulo.Text = "Título por defecto";
            txbTitulo.Enter += txbTitulo_Enter;
            txbTitulo.Leave += txbTitulo_Leave;
            // 
            // picboxImagen
            // 
            picboxImagen.BorderStyle = BorderStyle.Fixed3D;
            picboxImagen.Location = new Point(24, 98);
            picboxImagen.Name = "picboxImagen";
            picboxImagen.Size = new Size(197, 269);
            picboxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxImagen.TabIndex = 5;
            picboxImagen.TabStop = false;
            // 
            // btnAnadirImagen
            // 
            btnAnadirImagen.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnadirImagen.Location = new Point(24, 376);
            btnAnadirImagen.Name = "btnAnadirImagen";
            btnAnadirImagen.Size = new Size(197, 32);
            btnAnadirImagen.TabIndex = 6;
            btnAnadirImagen.Text = "Añadir Foto";
            btnAnadirImagen.UseVisualStyleBackColor = true;
            btnAnadirImagen.Click += btnAnadirImagen_Click;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTipo.Location = new Point(334, 101);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(56, 33);
            lbTipo.TabIndex = 7;
            lbTipo.Text = "Tipo";
            // 
            // cboxTipo
            // 
            cboxTipo.AllowDrop = true;
            cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTipo.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxTipo.FormattingEnabled = true;
            cboxTipo.Items.AddRange(new object[] { "Pelicula", "Serie" });
            cboxTipo.Location = new Point(396, 98);
            cboxTipo.Name = "cboxTipo";
            cboxTipo.Size = new Size(121, 36);
            cboxTipo.TabIndex = 8;
            // 
            // lbGenero
            // 
            lbGenero.AutoSize = true;
            lbGenero.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGenero.Location = new Point(306, 154);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(84, 33);
            lbGenero.TabIndex = 9;
            lbGenero.Text = "Género";
            // 
            // cboxGenero
            // 
            cboxGenero.AllowDrop = true;
            cboxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxGenero.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxGenero.FormattingEnabled = true;
            cboxGenero.Items.AddRange(new object[] { "Acción", "Animes", "Ciencia Ficción", "Ciencia y naturaleza", "Comedias", "Documental", "Drama", "Españolas", "Estadounidenses", "Europeas", "Extranjeras", "Infantiles", "Juveniles", "Policiacas", "Realities", "Románticas", "Terror", "Thrillers" });
            cboxGenero.Location = new Point(396, 155);
            cboxGenero.Name = "cboxGenero";
            cboxGenero.Size = new Size(121, 36);
            cboxGenero.TabIndex = 10;
            // 
            // lbFechaEstreno
            // 
            lbFechaEstreno.AutoSize = true;
            lbFechaEstreno.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechaEstreno.Location = new Point(306, 203);
            lbFechaEstreno.Name = "lbFechaEstreno";
            lbFechaEstreno.Size = new Size(179, 33);
            lbFechaEstreno.TabIndex = 11;
            lbFechaEstreno.Text = "Fecha de estreno";
            // 
            // datetimeFechaEstreno
            // 
            datetimeFechaEstreno.CalendarFont = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetimeFechaEstreno.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetimeFechaEstreno.Location = new Point(306, 239);
            datetimeFechaEstreno.MinDate = new DateTime(1920, 1, 1, 0, 0, 0, 0);
            datetimeFechaEstreno.Name = "datetimeFechaEstreno";
            datetimeFechaEstreno.Size = new Size(285, 30);
            datetimeFechaEstreno.TabIndex = 12;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDescripcion.Location = new Point(306, 289);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(124, 33);
            lbDescripcion.TabIndex = 13;
            lbDescripcion.Text = "Descripción";
            // 
            // richtxbDescripcion
            // 
            richtxbDescripcion.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richtxbDescripcion.Location = new Point(306, 325);
            richtxbDescripcion.Name = "richtxbDescripcion";
            richtxbDescripcion.Size = new Size(285, 96);
            richtxbDescripcion.TabIndex = 15;
            richtxbDescripcion.Text = "Descripción por defecto";
            richtxbDescripcion.Enter += richtxbDescripcion_Enter;
            richtxbDescripcion.Leave += richtxbDescripcion_Leave;
            // 
            // btnAnadir
            // 
            btnAnadir.BackgroundImage = (Image)resources.GetObject("btnAnadir.BackgroundImage");
            btnAnadir.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnadir.FlatAppearance.BorderSize = 0;
            btnAnadir.FlatStyle = FlatStyle.Flat;
            btnAnadir.Location = new Point(696, 366);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(66, 55);
            btnAnadir.TabIndex = 16;
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // FormularioContenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnadir);
            Controls.Add(richtxbDescripcion);
            Controls.Add(lbDescripcion);
            Controls.Add(datetimeFechaEstreno);
            Controls.Add(lbFechaEstreno);
            Controls.Add(cboxGenero);
            Controls.Add(lbGenero);
            Controls.Add(cboxTipo);
            Controls.Add(lbTipo);
            Controls.Add(btnAnadirImagen);
            Controls.Add(picboxImagen);
            Controls.Add(txbTitulo);
            Controls.Add(btnVolver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormularioContenido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioContenido";
            ((System.ComponentModel.ISupportInitialize)picboxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private TextBox txbTitulo;
        private PictureBox picboxImagen;
        private Button btnAnadirImagen;
        private Label lbTipo;
        private ComboBox cboxTipo;
        private Label lbGenero;
        private ComboBox comboBox1;
        private Label lbFechaEstreno;
        private DateTimePicker datetimeFechaEstreno;
        private Label lbDescripcion;
        private RichTextBox richtxbDescripcion;
        private Button btnAnadir;
        private ComboBox cboxGenero;
    }
}