using BasicFacebookFeatures;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace BasicFacebookFeatures
{
    public class WorkoutFrequencyPerWeekStrategy : IWorkoutStatisticStrategy
    {
        public Dictionary<int, int> Calculate(DataGridView i_WorkoutTable)
        {
            Dictionary<int, int> workoutCountPerWeek = new Dictionary<int, int>();

            foreach (DataGridViewRow row in i_WorkoutTable.Rows)
            {
                if (row.Cells["Date"]?.Value != null)
                {
                    DateTime workoutDate = Convert.ToDateTime(row.Cells["Date"].Value);
                    int week = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear
                              (workoutDate, System.Globalization.CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);

                    if (workoutCountPerWeek.ContainsKey(week))
                    {
                        workoutCountPerWeek[week]++;
                    }
                    else
                    {
                        workoutCountPerWeek[week] = 1;
                    }
                }
            }
            return workoutCountPerWeek;
        }
    }
}