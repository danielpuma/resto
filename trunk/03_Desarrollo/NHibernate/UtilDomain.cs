using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using NHibernate;
using NHibernate.SqlTypes;

namespace FSO_NHDATA
{

    /// <summary>
    /// Indicates the direction for sorting
    /// usar para MultiPropertyComparer SortCollection by ale
    /// </summary>
    public enum SortDirection
    {
        /// <summary>
        /// Bottom to top, or oldest to youngest
        /// </summary>
        Ascending,

        /// <summary>
        /// Top to bottom, or youngest to oldest
        /// </summary>
        Descending
    }
    public class ParClaveValor
	{
        private int m_id;

        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private string m_valor;

        public string Valor
        {
            get { return m_valor; }
            set { m_valor = value; }
        }
		
	}
    
    
    /// <summary>
    /// clase de prueba de tipos de variables
    /// </summary>
    public class LocalToUniversalTimeConversionType : IUserType
    {
        #region IUserType Members
        /// <summary>
        /// Compare two instances of the datetime class
        /// </summary>
        public new bool Equals(object x, object y)
        {
            bool returnvalue = false;
            if ((x != null) && (y != null))
            {
                returnvalue = x.Equals(y);
            }
            return returnvalue;
        }
        /// <summary>
        /// The database contains datetime values
        /// </summary>
        public SqlType[] SqlTypes
        {
            get
            {
                SqlType[] types = { new DateTimeSqlType() };
                return types;
            }
        }
        /// <summary>
        /// Internally datetime values are used 
        /// </summary>
        public Type ReturnedType
        {
            get { return Type.GetType("System.DateTime"); }
        }
        /// <summary>
        /// Converts the database datetime to a UniversalTime instance and takes care of null values.
        /// </summary>
        public object NullSafeGet(System.Data.IDataReader rs, string[] names, object owner)
        {
            object value = rs.GetValue(rs.GetOrdinal(names[0]));
            if (value == DBNull.Value)
            {
                return DateTime.MinValue;
            }
            else
            {
                return ((DateTime)value).ToUniversalTime();
            }
        }
        /// <summary>
        /// Converts internal universal time to local time for storage and takes care of null values.
        /// </summary>
        public void NullSafeSet(System.Data.IDbCommand cmd, object value, int index)
        {
            if ((DateTime)value == DateTime.MinValue)
            {
                ((IDataParameter)cmd.Parameters[index]).Value = DBNull.Value;
            }
            else
            {
                ((IDataParameter)cmd.Parameters[index]).Value = ((DateTime)value).ToLocalTime();
            }

        }
        /// <summary>
        /// Value types allways return a copy.
        /// </summary>
        public object DeepCopy(object value)
        {
            return value;
        }
        /// <summary>
        /// DateTimes may change.
        /// </summary>
        public bool IsMutable
        {
            get { return true; }
        }
        #endregion
    }
    
    //public struct mychar : System.Char
    //{
        
    //}
}