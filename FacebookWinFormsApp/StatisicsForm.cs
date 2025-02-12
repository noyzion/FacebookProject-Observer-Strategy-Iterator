using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class StatisicsForm : Form
    {
        private readonly DataGridView r_WorkoutTable;
        private const int k_LabelAngle = -45;
        public StatisicsForm(DataGridView i_WorkoutTable)
        {
            InitializeComponent();
            r_WorkoutTable = i_WorkoutTable;
            generateWorkoutStatistics();
        }
        private void generateWorkoutStatistics()
        {
            Dictionary<int, int> caloriesPerMonth = calculateCaloriesPerMonth();
            Dictionary<int, int> workoutCountPerMonth = calculateWorkoutCountPerMonth();

            displayCharts(caloriesPerMonth, workoutCountPerMonth);
        }
        private Dictionary<int, int> calculateCaloriesPerMonth()
        {
            Dictionary<int, int> caloriesPerMonth = new Dictionary<int, int>();

            foreach (DataGridViewRow row in r_WorkoutTable.Rows)
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
        private Dictionary<int, int> calculateWorkoutCountPerMonth()
        {
            Dictionary<int, int> workoutCountPerMonth = new Dictionary<int, int>();

            foreach (DataGridViewRow row in r_WorkoutTable.Rows)
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
        private void displayCharts(Dictionary<int, int> i_CaloriesPerMonth, Dictionary<int, int> i_WorkoutCountPerMonth)
        {
            string[] monthNames = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            caloriesChart.Series["Calories"].Points.Clear();
            timeChart.Series["Amount"].Points.Clear();

            var months = i_WorkoutCountPerMonth.Keys
                           .Union(i_CaloriesPerMonth.Keys)
                           .Distinct()
                           .OrderBy(m => m);

            foreach (var month in months)
            {
                string monthName = monthNames[month - 1];
                int caloriesForMonth = i_CaloriesPerMonth.ContainsKey(month) ? i_CaloriesPerMonth[month] : 0;
                int workoutCountForMonth = i_WorkoutCountPerMonth.ContainsKey(month) ? i_WorkoutCountPerMonth[month] : 0;

                if (caloriesForMonth > 0)
                {
                    caloriesChart.Series["Calories"].Points.AddXY(monthName, caloriesForMonth);
                }
                if (workoutCountForMonth > 0)
                {
                    timeChart.Series["Amount"].Points.AddXY(monthName, workoutCountForMonth);
                }
            }

            caloriesChart.ChartAreas[0].AxisX.LabelStyle.Angle = -k_LabelAngle;
            timeChart.ChartAreas[0].AxisX.LabelStyle.Angle = -k_LabelAngle;
        }
    }
}