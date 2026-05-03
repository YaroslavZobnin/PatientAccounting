namespace PatientAccounting
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GeneralForm());
            //ApplicationConfiguration.Initialize();
            //var authorization = new Authorization();
            //if (authorization.ShowDialog() == DialogResult.OK)
            //    Application.Run(new GeneralForm(authorization.GetUser));
        }
    }
}