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

        
        public FishyNote()
        {
            InitializeComponent();
        }

        
        private void Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void CloseNote_Click(object sender, EventArgs e)
        {
            _noteHight = Size.Height;

            if (_noteHight == 500)
            {
                Size = new Size(500,70);
            }
            else
            {
                Size = new Size(500,500);
            }


        }

        private void Note_Clicked(object sender, EventArgs e)
        {
            this.Note.Text = "";
        }
    }
}
