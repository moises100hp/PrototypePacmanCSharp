using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePacman
{
    internal interface IFantasmaPrototype
    {
        IFantasmaPrototype Clone();
        void ExibirInfo();
        void Mover();

    }
}
