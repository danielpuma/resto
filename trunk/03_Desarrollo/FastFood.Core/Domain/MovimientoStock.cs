using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.Core;

namespace FastFood.Core
{
    public class MovimientoStock:DomainObject
    {
        private DateTime _Fecha;

        public virtual DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private bool _Activo;

        public virtual bool Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }
        private int _IdMovimientoExterno;

        public virtual int IdMovimientoExterno
        {
            get { return _IdMovimientoExterno; }
            set { _IdMovimientoExterno = value; }
        }
        private bool _Ingreso;

        public virtual bool Ingreso
        {
            get { return _Ingreso; }
            set { _Ingreso = value; }
        }
        private System.Collections.IList _MyMovimientoStockDetalle;

        public virtual System.Collections.IList MyMovimientoStockDetalle
        {
            get { return _MyMovimientoStockDetalle; }
            set { _MyMovimientoStockDetalle = value; }
        }

        private DateTime? _FechaCarga;
        public virtual DateTime? FechaCarga
        {
            get { return _FechaCarga; }
            set { _FechaCarga = value; }
        }

        private DateTime? _FechaAnulacion;
        public virtual DateTime? FechaAnulacion
        {
            get { return _FechaAnulacion; }
            set { _FechaAnulacion = value; }
        }

        private Int32? _IdUsuarioCarga;

        public virtual Int32? IdUsuarioCarga
        {
            get { return _IdUsuarioCarga; }
            set { _IdUsuarioCarga = value; }
        }

        private Int32? _IdUsuarioAnula;

        public virtual Int32? IdUsuarioAnula
        {
            get { return _IdUsuarioAnula; }
            set { _IdUsuarioAnula = value; }
        }

    }
}
