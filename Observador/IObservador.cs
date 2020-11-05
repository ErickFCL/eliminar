using System;
using System.Collections.Generic;
using System.Text;

namespace PatDeDisObservador
{
    interface IObservador
    {
        void Update(string mensaje);
        //void UpdatePull();
    }
}
