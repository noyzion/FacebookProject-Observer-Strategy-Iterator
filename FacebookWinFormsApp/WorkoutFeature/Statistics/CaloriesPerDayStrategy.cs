using BasicFacebookFeatures;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

public class CaloriesPerDayStrategy : IWorkoutStatisticStrategy
{
    public Dictionary<int, int> Calculate(DataGridView workoutTable)
    {
        Dictionary<int, int> caloriesPerDay = new Dictionary<int, int>();

        foreach (DataGridViewRow row in workoutTable.Rows)
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
