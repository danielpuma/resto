using System;
using System.Collections.Generic;

namespace FSO_NH.Core
{
    /// <summary>
    ///  ID may be of type string, int, custom type, etc.
    /// </summary>
    /// <typeparam name="IdT"></typeparam>
    [Serializable]
    public class DomainObject:IDomainObject
    {
        public DomainObject()
        { }

       
         private Int32 id = 0; 
        /// <summary>
        /// ID may be of type string, int, custom type, etc.
        /// </summary>
        public Int32 ID
        {
            get { return id; }
            set { id = value; }
        }

        private bool _baja;

        public bool EsBaja
        {
            get { return _baja; }
            set { _baja = value; }
        }
        /// <summary>
        /// Transient objects are not associated with an item already
        /// in storage.  For instance,
        /// a  is transient if its ID is 0.
        /// </summary>
        public bool IsTransient()
        {
            return  ID.Equals(0);
        }

   

        #region Equals And HashCode Overrides


                    /// <summary>
                    /// local implementation of GetHashCode based on unique value members
                    /// </summary>
                    public override int GetHashCode()
                    {
                        try
                        {
                            int hash = 57;
                            hash = 27 * hash * ID.GetHashCode();
                            return hash;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }

        #endregion

          public virtual string NombreCampoCodigo
        {
            get { return "Codigo"; }
        }
        public virtual string MiCodigo
        {
            get { return ""; }
        }

        public virtual string MiDescripcion
        {
            get { return ""; }
        }
        public  bool EsNuevo
        {
            get { return (ID == 0); }
        }
    }
}