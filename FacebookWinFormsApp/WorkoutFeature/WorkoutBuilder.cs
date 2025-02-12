using System;

namespace BasicFacebookFeatures
{
    public class WorkoutBuilder : IWorkoutBuilder
    {
        private Workout m_Workout;

        public WorkoutBuilder()
        {
            m_Workout = new Workout();
        }
        public void SetDuration(decimal i_Duration)
        {
            if (i_Duration <= 0)
            {
                throw new ArgumentException("Duration must be greater than 0.");
            }

            m_Workout.Duration = i_Duration;
        }
        public void SetCategory(string i_Category)
        {
            if (string.IsNullOrWhiteSpace(i_Category))
            {
                throw new ArgumentException("Category cannot be null or empty.");
            }

            m_Workout.Category = i_Category;
        }
        public void SetDate(DateTime i_Date)
        {
            if (i_Date > DateTime.Now)
            {
                throw new ArgumentException("Date cannot be in the future.");
            }

            m_Workout.Date = i_Date;
        }
        public void SetCalories(decimal i_Calories)
        {
            if (i_Calories <= 0)
            {
                throw new ArgumentException("Calories must be greater than 0.");
            }

            m_Workout.Calories = i_Calories;
        }
        public Workout GetWorkout()
        {
            Workout result = m_Workout;

            m_Workout = new Workout();

            return result;
        }
    }
}
