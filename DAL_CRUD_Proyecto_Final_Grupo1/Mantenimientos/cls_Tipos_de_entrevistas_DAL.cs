using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Tipos_de_entrevistas_DAL
    {
        #region Variables Privadas
        /*
          Id_TipoEntrevista INT IDENTITY(1,1) PRIMARY KEY,TipoEntrevista NVARCHAR(100) NOT NULL,Estado CHAR(1) CHECK (Estado IN ('A', 'I'))
        */
        private int _iId_TipoEntrevista;
        private string _sTipoEntrevista;
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
        public int iId_TipoEntrevista { get => _iId_TipoEntrevista; set => _iId_TipoEntrevista = value; }
        public string sTipoEntrevista { get => _sTipoEntrevista; set => _sTipoEntrevista = value; }
        public char cEstado { get => _cEstado; set => _cEstado = value; }

        #endregion

    }
}
