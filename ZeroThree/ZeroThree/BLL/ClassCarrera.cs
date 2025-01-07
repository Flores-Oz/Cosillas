using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ZeroThree.DAL.DataSetGeneralTableAdapters;

namespace ZeroThree.BLL
{
    public class ClassCarrera
    {
        private CarreraTableAdapter carr = new CarreraTableAdapter();
        private CarreraTableAdapter CARRERA
        {
            get
            {
                if (carr == null)
                    carr = new CarreraTableAdapter();
                return carr;
            }
        }
        //Metodos
        public DataTable ListarCarreras()
        {
            return CARRERA.GetData();
        }
        public int InsertarCarreras(string id, string carrera, bool est)
        {
            try
            {
                CARRERA.InsertarCarrera(id,carrera,est);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int ActualizarEstadoCarrera(string id, bool est)
        {
            try
            {
                CARRERA.ActualizarEstadoCarrera(est, id);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}