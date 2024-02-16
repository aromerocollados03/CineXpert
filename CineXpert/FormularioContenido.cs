using MySql.Data.MySqlClient;
using System.Configuration;


namespace CineXpert
{
    /// <summary>
    /// Representa el formulario para añadir o editar el contenido dentro de la aplicación CineXpert.
    /// Permite al usuario especificar o modificar los detalles de una película o serie,
    /// incluyendo título, tipo, género, fecha de estreno, descripción y una imagen representativa.
    /// </summary>
    public partial class FormularioContenido : Form
    {
        /// <summary>
        /// Referencia al formulario principal de inicio para permitir la interacción.
        /// </summary>
        private Inicio inicioForm;

        /// <summary>
        /// Textos predeterminados para los campos de título y descripción.
        /// </summary>
        private string DefaultTituloText = "Título por defecto";
        private string DefaultDescripcionText = "Descripción por defecto";

        /// <summary>
        /// Ruta de la imagen seleccionada por el usuario.
        /// </summary>
        private string imagePath;

        /// <summary>
        /// Identificador opcional del contenido para determinar si se está editando.
        /// </summary>
        private int? contenidoId;

        /// <summary>
        /// Constructor que inicializa el formulario y carga los datos del contenido si se está editando.
        /// </summary>
        /// <param name="inicio">Instancia del formulario de inicio para interactuar con él.</param>
        /// <param name="contenidoId">Identificador del contenido a editar; null si es una adición nueva.</param>
        public FormularioContenido(Inicio inicio, int? contenidoId)
        {
            InitializeComponent();
            inicioForm = inicio;
            this.contenidoId = contenidoId;

            // Carga los datos del contenido si se proporciona un ID válido.
            if (contenidoId.HasValue)
            {
                CargarDatosContenido(contenidoId.Value);
            }
        }

        /// <summary>
        /// Muestra el formulario de inicio y cierra el formulario actual.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            inicioForm.Show();
            this.Close();
        }

        /// <summary>
        /// Limpia el texto por defecto al entrar en el campo de título si es necesario.
        /// </summary>
        private void txbTitulo_Enter(object sender, EventArgs e)
        {
            if (txbTitulo.Text == DefaultTituloText)
            {
                txbTitulo.Text = "";
            }
        }

