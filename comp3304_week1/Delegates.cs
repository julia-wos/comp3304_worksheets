using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp3304_week1
{

    public delegate void RemoveDelegate(int id);

    public delegate void TextUpdate(int id, string newText);

    public delegate String RetriveText(int id);
    
}
