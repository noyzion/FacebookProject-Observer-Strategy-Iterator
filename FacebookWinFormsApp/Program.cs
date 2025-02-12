using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    //https://docs.google.com/document/d/1UXaie6tFDTP3LM6QzMRI4fN0GiwbZXfrhr2nOSAYoPA/edit?usp=sharing
    static class Program
    {
        [STAThread]    
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
