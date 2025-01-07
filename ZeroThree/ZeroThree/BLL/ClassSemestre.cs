using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using ZeroThree.DAL;
using ZeroThree.DAL.DataSetGeneralTableAdapters;

namespace ZeroThree.BLL
{
    public class ClassSemestre
    {
        private SemestreTableAdapter sem = new SemestreTableAdapter();

        private SemestreTableAdapter SEMESTRE
        {
            get
            {
                if (sem == null)
                    sem = new SemestreTableAdapter();
                return sem;
            }
        }
        //Metodos
        public DataTable ObtenerSemestre()
        {
            return SEMESTRE.GetData();
        }

        public int InsertarSemestre(int cod, string semestre)
        {
            try
            {
                SEMESTRE.InsertarSemestre(cod, semestre);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}