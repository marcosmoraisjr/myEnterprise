using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace portal.DAL
{
    public class EMPRESAS_EXTENSAO
    {
        //MARCOS: retorna nome da empresa
        public String getEmpresaNomeFantasia(Int32 _id)
        {
            DAL.EMPRESAS empresa = new DAL.EMPRESAS(); 
            String ISQL = "SELECT empresasID, empresasNomeFantasia FROM empresas WHERE empresasID = " + _id.ToString() + " ";
            DataTable dt = empresa.FindQueryDataTable(ISQL);
            int numrows = dt.Rows.Count;
            if (numrows > 0)
            {
                return dt.Rows[0].ItemArray[1].ToString();
            }
            else
            {
                return "NOME DA EMPRESA";
            }

        }
        public String getEmpresaNomeSocial(Int32 _id)
        {
            DAL.EMPRESAS empresa = new DAL.EMPRESAS();
            String ISQL = "SELECT empresasID, empresasNomeSocial FROM empresas WHERE empresasID = " + _id.ToString() + " ";
            DataTable dt = empresa.FindQueryDataTable(ISQL);
            int numrows = dt.Rows.Count;
            if (numrows > 0)
            {
                return dt.Rows[0].ItemArray[1].ToString();
            }
            else
            {
                return "NOME DA EMPRESA";
            }

        }
    }
}
