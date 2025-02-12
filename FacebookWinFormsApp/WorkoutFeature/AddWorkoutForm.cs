using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class AddWorkoutForm : Form
    {
        private bool m_CategoryChanged;
        private bool m_DateTimeChanged;
        private bool m_CaloriesChanged;
        private bool m_DurationChanged;
        private readonly WorkoutFacade r_WorkoutFacade;
        public AddWorkoutForm(WorkoutFacade i_WorkoutFacade)
        {
            InitializeComponent();
            this.r_WorkoutFacade = i_WorkoutFacade;
        }
        private void comboBoxWorkoutCategory_TextChanged(object sender, EventArgs e)
        {
            m_CategoryChanged = true;
            enableAddWorkoutButton();
        }
        private void dateTimePickerWorkout_ValueChanged(object sender, EventArgs e)
        {
            m_DateTimeChanged = true;
            enableAddWorkoutButton();
        }
        private void numericUpDownCalories_ValueChanged(object sender, EventArgs e)
        {
            m_CaloriesChanged = true;
            enableAddWorkoutButton();
        }
        private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
        {
            m_DurationChanged = true;
            enableAddWorkoutButton();
        }
        private void enableAddWorkoutButton()
        {
            buttonAddWorkout.Enabled = m_DurationChanged && m_CaloriesChanged && m_DateTimeChanged && m_CategoryChanged;
        }
        private void buttonAddWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                decimal duration = numericUpDownDuration.Value;
                string category = comboBoxWorkoutCategory.Text;
                DateTime date = dateTimePickerWorkout.Value;
                decimal calories = numericUpDownCalories.Value;
                WorkoutComposer composer = new WorkoutComposer();
                Workout workout = composer.ComposeWorkout(duration, category, date, calories);

                r_WorkoutFacade.AddWorkout(workout);
                r_WorkoutFacade.FetchWorkoutData();
                MessageBox.Show("Workout saved successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}