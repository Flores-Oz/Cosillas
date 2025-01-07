using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ZeroThree.DAL.DataSetGeneralTableAdapters;

namespace ZeroThree.BLL
{
    public class ClassCurso
    {
        private CursoTableAdapter cur = new CursoTableAdapter();

        private CursoTableAdapter CURSO
        {
            get
            {
                if (cur == null)
                    cur = new CursoTableAdapter();
                return cur;
            }
        }
        //Metodos
        public DataTable ListarCursos()
        {
            return CURSO.GetData();
        }
        public int InsertarCurso(string id, string nomCurso, int credit, string idCarrera, int idSem)
        {
            try
            {
                CURSO.InsertarCurso(id, nomCurso, credit, idCarrera, idSem);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}