using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models
{
    //{
    //    "date": "2024-03-02",
    //    "type": "Weightlifting",
    //    "exercises": [
    //      {
    //        "name": "Bench Press",
    //        "sets": 3,
    //        "reps": 12,
    //        "weight": 60 
    //      },
    //      {
    //        "name": "Squats",
    //        "sets": 4,
    //        "reps": 10,
    //        "weight": 80
    //      }
    //    ],
    //    "duration": 60, 
    //    "caloriesBurned": 350
    //  },
    public class SessionRoot
    {
        public List<Session>? sessions { get; set; }
    }
    public  class Session
    {
        public DateOnly Date { get; set; }
        public string? Type { get; set; }
        public List<Exercise> Exercises { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned { get; set; }

    }
}
