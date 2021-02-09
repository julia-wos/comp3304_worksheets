using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp3304_week1
{
    public class Controller
    {
        IDictionary<int, Form> fishyNoteList = new Dictionary<int, Form>();

        INotes noteData = new NoteData();

        public Controller()
        {
            Application.Run(new FishyNotes(fishyNoteList, noteData));
        }
    }
}