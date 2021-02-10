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

        public Controller()
        {
            IDictionary<int, Form> fishyNoteList = new Dictionary<int, Form>();

            IFactory<INotes> _noteDataFactory = new Factory<INotes>();
                        
            INotes noteData = _noteDataFactory.Create<NoteData>();
 
            Application.Run(new FishyNotes(fishyNoteList, noteData));
        }
    }
}