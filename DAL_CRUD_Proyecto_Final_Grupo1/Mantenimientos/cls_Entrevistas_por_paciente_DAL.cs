using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL_CRUD_Proyecto_Final_Grupo1.Mantenimientos
{
    public class cls_Entrevistas_por_paciente_DAL
    {
        #region Variables Privadas

        /*    Id_EntrevistaXPaciente INT IDENTITY PRIMARY KEY,
            Id_Paciente INT,
            Prenatal NVARCHAR(100) NOT NULL,
            Parto NVARCHAR(100) NOT NULL,
            Motora NVARCHAR(100) NOT NULL,
            Vocabulario NVARCHAR(100),
            Accidentes NVARCHAR(50),
            Enfermedades NVARCHAR(50),
            Tratamientos NVARCHAR(50),
	        Psicologicos NVARCHAR(50),
            Psiquiatricos NVARCHAR(50),
	        Internamiento NVARCHAR(100),
            Historia_Longitudinal NVARCHAR(50),
            Dinamica_Familiar NVARCHAR(50),
            Situacion_Laboral_y_Economica NVARCHAR(50),
	        Puntualidad NVARCHAR(50),
            Aseo_General NVARCHAR(50),
	        Presentacion_Personal  NVARCHAR(100),
            Estatura NVARCHAR(50),
            Contextura NVARCHAR(50),
            Motricidad NVARCHAR(50),
	        Postura NVARCHAR(50),
            Distancia NVARCHAR(50),
	        Disposicion  NVARCHAR(100),
            Empatia NVARCHAR(50),
            Emotividad NVARCHAR(50),
            Orientacion NVARCHAR(50),
	        Comportamiento NVARCHAR(50),
            Comunicacion NVARCHAR(50),
	        Capacidad_de_Juicio NVARCHAR(100),
            Fecha_de_Entrevista DATETIME NOT NULL,
            Fecha_de_Registro DATETIME NOT NULL,
            Id_TipoEntrevista INT,
         * 
         */

        private int _iId_EntrevistaXPaciente, _iId_Paciente, Id_TipoEntrevista;
        private string _sPrenatal, _sParto, _sMotora, _sVocabulario, _sAccidentes, _sEnfermedades, _sTratamientos, _sPsicologicos, _sPsiquiatricos, _sInternamiento, _sHistoria_Longitudinal, _sDinamica_Familiar, _sSituacion_Laboral_y_Economica,
            _sPuntualidad, _sAseo_General, _sPresentacion_Personal, _sEstatura, _sContextura, _sMotricidad, _sPostura, _sDistancia, _sDisposicion, _sEmpatia, _sEmotividad, _sOrientacion, _sComportamiento, _sComunicacion, _sCapacidad_de_Juicio;
        private DateTime _dtFecha_de_Entrevista, _dtFecha_de_Registro;


        private string _sValorScalar, _sAXN, _sMSJError; //en todas las clases
        private DataTable _dtDatos, _dtParametros; //en todas las clases
        private int _iIdUsuarioGlobal;//en todas las clases
        #endregion

        #region Variables Públicas o Constructores
        public int iId_EntrevistaXPaciente { get => _iId_EntrevistaXPaciente; set => _iId_EntrevistaXPaciente = value; }
        public int iId_Paciente { get => _iId_Paciente; set => _iId_Paciente = value; }
        public int id_TipoEntrevista1 { get => Id_TipoEntrevista; set => Id_TipoEntrevista = value; }
        public string sPrenatal { get => _sPrenatal; set => _sPrenatal = value; }
        public string sParto { get => _sParto; set => _sParto = value; }
        public string sMotora { get => _sMotora; set => _sMotora = value; }
        public string sVocabulario { get => _sVocabulario; set => _sVocabulario = value; }
        public string sAccidentes { get => _sAccidentes; set => _sAccidentes = value; }
        public string sEnfermedades { get => _sEnfermedades; set => _sEnfermedades = value; }
        public string sTratamientos { get => _sTratamientos; set => _sTratamientos = value; }
        public string sPsicologicos { get => _sPsicologicos; set => _sPsicologicos = value; }
        public string sPsiquiatricos { get => _sPsiquiatricos; set => _sPsiquiatricos = value; }
        public string sInternamiento { get => _sInternamiento; set => _sInternamiento = value; }
        public string sHistoria_Longitudinal { get => _sHistoria_Longitudinal; set => _sHistoria_Longitudinal = value; }
        public string sDinamica_Familiar { get => _sDinamica_Familiar; set => _sDinamica_Familiar = value; }
        public string sSituacion_Laboral_y_Economica { get => _sSituacion_Laboral_y_Economica; set => _sSituacion_Laboral_y_Economica = value; }
        public string sPuntualidad { get => _sPuntualidad; set => _sPuntualidad = value; }
        public string sAseo_General { get => _sAseo_General; set => _sAseo_General = value; }
        public string sPresentacion_Personal { get => _sPresentacion_Personal; set => _sPresentacion_Personal = value; }
        public string sEstatura { get => _sEstatura; set => _sEstatura = value; }
        public string sContextura { get => _sContextura; set => _sContextura = value; }
        public string sMotricidad { get => _sMotricidad; set => _sMotricidad = value; }
        public string sPostura { get => _sPostura; set => _sPostura = value; }
        public string sDistancia { get => _sDistancia; set => _sDistancia = value; }
        public string sDisposicion { get => _sDisposicion; set => _sDisposicion = value; }
        public string sEmpatia { get => _sEmpatia; set => _sEmpatia = value; }
        public string sEmotividad { get => _sEmotividad; set => _sEmotividad = value; }
        public string sOrientacion { get => _sOrientacion; set => _sOrientacion = value; }
        public string sComportamiento { get => _sComportamiento; set => _sComportamiento = value; }
        public string sComunicacion { get => _sComunicacion; set => _sComunicacion = value; }
        public string sCapacidad_de_Juicio { get => _sCapacidad_de_Juicio; set => _sCapacidad_de_Juicio = value; }
        public DateTime dtFecha_de_Entrevista { get => _dtFecha_de_Entrevista; set => _dtFecha_de_Entrevista = value; }
        public DateTime dtFecha_de_Registro { get => _dtFecha_de_Registro; set => _dtFecha_de_Registro = value; }

        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iIdUsuarioGlobal { get => _iIdUsuarioGlobal; set => _iIdUsuarioGlobal = value; }

        #endregion
    }
}
