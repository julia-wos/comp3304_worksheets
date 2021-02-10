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
        private IDictionary<int, Form> _noteForms;

        private int _fishyNoteID = 0;

        private Form _newNote;

        private INotes _noteData;

        private INoteText _noteTextData;

        public FishyNotes(IDictionary<int, Form> noteForms, INotes noteData)
        {
            InitializeComponent();
            _noteForms = noteForms;
            _noteData = noteData;
            _noteTextData = _noteData as INoteText;
        }


        /// <summary>
        /// This method is responsible for Removing notes from the Dictionairy 
        /// based on the unique id/key
        /// </summary>
        /// <param name="id"></param>
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
        /// This method is responsible for adding a note and it's data(text)
        /// after an AddNote button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            //CREATE a new note
            _newNote = new FishyNote(_fishyNoteID, Remove, _noteTextData.UpdateNoteText, _noteTextData.RetriveNoteText);
            
            //ADD am empty text field to the NoteText dictionary
            _noteData.AddNoteText(_fishyNoteID);
            
            //ADD a note to the dictionary of notes
            _noteForms.Add(_fishyNoteID, _newNote);

            //display the note
            _noteForms[_fishyNoteID].Show();
            
            //increment id
            _fishyNoteID++;
        }


    }
}
