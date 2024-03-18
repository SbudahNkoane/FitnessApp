using FitnessApp.ViewModels;

namespace FitnessApp.Views;

public partial class WorkoutsPage : ContentPage
{


    public WorkoutsPage(WorkoutsPageViewModel vm)
    {
        InitializeComponent();

        //get the list when this page is called if Workouts are empty
        vm.GetWorkouts();


        BindingContext = vm;

    }


}