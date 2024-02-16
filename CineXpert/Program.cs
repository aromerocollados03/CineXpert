namespace CineXpert
{
    /// <summary>
    /// Clase principal del programa que gestiona el punto de entrada de la aplicación.
    /// Esta clase es responsable de inicializar la configuración de la aplicación y lanzar el formulario de inicio de sesión.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Este método inicia la configuración de la aplicación y muestra la ventana de inicio de sesión.
        /// Para personalizar la configuración de la aplicación, como configuraciones de DPI alto o fuente predeterminada,
        /// consulte https://aka.ms/applicationconfiguration.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new InicioSesion());
        }
    }
}