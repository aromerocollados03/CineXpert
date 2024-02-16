using MySql.Data.MySqlClient;
using System.Configuration;

namespace CineXpert
{
    /// <summary>
    /// Proporciona una interfaz para el registro de nuevos usuarios en la aplicación CineXpert.
    /// Los usuarios deben proporcionar su información personal y elegir una contraseña para crear una nueva cuenta.
    /// Además, pueden añadir una foto de perfil durante el proceso de registro.
    /// </summary>
    public partial class FormularioRegistro : Form
    {
        /// <summary>
        /// Referencia al formulario de inicio de sesión para permitir la navegación hacia atrás una vez completado el registro o en caso de cancelación.
        /// </summary>
        private InicioSesion inicioSesionForm;

        /// <summary>
        /// Ruta del archivo de la imagen seleccionada por el usuario para usar como foto de perfil. Este valor se establece cuando el usuario elige una imagen a través del diálogo de selección de archivos.
        /// </summary>
        private string imagePath;

        /// <summary>
        /// Inicializa una nueva instancia de FormularioRegistro y configura la referencia al formulario de inicio de sesión.
        /// </summary>
        /// <param name="inicioForm">Referencia al formulario de inicio de sesión para permitir la navegación de vuelta.</param>
        public FormularioRegistro(InicioSesion inicioForm)
        {
            InitializeComponent();
            inicioSesionForm = inicioForm;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de volver, cerrando este formulario y mostrando el de inicio de sesión.
        /// </summary>
        private void btnVolverRegistro_Click(object sender, EventArgs e)
        {
            inicioSesionForm.Show();
            this.Close();
        }

        /// <summary>
        /// Evento que maneja la visibilidad de las contraseñas en los TextBox, mostrándolas o escondiéndolas según el estado del CheckBox.
        /// </summary>
        private void chbMostrarPasswd_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = chbMostrarPasswd.Checked ? '\0' : '*';
            txbConfPassword.PasswordChar = chbMostrarPasswd.Checked ? '\0' : '*';
        }

        /// <summary>
        /// Permite al usuario añadir una foto de perfil seleccionando un archivo de imagen mediante un diálogo de archivos.
        /// </summary>
        private void btnAñadirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Asignar a la variable de instancia, no a una local
                imagePath = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox 
                picboxFotoUsuario.Image = Image.FromFile(imagePath);
            }
        }

        /// <summary>
        /// Gestiona el evento de clic en el botón de confirmación de registro, verificando la validez de los datos ingresados y registrando el nuevo usuario en la base de datos si todo es correcto.
        /// </summary>
        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellidos = txbApellidos.Text;
            string nombreUsuario = txbUsuario.Text;
            string correoElectronico = txbCorreo.Text;
            string password = txbPassword.Text;
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            string confPassword = txbConfPassword.Text;
            string provincia = cmbProvincia.Text;
            int edad = int.Parse(numudEdad.Text);

            string[] campos = { nombre, apellidos, nombreUsuario, correoElectronico, password, confPassword, provincia };
            byte[] imagenBytes = Validaciones.ConvertirImagenABytes(imagePath);

            // Verifica si las contraseñas coinciden
            if (!Validaciones.CamposEstanVacios(campos) && Validaciones.PasswordCoinciden(password, confPassword) && Validaciones.EsCorreoValido(correoElectronico) && Validaciones.VerificarUsuarioYCorreo(nombreUsuario, correoElectronico))
            {
                // Continuar con la lógica de registro si las contraseñas coinciden
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

                // Query SQL para insertar los datos
                string query = "INSERT INTO usuarios (nombre, apellidos, nombre_usuario, correo_electronico, password, provincia, edad, imagen) VALUES (@nombre, @apellidos, @nombreUsuario, @correoElectronico, @password, @provincia, @edad, @imagen)";

                // Crear conexión y comando
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Asignar los valores a los parámetros
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                        comando.Parameters.AddWithValue("@password", hash);
                        comando.Parameters.AddWithValue("@provincia", provincia);
                        comando.Parameters.AddWithValue("@edad", edad);
                        if (imagenBytes != null)
                        {
                            comando.Parameters.AddWithValue("@imagen", imagenBytes);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@imagen", DBNull.Value);
                        }

                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Usuario registrado con éxito.");
                            inicioSesionForm.Show();
                            this.Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al registrar usuario: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}