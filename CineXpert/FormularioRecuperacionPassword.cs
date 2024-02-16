using MySql.Data.MySqlClient;
using System.Configuration;

namespace CineXpert
{
    /// <summary>
    /// Clase FormularioRecuperacionPassword que proporciona un formulario para que los usuarios puedan recuperar su contraseña.
    /// Los usuarios deben proporcionar su nombre de usuario y correo electrónico asociados a su cuenta, junto con la nueva contraseña deseada.
    /// Si los datos coinciden con los registros, la contraseña se actualiza en la base de datos.
    /// </summary>
    public partial class FormularioRecuperacionPassword : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario FormularioRecuperacionPassword.
        /// Este constructor configura los componentes del formulario.
        /// </summary>
        public FormularioRecuperacionPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de confirmar cambio de contraseña.
        /// Verifica los campos y actualiza la contraseña si las validaciones son correctas.
        /// </summary>
        private void btnConfirmarCambio_Click(object sender, EventArgs e)
        {
            string correoElectronico = txbCorreo.Text;
            string nombreUsuario = txbNombreUsuario.Text;
            string nuevaContrasena = txbPasswordNueva.Text;
            string confirmarContrasena = txbConfirmacionPasswd.Text;

            string[] campos = { correoElectronico, nombreUsuario, nuevaContrasena, confirmarContrasena };

            if (!Validaciones.CamposEstanVacios(campos)
                && Validaciones.EsCorreoValido(correoElectronico)
                && Validaciones.PasswordCoinciden(nuevaContrasena, confirmarContrasena)
                && VerificarUsuarioYCorreoParaRecuperacion(nombreUsuario, correoElectronico))
            {
                ActualizarContrasena(nombreUsuario, nuevaContrasena);
            }
        }

        /// <summary>
        /// Verifica que el nombre de usuario y el correo electrónico existan en la base de datos.
        /// </summary>
        /// <param name="nombreUsuario">El nombre de usuario a verificar.</param>
        /// <param name="correoElectronico">El correo electrónico a verificar.</param>
        /// <returns>Verdadero si el usuario y correo coinciden en la base de datos, falso de lo contrario.</returns>
        private bool VerificarUsuarioYCorreoParaRecuperacion(string nombreUsuario, string correoElectronico)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(1) FROM usuarios WHERE nombre_usuario = @nombreUsuario AND correo_electronico = @correoElectronico";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);

                        // El resultado retornará el número de filas afectadas
                        int resultado = Convert.ToInt32(comando.ExecuteScalar());
                        return resultado > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el usuario y correo: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Actualiza la contraseña del usuario en la base de datos.
        /// </summary>
        /// <param name="nombreUsuario">El nombre de usuario cuya contraseña se actualizará.</param>
        /// <param name="nuevaContrasena">La nueva contraseña para el usuario.</param>
        /// <returns>Verdadero si la contraseña se actualizó con éxito, falso de lo contrario.</returns>
        private bool ActualizarContrasena(string nombreUsuario, string nuevaContrasena)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE usuarios SET password = @nuevaContrasena WHERE nombre_usuario = @nombreUsuario";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nuevaContrasena", BCrypt.Net.BCrypt.HashPassword(nuevaContrasena));
                        comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());
                        MessageBox.Show("La contraseña ha sido actualizada con éxito.");
                        this.Close();
                        return resultado > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de volver.
        /// Cierra el formulario de recuperación de contraseña.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
