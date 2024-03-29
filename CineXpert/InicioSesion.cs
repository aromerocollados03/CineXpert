using MySql.Data.MySqlClient;
using System.Configuration;

namespace CineXpert
{
    /// <summary>
    /// Representa el formulario de inicio de sesi�n para la aplicaci�n.
    /// Proporciona campos para que el usuario ingrese su nombre de usuario y contrase�a,
    /// adem�s de opciones para registrarse o recuperar la contrase�a en caso de ser necesario.
    /// </summary>
    public partial class InicioSesion : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="InicioSesion"/>.
        /// Este constructor configura los componentes del formulario de inicio de sesi�n.
        /// </summary>
        public InicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cambia la visibilidad del car�cter de contrase�a en el campo de texto de contrase�a
        /// cuando el usuario marca o desmarca la casilla de mostrar contrase�a.
        /// </summary>
        private void chbMostrarPasswd_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = chbMostrarPasswd.Checked ? '\0' : '*';
        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n de registrarse.
        /// Abre el formulario de registro para que un nuevo usuario pueda registrarse.
        /// </summary>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormularioRegistro FormRegistro = new FormularioRegistro(this);
            FormRegistro.Show();
            this.Hide();
        }

        /// <summary>
        /// Intenta autenticar al usuario con las credenciales proporcionadas.
        /// Si las credenciales son correctas, guarda el ID del usuario y abre el formulario principal.
        /// En caso contrario, muestra un mensaje de error.
        /// </summary>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txbUsuario.Text;
            string password = txbPassword.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, password FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    try
                    {
                        conexion.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hash = reader.GetString("password");
                                int idUsuario = reader.GetInt32("id");
                                if (BCrypt.Net.BCrypt.Verify(password, hash))
                                {
                                    UsuarioActual.Id = idUsuario;
                                    Inicio inicioForm = new Inicio();
                                    inicioForm.MostrarImagenUsuario(nombreUsuario);
                                    inicioForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contrase�a incorrectos.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contrase�a incorrectos.");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al iniciar sesi�n: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Abre el formulario para recuperar la contrase�a cuando el usuario hace clic en el enlace de olvido de contrase�a.
        /// </summary>
        private void linklbOlvidarContrase�a_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioRecuperacionPassword formularioRecuperacionPassword = new FormularioRecuperacionPassword();
            formularioRecuperacionPassword.ShowDialog();
        }
    }
}



