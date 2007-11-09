using System;
using System.Collections.Generic;
using System.Text;

namespace FSO_NH.Core
{
    /// <summary>
    /// 
    /// </summary>
    public enum Severity
    {
        /// <summary>
        /// Warning
        /// </summary>
        Warning, 
        /// <summary>
        /// Error
        /// </summary>
        Error, 
        /// <summary>
        /// Fatal
        /// </summary>
        Fatal
    }
	;

    /// <summary>
    /// 
    /// </summary>
    public enum MensajesErrorDomain
    {
        /// <summary>
        /// UNKNOW_ERROR
        /// </summary>
        UNKNOW_ERROR ,
        /// <summary>
        /// FATAL_ERROR
        /// </summary>
        FATAL_ERROR,
        /// <summary>
        /// CAN_NOT_BE_NULL
        /// </summary>
        CAN_NOT_BE_NULL,
        /// <summary>
        /// IS_REQUIRED
        /// </summary>
        IS_REQUIRED, 
    }
	;
    
    /// <summary>
    /// 
    /// </summary>
    public static class ErrorDesc
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pTipo"></param>
        /// <returns></returns>
        public static string ErrorIS(MensajesErrorDomain pTipo)
        {
            string errDesc  ;

            switch (pTipo)
            {
                case MensajesErrorDomain.UNKNOW_ERROR  :
                    errDesc = "UNKNOW_ERROR";
                    break;
                case MensajesErrorDomain.CAN_NOT_BE_NULL:
                    errDesc = "No Puede ser Nulo ";
                    //goto case 1;
                    break;
                case MensajesErrorDomain.FATAL_ERROR:
                    errDesc = "Error Fatal";
                    break;
                case MensajesErrorDomain.IS_REQUIRED:
                    errDesc = " Es Requerido ";
                    break;
                default:
                    errDesc = "Error No Conocido ? ";
                    break;
            }

            
            return "" + errDesc;
        }
    }
    
    /// <summary>
    /// Class to Handle Errors.
    /// Supports Severity Level.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Method that transform a list of Errors into a nice string format.
        /// </summary>
        /// <param name="pErrors">Errors to Transform</param>
        /// <returns></returns>
        public static string ErrorsToString(List<Error> pErrors)
        {
            if (pErrors == null) throw new ArgumentNullException("pErrors");

            StringBuilder _sb = new StringBuilder();
            string _ret = String.Empty;
            foreach (Error _error in pErrors)
            {
                _sb.AppendLine(_error.ErrorMessage + "(" + _error.Severity.ToString() + ")");
            }
            return _sb.ToString();
        }

        #region --- Fields ---

        Severity _severity;
        string _errorMessage;

        #endregion

        #region --- Constructors ---
     
        /// <summary>
        /// 
        /// </summary>
        public Error()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pErrorMessage"></param>
        public Error(string pErrorMessage)
        {
            _errorMessage = pErrorMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pErrorMessage"></param>
        /// <param name="pSeverityLevel"></param>
        public Error(string pErrorMessage, Severity pSeverityLevel)
            : this(pErrorMessage)
        {
            _severity = pSeverityLevel;
        }

        #endregion


        #region --- Properties ---

        /// <summary>
        /// Severity Error
        /// </summary>
        public Severity Severity
        {
            get
            {
                return _severity;
            }
            set
            {
                _severity = value;
            }
        }

        /// <summary>
        /// Error Message
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
            }
        }
 
        
        #endregion

        /// <summary>
        /// GetMsg
        /// </summary>
        /// <param name="EnumError"></param>
        /// <returns></returns>
        public string GetMsg(MensajesErrorDomain EnumError)
        {
            
            return "";
        }
    }
}
