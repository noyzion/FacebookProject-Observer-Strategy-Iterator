using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class WorkoutFacade
    {
        public WorkoutManager WorkoutManager { get; set; }
        private readonly DataGridView r_WorkoutTable;
        private readonly WorkoutManagerUI r_WorkoutManagerUI;

        public WorkoutFacade()
        {
            WorkoutManager = new WorkoutManager();
            r_WorkoutManagerUI = new WorkoutManagerUI();
            r_WorkoutTable = WorkoutManager.InitializeWorkoutTable();
        }
        public DataGridView GetWorkoutTable()
        {
            return r_WorkoutTable;
        }
        public void ResetWorkoutTable()
        {
            r_WorkoutTable.Rows.Clear();
        }
        public void FetchWorkoutData()
        {
            WorkoutManager.FetchWorkoutData(r_WorkoutTable);
        }
        public void AddWorkout(Workout i_Workout)
        {
            if (WorkoutManager.Workouts == null)
            {
                WorkoutManager.Workouts = new List<Workout>();
            }

            WorkoutManager.Workouts.Add(i_Workout);
            FetchWorkoutData();
        }
        public string PreparePostWorkouts()
        {
            r_WorkoutManagerUI.DisplayWorkoutsPopup(WorkoutManager.Workouts);

            return WorkoutManager.GenerateWorkoutsSummary();
        }
        public void DisplayInviteFriendsPost(List<User> i_Friends)
        {
            r_WorkoutManagerUI.DisplayFriendsPopup(i_Friends);
        }
    }
}