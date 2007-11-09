using System;


namespace FSO_NH.Data
{
    public class DataAccessException : ApplicationException
    {
        public DataAccessException(string message) : base(message)
        {
        }
    }
}
