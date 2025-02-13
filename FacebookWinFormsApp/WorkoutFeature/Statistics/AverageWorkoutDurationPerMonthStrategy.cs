using BasicFacebookFeatures;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;
namespace BasicFacebookFeatures
{
    public class AverageWorkoutDurationPerMonthStrategy : IWorkoutStatisticStrategy
    {
        public Dictionary<int, int> Calculate(DataGridView i_WorkoutTable)
        {
            Dictionary<int, List<int>> durationPerMonth = new Dictionary<int, List<int>>();
            Dictionary<int, int> avgDurationPerMonth = new Dictionary<int, int>();

            foreach (DataGridViewRow row in i_WorkoutTable.Rows)
            {
                if (row.Cells["Date"]?.Value != null && row.Cells["Duration"]?.Value != null)
                {
                    DateTime workoutDate = Convert.ToDateTime(row.Cells["Date"].Value);
                    int month = workoutDate.Month;
                    int duration = Convert.ToInt32(row.Cells["Duration"].Value);

                    if (!durationPerMonth.ContainsKey(month))
                    {
                        durationPerMonth[month] = new List<int>();
                    }
                    durationPerMonth[month].Add(duration);
                }
            }

            foreach (var entry in durationPerMonth)
            {
                avgDurationPerMonth[entry.Key] = (int)entry.Value.Average();
            }

            return avgDurationPerMonth;
        }
    }
}