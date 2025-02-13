using BasicFacebookFeatures;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

public class CaloriesPerMonthStrategy : IWorkoutStatisticStrategy
{
    public Dictionary<int, int> Calculate(DataGridView workoutTable)
    {
        Dictionary<int, int> caloriesPerMonth = new Dictionary<int, int>();

        foreach (DataGridViewRow row in workoutTable.Rows)
        {
            if (row.Cells["Date"]?.Value != null && row.Cells["Calories"]?.Value != null)
            {
                DateTime workoutDate = Convert.ToDateTime(row.Cells["Date"].Value);
                int month = workoutDate.Month;
                int calories = Convert.ToInt32(row.Cells["Calories"].Value);

                if (caloriesPerMonth.ContainsKey(month))
                {
                    caloriesPerMonth[month] += calories;
                }
                else
                {
                    caloriesPerMonth[month] = calories;
                }
            }
        }
        return caloriesPerMonth;
    }
}
