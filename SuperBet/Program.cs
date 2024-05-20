using SuperBet.DatabaseCommunication;
using SuperBet.UiElements;

namespace SuperBet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var db = new SuperBetDb(args[0]);
            var model = new Model(db);
            
            //model.onetimeinsertdata();
            ScreenStorage screenStorage = new ScreenStorage(model);
            Application.Run(screenStorage.login);
        }
    }
}