using System;

namespace BasicFacebookFeatures
{
    public class Workout
    {
        public decimal Duration { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Calories { get; set; }
        public Workout() { }
        public Workout(decimal i_Duration, string i_Catergory, DateTime i_DateTime, decimal i_Calories)
        {
            Duration = i_Duration;
            Category = i_Catergory;
            Date = i_DateTime;
            Calories = i_Calories;
        }
    }
}