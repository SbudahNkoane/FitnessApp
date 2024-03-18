using FitnessApp.ViewModels;

namespace FitnessApp
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhKYVF3WmFZfVpgcF9DY1ZUQmY/P1ZhSXxXdkZiXX5YdXdQQGZfWEA=");
            MainPage = new AppShell();

        }

        protected async override void OnStart()
        {
            WorkoutsPageViewModel viewModel = new();
            await viewModel.GetWorkouts();
        }
    }
}
