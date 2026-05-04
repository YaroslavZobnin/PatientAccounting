namespace PatientAccounting
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            bool needToAuthorize = true;
            while(needToAuthorize)
            {
                needToAuthorize = false;
                var auth = new Authorization();
                if(auth.ShowDialog() == DialogResult.OK )
                {
                    var generalForm = new GeneralForm(auth.GetUser);
                    DialogResult res = generalForm.ShowDialog();
                    if (res == DialogResult.Retry)
                        needToAuthorize = true;
                }
            }
        }
    }
}