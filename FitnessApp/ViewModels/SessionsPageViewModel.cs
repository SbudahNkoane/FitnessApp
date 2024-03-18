using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessApp.Models;
using FitnessApp.Services.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.ViewModels
{
    public partial class SessionsPageViewModel:ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Session> sessions;

        [ObservableProperty]
        bool isLoading;

        readonly SessionRepository sessionRepository = new();

        public SessionsPageViewModel()
        {
            sessions = [];
        }
        [RelayCommand]
        public async Task GetSessions()
        {
            IsLoading = true;
            var listOfSessions = await sessionRepository.GetSessions();

            //after getting the data from the api, update the observable collection
            foreach (var session in listOfSessions)
            {
                Sessions.Add(session);
            }
            IsLoading = false;
        }
    }
}
