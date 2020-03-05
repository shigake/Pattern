using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        public IphoneBuilder()
        {
            this.celular = new Celular("Iphone");
        }


        public Celular celular { get; set; }
        public Celular Celular {
            get { return this.celular; }
        }

        public void Buildbateria()
        {
            this.celular.bateria = "MAH_2000";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16MP";
        }

        public void BuildSistema()
        { 
            this.celular.sistema = "iOS 11";
        }

    public void BuildTela()
        {
            this.celular.tela = "9";
        }
    }
}
