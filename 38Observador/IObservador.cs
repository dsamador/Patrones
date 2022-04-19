using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Observador
{
    public interface IObservador
    {
        void Update(string mensaje);
        void UpdatePull();
    }
}
