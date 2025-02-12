namespace BasicFacebookFeatures
{
    partial class AddWorkoutForm
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
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxWorkoutCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerWorkout = new System.Windows.Forms.DateTimePicker();
            this.buttonAddWorkout = new System.Windows.Forms.Button();
            this.labelChooseDate = new System.Windows.Forms.Label();
            this.labelAddCalories = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCalories = new System.Windows.Forms.NumericUpDown();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelAddWorkoutHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelCategory.Location = new System.Drawing.Point(99, 79);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 20);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            // 
            // comboBoxWorkoutCategory
            // 
            this.comboBoxWorkoutCategory.FormattingEnabled = true;
            this.comboBoxWorkoutCategory.Items.AddRange(new object[] {
            "Cardio",
            "Running",
            "Cycling",
            "Swimming",
            "Walking",
            "Jump Rope",
            "Hiking",
            "Weightlifting",
            "Bodyweight",
            "Powerlifting",
            "CrossFit",
            "Yoga & Flexibility",
            "Hatha Yoga",
            "Vinyasa Yoga",
            "Pilates",
            "Basketball",
            "Soccer",
            "Tennis",
            "Football",
            "Baseball",
            "Golf",
            "HIIT (High-Intensity Interval Training)",
            "Tabata",
            "Core & Abs",
            "Dance",
            "Zumba"});
            this.comboBoxWorkoutCategory.Location = new System.Drawing.Point(81, 102);
            this.comboBoxWorkoutCategory.Name = "comboBoxWorkoutCategory";
            this.comboBoxWorkoutCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWorkoutCategory.TabIndex = 3;
            this.comboBoxWorkoutCategory.TextChanged += new System.EventHandler(this.comboBoxWorkoutCategory_TextChanged);
            // 
            // dateTimePickerWorkout
            // 
            this.dateTimePickerWorkout.Location = new System.Drawing.Point(43, 172);
            this.dateTimePickerWorkout.Name = "dateTimePickerWorkout";
            this.dateTimePickerWorkout.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerWorkout.TabIndex = 4;
            this.dateTimePickerWorkout.ValueChanged += new System.EventHandler(this.dateTimePickerWorkout_ValueChanged);
            // 
            // buttonAddWorkout
            // 
            this.buttonAddWorkout.Enabled = false;
            this.buttonAddWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAddWorkout.Location = new System.Drawing.Point(103, 349);
            this.buttonAddWorkout.Name = "buttonAddWorkout";
            this.buttonAddWorkout.Size = new System.Drawing.Size(58, 34);
            this.buttonAddWorkout.TabIndex = 6;
            this.buttonAddWorkout.Text = "Add";
            this.buttonAddWorkout.UseVisualStyleBackColor = true;
            this.buttonAddWorkout.Click += new System.EventHandler(this.buttonAddWorkout_Click);
            // 
            // labelChooseDate
            // 
            this.labelChooseDate.AutoSize = true;
            this.labelChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelChooseDate.Location = new System.Drawing.Point(57, 149);
            this.labelChooseDate.Name = "labelChooseDate";
            this.labelChooseDate.Size = new System.Drawing.Size(179, 20);
            this.labelChooseDate.TabIndex = 7;
            this.labelChooseDate.Text = "Choose Workout Date:";
            // 
            // labelAddCalories
            // 
            this.labelAddCalories.AutoSize = true;
            this.labelAddCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelAddCalories.Location = new System.Drawing.Point(88, 219);
            this.labelAddCalories.Name = "labelAddCalories";
            this.labelAddCalories.Size = new System.Drawing.Size(107, 20);
            this.labelAddCalories.TabIndex = 8;
            this.labelAddCalories.Text = "Add calories:";
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(80, 311);
            this.numericUpDownDuration.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDuration.TabIndex = 9;
            this.numericUpDownDuration.ValueChanged += new System.EventHandler(this.numericUpDownDuration_ValueChanged);
            // 
            // numericUpDownCalories
            // 
            this.numericUpDownCalories.Location = new System.Drawing.Point(81, 242);
            this.numericUpDownCalories.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownCalories.Name = "numericUpDownCalories";
            this.numericUpDownCalories.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCalories.TabIndex = 10;
            this.numericUpDownCalories.ValueChanged += new System.EventHandler(this.numericUpDownCalories_ValueChanged);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelDuration.Location = new System.Drawing.Point(63, 288);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(154, 20);
            this.labelDuration.TabIndex = 11;
            this.labelDuration.Text = "Duration (Minutes):";
            // 
            // labelAddWorkoutHeader
            // 
            this.labelAddWorkoutHeader.AutoSize = true;
            this.labelAddWorkoutHeader.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelAddWorkoutHeader.Location = new System.Drawing.Point(61, 33);
            this.labelAddWorkoutHeader.Name = "labelAddWorkoutHeader";
            this.labelAddWorkoutHeader.Size = new System.Drawing.Size(160, 33);
            this.labelAddWorkoutHeader.TabIndex = 1;
            this.labelAddWorkoutHeader.Text = "Add Workout";
            // 
            // AddWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 411);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.numericUpDownCalories);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.labelAddCalories);
            this.Controls.Add(this.labelChooseDate);
            this.Controls.Add(this.buttonAddWorkout);
            this.Controls.Add(this.dateTimePickerWorkout);
            this.Controls.Add(this.comboBoxWorkoutCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelAddWorkoutHeader);
            this.Name = "AddWorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Workout";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxWorkoutCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkout;
        private System.Windows.Forms.Button buttonAddWorkout;
        private System.Windows.Forms.Label labelChooseDate;
        private System.Windows.Forms.Label labelAddCalories;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.NumericUpDown numericUpDownCalories;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelAddWorkoutHeader;
    }
}