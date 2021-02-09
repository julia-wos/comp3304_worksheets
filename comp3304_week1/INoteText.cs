using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp3304_week1
{
    public interface INoteText
    {
        void UpdateNoteText(int id, string newText);

        String RetriveNoteText(int id);
    }
}
