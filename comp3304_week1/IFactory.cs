using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp3304_week1
{
    public interface IFactory<E>
    {
        E Create<T>() where T : E, new();
    }
}
