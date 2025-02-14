using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class StatisicsForm : Form
    {
        private readonly DataGridView r_WorkoutTable;
        private IWorkoutStatisticStrategy m_CurrentStrategy;

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
            Dictionary<int, int> data = m_CurrentStrategy.Calculate(r_WorkoutTable);

            displayChart(data);
        }
        private void displayChart(Dictionary<int, int> i_Data)
        {
            if (statisticsChart.Series.Count == 0)
            {
                statisticsChart.Series.Add("Data");
            }

            statisticsChart.Series[0].Points.Clear();
            statisticsChart.Series[0].BorderWidth = 3;
            statisticsChart.Series[0].IsValueShownAsLabel = true;
            Dictionary<int, string> xAxisLabels = generateXAxisLabels(i_Data);

            foreach (var entry in i_Data)
            {
                DataPoint point = new DataPoint(entry.Key, entry.Value)
                {
                    AxisLabel = xAxisLabels.ContainsKey(entry.Key) ? xAxisLabels[entry.Key] : entry.Key.ToString(),
                    ToolTip = $"Value: {entry.Value}"
                };

                statisticsChart.Series[0].Points.Add(point);
            }

            formatChart();
            setChartColor();
        }
        private Dictionary<int, string> generateXAxisLabels(Dictionary<int, int> i_Data)
        {
            Dictionary<int, string> labels = new Dictionary<int, string>();

            if (m_CurrentStrategy is CaloriesPerMonthStrategy || m_CurrentStrategy is WorkoutCountPerMonthStrategy)
            {
                string[] monthNames = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                foreach (var entry in i_Data)
                {
                    labels[entry.Key] = monthNames[entry.Key];
                }
            }
            else if (m_CurrentStrategy is CaloriesPerDayStrategy)
            {
                foreach (var entry in i_Data)
                {
                    DateTime date = DateTime.Today.AddDays(entry.Key - DateTime.Today.Day);

                    labels[entry.Key] = date.ToString("dddd");
                }
            }
            else if (m_CurrentStrategy is WorkoutFrequencyPerWeekStrategy)
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
            if (m_CurrentStrategy is CaloriesPerMonthStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Green;
            }
            else if (m_CurrentStrategy is WorkoutCountPerMonthStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Blue;
            }
            else if (m_CurrentStrategy is CaloriesPerDayStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Orange;
            }
            else if (m_CurrentStrategy is WorkoutFrequencyPerWeekStrategy)
            {
                statisticsChart.Series[0].Color = System.Drawing.Color.Purple;
            }
            else if (m_CurrentStrategy is AverageWorkoutDurationPerMonthStrategy)
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
                        m_CurrentStrategy = new CaloriesPerMonthStrategy();
                        labelChartTitle.Text = "How Many Calories\r\n Do You Burn Each Month?";
                        this.Text = "Statistics - Calories Per Month";
                        break;
                    }
                case "Workout Count Per Month":
                    {
                        m_CurrentStrategy = new WorkoutCountPerMonthStrategy();
                        labelChartTitle.Text = "How Many Times\r\n Do You Workout Each Month?";
                        this.Text = "Statistics - Workouts Per Month";
                        break;
                    }
                case "Calories Per Day":
                    {
                        m_CurrentStrategy = new CaloriesPerDayStrategy();
                        labelChartTitle.Text = "How Many Calories\r\n Do You Burn Each Day?";
                        this.Text = "Statistics - Calories Per Day";
                        break;
                    }
                case "Workout Frequency Per Week":
                    {
                        m_CurrentStrategy = new WorkoutFrequencyPerWeekStrategy();
                        labelChartTitle.Text = "How Often\r\n Do You Workout Each Week?";
                        this.Text = "Statistics - Workouts Per Week";
                        break;
                    }
                case "Average Workout Duration Per Month":
                    {
                        m_CurrentStrategy = new AverageWorkoutDurationPerMonthStrategy();
                        labelChartTitle.Text = "What is Your\r\n Average Workout Duration?";
                        this.Text = "Statistics - Avg Duration Per Month";
                        break;
                    }
            }

            generateWorkoutStatistics();
        }
    }
}