using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IWorkoutBuilder
    {
        void SetDuration(decimal i_Duration);
        void SetCategory(string i_Category);
        void SetDate(DateTime i_Date);
        void SetCalories(decimal i_Calories);
        Workout GetWorkout();
    }
}