using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Modulos_por_usuario_DAL
    {
        #region Variables Privadas
        /*    Id_ModuloXUsuario INT IDENTITY PRIMARY KEY,
            Id_Modulo INT,
	        Id_Usuario INT,
         */

        private int _iId_ModuloXUsuario, _iId_Modulo, _iId_Usuario;


        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
        public int iId_ModuloXUsuario { get => _iId_ModuloXUsuario; set => _iId_ModuloXUsuario = value; }
        public int iId_Modulo { get => _iId_Modulo; set => _iId_Modulo = value; }
        public int iId_Usuario { get => _iId_Usuario; set => _iId_Usuario = value; }

        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }

        #endregion
    }
}
