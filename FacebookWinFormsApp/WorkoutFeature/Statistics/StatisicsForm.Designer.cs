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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlStatistics = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChartTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.tabControlStatistics.SuspendLayout();
            this.mainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStatistics
            // 
            this.tabControlStatistics.Controls.Add(this.mainTab);
            this.tabControlStatistics.Location = new System.Drawing.Point(12, 12);
            this.tabControlStatistics.Name = "tabControlStatistics";
            this.tabControlStatistics.SelectedIndex = 0;
            this.tabControlStatistics.Size = new System.Drawing.Size(634, 627);
            this.tabControlStatistics.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.labelCategory);
            this.mainTab.Controls.Add(this.title);
            this.mainTab.Controls.Add(this.comboBoxSelect);
            this.mainTab.Controls.Add(this.statisticsChart);
            this.mainTab.Controls.Add(this.labelChartTitle);
            this.mainTab.Location = new System.Drawing.Point(4, 25);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(626, 598);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Statistics";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(493, 533);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 16);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Category:";
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "Calories Per Month",
            "Workout Count Per Month",
            "Calories Per Day",
            "Workout Frequency Per Week",
            "Average Workout Duration Per Month"});
            this.comboBoxSelect.Location = new System.Drawing.Point(438, 552);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(165, 24);
            this.comboBoxSelect.TabIndex = 3;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // statisticsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend1);
            this.statisticsChart.Location = new System.Drawing.Point(25, 95);
            this.statisticsChart.Name = "statisticsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount";
            this.statisticsChart.Series.Add(series1);
            this.statisticsChart.Size = new System.Drawing.Size(564, 435);
            this.statisticsChart.TabIndex = 2;
            // 
            // labelChartTitle
            // 
            this.labelChartTitle.AutoSize = true;
            this.labelChartTitle.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelChartTitle.Location = new System.Drawing.Point(127, 15);
            this.labelChartTitle.Name = "labelChartTitle";
            this.labelChartTitle.Size = new System.Drawing.Size(0, 27);
            this.labelChartTitle.TabIndex = 1;
            this.labelChartTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 23);
            this.title.TabIndex = 6;
            // 
            // StatisicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 651);
            this.Controls.Add(this.tabControlStatistics);
            this.Name = "StatisicsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tabControlStatistics.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStatistics;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Label labelChartTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label title;
    }
}