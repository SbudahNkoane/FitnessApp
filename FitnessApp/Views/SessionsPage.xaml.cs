using FitnessApp.ViewModels;

namespace FitnessApp.Views;

public partial class SessionsPage : ContentPage
{
	public SessionsPage(SessionsPageViewModel sessionPageViewModel)
	{
		InitializeComponent();
		sessionPageViewModel.GetSessions();
		BindingContext = sessionPageViewModel;
	}

   
}