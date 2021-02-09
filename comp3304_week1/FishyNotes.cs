using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp3304_week1
{
    /// <summary>
    /// This class is responsible for adding new fishy notes
    /// </summary>
    public partial class FishyNotes : Form
    {
        // DECLARATION of _newNote of type Form
        //private Form _newNote;
        private IDictionary<int, Form> _noteForms;

        private int _fishyNoteID = 0;

        private Form _newNote;

        private INotes _noteData;

        private INoteText _noteTextData;

        //private IDictionary<int, string> _noteTextStorage;


        public FishyNotes(IDictionary<int, Form> noteForms, INotes noteData)
        {
            InitializeComponent();
            _noteForms = noteForms;
            _noteData = noteData;
            _noteTextData = _noteData as INoteText;

            //_noteTextStorage = new Dictionary<int, string>();
        }

        /*
        public void UpdateNoteText(int id, string newText) 
        {
            _noteTextStorage[id] = newText;           

        }
        */

        /*
        public String RetriveNoteText(int id)
        {
            return (_noteTextStorage[id]);
        }
        */


        public void Remove(int id) 
        {
            _noteData.DeleteNoteText(id);
            _noteForms.Remove(id);            
        }

        

        /// <summary>
        /// This methos is resposible for loading the fishy notes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishyNotes_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// This method is responsible for adding a note after an AddNote button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {            
            _newNote = new FishyNote(_fishyNoteID, Remove, _noteTextData.UpdateNoteText, _noteTextData.RetriveNoteText);

            //_noteTextStorage.Add(_fishyNoteID, "");
            _noteData.AddNoteText(_fishyNoteID);
            
            _noteForms.Add(_fishyNoteID, _newNote);

            _noteForms[_fishyNoteID].Show();
            
            _fishyNoteID++;
        }


    }
}
