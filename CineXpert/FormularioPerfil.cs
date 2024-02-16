using MySql.Data.MySqlClient;
using System.Configuration;

namespace CineXpert
{
    /// <summary>
    /// Formulario para visualizar y actualizar el perfil de un usuario en la aplicación.
    /// Permite al usuario modificar su información personal, incluida la imagen de perfil.
    /// </summary>
    public partial class FormularioPerfil : Form
    {
        /// <summary>
        /// Referencia al formulario principal de inicio para permitir la interacción.
        /// </summary>
        private Inicio inicioForm;

        /// <summary>
        /// Ruta de la imagen de perfil del usuario seleccionada para ser cargada o actualizada.
        /// </summary>
        private string imagePath;

        /// <summary>
        /// Constructor del formulario de perfil. Inicializa los componentes y carga la información actual del usuario desde la base de datos.
        /// </summary>
        /// <param name="inicio">Instancia del formulario de inicio para permitir la interacción con el contexto general de la aplicación.</param>
        public FormularioPerfil(Inicio inicio)
        {
            InitializeComponent();
            CargarDatosUsuario();
            this.inicioForm = inicio;
        }

        /// <summary>
        /// Método que carga la información del usuario
        /// </summary>
        private void CargarDatosUsuario()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (var conexion = new MySqlConnection(connectionString))
            {
                string query = "SELECT nombre, apellidos, nombre_usuario, correo_electronico, provincia, edad, imagen FROM usuarios WHERE id = @idUsuario";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idUsuario", UsuarioActual.Id);
                    conexion.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txbNombre.Text = reader["nombre"].ToString();
                            txbApellidos.Text = reader["apellidos"].ToString();
                            txbUsuario.Text = reader["nombre_usuario"].ToString();
                            txbCorreo.Text = reader["correo_electronico"].ToString();
                            cmbProvincia.Text = reader["provincia"].ToString();
                            numudEdad.Value = Convert.ToInt32(reader["edad"]);
                            byte[] imagenBytes = reader["imagen"] as byte[];
                            if (imagenBytes != null && imagenBytes.Length > 0)
                            {
                                using (var ms = new MemoryStream(imagenBytes))
                                {
                                    picboxFotoUsuario.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Volver". Cierra el formulario actual y muestra el formulario de inicio.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            inicioForm.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Actualizar Foto". Permite al usuario seleccionar una nueva imagen de perfil a través de un cuadro de diálogo.
        /// </summary>
        private void btnActualizarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                picboxFotoUsuario.Image = Image.FromFile(imagePath);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Confirmar". Actualiza la información del perfil del usuario en la base de datos.
        /// </summary>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellidos = txbApellidos.Text;
            string usuario = txbUsuario.Text;
            string correoElectronico = txbCorreo.Text;
            string provincia = cmbProvincia.SelectedItem.ToString();
            int edad = (int)numudEdad.Value;
            byte[] imagenBytes = !string.IsNullOrEmpty(imagePath) ? Validaciones.ConvertirImagenABytes(imagePath) : null;

            string[] campos = { nombre, apellidos, usuario, correoElectronico, provincia };

            if (!Validaciones.CamposEstanVacios(campos) && Validaciones.EsCorreoValido(correoElectronico))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (var conexion = new MySqlConnection(connectionString))
                {
                    string query = @"UPDATE usuarios SET 
                                    nombre=@nombre, 
                                    apellidos=@apellidos, 
                                    nombre_usuario=@usuario, 
                                    correo_electronico=@correoElectronico, 
                                    provincia=@provincia, 
                                    edad=@edad
                                    " + (imagenBytes != null ? ", imagen=@imagen " : " ") +
                                            "WHERE id=@idUsuario";

                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                        comando.Parameters.AddWithValue("@provincia", provincia);
                        comando.Parameters.AddWithValue("@edad", edad);
                        if (imagenBytes != null)
                        {
                            comando.Parameters.AddWithValue("@imagen", imagenBytes);
                        }
                        comando.Parameters.AddWithValue("@idUsuario", UsuarioActual.Id);

                        try
                        {
                            conexion.Open();
                            int resultado = comando.ExecuteNonQuery();
                            if (resultado > 0)
                            {
                                MessageBox.Show("Datos actualizados con éxito.");
                                this.Close();
                                inicioForm.MostrarImagenUsuario(usuario);
                                inicioForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron actualizar los datos. Por favor, inténtelo de nuevo.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cerrar Sesión". Reinicia el estado de la sesión actual y muestra el formulario de inicio de sesión.
        /// </summary>
        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            UsuarioActual.Id = 0;
            this.Close();
            inicioForm.Close();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
        }

        /// <summary>
        /// Maneja el evento de clic en el enlace "Cambiar Contraseña". Muestra el formulario para la recuperación de la contraseña.
        /// </summary>
        private void linklbCambiarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioRecuperacionPassword formularioRecuperacionPassword = new FormularioRecuperacionPassword();
            formularioRecuperacionPassword.ShowDialog();
        }
    }
}
