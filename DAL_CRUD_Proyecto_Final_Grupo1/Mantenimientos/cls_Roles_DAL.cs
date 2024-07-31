using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Roles_DAL
    {
        #region Variables Privadas
        /*
             Id_Rol INT IDENTITY PRIMARY KEY,
            Rol NVARCHAR(50) NOT NULL,
	        Estado CHAR(1) CHECK (Estado IN ('A', 'I'))
         */
        private int _iId_Rol;
        private string _sRol;
        private char _sEstado;

        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores

        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }
        public int iId_Rol { get => _iId_Rol; set => _iId_Rol = value; }
        public string sRol { get => _sRol; set => _sRol = value; }
        public char sEstado { get => _sEstado; set => _sEstado = value; }
        #endregion

    }
}
