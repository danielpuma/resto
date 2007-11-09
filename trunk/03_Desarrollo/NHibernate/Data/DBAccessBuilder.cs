using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace FSO_NH.Data
{
    public enum DBServerType
    {
        SQLServer = 1,
        Oracle = 2,
        OleDb = 3,
        MySQL = 4
    }

    public sealed class DBAccessBuilder
    {
        private static DBAccessBuilder s_instance = null;
        private static readonly object s_padLock = new object();

        /// <summary>
        /// 
        /// </summary>
        private DBAccessBuilder()
        {
        }

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public static DBAccessBuilder Instance
        {
            get
            {
                lock (s_padLock)
                {
                    if (s_instance == null)
                    {
                        s_instance = new DBAccessBuilder();
                    }
                    return s_instance;
                }
            }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IDbCommand BuildCommand(DBServerType type)
        {
            return BuildCommand(type, string.Empty, null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public IDbCommand BuildCommand(DBServerType type, string cmdText)
        {
            return BuildCommand(type, cmdText, null, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cmdText"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public IDbCommand BuildCommand(DBServerType type, string cmdText, IDbConnection connection)
        {
            return BuildCommand(type, cmdText, connection, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cmdText"></param>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public IDbCommand BuildCommand(DBServerType type, string cmdText, IDbConnection connection,
                                       IDbTransaction transaction)
        {
            switch (type)
            {
                case DBServerType.SQLServer:
                    return new SqlCommand(cmdText, (SqlConnection) connection, (SqlTransaction) transaction);
                case DBServerType.Oracle:
                    throw new NotImplementedException("Oracle not supported");
                case DBServerType.OleDb:
                    return new OleDbCommand(cmdText, (OleDbConnection) connection, (OleDbTransaction) transaction);
            }
            throw new DataAccessException("Server not supported");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverType"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        public IDbDataAdapter BuildDataAdapter(DBServerType serverType, IDbCommand command)
        {
            switch (serverType)
            {
                case DBServerType.SQLServer:
                    return new SqlDataAdapter((SqlCommand) command);
                case DBServerType.Oracle:
                    throw new NotImplementedException("Oracle not supported");
                case DBServerType.OleDb:
                    return new OleDbDataAdapter((OleDbCommand) command);
            }
            throw new DataAccessException("Server not supported");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverType"></param>
        /// <param name="command"></param>
        /// <param name="parameterList"></param>
        public void SetCommandParameters(DBServerType serverType, IDbCommand command,
                                         IDataParameterCollection parameterList)
        {
            SetCommandParameters(serverType, command, parameterList, parameterList.Count);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverType"></param>
        /// <param name="command"></param>
        /// <param name="parameterList"></param>
        /// <param name="paramCount"></param>
        private void SetCommandParameters(DBServerType serverType, IDbCommand command,
                                          IDataParameterCollection parameterList, int paramCount)
        {
            for (int i = 0; i < paramCount; i++)
            {
                IDbDataParameter parameter = BuildIDbDataParameter(serverType);
                parameter.DbType = ((IDbDataParameter) parameterList[i]).DbType;
                parameter.Direction = ((IDbDataParameter) parameterList[i]).Direction;
                parameter.ParameterName = ((IDbDataParameter) parameterList[i]).ParameterName;
                if (((IDbDataParameter) parameterList[i]).Size > 0)
                {
                    parameter.Size = ((IDbDataParameter) parameterList[i]).Size;
                }
                parameter.Value = ((IDbDataParameter) parameterList[i]).Value;
                command.Parameters.Add(parameter);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverType"></param>
        /// <returns></returns>
        private IDbDataParameter BuildIDbDataParameter(DBServerType serverType)
        {
            switch (serverType)
            {
                case DBServerType.SQLServer:
                    return new SqlParameter();
                case DBServerType.Oracle:
                    throw new NotImplementedException("Oracle not supported");
                case DBServerType.OleDb:
                    return new OleDbParameter();
            }
            throw new DataAccessException("Server not supported");
        }
    }
}