using MySql.Data.MySqlClient;
using System.Configuration;

namespace CineXpert
{
    /// <summary>
    /// Clase para representar un componente visual personalizado que muestra información de contenido (como películas o series) en la página de inicio.
    /// Permite la interacción con el contenido, como visualizar detalles, eliminarlo o editar su información.
    /// </summary>
    public partial class CompPersContenido : UserControl
    {
        /// <summary>
        /// Identificador del contenido asociado a este componente personalizado.
        /// </summary>
        public int ContenidoId { get; set; }

        /// <summary>
        /// Referencia al formulario de inicio de la aplicación. Se utiliza para acceder a métodos y propiedades del formulario principal, permitiendo actualizar la interfaz de usuario y realizar acciones como cargar contenido.
        /// </summary>
        private Inicio inicioForm;

        /// <summary>
        /// Constructor que inicializa el componente personalizado y asigna la instancia del formulario de inicio.
        /// </summary>
        /// <param name="inicioform">Instancia del formulario de inicio.</param>
        public CompPersContenido(Inicio inicioform)
        {
            InitializeComponent();
            this.Controls.Add(picboxImagen);
            this.inicioForm = inicioform;
        }

        /// <summary>
        /// Establece la imagen del contenido en el componente.
        /// </summary>
        /// <param name="imagen">Imagen del contenido a mostrar.</param>
        public void SetImagen(Image imagen)
        {
            picboxImagen.Image = imagen;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón de eliminar, solicitando confirmación y eliminando el contenido si se confirma.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Estás seguro de que deseas borrar este contenido?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                EliminarContenidoDeLaBaseDeDatos();
            }
        }

        /// <summary>
        /// Elimina el contenido asociado a este componente de la base de datos.
        /// </summary>
        private void EliminarContenidoDeLaBaseDeDatos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (var conexion = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM contenido WHERE id = @contenidoId";
                using (var comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@contenidoId", this.ContenidoId);
                    conexion.Open();
                    int result = comando.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Contenido eliminado con éxito.");
                        this.Parent.Controls.Remove(this);
                        this.Dispose();
                        inicioForm.CargarContenidoEnFlowLayout(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar contenido. Por favor, inténtelo de nuevo.");
                    }
                }
            }
        }

        /// <summary>
        /// Alterna la visibilidad del botón de eliminar.
        /// </summary>
        public void VisibilidadBtnEliminar()
        {
            btnEliminar.Visible = !btnEliminar.Visible;
        }

        /// <summary>
        /// Maneja el evento de clic en la imagen, abriendo el formulario de edición de contenido con los datos del contenido actual.
        /// </summary>
        private void picboxImagen_Click(object sender, EventArgs e)
        {
            FormularioContenido formularioEdicion = new FormularioContenido(inicioForm, this.ContenidoId);
            formularioEdicion.Show();
            inicioForm.Hide(); // Oculta el formulario de inicio mientras se edita el contenido.
        }
    }
}
