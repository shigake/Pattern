using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICelular
    {
        void BuildTela();
        void Buildbateria();
        void BuildCamera();

        void BuildSistema();

        Celular Celular { get; }
    }
}
