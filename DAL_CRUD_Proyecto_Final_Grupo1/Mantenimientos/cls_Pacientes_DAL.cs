using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Pacientes_DAL
    {
        #region Variables Privadas

        /*
         *     Id_Paciente INT IDENTITY PRIMARY KEY,
                Id_TipoIdentificacion INT,
                Identificacion NVARCHAR(100) NOT NULL,
                Nombre NVARCHAR(100) NOT NULL,
                Apellido1 NVARCHAR(100) NOT NULL,
                Apellido2 NVARCHAR(100),
                Fecha_Nacimiento DATETIME NOT NULL,
                Genero CHAR(1) CHECK (Genero IN ('M', 'F')),
                Direccion NVARCHAR(255),
	            Telefono_Fijo NVARCHAR(50),
                Telefono_Movil NVARCHAR(50),
                Email NVARCHAR(100),
                Estado_Civil NVARCHAR(100) NOT NULL,
         
         */
        private int _iId_Paciente, _iId_TipoIdentificacion;
        private string _sIdentificacion, _sNombre, _sApellido1, _sApellido2, _sDireccion, _sTelefono_Fijo, _sTelefono_Movil, _sEmail,_sEstado_Civil;
        private DateTime _dtFecha_Nacimiento;
        private char _cGenero;

        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
        public int iId_Paciente { get => _iId_Paciente; set => _iId_Paciente = value; }
        public int iId_TipoIdentificacion { get => _iId_TipoIdentificacion; set => _iId_TipoIdentificacion = value; }
        public string sIdentificacion { get => _sIdentificacion; set => _sIdentificacion = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellido1 { get => _sApellido1; set => _sApellido1 = value; }
        public string sApellido2 { get => _sApellido2; set => _sApellido2 = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sTelefono_Fijo { get => _sTelefono_Fijo; set => _sTelefono_Fijo = value; }
        public string sTelefono_Movil { get => _sTelefono_Movil; set => _sTelefono_Movil = value; }
        public string sEmail { get => _sEmail; set => _sEmail = value; }
        public string sEstado_Civil { get => sEstado_Civil; set => sEstado_Civil = value; }
        public DateTime dtFecha_Nacimiento { get => _dtFecha_Nacimiento; set => _dtFecha_Nacimiento = value; }
        public char cGenero { get => _cGenero; set => _cGenero = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }

        #endregion

    }
}
