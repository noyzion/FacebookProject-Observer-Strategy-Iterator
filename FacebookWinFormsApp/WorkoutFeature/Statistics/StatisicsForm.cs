using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class StatisicsForm : Form
    {
        private readonly DataGridView r_WorkoutTable;
        private IWorkoutStatisticStrategy currentStrategy;

        public StatisicsForm(DataGridView i_WorkoutTable)
        {
            InitializeComponent();
            r_WorkoutTable = i_WorkoutTable;
            if (comboBoxSelect.Items.Count > 0)
            {
                comboBoxSelect.SelectedIndex = 0;
            }
        }
        private void generateWorkoutStatistics()
        {
            Dictionary<int, int> data = currentStrategy.Calculate(r_WorkoutTable);
            displayChart(data);
        }

        private void displayChart(Dictionary<int, int> i_Data)
        {
            statisticsChart.Series.Clear();
            Series series = createSeries();

            Dictionary<int, string> xAxisLabels = generateXAxisLabels(i_Data);

            foreach (var entry in i_Data)
            {
                DataPoint point = new DataPoint(entry.Key, entry.Value)
                {
                    AxisLabel = xAxisLabels.ContainsKey(entry.Key) ? xAxisLabels[entry.Key] : entry.Key.ToString(),
                    ToolTip = $"Value: {entry.Value}"
                };
                series.Points.Add(point);
            }

            statisticsChart.Series.Add(series);
            formatChart();
            setChartColor();
        }

        private Series createSeries()
        {
            return new Series("Data")
            {
                BorderWidth = 3,
                IsValueShownAsLabel = true
            };
        }

        private Dictionary<int, string> generateXAxisLabels(Dictionary<int, int> i_Data)
        {
            Dictionary<int, string> labels = new Dictionary<int, string>();

            if (currentStrategy is CaloriesPerMonthStrategy || currentStrategy is WorkoutCountPerMonthStrategy)
            {
                string[] monthNames = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                foreach (var entry in i_Data)
                {
                    labels[entry.Key] = monthNames[entry.Key];
                }
            }
            else if (currentStrategy is CaloriesPerDayStrategy)
            {
                foreach (var entry in i_Data)
                {
                    DateTime date = DateTime.Today.AddDays(entry.Key - DateTime.Today.Day);
                    labels[entry.Key] = date.ToString("dddd");
                }
            }
            else if (currentStrategy is WorkoutFrequencyPerWeekStrategy)
            {
                foreach (var entry in i_Data)
                {
                    labels[entry.Key] = $"Week {entry.Key}";
                }
            }
            else
            {
                foreach (var entry in i_Data)
                {
                    labels[entry.Key] = entry.Key.ToString();
                }
            }

            return labels;
        }
        private void formatChart()
        {
            statisticsChart.ChartAreas[0].AxisX.Interval = 1;
            statisticsChart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            statisticsChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            statisticsChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            statisticsChart.ChartAreas[0].RecalculateAxesScale();
            statisticsChart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            statisticsChart.Legends[0].Enabled = true;
            statisticsChart.Legends[0].Docking = Docking.Bottom;
        }
        private void setChartColor()
        {
            if (currentStrategy is CaloriesPerMonthStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Green;
            }
            else if (currentStrategy is WorkoutCountPerMonthStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Blue;
            }
            else if (currentStrategy is CaloriesPerDayStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Orange;
            }
            else if (currentStrategy is WorkoutFrequencyPerWeekStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Purple;
            }
            else if (currentStrategy is AverageWorkoutDurationPerMonthStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.DarkCyan;
            }
        }
        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStat = comboBoxSelect.SelectedItem.ToString();

            switch (selectedStat)
            {
                case "Calories Per Month":
                    {
                        currentStrategy = new CaloriesPerMonthStrategy();
                        labelChartTitle.Text = "How Many Calories\r\n Do You Burn Each Month?";
                        this.Text = "Statistics - Calories Per Month";
                        break;
                    }
                case "Workout Count Per Month":
                    {
                        currentStrategy = new WorkoutCountPerMonthStrategy();
                        labelChartTitle.Text = "How Many Times\r\n Do You Workout Each Month?";
                        this.Text = "Statistics - Workouts Per Month";
                        break;
                    }
                case "Calories Per Day":
                    {
                        currentStrategy = new CaloriesPerDayStrategy();
                        labelChartTitle.Text = "How Many Calories\r\n Do You Burn Each Day?";
                        this.Text = "Statistics - Calories Per Day";
                        break;
                    }
                case "Workout Frequency Per Week":
                    {
                        currentStrategy = new WorkoutFrequencyPerWeekStrategy();
                        labelChartTitle.Text = "How Often\r\n Do You Workout Each Week?";
                        this.Text = "Statistics - Workouts Per Week";
                        break;
                    }
                case "Average Workout Duration Per Month":
                    {
                        currentStrategy = new AverageWorkoutDurationPerMonthStrategy();
                        labelChartTitle.Text = "What is Your\r\n Average Workout Duration?";
                        this.Text = "Statistics - Avg Duration Per Month";
                        break;
                    }
            }

            generateWorkoutStatistics();
        }
    }
}