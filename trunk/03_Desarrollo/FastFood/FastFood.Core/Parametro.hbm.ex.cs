using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.Core;

namespace FastFood.Core
{
    public partial class Parametro
    {
        public override string MiCodigo
        {
            get { return Codigo; }
        }

        public override string MiDescripcion
        {
            get { return Descripcion; }
        }
        private static BBParametro BBA = new BBParametro();
        public  void Guardar()
        {
            BBA.Guardar(this);
        }
        public static Parametro GetById(Int32 ID)
        {
            return BBA.GetById(ID, true);
        }
    }
}
