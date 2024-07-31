using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Tipos_de_Identificacion_DAL
    {
        #region Variables Privadas

        /*
           Id_TipoIdentificacion INT IDENTITY(1,1) PRIMARY KEY, TipoIdentificacion NVARCHAR(100) NOT NULL,Estado CHAR(1) CHECK (Estado IN ('A', 'I'))
        */

        private int _iId_TipoIdentificacion;
        private string _sTipoIdentificacion;
        private char _cEstado;

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
        public int iId_TipoIdentificacion { get => _iId_TipoIdentificacion; set => _iId_TipoIdentificacion = value; }
        public string sTipoIdentificacion { get => _sTipoIdentificacion; set => _sTipoIdentificacion = value; }
        public char cEstado { get => _cEstado; set => _cEstado = value; }
        #endregion

    }
}
