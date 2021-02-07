using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp3304_week1
{
    class Controller
    {
        private IDictionary<int, Form> fishyNoteList = new Dictionary<int, Form>();

        public Controller()
        {
            Application.Run(new FishyNotes(fishyNoteList));
        }
    }
}