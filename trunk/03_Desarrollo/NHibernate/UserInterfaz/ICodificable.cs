using System;
using System.Collections.Generic;
using System.Text;

namespace FSO_NH.UserInterfaz
{
    public interface ICodificable<IdT>
    {
        /// <summary>
        /// ID may be of type string, int, custom type, etc.
        /// </summary>
        IdT ID { get; set; }
        string MiCodigo { get; }
        string MiDescripcion { get; }
      
    }
}