        /// <summary>
        /// Restablece el texto por defecto al salir del campo de título si está vacío.
        /// </summary>
        private void txbTitulo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTitulo.Text))
            {
                txbTitulo.Text = DefaultTituloText;
            }
        }

        /// <summary>
        /// Limpia el texto por defecto al entrar en el campo de descripción si es necesario.
        /// </summary>
        private void richtxbDescripcion_Enter(object sender, EventArgs e)
        {
            if (richtxbDescripcion.Text == DefaultDescripcionText)
            {
                richtxbDescripcion.Text = "";
            }
        }

        /// <summary>
        /// Restablece el texto por defecto al salir del campo de descripción si está vacío.
        /// </summary>
        private void richtxbDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richtxbDescripcion.Text))
            {
                richtxbDescripcion.Text = DefaultDescripcionText;
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Añadir", decidindo entre agregar un nuevo contenido
        /// o actualizar uno existente basado en la presencia de un identificador de contenido.
        /// </summary>
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string titulo = txbTitulo.Text;
            string tipo = cboxTipo.Text;
            string genero = cboxGenero.Text;
            DateTime fechaEstreno = datetimeFechaEstreno.Value;
            string descripcion = richtxbDescripcion.Text;
            byte[] imagenBytes = ConvertirImagenABytes(imagePath);

            if (picboxImagen.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picboxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }
            }

            if (contenidoId.HasValue)
            {
                ActualizarContenido(titulo, tipo, genero, fechaEstreno, descripcion, imagenBytes);
            }
            else
            {
                AgregarContenido(titulo, tipo, genero, fechaEstreno, descripcion, imagenBytes);
            }
        }

        /// <summary>
        /// Actualiza los detalles de un contenido existente en la base de datos.
        /// </summary>
        /// <param name="titulo">El título del contenido.</param>
        /// <param name="tipo">El tipo de contenido (por ejemplo, película, serie).</param>
        /// <param name="genero">El género del contenido.</param>
        /// <param name="fechaEstreno">La fecha de estreno del contenido.</param>
        /// <param name="descripcion">La descripción del contenido.</param>
        /// <param name="imagenBytes">La imagen del contenido como un arreglo de bytes.</param>
        /// <remarks>
        /// Este método actualiza un registro de contenido existente en la base de datos con los valores proporcionados.
        /// Se identifica el contenido a actualizar mediante el 'contenidoId' asociado al formulario.
        /// Si la actualización es exitosa, muestra un mensaje de confirmación.
        /// Si ocurre un error durante la actualización, muestra un mensaje de error.
        /// Independientemente del resultado, cierra el formulario de edición y recarga el contenido en el formulario principal.
        /// </remarks>
        private void ActualizarContenido(string titulo, string tipo, string genero, DateTime fechaEstreno, string descripcion, byte[] imagenBytes)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (var conexion = new MySqlConnection(connectionString))
            {
                string query = "UPDATE contenido SET titulo=@titulo, tipo=@tipo, genero=@genero, fecha_estreno=@fechaEstreno, descripcion=@descripcion, foto=@foto WHERE id=@id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@titulo", titulo);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@genero", genero);
                    comando.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@foto", imagenBytes); 
                    comando.Parameters.AddWithValue("@id", contenidoId.Value);

                    conexion.Open();
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contenido actualizado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el contenido.");
                    }
                }
            }
            this.Close();
            inicioForm.CargarContenidoEnFlowLayout();
            inicioForm.Show();
        }


        /// <summary>
        /// Agrega un nuevo contenido a la base de datos basado en la información proporcionada en el formulario.
        /// </summary>
        /// <param name="titulo">El título del contenido a agregar.</param>
        /// <param name="tipo">El tipo de contenido (p.ej., película, serie).</param>
        /// <param name="genero">El género del contenido.</param>
        /// <param name="fechaEstreno">La fecha de estreno del contenido.</param>
        /// <param name="descripcion">La descripción del contenido.</param>
        /// <param name="imagenBytes">La imagen del contenido como un arreglo de bytes.</param>
        /// <remarks>
        /// Este método inserta un nuevo registro de contenido en la base de datos utilizando los valores proporcionados.
        /// Verifica que los campos tipo y género no estén vacíos antes de proceder con la inserción.
        /// En caso de éxito, muestra un mensaje de confirmación.
        /// En caso de error durante la inserción, muestra un mensaje de error.
        /// Independientemente del resultado, cierra el formulario de creación/edición y recarga el contenido en el formulario principal para reflejar los cambios.
        /// </remarks>
        private void AgregarContenido(string titulo, string tipo, string genero, DateTime fechaEstreno, string descripcion, byte[] imagenBytes)
        {
            // Verifica que los campos obligatorios estén llenos antes de proceder.
            string[] campos = { tipo, genero };
            if (!CamposEstanVacios(campos))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                string query = "INSERT INTO contenido (titulo, tipo, genero, fecha_estreno, descripcion, foto, usuario_id) VALUES (@titulo, @tipo, @genero, @fechaEstreno, @descripcion, @foto, @usuarioId)";

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Asigna los valores a los parámetros de la consulta SQL para insertar el nuevo contenido.
                        comando.Parameters.AddWithValue("@titulo", titulo);
                        comando.Parameters.AddWithValue("@tipo", tipo);
                        comando.Parameters.AddWithValue("@genero", genero);
                        comando.Parameters.AddWithValue("@fechaEstreno", fechaEstreno);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@foto", imagenBytes); 
                        comando.Parameters.AddWithValue("@usuarioId", UsuarioActual.Id);

                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Contenido añadido con éxito.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al añadir contenido: " + ex.Message);
                        }
                    }
                }

                // Cierra el formulario actual y recarga el contenido en el formulario principal para reflejar los cambios.
                this.Close();
                inicioForm.CargarContenidoEnFlowLayout();
                inicioForm.Show();
            }
        }


        /// <summary>
        /// Verifica si alguno de los campos obligatorios está vacío.
        /// </summary>
        /// <param name="campos">Array de campos a verificar.</param>
        /// <returns>Verdadero si alguno de los campos está vacío, de lo contrario, falso.</returns>
        private bool CamposEstanVacios(string[] campos)
        {
            foreach (string campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo))
                {
                    MessageBox.Show("Por favor, rellena todos los campos.");
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Convierte una imagen seleccionada por el usuario en un arreglo de bytes.
        /// </summary>
        /// <param name="rutaImagen">La ruta completa de la imagen a convertir.</param>
        /// <returns>Un arreglo de bytes que representa la imagen.</returns>
        private byte[] ConvertirImagenABytes(string rutaImagen)
        {
            if (string.IsNullOrWhiteSpace(rutaImagen))
            {
                return null;
            }

            try
            {
                if (File.Exists(rutaImagen))
                {
                    using (FileStream stream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader reader = new BinaryReader(stream))
                        {
                            return reader.ReadBytes((int)stream.Length);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de imagen no existe.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la imagen: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Permite al usuario seleccionar una imagen desde su dispositivo y establecerla como la imagen del contenido.
        /// </summary>
        private void btnAnadirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                picboxImagen.Image = Image.FromFile(imagePath);
            }
        }

        /// <summary>
        /// Carga los datos de un contenido específico desde la base de datos y los muestra en el formulario.
        /// </summary>
        /// <param name="contenidoId">El ID del contenido a cargar.</param>
        private void CargarDatosContenido(int contenidoId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (var conexion = new MySqlConnection(connectionString))
            {
                string query = "SELECT titulo, tipo, genero, fecha_estreno, descripcion, foto FROM contenido WHERE id = @id";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", contenidoId);
                    conexion.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txbTitulo.Text = reader["titulo"].ToString();
                            cboxTipo.Text = reader["tipo"].ToString();
                            cboxGenero.Text = reader["genero"].ToString();
                            datetimeFechaEstreno.Value = reader.GetDateTime(reader.GetOrdinal("fecha_estreno"));
                            richtxbDescripcion.Text = reader["descripcion"].ToString();

                            byte[] imagenBytes = reader["foto"] as byte[];
                            if (imagenBytes != null)
                            {
                                using (var ms = new MemoryStream(imagenBytes))
                                {
                                    picboxImagen.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                picboxImagen.Image = null;
                            }
                        }
                    }
                }
            }
        }
    }
}
