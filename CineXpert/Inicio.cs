using MySql.Data.MySqlClient;
using System.Configuration;

namespace CineXpert
{
    /// <summary>
    /// Clase principal del formulario de inicio, encargada de gestionar la interfaz principal de la aplicación.
    /// </summary>
    public partial class Inicio : Form
    {
        /// <summary>
        /// Almacena el texto actual de búsqueda utilizado para filtrar el contenido mostrado al usuario.
        /// Este texto se usa para limitar los resultados mostrados en la interfaz gráfica, basándose en el título del contenido.
        /// </summary>
        private string textoDeBusqueda = "";

        /// <summary>
        /// Constructor por defecto de la página de inicio.
        /// Inicializa la interfaz de usuario y carga el contenido en el FlowLayoutPanel.
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            CargarContenidoEnFlowLayout();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Añadir"
        /// </summary>
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            FormularioContenido formularioContenido = new FormularioContenido(this, null);
            formularioContenido.Show();
            this.Hide();
        }


        /// <summary>
        /// Obtiene la imagen del usuario desde la base de datos.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario cuya imagen se desea obtener.</param>
        /// <returns>Un arreglo de bytes que representa la imagen de usuario.</returns>
        private byte[] ObtenerImagenUsuario(string nombreUsuario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                string query = "SELECT imagen FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                try
                {
                    conexion.Open();
                    object resultado = comando.ExecuteScalar();
                    if (resultado != DBNull.Value && resultado != null)
                    {
                        return (byte[])resultado;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener imagen: " + ex.Message);
                }
                return null;
            }
        }


        /// <summary>
        /// Muestra la imagen de usuario en un PictureBox.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario cuya imagen se mostrará.</param>
        public void MostrarImagenUsuario(string nombreUsuario)
        {
            byte[] imagenBytes = ObtenerImagenUsuario(nombreUsuario);
            if (imagenBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    picboxFotoPerfil.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picboxFotoPerfil.Image = null;
            }
        }


        /// <summary>
        /// Recupera el contenido (películas y series) asociado al usuario actual basado en un criterio de búsqueda de títulos.
        /// Filtra el contenido por título, utilizando el texto de búsqueda proporcionado y compara con los títulos almacenados en la base de datos.
        /// </summary>
        /// <param name="textoBusqueda">Texto utilizado para filtrar el contenido por título. Solo se incluyen aquellos títulos que comienzan con el texto especificado.</param>
        /// <returns>Una lista de tuplas, donde cada tupla contiene el identificador del contenido, el título, la imagen representativa y el tipo de contenido (película o serie).</returns>
        /// <remarks>
        /// Utiliza la conexión a la base de datos especificada en la cadena de conexión "MySqlConnection".
        /// La búsqueda es sensible al inicio del título, asegurando que el contenido retornado coincida con el comienzo del texto de búsqueda.
        /// </remarks>

        private List<(int id, string Titulo, Image Imagen, string tipo)> ObtenerContenido(string textoBusqueda)
        {
            var contenido = new List<(int id, string Titulo, Image Imagen, string tipo)>();
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            string query = @"SELECT id, titulo, foto, tipo 
                     FROM contenido 
                     WHERE usuario_id = @usuarioId 
                     AND titulo LIKE @textoBusqueda 
                     ORDER BY id ASC";

            using (var conexion = new MySqlConnection(connectionString))
            {
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@usuarioId", UsuarioActual.Id);
                    comando.Parameters.AddWithValue("@textoBusqueda", $"{textoBusqueda}%");

                    try
                    {
                        conexion.Open();
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                var titulo = reader["titulo"].ToString();
                                var tipo = reader["tipo"].ToString();
                                byte[] imagenBytes = reader["foto"] as byte[];
                                Image imagen = ConvertirByteAImagen(imagenBytes);
                                contenido.Add((id, titulo, imagen, tipo));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener el contenido: {ex.Message}");
                    }
                }
            }
            return contenido;
        }


        /// <summary>
        /// Convierte un arreglo de bytes en un objeto Image.
        /// </summary>
        /// <param name="bytes">Los bytes que representan la imagen.</param>
        /// <returns>Un objeto Image creado a partir de los bytes o nulo si los bytes son nulos o tienen longitud cero.</returns>
        private Image ConvertirByteAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }


        /// <summary>
        /// Carga el contenido en el FlowLayoutPanel (Panel de inicio).
        /// </summary>
        public void CargarContenidoEnFlowLayout()
        {
            var contenido = ObtenerContenido(textoDeBusqueda);

            flayoutPeliculas.Controls.Clear();
            flayoutSeries.Controls.Clear();

            foreach (var item in contenido)
            {
                var compPersContenido = new CompPersContenido(this);
                compPersContenido.SetImagen(item.Imagen);
                compPersContenido.ContenidoId = item.id;

                if (item.tipo == "pelicula")
                {
                    flayoutPeliculas.Controls.Add(compPersContenido);
                }
                else
                {
                    flayoutSeries.Controls.Add(compPersContenido);
                }
            }

            ActualizarVisibilidadMensajeYFlecha();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Borrar", haciendo visible el botón de eliminar en cada componente de contenido.
        /// Esto permite al usuario iniciar el proceso de eliminación de contenido específico tanto en películas como en series.
        /// </summary>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (CompPersContenido componente in flayoutPeliculas.Controls.OfType<CompPersContenido>())
            {
                componente.VisibilidadBtnEliminar();
            }
            foreach (CompPersContenido componente in flayoutSeries.Controls.OfType<CompPersContenido>())
            {
                componente.VisibilidadBtnEliminar();
            }
        }

        /// <summary>
        /// Actualiza la visibilidad de un mensaje y una flecha en la interfaz de usuario para indicar al usuario que no hay contenido disponible
        /// y sugerir la acción de añadir nuevo contenido. Se muestra un mensaje y una flecha cuando no hay elementos en ninguno de los FlowLayoutPanels.
        /// </summary>
        private void ActualizarVisibilidadMensajeYFlecha()
        {
            bool mostrarMensaje = flayoutPeliculas.Controls.Count == 0 && flayoutSeries.Controls.Count == 0;
            lbMensaje.Visible = mostrarMensaje;
            picboxFlecha.Visible = mostrarMensaje;
        }

        /// <summary>
        /// Responde a los cambios en el texto de búsqueda. Cada vez que el texto cambia, filtra el contenido mostrado en los FlowLayoutPanels
        /// basándose en el texto de búsqueda ingresado, permitiendo una búsqueda dinámica de contenido por título.
        /// </summary>
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            textoDeBusqueda = txbBuscar.Text;
            CargarContenidoEnFlowLayout();
        }

        /// <summary>
        /// Maneja el evento de clic en la foto de perfil del usuario. Al hacer clic, se abre el formulario de perfil del usuario,
        /// ocultando temporalmente el formulario actual. Esto permite al usuario ver y posiblemente editar su perfil.
        /// </summary>
        private void picboxFotoPerfil_Click(object sender, EventArgs e)
        {
            FormularioPerfil formularioPerfil = new FormularioPerfil(this);
            formularioPerfil.Show();
            this.Hide();
        }
    }
}