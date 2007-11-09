using System.Collections.Generic;
using System;

namespace FSO_NH.Core
{
    public interface IDomainObject
    {
        string NombreCampoCodigo{get;}
        string MiCodigo { get; }
        string MiDescripcion { get; }
        Int32 ID { get; set; }
        bool EsNuevo { get;}
    }
}