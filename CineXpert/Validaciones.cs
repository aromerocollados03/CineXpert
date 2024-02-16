using MySql.Data.MySqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace CineXpert
{
    /// <summary>
    /// Clase estática que proporciona métodos de validación para diferentes campos y acciones en la aplicación CineXpert.
    /// Incluye validaciones para contraseñas, campos vacíos, formato de correo electrónico y unicidad de usuario y correo en la base de datos.
    /// </summary>
    public static class Validaciones
    {
        /// <summary>
        /// Verifica si dos contraseñas ingresadas coinciden.
        /// </summary>
        /// <param name="password">La contraseña introducida por el usuario.</param>
        /// <param name="confirmarContraseña">La confirmación de la contraseña introducida por el usuario.</param>
        /// <returns>True si las contraseñas coinciden, de lo contrario, false.</returns>
        public static bool PasswordCoinciden(string password, string confirmarContraseña)
        {
            if (password != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verifica si algún campo de un conjunto de campos está vacío.
        /// </summary>
        /// <param name="campos">Array de cadenas que representan los valores de los campos a verificar.</param>
        /// <returns>True si al menos un campo está vacío, de lo contrario, false.</returns>
        public static bool CamposEstanVacios(string[] campos)
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
        /// Convierte una imagen de ruta especificada a un arreglo de bytes.
        /// </summary>
        /// <param name="rutaImagen">La ruta de la imagen a convertir.</param>
        /// <returns>Un arreglo de bytes de la imagen.</returns>
        public static byte[] ConvertirImagenABytes(string rutaImagen)
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
        /// Valida si el correo electrónico cumple con el formato estándar.
        /// </summary>
        /// <param name="correoElectronico">Correo electrónico a validar.</param>
        /// <returns>True si el correo es válido, de lo contrario, false.</returns>
        public static bool EsCorreoValido(string correoElectronico)
        {
            string patron = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
            if (!Regex.IsMatch(correoElectronico, patron))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verifica en la base de datos si el nombre de usuario y correo electrónico ya están en uso.
        /// </summary>
        /// <param name="nombreUsuario">El nombre de usuario a verificar.</param>
        /// <param name="correoElectronico">El correo electrónico a verificar.</param>
        /// <returns>True si el nombre de usuario y correo no están en uso, de lo contrario, false.</returns>
        public static bool VerificarUsuarioYCorreo(string nombreUsuario, string correoElectronico)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                string queryUsuario = "SELECT COUNT(1) FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                using (MySqlCommand comando = new MySqlCommand(queryUsuario, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("El nombre de usuario ya está en uso.");
                        return false;
                    }
                }

                string queryCorreo = "SELECT COUNT(1) FROM usuarios WHERE correo_electronico = @correoElectronico";
                using (MySqlCommand comando = new MySqlCommand(queryCorreo, conexion))
                {
                    comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("El correo electrónico ya está en uso.");
                        return false;
                    }
                }
            }
            return true;
        }
    }

}
