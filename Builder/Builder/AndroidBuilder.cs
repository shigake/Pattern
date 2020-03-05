using System;

namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        public AndroidBuilder()
        {
            this.celular = new Celular("Android");
        }

        public Celular celular { get; set; }
        public Celular Celular {
            get { return this.celular; }
        }
        public void Buildbateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "15MP";
        }
        public void BuildSistema() {
            this.celular.sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            this.celular.tela = "7";
        }
    }
}
