using Newtonsoft.Json.Linq;

namespace FitnessApp.Models
{
    //"date": "2024-03-01",
    //"type": "Running",
    //"duration": 30, 
    //"distance": 5, 
    //"caloriesBurned": 300,
    //"averageHeartRate": 150 
    public class WorkoutRoot
    {
        public List<Workout> workouts { get; set; }
    }
    public class Workout
    {
        public DateOnly Date { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public double Distance { get; set; }
        public int CaloriesBurned { get; set; }
        public int AverageHeartRate { get; set; }
       
           
        

    }
}
