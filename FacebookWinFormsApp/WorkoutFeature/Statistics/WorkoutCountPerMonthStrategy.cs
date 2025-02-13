using BasicFacebookFeatures;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace BasicFacebookFeatures
{
    public class WorkoutCountPerMonthStrategy : IWorkoutStatisticStrategy
    {
        public Dictionary<int, int> Calculate(DataGridView i_WorkoutTable)
        {
            Dictionary<int, int> workoutCountPerMonth = new Dictionary<int, int>();

            foreach (DataGridViewRow row in i_WorkoutTable.Rows)
            {
                if (row.Cells["Date"]?.Value != null)
                {
                    DateTime workoutDate = Convert.ToDateTime(row.Cells["Date"].Value);
                    int month = workoutDate.Month;

                    if (workoutCountPerMonth.ContainsKey(month))
                    {
                        workoutCountPerMonth[month]++;
                    }
                    else
                    {
                        workoutCountPerMonth[month] = 1;
                    }
                }
            }
            return workoutCountPerMonth;
        }
    }
}