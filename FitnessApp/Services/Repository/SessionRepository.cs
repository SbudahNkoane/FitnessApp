using FitnessApp.Constants;
using FitnessApp.Models;
using FitnessApp.Services.Interface;
using Newtonsoft.Json;

namespace FitnessApp.Services.Repository
{
    internal class SessionRepository : ISessionRepository
    {
        readonly HttpClient httpClient;
        readonly AppConstants appConstants;
        public SessionRepository()
        {
            appConstants = new AppConstants();
            httpClient = new HttpClient();
        }
        public async Task<IEnumerable<Session>> GetSessions()
        {
            try
            {
                //inizialize endpoint
                string sessionsUrl = $"{appConstants.baseUrl}/Sessions";

                httpClient.BaseAddress = new Uri(sessionsUrl);
                HttpResponseMessage response = await httpClient.GetAsync(sessionsUrl);

                var content = await response.Content.ReadAsStringAsync();

                SessionRoot? sessionRoot = JsonConvert.DeserializeObject<SessionRoot>(content);

                if (sessionRoot != null)
                {
                    return await Task.FromResult(sessionRoot.sessions);
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
            }
            return [];
        } 
       
    }
}
