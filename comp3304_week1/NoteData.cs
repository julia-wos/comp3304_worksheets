using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp3304_week1
{
    public class NoteData : INotes, INoteText
    {

        public IDictionary<int, string> _noteTextStorage;

        public NoteData()
        {
            _noteTextStorage = new Dictionary<int, string>();
        }


        #region IMPLEMENTATION of INoteText
        public void UpdateNoteText(int id, string newText)
        {
            _noteTextStorage[id] = newText;

        }

        public String RetriveNoteText(int id)
        {
            return (_noteTextStorage[id]);
        }
        #endregion

        #region IMPLEMENTATION of INotes
        public void AddNoteText(int id)
        {
            _noteTextStorage.Add(id, "");
        }

        public void DeleteNoteText(int id)
        {
            _noteTextStorage.Remove(id);
        }
        #endregion

    }
}
