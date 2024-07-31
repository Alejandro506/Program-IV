using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Tipos_de_Parentesco_DAL
    {
        #region Variables Privadas
        /*
         *     Id_TipoParentesco INT IDENTITY(1,1) PRIMARY KEY,Parentesco NVARCHAR(100) NOT NULL,Estado CHAR(1) CHECK (Estado IN ('A', 'I'))
           */
        private int _iId_TipoParentesco;
        private string _sParentesco;
        private char _cEstado;

        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }
        public int iId_TipoParentesco { get => _iId_TipoParentesco; set => _iId_TipoParentesco = value; }
        public string sParentesco { get => _sParentesco; set => _sParentesco = value; }
        public char cEstado { get => _cEstado; set => _cEstado = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion
    }
}
