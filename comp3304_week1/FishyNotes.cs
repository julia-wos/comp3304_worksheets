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

        private int _fishyNoteID = 1;

        private Form _newNote;

        

       

        public FishyNotes(IDictionary<int, Form> noteForms)
        {
            InitializeComponent();
            _noteForms = noteForms;
        }


        public void Remove(int id) 
        {
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
            
            _newNote = new FishyNote(_fishyNoteID, Remove);
            //_newNote.Show();

            _noteForms.Add(_fishyNoteID, _newNote);

            _noteForms[_fishyNoteID].Show();
            _fishyNoteID++;
        }


    }
}
