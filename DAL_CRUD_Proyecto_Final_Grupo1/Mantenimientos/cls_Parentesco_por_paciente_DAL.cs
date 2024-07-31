using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Parentesco_por_paciente_DAL
    {
        #region Variables Privadas

        /*
         *     Id_ParentescoXPaciente INT IDENTITY PRIMARY KEY,
                Id_Paciente INT,
                Id_TipoParentesco INT,
                Nombre NVARCHAR(100) NOT NULL,
                Apellido1 NVARCHAR(100) NOT NULL,
                Apellido2 NVARCHAR(100),
                Fecha_Nacimiento DATETIME NOT NULL,
                Ingreso FLOAT,
         * 
         */

        private int _iId_ParentescoXPaciente, _iId_Paciente, _iId_TipoParentesco;
        private string _sNombre, _sApellido1, _sApellido2;
        private DateTime _dtFecha_Nacimiento;
        private float _fIngreso;

        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
        public int iId_ParentescoXPaciente { get => _iId_ParentescoXPaciente; set => _iId_ParentescoXPaciente = value; }
        public int iId_Paciente { get => _iId_Paciente; set => _iId_Paciente = value; }
        public int iId_TipoParentesco { get => _iId_TipoParentesco; set => _iId_TipoParentesco = value; }
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellido1 { get => _sApellido1; set => _sApellido1 = value; }
        public string sApellido2 { get => _sApellido2; set => _sApellido2 = value; }
        public DateTime dtFecha_Nacimiento { get => _dtFecha_Nacimiento; set => _dtFecha_Nacimiento = value; }
        public float fIngreso { get => _fIngreso; set => _fIngreso = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }

        #endregion

    }
}
