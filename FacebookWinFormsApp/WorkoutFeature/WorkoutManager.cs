using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class WorkoutManager
    {
        public List<Workout> Workouts { get; set; }
        private readonly string[] r_ColumnNames = { "Category", "Duration", "Calories", "Date" };

        public DataGridView InitializeWorkoutTable()
        {
            DataGridView workoutTable = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            foreach (string columnName in r_ColumnNames)
            {
                workoutTable.Columns.Add(columnName, columnName);
            }

            return workoutTable;
        }
        public void FetchWorkoutData(DataGridView i_WorkoutTable)
        {
            i_WorkoutTable.Rows.Clear();
            if (Workouts != null)
            {
                foreach (Workout workout in Workouts)
                {
                    i_WorkoutTable.Rows.Add(
                        workout.Category,
                        workout.Duration,
                        workout.Calories,
                        workout.Date.ToString("yyyy-MM-dd")
                    );
                }
            }
        }
        public string GenerateWorkoutsSummary()
        {
            if (Workouts == null || Workouts.Count == 0)
            {
                return "No workouts available to share.";
            }

            StringBuilder summaryBuilder = new StringBuilder();

            summaryBuilder.AppendLine("My Recent Workouts:");
            foreach (Workout workout in Workouts)
            {
                summaryBuilder.AppendLine($"- {workout.Category}: {workout.Duration} mins, " +
                                          $"{workout.Calories} cal on {workout.Date:yyyy-MM-dd}");
            }

            return summaryBuilder.ToString();
        }
    }
}
