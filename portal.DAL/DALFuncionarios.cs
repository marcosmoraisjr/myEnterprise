using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace portal.DAL
{
    public class FUNCIONARIOS_EXTENSAO
    {
        /// <summary>
        /// Seleciona todos os registros por uma query parametrizavel.
        /// </summary>
        /// <param name="query">filtro de consulta</param>
        /// <returns>ArrayList</returns>
        public ArrayList retornarQueryArrayList(String query)
        {
            var connect = dados.stringConnection;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    ArrayList lista = new ArrayList();
                    while (dr.Read())
                    {
                        TAB.FUNCIONARIOS registro = new TAB.FUNCIONARIOS();
                        registro.funcionarioID = Convert.ToInt32(dr["funcionarioID"]);
                        registro.funcionarioNOME = dr["funcionarioNome"].ToString();
                        registro.funcionarioEMail = dr["funcionarioEMail"].ToString();
                        registro.funcionarioCargo = dr["funcionarioCargo"].ToString();
                        lista.Add(registro);
                    }
                    dr.Close();
                    conn.Close();
                    return lista;
                }
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNascimento.
        /// </summary>
        /// <param name="_funcionarioNascimento">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNascimento(DateTime _funcionarioNascimento, string _orderby)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");
            query.Append(" funcionarioID, funcionarioNome, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPg, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO  ");
            query.Append(" FROM FUNCIONARIOS  ");
            query.Append(" WHERE (  funcionarioNascimento = CONVERT(DATETIME, '" + _funcionarioNascimento + " 00:00:00', 103)  ) ");
            query.Append(" ORDER BY " + _orderby);

            var connect = dados.stringConnection;
            var ds = new DataSet();
            using (var conn = new SqlConnection(connect))
            {
                using (var cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNascimento.
        /// </summary>
        /// <param name="_funcionarioNascimento">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNascimentoMes(String _funcionarioNascimentoMes, string _orderby)
        {

            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");
            query.Append(" funcionarioNome,funcionarioEmail,funcionarioCargo,funcionarioNascimento,funcionarioAdmissao ");
            query.Append(" FROM FUNCIONARIOS  ");
            query.Append(" WHERE funcionarioInativo=0 AND (  (MONTH(funcionarioNascimento) = '" + _funcionarioNascimentoMes + "'))");
            query.Append(" ORDER BY " + _orderby);

            var connect = dados.stringConnection;
            var ds = new DataSet();
            using (var conn = new SqlConnection(connect))
            {
                using (var cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNascimento.
        /// </summary>
        /// <param name="_funcionarioNascimento">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNascimentoMes(String _funcionarioNascimentoMes)
        {

            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");
            query.Append(" funcionarioNome,funcionarioEmail,funcionarioCargo,funcionarioNascimento,funcionarioAdmissao  ");
            query.Append(" FROM  FUNCIONARIOS  ");
            query.Append(" WHERE funcionarioInativo=0 AND (  (MONTH(funcionarioNascimento) = '" + _funcionarioNascimentoMes + "'))");
            query.Append(" ORDER BY DAY(funcionarioNascimento)");

            var connect = dados.stringConnection;
            var ds = new DataSet();
            using (var conn = new SqlConnection(connect))
            {
                using (var cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNascimento.
        /// </summary>
        /// <param name="_funcionarioNascimento">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNascimentoMesDia(String _funcionarioNascimentoMes, String _funcionarioNascimentoDia)
        {

            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");
            query.Append(" funcionarioNome,funcionarioEmail,funcionarioCargo,funcionarioNascimento,funcionarioAdmissao  ");
            query.Append(" FROM  FUNCIONARIOS  ");
            query.Append(" WHERE funcionarioInativo=0 AND ((MONTH(funcionarioNascimento) = '" + _funcionarioNascimentoMes + "')) AND ((DAY(funcionarioNascimento) = '" + _funcionarioNascimentoDia + "'))");
            query.Append(" ORDER BY DAY(funcionarioNascimento)");

            var connect = dados.stringConnection;
            var ds = new DataSet();
            using (var conn = new SqlConnection(connect))
            {
                using (var cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNascimento.
        /// </summary>
        /// <param name="query">filtro de consulta</param>
        /// <returns>ArrayList</returns>
        public ArrayList retornarQueryArrayList_funcionarioNascimentoMesDia(String _funcionarioNascimentoMes, String _funcionarioNascimentoDia)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT ");
            query.Append(" funcionarioNome,funcionarioEmail,funcionarioCargo,funcionarioNascimento,funcionarioAdmissao  ");
            query.Append(" FROM  FUNCIONARIOS  ");
            query.Append(" WHERE funcionarioInativo=0 AND ((MONTH(funcionarioNascimento) = '" + _funcionarioNascimentoMes + "')) AND ((DAY(funcionarioNascimento) = '" + _funcionarioNascimentoDia + "'))");
            query.Append(" ORDER BY DAY(funcionarioNascimento)");

            var connect = dados.stringConnection;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand(query.ToString(), conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    ArrayList lista = new ArrayList();
                    while (dr.Read())
                    {
                        TAB.FUNCIONARIOS registro = new TAB.FUNCIONARIOS();
                        registro.funcionarioID = Convert.ToInt32(dr["funcionarioID"]);
                        registro.funcionarioNOME = dr["funcionarioNome"].ToString();
                        registro.funcionarioEMail = dr["funcionarioEMail"].ToString();
                        registro.funcionarioCargo = dr["funcionarioCargo"].ToString();
                        lista.Add(registro);
                    }
                    dr.Close();
                    conn.Close();
                    return lista;
                }
            }
        }

    }
}
