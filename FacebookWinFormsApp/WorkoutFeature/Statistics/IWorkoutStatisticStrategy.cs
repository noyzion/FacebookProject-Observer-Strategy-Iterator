using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IWorkoutStatisticStrategy
    {
        Dictionary<int, int> Calculate(DataGridView i_WorkoutTable);
    }
}