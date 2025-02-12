using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class WorkoutComposer
    {
        private readonly IWorkoutBuilder r_Builder;

        public WorkoutComposer()
        {
            r_Builder = new WorkoutBuilder();
        }
        public Workout ComposeWorkout(decimal i_Duration, string i_Category, DateTime i_Date, decimal i_Calories)
        {
            r_Builder.SetDuration(i_Duration);
            r_Builder.SetCategory(i_Category);
            r_Builder.SetDate(i_Date);
            r_Builder.SetCalories(i_Calories);

            return r_Builder.GetWorkout();
        }
    }
}
