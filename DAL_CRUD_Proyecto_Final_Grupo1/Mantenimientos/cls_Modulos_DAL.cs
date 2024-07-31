using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Principal;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Modulos_DAL
    {
        #region Variables Privadas


        /* 
         * Id_Modulo INT IDENTITY PRIMARY KEY,Modulo NVARCHAR(50) NOT NULL, Enlace NVARCHAR(100) NOT NULL,
         * ClaseCSS NVARCHAR(100) NOT NULL*/

        private int _iId_Modulo;
        private string _sModulo, _sEnlace, _sClasesCSS;

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
        public int iId_Modulo { get => _iId_Modulo; set => _iId_Modulo = value; }
        public string sModulo { get => _sModulo; set => _sModulo = value; }
        public string sEnlace { get => _sEnlace; set => _sEnlace = value; }
        public string sClasesCSS { get => sClasesCSS; set => sClasesCSS = value; }
        #endregion

    }
}
