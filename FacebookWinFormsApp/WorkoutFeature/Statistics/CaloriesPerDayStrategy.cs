using BasicFacebookFeatures;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
namespace BasicFacebookFeatures
{
    public class CaloriesPerDayStrategy : IWorkoutStatisticStrategy
    {
        public Dictionary<int, int> Calculate(DataGridView i_WorkoutTable)
        {
            Dictionary<int, int> caloriesPerDay = new Dictionary<int, int>();

            foreach (DataGridViewRow row in i_WorkoutTable.Rows)
            {
                if (row.Cells["Date"]?.Value != null && row.Cells["Calories"]?.Value != null)
                {
                    DateTime workoutDate = Convert.ToDateTime(row.Cells["Date"].Value);
                    int day = workoutDate.Day;
                    int calories = Convert.ToInt32(row.Cells["Calories"].Value);

                    if (caloriesPerDay.ContainsKey(day))
                    {
                        caloriesPerDay[day] += calories;
                    }
                    else
                    {
                        caloriesPerDay[day] = calories;
                    }
                }
            }
            return caloriesPerDay;
        }
    }
}
