namespace InventoryManagementSystem
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

            // Preload part and product data
            Inventory inventory = new Inventory();
            inventory.Preload();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(inventory));
        }
    }
}