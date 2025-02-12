namespace BasicFacebookFeatures
{
    partial class StatisicsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaAmountOfWorkouts = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaCaloriesOfWorkouts = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlStatistics = new System.Windows.Forms.TabControl();
            this.amountTab = new System.Windows.Forms.TabPage();
            this.timeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAmountTimesHeader = new System.Windows.Forms.Label();
            this.caloriesTab = new System.Windows.Forms.TabPage();
            this.labelCaloriesChartHeader = new System.Windows.Forms.Label();
            this.caloriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlStatistics.SuspendLayout();
            this.amountTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).BeginInit();
            this.caloriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStatistics
            // 
            this.tabControlStatistics.Controls.Add(this.amountTab);
            this.tabControlStatistics.Controls.Add(this.caloriesTab);
            this.tabControlStatistics.Location = new System.Drawing.Point(12, 12);
            this.tabControlStatistics.Name = "tabControlStatistics";
            this.tabControlStatistics.SelectedIndex = 0;
            this.tabControlStatistics.Size = new System.Drawing.Size(551, 540);
            this.tabControlStatistics.TabIndex = 0;
            // 
            // amountTab
            // 
            this.amountTab.Controls.Add(this.timeChart);
            this.amountTab.Controls.Add(this.labelAmountTimesHeader);
            this.amountTab.Location = new System.Drawing.Point(4, 25);
            this.amountTab.Name = "amountTab";
            this.amountTab.Padding = new System.Windows.Forms.Padding(3);
            this.amountTab.Size = new System.Drawing.Size(543, 511);
            this.amountTab.TabIndex = 0;
            this.amountTab.Text = "By Amount";
            this.amountTab.UseVisualStyleBackColor = true;
            // 
            // timeChart
            // 
            chartAreaAmountOfWorkouts.Name = "ChartArea1";
            this.timeChart.ChartAreas.Add(chartAreaAmountOfWorkouts);
            legend1.Name = "Legend1";
            this.timeChart.Legends.Add(legend1);
            this.timeChart.Location = new System.Drawing.Point(34, 73);
            this.timeChart.Name = "timeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount";
            this.timeChart.Series.Add(series1);
            this.timeChart.Size = new System.Drawing.Size(503, 435);
            this.timeChart.TabIndex = 2;
            this.timeChart.Text = "chart2";
            // 
            // labelAmountTimesHeader
            // 
            this.labelAmountTimesHeader.AutoSize = true;
            this.labelAmountTimesHeader.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountTimesHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAmountTimesHeader.Location = new System.Drawing.Point(127, 15);
            this.labelAmountTimesHeader.Name = "labelAmountTimesHeader";
            this.labelAmountTimesHeader.Size = new System.Drawing.Size(293, 54);
            this.labelAmountTimesHeader.TabIndex = 1;
            this.labelAmountTimesHeader.Text = "How Many Times\r\n Do You Workout Each Month?";
            this.labelAmountTimesHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // caloriesTab
            // 
            this.caloriesTab.Controls.Add(this.labelCaloriesChartHeader);
            this.caloriesTab.Controls.Add(this.caloriesChart);
            this.caloriesTab.Location = new System.Drawing.Point(4, 25);
            this.caloriesTab.Name = "caloriesTab";
            this.caloriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.caloriesTab.Size = new System.Drawing.Size(543, 511);
            this.caloriesTab.TabIndex = 1;
            this.caloriesTab.Text = "By Calories";
            this.caloriesTab.UseVisualStyleBackColor = true;
            // 
            // labelCaloriesChartHeader
            // 
            this.labelCaloriesChartHeader.AutoSize = true;
            this.labelCaloriesChartHeader.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaloriesChartHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCaloriesChartHeader.Location = new System.Drawing.Point(127, 15);
            this.labelCaloriesChartHeader.Name = "labelCaloriesChartHeader";
            this.labelCaloriesChartHeader.Size = new System.Drawing.Size(261, 54);
            this.labelCaloriesChartHeader.TabIndex = 2;
            this.labelCaloriesChartHeader.Text = "How Many Calories\r\n Do You Burn Each Month?";
            this.labelCaloriesChartHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // caloriesChart
            // 
            chartAreaCaloriesOfWorkouts.Name = "ChartArea1";
            this.caloriesChart.ChartAreas.Add(chartAreaCaloriesOfWorkouts);
            legend2.Name = "Legend1";
            this.caloriesChart.Legends.Add(legend2);
            this.caloriesChart.Location = new System.Drawing.Point(34, 73);
            this.caloriesChart.Name = "caloriesChart";
            this.caloriesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Calories";
            this.caloriesChart.Series.Add(series2);
            this.caloriesChart.Size = new System.Drawing.Size(503, 435);
            this.caloriesChart.TabIndex = 0;
            this.caloriesChart.Text = "chart2";
            // 
            // StatisicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 567);
            this.Controls.Add(this.tabControlStatistics);
            this.Name = "StatisicsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statisics By Month";
            this.tabControlStatistics.ResumeLayout(false);
            this.amountTab.ResumeLayout(false);
            this.amountTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).EndInit();
            this.caloriesTab.ResumeLayout(false);
            this.caloriesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStatistics;
        private System.Windows.Forms.TabPage amountTab;
        private System.Windows.Forms.TabPage caloriesTab;
        private System.Windows.Forms.Label labelAmountTimesHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart caloriesChart;
        private System.Windows.Forms.Label labelCaloriesChartHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
    }
}