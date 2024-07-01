using WinFormsAppSource.Controller;
using WinFormsAppSource.Model;

namespace WinFormsAppSource
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Initialize the Model
            StringModel model = new StringModel();


            // Initialize the View
            Form1 view = new Form1();


            // Initialize the Controller
            StringController controller = new StringController(model, view);
                  // Run the application with the View
            Application.Run(view);
        }
    }
}