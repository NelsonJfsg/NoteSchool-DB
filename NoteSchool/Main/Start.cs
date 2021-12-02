using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout.Login;

namespace NoteSchool.Main
{
    class Start
    {

        public static void Main()
        {

        
            //ejecutar load.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScLogin());
        }
    }
}
