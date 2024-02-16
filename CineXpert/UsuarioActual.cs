namespace CineXpert
{
    /// <summary>
    /// Clase estática que representa el usuario actualmente logueado en la aplicación CineXpert.
    /// Mantiene el identificador (Id) del usuario para acceder a sus datos y preferencias a lo largo de la aplicación.
    /// </summary>
    public static class UsuarioActual
    {
        /// <summary>
        /// Propiedad estática que almacena el identificador del usuario actual.
        /// </summary>
        public static int Id { get; set; }
    }
}
