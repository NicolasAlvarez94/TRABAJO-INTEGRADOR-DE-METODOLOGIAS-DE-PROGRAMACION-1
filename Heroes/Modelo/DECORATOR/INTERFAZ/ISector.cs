using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    interface ISector
    {
        void Mojar(double pAgua);

        bool EstaApagado();

        double getPorcentajeAfectacionFuego();
    }
}
