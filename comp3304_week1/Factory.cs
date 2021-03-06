﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp3304_week1
{
    public class Factory<E> : IFactory<E>
    {
        public E Create<T>() where T : E, new()
        {
            return new T();
        }
    }
}
