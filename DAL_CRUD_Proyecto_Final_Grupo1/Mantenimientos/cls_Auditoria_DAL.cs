using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Auditoria_DAL
    {
        #region Variables Privadas
        /*    Id_Auditoria INT IDENTITY(1,1) PRIMARY KEY,
            Id_Usuario INT NOT NULL,
            Fecha_Hora_Accion DATETIME NOT NULL,
            Accion CHAR(1) CHECK (Accion IN ('I', 'A', 'E')),
            Descripcion NVARCHAR(255) NOT NULL,
             */
        private int _iId_Auditoria, _iId_Usuario;
        private string _sDescripcion;
        private DateTime _dtFecha_Hora_Accion;
        private char _cAccion;


        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
          public int iId_Auditoria { get => _iId_Auditoria; set => _iId_Auditoria = value; }
        public int iId_Usuario { get => _iId_Usuario; set => _iId_Usuario = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public DateTime dtFecha_Hora_Accion { get => _dtFecha_Hora_Accion; set => _dtFecha_Hora_Accion = value; }
        public char cAccion { get => _cAccion; set => _cAccion = value; }

        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }

        #endregion
    }
}
