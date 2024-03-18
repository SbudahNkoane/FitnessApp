using FitnessApp.Constants;
using FitnessApp.Models;
using FitnessApp.Services.Interface;
using Newtonsoft.Json;


namespace FitnessApp.Services.Repository
{
    class WorkoutRepository : IWorkoutRepository
    {
        readonly HttpClient httpClient;
        readonly AppConstants appConstants;
        public WorkoutRepository()
        {
            appConstants = new AppConstants();
            httpClient = new HttpClient();
        }
        public async Task<IEnumerable<Workout>> GetWorkouts()
        {
            try
            {
                //inizialize endpoint
                string workOutsUrl = $"{appConstants.baseUrl}/Workouts";

                //set the base address
                httpClient.BaseAddress = new Uri(workOutsUrl);

                //send a request to the server
                HttpResponseMessage response = await httpClient.GetAsync(httpClient.BaseAddress);

                //read the content of the response
                var content = await response.Content.ReadAsStringAsync();

                WorkoutRoot? workouts = JsonConvert.DeserializeObject<WorkoutRoot>(content.ToString());

                if (workouts != null)
                {
                   
                    return await Task.FromResult(workouts.workouts);
                }


            }//end try
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
            }

            return [];
        }
    }
}
