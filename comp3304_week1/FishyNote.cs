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
    public partial class FishyNote : Form
    {
        private int _noteHight;

        private int _fishyNoteID;

        private string _newText;

        private RemoveDelegate _deleteMe;

        private TextUpdate _noteTextUpdate;

        private RetriveText _retriveNoteText;

        private Boolean _expanded = true;

        private Size _expandSize = new Size(500, 500);

        private Size _minimiseSize = new Size(500, 70);





        public FishyNote(int fishyNoteID, RemoveDelegate deleteMe, TextUpdate noteTextUpdate, RetriveText retriveNoteText)
        {
            InitializeComponent();
            _fishyNoteID = fishyNoteID;

            _deleteMe += deleteMe;
            _noteTextUpdate += noteTextUpdate;
            _retriveNoteText += retriveNoteText;

        }




        private void Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this._deleteMe(_fishyNoteID);
        }

       

        private void CloseNote_Click(object sender, EventArgs e)
        {
            if (_expanded)
            {
                this.ClientSize = _minimiseSize;
                _expanded = false;
            }
            else 
            {
                this.ClientSize = _expandSize;
                _expanded = true;
            }

        }

        private void NoteTextBox_Click(object sender, EventArgs e) 
        {
            this.Note.Text = _retriveNoteText(_fishyNoteID);
        }

        private void NoteText_Change(object sender, EventArgs e) 
        {
            _newText = this.Note.Text;

            this._noteTextUpdate(_fishyNoteID, _newText);
        }

        /*
        private void Note_Clicked(object sender, EventArgs e)
        {
            if (this.Note.Text == "Enter your note text here...")
            { 
                this.Note.Text = "";
            }

            _newText = this.Note.Text;

            this._noteTextUpdate(_fishyNoteID, _newText);
        }
        */

        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }
        #endregion


    }

}
