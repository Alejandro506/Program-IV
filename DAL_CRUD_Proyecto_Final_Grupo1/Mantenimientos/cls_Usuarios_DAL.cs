using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Usuarios_DAL
    {
        #region Variables Privadas

        /*
         *     Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
                Id_Rol INT NOT NULL,
                Email NVARCHAR(255) NOT NULL,
                Contraseña NVARCHAR(255) NOT NULL,
                Nombre NVARCHAR(100) NOT NULL,
                Apellido1 NVARCHAR(100) NOT NULL,
                Apellido2 NVARCHAR(100),
                Estado CHAR(1) CHECK (Estado IN ('A', 'I')),
              * */

        private int _iId_Usuario, _iId_Rol;
        private string _sEmail, _sContraseña, _sNombre, _sApellido1, _sApellido2;
        private char _cEstado;

        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
        public int iId_Usuario { get => _iId_Usuario; set => _iId_Usuario = value; }
        public int iId_Rol { get => _iId_Rol; set => _iId_Rol = value; }
        public string sEmail { get => _sEmail; set => _sEmail = value; }
        public string sContraseña { get => _sContraseña; set => _sContraseña = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellido1 { get => _sApellido1; set => _sApellido1 = value; }
        public string sApellido2 { get => _sApellido2; set => _sApellido2 = value; }
        public char cEstado { get => _cEstado; set => _cEstado = value; }

        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }

        #endregion
    }
}
