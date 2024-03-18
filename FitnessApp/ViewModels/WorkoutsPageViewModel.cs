using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessApp.Models;
using FitnessApp.Services.Repository;
using System.Collections.ObjectModel;

namespace FitnessApp.ViewModels
{
    public partial class WorkoutsPageViewModel : ObservableObject
    {
        public WorkoutsPageViewModel()
        {
            workouts = [];


        }
        [ObservableProperty]
        private ObservableCollection<Workout> workouts;
        [ObservableProperty]
        private ObservableCollection<Workout> data = [
                new Workout()
        {
            Type = "Running",
                     AverageHeartRate = 20,
                     CaloriesBurned = 30,
                     Duration = 40,
                     Distance = 50,
                     Date =DateOnly.FromDateTime(DateTime.Now),
                },
                new Workout()
        {
            Type = "Running",
                     AverageHeartRate = 43,
                     CaloriesBurned = 23,
                     Duration = 20,
                     Distance = 60,
                     Date = DateOnly.FromDateTime(DateTime.Now),
                },
            ];

        [ObservableProperty]
        bool isLoading;



        readonly WorkoutRepository workoutRepository = new();


        [RelayCommand]
        public async Task GetWorkouts()
        {
            IsLoading = true;
            var listOfWorkouts = await workoutRepository.GetWorkouts();

            //after getting the data from the api, update the observable collection
            foreach (var workout in listOfWorkouts)
            {
                Workouts.Add(workout);
            }

            IsLoading = false;

        }



    }
}
