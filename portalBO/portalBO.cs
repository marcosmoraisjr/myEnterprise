using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace portalBO
{

    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class AUDITORIABO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaID.
        /// </summary>
        /// <param name="_auditoriaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaID(int _auditoriaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaID =   " + _auditoriaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaID.
        /// </summary>
        /// <param name="_auditoriaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaID(int _auditoriaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaID =   " + _auditoriaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaEmpresaID.
        /// </summary>
        /// <param name="_auditoriaEmpresaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaEmpresaID(int _auditoriaEmpresaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaEmpresaID =   " + _auditoriaEmpresaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaEmpresaID.
        /// </summary>
        /// <param name="_auditoriaEmpresaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaEmpresaID(int _auditoriaEmpresaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaEmpresaID =   " + _auditoriaEmpresaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaData.
        /// </summary>
        /// <param name="_auditoriaData">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaData(DateTime _auditoriaData)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaData = CONVERT(DATETIME, '" + _auditoriaData + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaData.
        /// </summary>
        /// <param name="_auditoriaData">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaData(DateTime _auditoriaData, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaData = CONVERT(DATETIME, '" + _auditoriaData + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaInicio.
        /// </summary>
        /// <param name="_auditoriaInicio">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaInicio(DateTime _auditoriaInicio)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaInicio = CONVERT(DATETIME, '" + _auditoriaInicio + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaInicio.
        /// </summary>
        /// <param name="_auditoriaInicio">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaInicio(DateTime _auditoriaInicio, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaInicio = CONVERT(DATETIME, '" + _auditoriaInicio + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaFim.
        /// </summary>
        /// <param name="_auditoriaFim">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaFim(DateTime _auditoriaFim)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaFim = CONVERT(DATETIME, '" + _auditoriaFim + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaFim.
        /// </summary>
        /// <param name="_auditoriaFim">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaFim(DateTime _auditoriaFim, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaFim = CONVERT(DATETIME, '" + _auditoriaFim + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaUsuario.
        /// </summary>
        /// <param name="_auditoriaUsuario">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaUsuario(string _auditoriaUsuario)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaUsuario =  '" + _auditoriaUsuario + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaUsuario.
        /// </summary>
        /// <param name="_auditoriaUsuario">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaUsuario(string _auditoriaUsuario, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaUsuario =  '" + _auditoriaUsuario + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaPerfil.
        /// </summary>
        /// <param name="_auditoriaPerfil">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaPerfil(string _auditoriaPerfil)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaPerfil =  '" + _auditoriaPerfil + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaPerfil.
        /// </summary>
        /// <param name="_auditoriaPerfil">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaPerfil(string _auditoriaPerfil, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaPerfil =  '" + _auditoriaPerfil + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaAcoes.
        /// </summary>
        /// <param name="_auditoriaAcoes">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaAcoes(StringBuilder _auditoriaAcoes)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaAcoes =  '" + _auditoriaAcoes + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaAcoes.
        /// </summary>
        /// <param name="_auditoriaAcoes">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaAcoes(StringBuilder _auditoriaAcoes, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaAcoes =  '" + _auditoriaAcoes + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaTerminal.
        /// </summary>
        /// <param name="_auditoriaTerminal">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaTerminal(string _auditoriaTerminal)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaTerminal =  '" + _auditoriaTerminal + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaTerminal.
        /// </summary>
        /// <param name="_auditoriaTerminal">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaTerminal(string _auditoriaTerminal, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaTerminal =  '" + _auditoriaTerminal + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaIP.
        /// </summary>
        /// <param name="_auditoriaIP">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaIP(string _auditoriaIP)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaIP =  '" + _auditoriaIP + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por auditoriaIP.
        /// </summary>
        /// <param name="_auditoriaIP">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_auditoriaIP(string _auditoriaIP, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" auditoriaID, auditoriaEmpresaID, auditoriaData, auditoriaInicio, auditoriaFim, auditoriaUsuario, auditoriaPerfil, auditoriaAcoes, auditoriaTerminal, auditoriaIP  ");
                strSql.Append(" FROM  AUDITORIA  ");
                strSql.Append(" WHERE (  auditoriaIP =  '" + _auditoriaIP + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "AUDITORIA");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.AUDITORIAVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  AUDITORIA  ");
                strSql.Append(" (");
                strSql.Append(" auditoriaEmpresaID, ");
                strSql.Append(" auditoriaData, ");
                strSql.Append(" auditoriaInicio, ");
                strSql.Append(" auditoriaFim, ");
                strSql.Append(" auditoriaUsuario, ");
                strSql.Append(" auditoriaPerfil, ");
                strSql.Append(" auditoriaAcoes, ");
                strSql.Append(" auditoriaTerminal, ");
                strSql.Append(" auditoriaIP ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.auditoriaEmpresaID + " , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.auditoriaData + "', 103) , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.auditoriaInicio + "', 103) , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.auditoriaFim + "', 103) , ");
                strSql.Append("  '" + _vo.auditoriaUsuario + "' , ");
                strSql.Append("  '" + _vo.auditoriaPerfil + "' , ");
                strSql.Append("  '" + _vo.auditoriaAcoes + "' , ");
                strSql.Append("  '" + _vo.auditoriaTerminal + "' , ");
                strSql.Append("  '" + _vo.auditoriaIP + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.AUDITORIAVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  AUDITORIA  ");
                strSql.Append(" SET ");

                strSql.Append("   auditoriaEmpresaID =   " + _vo.auditoriaEmpresaID + " ,  ");
                strSql.Append("   auditoriaData = CONVERT(DATETIME, '" + _vo.auditoriaData + "', 103) ,  ");
                strSql.Append("   auditoriaInicio = CONVERT(DATETIME, '" + _vo.auditoriaInicio + "', 103) ,  ");
                strSql.Append("   auditoriaFim = CONVERT(DATETIME, '" + _vo.auditoriaFim + "', 103) ,  ");
                strSql.Append("   auditoriaUsuario =  '" + _vo.auditoriaUsuario + "' ,  ");
                strSql.Append("   auditoriaPerfil =  '" + _vo.auditoriaPerfil + "' ,  ");
                strSql.Append("   auditoriaAcoes =  '" + _vo.auditoriaAcoes + "' ,  ");
                strSql.Append("   auditoriaTerminal =  '" + _vo.auditoriaTerminal + "' ,  ");
                strSql.Append("   auditoriaIP =  '" + _vo.auditoriaIP + "'   ");

                strSql.Append(" WHERE ( auditoriaID =   " + _vo.auditoriaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.AUDITORIAVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM AUDITORIA  ");
                strSql.Append(" WHERE ( auditoriaID = " + _vo.auditoriaID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class ENDERECOBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                // tabela
                strSql.Append(" FROM  ENDERECO  ");
                // condição 
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por BAIRRO_CODIGO.
        /// </summary>
        /// <param name="_BAIRRO_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_BAIRRO_CODIGO(int _BAIRRO_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  BAIRRO_CODIGO =   " + _BAIRRO_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por BAIRRO_CODIGO.
        /// </summary>
        /// <param name="_BAIRRO_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_BAIRRO_CODIGO(int _BAIRRO_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  BAIRRO_CODIGO =   " + _BAIRRO_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_CODIGO.
        /// </summary>
        /// <param name="_ENDERECO_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_CODIGO(int _ENDERECO_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_CODIGO =   " + _ENDERECO_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_CODIGO.
        /// </summary>
        /// <param name="_ENDERECO_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_CODIGO(int _ENDERECO_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_CODIGO =   " + _ENDERECO_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_CEP.
        /// </summary>
        /// <param name="_ENDERECO_CEP">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_CEP(string _ENDERECO_CEP)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_CEP =  '" + _ENDERECO_CEP + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_CEP.
        /// </summary>
        /// <param name="_ENDERECO_CEP">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_CEP(string _ENDERECO_CEP, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_CEP =  '" + _ENDERECO_CEP + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_LOGRADOURO.
        /// </summary>
        /// <param name="_ENDERECO_LOGRADOURO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_LOGRADOURO(string _ENDERECO_LOGRADOURO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_LOGRADOURO =  '" + _ENDERECO_LOGRADOURO + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_LOGRADOURO.
        /// </summary>
        /// <param name="_ENDERECO_LOGRADOURO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_LOGRADOURO(string _ENDERECO_LOGRADOURO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_LOGRADOURO =  '" + _ENDERECO_LOGRADOURO + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_COMPLEMENTO.
        /// </summary>
        /// <param name="_ENDERECO_COMPLEMENTO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_COMPLEMENTO(string _ENDERECO_COMPLEMENTO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_COMPLEMENTO =  '" + _ENDERECO_COMPLEMENTO + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por ENDERECO_COMPLEMENTO.
        /// </summary>
        /// <param name="_ENDERECO_COMPLEMENTO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_ENDERECO_COMPLEMENTO(string _ENDERECO_COMPLEMENTO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" BAIRRO_CODIGO, ENDERECO_CODIGO, ENDERECO_CEP, ENDERECO_LOGRADOURO, ENDERECO_COMPLEMENTO  ");
                strSql.Append(" FROM  ENDERECO  ");
                strSql.Append(" WHERE (  ENDERECO_COMPLEMENTO =  '" + _ENDERECO_COMPLEMENTO + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "ENDERECO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.ENDERECOVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  ENDERECO  ");
                strSql.Append(" (");

                strSql.Append(" ENDERECO_CODIGO, ");
                strSql.Append(" ENDERECO_CEP, ");
                strSql.Append(" ENDERECO_LOGRADOURO, ");
                strSql.Append(" ENDERECO_COMPLEMENTO ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.ENDERECO_CODIGO + " , ");
                strSql.Append("  '" + _vo.ENDERECO_CEP + "' , ");
                strSql.Append("  '" + _vo.ENDERECO_LOGRADOURO + "' , ");
                strSql.Append("  '" + _vo.ENDERECO_COMPLEMENTO + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.ENDERECOVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  ENDERECO  ");
                strSql.Append(" SET ");

                strSql.Append("   ENDERECO_CODIGO =   " + _vo.ENDERECO_CODIGO + " ,  ");
                strSql.Append("   ENDERECO_CEP =  '" + _vo.ENDERECO_CEP + "' ,  ");
                strSql.Append("   ENDERECO_LOGRADOURO =  '" + _vo.ENDERECO_LOGRADOURO + "' ,  ");
                strSql.Append("   ENDERECO_COMPLEMENTO =  '" + _vo.ENDERECO_COMPLEMENTO + "'   ");

                strSql.Append(" WHERE ( BAIRRO_CODIGO =   " + _vo.BAIRRO_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.ENDERECOVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM ENDERECO  ");
                strSql.Append(" WHERE ( BAIRRO_CODIGO = " + _vo.BAIRRO_CODIGO + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }
    
    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class BAIRROBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_CODIGO.
        /// </summary>
        /// <param name="_CIDADE_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_CODIGO(int _CIDADE_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE (  CIDADE_CODIGO =   " + _CIDADE_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_CODIGO.
        /// </summary>
        /// <param name="_CIDADE_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_CODIGO(int _CIDADE_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE (  CIDADE_CODIGO =   " + _CIDADE_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por BAIRRO_CODIGO.
        /// </summary>
        /// <param name="_BAIRRO_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_BAIRRO_CODIGO(int _BAIRRO_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE (  BAIRRO_CODIGO =   " + _BAIRRO_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por BAIRRO_CODIGO.
        /// </summary>
        /// <param name="_BAIRRO_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_BAIRRO_CODIGO(int _BAIRRO_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE (  BAIRRO_CODIGO =   " + _BAIRRO_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por BAIRRO_DESCRICAO.
        /// </summary>
        /// <param name="_BAIRRO_DESCRICAO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_BAIRRO_DESCRICAO(string _BAIRRO_DESCRICAO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE (  BAIRRO_DESCRICAO =  '" + _BAIRRO_DESCRICAO + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por BAIRRO_DESCRICAO.
        /// </summary>
        /// <param name="_BAIRRO_DESCRICAO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_BAIRRO_DESCRICAO(string _BAIRRO_DESCRICAO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" CIDADE_CODIGO, BAIRRO_CODIGO, BAIRRO_DESCRICAO  ");
                strSql.Append(" FROM  BAIRRO  ");
                strSql.Append(" WHERE (  BAIRRO_DESCRICAO =  '" + _BAIRRO_DESCRICAO + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "BAIRRO");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.BAIRROVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  BAIRRO  ");
                strSql.Append(" (");

                strSql.Append(" BAIRRO_CODIGO, ");
                strSql.Append(" BAIRRO_DESCRICAO ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.BAIRRO_CODIGO + " , ");
                strSql.Append("  '" + _vo.BAIRRO_DESCRICAO + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.BAIRROVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  BAIRRO  ");
                strSql.Append(" SET ");

                strSql.Append("   BAIRRO_CODIGO =   " + _vo.BAIRRO_CODIGO + " ,  ");
                strSql.Append("   BAIRRO_DESCRICAO =  '" + _vo.BAIRRO_DESCRICAO + "'   ");

                strSql.Append(" WHERE ( CIDADE_CODIGO =   " + _vo.CIDADE_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.BAIRROVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM BAIRRO  ");
                strSql.Append(" WHERE ( CIDADE_CODIGO = " + _vo.CIDADE_CODIGO + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class CIDADEBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_CODIGO.
        /// </summary>
        /// <param name="_UF_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_CODIGO(int _UF_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  UF_CODIGO =   " + _UF_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_CODIGO.
        /// </summary>
        /// <param name="_UF_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_CODIGO(int _UF_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  UF_CODIGO =   " + _UF_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_CODIGO.
        /// </summary>
        /// <param name="_CIDADE_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_CODIGO(int _CIDADE_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  CIDADE_CODIGO =   " + _CIDADE_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_CODIGO.
        /// </summary>
        /// <param name="_CIDADE_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_CODIGO(int _CIDADE_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  CIDADE_CODIGO =   " + _CIDADE_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_DESCRICAO.
        /// </summary>
        /// <param name="_CIDADE_DESCRICAO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_DESCRICAO(string _CIDADE_DESCRICAO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  CIDADE_DESCRICAO =  '" + _CIDADE_DESCRICAO + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_DESCRICAO.
        /// </summary>
        /// <param name="_CIDADE_DESCRICAO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_DESCRICAO(string _CIDADE_DESCRICAO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  CIDADE_DESCRICAO =  '" + _CIDADE_DESCRICAO + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_CEP.
        /// </summary>
        /// <param name="_CIDADE_CEP">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_CEP(string _CIDADE_CEP)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  CIDADE_CEP =  '" + _CIDADE_CEP + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por CIDADE_CEP.
        /// </summary>
        /// <param name="_CIDADE_CEP">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_CIDADE_CEP(string _CIDADE_CEP, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, CIDADE_CODIGO, CIDADE_DESCRICAO, CIDADE_CEP  ");
                strSql.Append(" FROM  CIDADE  ");
                strSql.Append(" WHERE (  CIDADE_CEP =  '" + _CIDADE_CEP + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "CIDADE");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.CIDADEVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  CIDADE  ");
                strSql.Append(" (");

                strSql.Append(" CIDADE_CODIGO, ");
                strSql.Append(" CIDADE_DESCRICAO, ");
                strSql.Append(" CIDADE_CEP ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.CIDADE_CODIGO + " , ");
                strSql.Append("  '" + _vo.CIDADE_DESCRICAO + "' , ");
                strSql.Append("  '" + _vo.CIDADE_CEP + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.CIDADEVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  CIDADE  ");
                strSql.Append(" SET ");

                strSql.Append("   CIDADE_CODIGO =   " + _vo.CIDADE_CODIGO + " ,  ");
                strSql.Append("   CIDADE_DESCRICAO =  '" + _vo.CIDADE_DESCRICAO + "' ,  ");
                strSql.Append("   CIDADE_CEP =  '" + _vo.CIDADE_CEP + "'   ");

                strSql.Append(" WHERE ( UF_CODIGO =   " + _vo.UF_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.CIDADEVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM CIDADE  ");
                strSql.Append(" WHERE ( UF_CODIGO = " + _vo.UF_CODIGO + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class UFBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_CODIGO.
        /// </summary>
        /// <param name="_UF_CODIGO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_CODIGO(int _UF_CODIGO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE (  UF_CODIGO =   " + _UF_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_CODIGO.
        /// </summary>
        /// <param name="_UF_CODIGO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_CODIGO(int _UF_CODIGO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE (  UF_CODIGO =   " + _UF_CODIGO + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_SIGLA.
        /// </summary>
        /// <param name="_UF_SIGLA">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_SIGLA(string _UF_SIGLA)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE (  UF_SIGLA =  '" + _UF_SIGLA + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_SIGLA.
        /// </summary>
        /// <param name="_UF_SIGLA">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_SIGLA(string _UF_SIGLA, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE (  UF_SIGLA =  '" + _UF_SIGLA + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_DESCRICAO.
        /// </summary>
        /// <param name="_UF_DESCRICAO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_DESCRICAO(string _UF_DESCRICAO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE (  UF_DESCRICAO =  '" + _UF_DESCRICAO + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por UF_DESCRICAO.
        /// </summary>
        /// <param name="_UF_DESCRICAO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_UF_DESCRICAO(string _UF_DESCRICAO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" UF_CODIGO, UF_SIGLA, UF_DESCRICAO  ");
                strSql.Append(" FROM  UF  ");
                strSql.Append(" WHERE (  UF_DESCRICAO =  '" + _UF_DESCRICAO + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "UF");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.UFVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  UF  ");
                strSql.Append(" (");

                strSql.Append(" UF_SIGLA, ");
                strSql.Append(" UF_DESCRICAO ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append("  '" + _vo.UF_SIGLA + "' , ");
                strSql.Append("  '" + _vo.UF_DESCRICAO + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.UFVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  UF  ");
                strSql.Append(" SET ");

                strSql.Append("   UF_SIGLA =  '" + _vo.UF_SIGLA + "' ,  ");
                strSql.Append("   UF_DESCRICAO =  '" + _vo.UF_DESCRICAO + "'   ");

                strSql.Append(" WHERE ( UF_CODIGO =   " + _vo.UF_CODIGO + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.UFVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM UF  ");
                strSql.Append(" WHERE ( UF_CODIGO = " + _vo.UF_CODIGO + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }

    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class DOWNLOADSBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadID.
        /// </summary>
        /// <param name="_downloadID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadID(int _downloadID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadID =   " + _downloadID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadID.
        /// </summary>
        /// <param name="_downloadID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadID(int _downloadID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadID =   " + _downloadID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadEmpresaID.
        /// </summary>
        /// <param name="_downloadEmpresaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadEmpresaID(int _downloadEmpresaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadEmpresaID =   " + _downloadEmpresaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadEmpresaID.
        /// </summary>
        /// <param name="_downloadEmpresaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadEmpresaID(int _downloadEmpresaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadEmpresaID =   " + _downloadEmpresaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadLocal.
        /// </summary>
        /// <param name="_downloadLocal">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadLocal(string _downloadLocal)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadLocal =  '" + _downloadLocal + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadLocal.
        /// </summary>
        /// <param name="_downloadLocal">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadLocal(string _downloadLocal, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadLocal =  '" + _downloadLocal + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadDataCadastro.
        /// </summary>
        /// <param name="_downloadDataCadastro">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadDataCadastro(DateTime _downloadDataCadastro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadDataCadastro = CONVERT(DATETIME, '" + _downloadDataCadastro + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadDataCadastro.
        /// </summary>
        /// <param name="_downloadDataCadastro">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadDataCadastro(DateTime _downloadDataCadastro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadDataCadastro = CONVERT(DATETIME, '" + _downloadDataCadastro + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadNome.
        /// </summary>
        /// <param name="_downloadNome">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadNome(string _downloadNome)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadNome =  '" + _downloadNome + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por downloadNome.
        /// </summary>
        /// <param name="_downloadNome">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_downloadNome(string _downloadNome, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" downloadID, downloadEmpresaID, downloadLocal, downloadDataCadastro, downloadNome  ");
                strSql.Append(" FROM  DOWNLOADS  ");
                strSql.Append(" WHERE (  downloadNome =  '" + _downloadNome + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "DOWNLOADS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.DOWNLOADSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  DOWNLOADS  ");
                strSql.Append(" (");

                strSql.Append(" downloadEmpresaID, ");
                strSql.Append(" downloadLocal, ");
                strSql.Append(" downloadDataCadastro, ");
                strSql.Append(" downloadNome ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.downloadEmpresaID + " , ");
                strSql.Append("  '" + _vo.downloadLocal + "' , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.downloadDataCadastro + "', 103) , ");
                strSql.Append("  '" + _vo.downloadNome + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.DOWNLOADSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  DOWNLOADS  ");
                strSql.Append(" SET ");

                strSql.Append("   downloadEmpresaID =   " + _vo.downloadEmpresaID + " ,  ");
                strSql.Append("   downloadLocal =  '" + _vo.downloadLocal + "' ,  ");
                strSql.Append("   downloadDataCadastro = CONVERT(DATETIME, '" + _vo.downloadDataCadastro + "', 103) ,  ");
                strSql.Append("   downloadNome =  '" + _vo.downloadNome + "'   ");

                strSql.Append(" WHERE ( downloadID =   " + _vo.downloadID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.DOWNLOADSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM DOWNLOADS  ");
                strSql.Append(" WHERE ( downloadID = " + _vo.downloadID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class EMPRESASBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasID.
        /// </summary>
        /// <param name="_empresasID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasID(int _empresasID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasID =   " + _empresasID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasID.
        /// </summary>
        /// <param name="_empresasID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasID(int _empresasID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasID =   " + _empresasID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasNomeFantasia.
        /// </summary>
        /// <param name="_empresasNomeFantasia">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasNomeFantasia(string _empresasNomeFantasia)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasNomeFantasia =  '" + _empresasNomeFantasia + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasNomeFantasia.
        /// </summary>
        /// <param name="_empresasNomeFantasia">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasNomeFantasia(string _empresasNomeFantasia, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasNomeFantasia =  '" + _empresasNomeFantasia + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasNomeSocial.
        /// </summary>
        /// <param name="_empresasNomeSocial">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasNomeSocial(string _empresasNomeSocial)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasNomeSocial =  '" + _empresasNomeSocial + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasNomeSocial.
        /// </summary>
        /// <param name="_empresasNomeSocial">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasNomeSocial(string _empresasNomeSocial, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasNomeSocial =  '" + _empresasNomeSocial + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasContato.
        /// </summary>
        /// <param name="_empresasContato">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasContato(string _empresasContato)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasContato =  '" + _empresasContato + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasContato.
        /// </summary>
        /// <param name="_empresasContato">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasContato(string _empresasContato, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasContato =  '" + _empresasContato + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasEndereco.
        /// </summary>
        /// <param name="_empresasEndereco">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasEndereco(string _empresasEndereco)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasEndereco =  '" + _empresasEndereco + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasEndereco.
        /// </summary>
        /// <param name="_empresasEndereco">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasEndereco(string _empresasEndereco, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasEndereco =  '" + _empresasEndereco + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasEnderecoNr.
        /// </summary>
        /// <param name="_empresasEnderecoNr">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasEnderecoNr(string _empresasEnderecoNr)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasEnderecoNr =  '" + _empresasEnderecoNr + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasEnderecoNr.
        /// </summary>
        /// <param name="_empresasEnderecoNr">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasEnderecoNr(string _empresasEnderecoNr, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasEnderecoNr =  '" + _empresasEnderecoNr + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasBairro.
        /// </summary>
        /// <param name="_empresasBairro">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasBairro(string _empresasBairro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasBairro =  '" + _empresasBairro + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasBairro.
        /// </summary>
        /// <param name="_empresasBairro">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasBairro(string _empresasBairro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasBairro =  '" + _empresasBairro + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasEstado.
        /// </summary>
        /// <param name="_empresasEstado">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasEstado(string _empresasEstado)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasEstado =  '" + _empresasEstado + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasEstado.
        /// </summary>
        /// <param name="_empresasEstado">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasEstado(string _empresasEstado, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasEstado =  '" + _empresasEstado + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasCNPJ.
        /// </summary>
        /// <param name="_empresasCNPJ">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasCNPJ(string _empresasCNPJ)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasCNPJ =  '" + _empresasCNPJ + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasCNPJ.
        /// </summary>
        /// <param name="_empresasCNPJ">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasCNPJ(string _empresasCNPJ, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasCNPJ =  '" + _empresasCNPJ + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasIE.
        /// </summary>
        /// <param name="_empresasIE">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasIE(string _empresasIE)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasIE =  '" + _empresasIE + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasIE.
        /// </summary>
        /// <param name="_empresasIE">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasIE(string _empresasIE, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasIE =  '" + _empresasIE + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasURL.
        /// </summary>
        /// <param name="_empresasURL">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasURL(string _empresasURL)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasURL =  '" + _empresasURL + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasURL.
        /// </summary>
        /// <param name="_empresasURL">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasURL(string _empresasURL, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasURL =  '" + _empresasURL + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasUsuarios.
        /// </summary>
        /// <param name="_empresasUsuarios">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasUsuarios(int _empresasUsuarios)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasUsuarios =   " + _empresasUsuarios + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasUsuarios.
        /// </summary>
        /// <param name="_empresasUsuarios">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasUsuarios(int _empresasUsuarios, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasUsuarios =   " + _empresasUsuarios + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasDataCadastro.
        /// </summary>
        /// <param name="_empresasDataCadastro">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasDataCadastro(DateTime _empresasDataCadastro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasDataCadastro = CONVERT(DATETIME, '" + _empresasDataCadastro + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasDataCadastro.
        /// </summary>
        /// <param name="_empresasDataCadastro">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasDataCadastro(DateTime _empresasDataCadastro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasDataCadastro = CONVERT(DATETIME, '" + _empresasDataCadastro + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasDataLimite.
        /// </summary>
        /// <param name="_empresasDataLimite">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasDataLimite(DateTime _empresasDataLimite)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasDataLimite = CONVERT(DATETIME, '" + _empresasDataLimite + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasDataLimite.
        /// </summary>
        /// <param name="_empresasDataLimite">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasDataLimite(DateTime _empresasDataLimite, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasDataLimite = CONVERT(DATETIME, '" + _empresasDataLimite + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasVersao.
        /// </summary>
        /// <param name="_empresasVersao">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasVersao(string _empresasVersao)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasVersao =  '" + _empresasVersao + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasVersao.
        /// </summary>
        /// <param name="_empresasVersao">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasVersao(string _empresasVersao, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasVersao =  '" + _empresasVersao + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasLiberada.
        /// </summary>
        /// <param name="_empresasLiberada">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasLiberada(byte _empresasLiberada)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasLiberada =   " + _empresasLiberada + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por empresasLiberada.
        /// </summary>
        /// <param name="_empresasLiberada">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_empresasLiberada(byte _empresasLiberada, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" empresasID, empresasNomeFantasia, empresasNomeSocial, empresasContato, empresasEndereco, empresasEnderecoNr, empresasBairro, empresasEstado, empresasCNPJ, empresasIE, empresasURL, empresasUsuarios, empresasDataCadastro, empresasDataLimite, empresasVersao, empresasLiberada  ");
                strSql.Append(" FROM  EMPRESAS  ");
                strSql.Append(" WHERE (  empresasLiberada =   " + _empresasLiberada + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "EMPRESAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.EMPRESASVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  EMPRESAS  ");
                strSql.Append(" (");

                strSql.Append(" empresasNomeFantasia, ");
                strSql.Append(" empresasNomeSocial, ");
                strSql.Append(" empresasContato, ");
                strSql.Append(" empresasEndereco, ");
                strSql.Append(" empresasEnderecoNr, ");
                strSql.Append(" empresasBairro, ");
                strSql.Append(" empresasEstado, ");
                strSql.Append(" empresasCNPJ, ");
                strSql.Append(" empresasIE, ");
                strSql.Append(" empresasURL, ");
                strSql.Append(" empresasUsuarios, ");
                strSql.Append(" empresasDataCadastro, ");
                strSql.Append(" empresasDataLimite, ");
                strSql.Append(" empresasVersao, ");
                strSql.Append(" empresasLiberada ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append("  '" + _vo.empresasNomeFantasia + "' , ");
                strSql.Append("  '" + _vo.empresasNomeSocial + "' , ");
                strSql.Append("  '" + _vo.empresasContato + "' , ");
                strSql.Append("  '" + _vo.empresasEndereco + "' , ");
                strSql.Append("  '" + _vo.empresasEnderecoNr + "' , ");
                strSql.Append("  '" + _vo.empresasBairro + "' , ");
                strSql.Append("  '" + _vo.empresasEstado + "' , ");
                strSql.Append("  '" + _vo.empresasCNPJ + "' , ");
                strSql.Append("  '" + _vo.empresasIE + "' , ");
                strSql.Append("  '" + _vo.empresasURL + "' , ");
                strSql.Append(" " + _vo.empresasUsuarios + " , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.empresasDataCadastro + "', 103) , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.empresasDataLimite + "', 103) , ");
                strSql.Append("  '" + _vo.empresasVersao + "' , ");
                strSql.Append(" " + _vo.empresasLiberada + "  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.EMPRESASVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  EMPRESAS  ");
                strSql.Append(" SET ");

                strSql.Append("   empresasNomeFantasia =  '" + _vo.empresasNomeFantasia + "' ,  ");
                strSql.Append("   empresasNomeSocial =  '" + _vo.empresasNomeSocial + "' ,  ");
                strSql.Append("   empresasContato =  '" + _vo.empresasContato + "' ,  ");
                strSql.Append("   empresasEndereco =  '" + _vo.empresasEndereco + "' ,  ");
                strSql.Append("   empresasEnderecoNr =  '" + _vo.empresasEnderecoNr + "' ,  ");
                strSql.Append("   empresasBairro =  '" + _vo.empresasBairro + "' ,  ");
                strSql.Append("   empresasEstado =  '" + _vo.empresasEstado + "' ,  ");
                strSql.Append("   empresasCNPJ =  '" + _vo.empresasCNPJ + "' ,  ");
                strSql.Append("   empresasIE =  '" + _vo.empresasIE + "' ,  ");
                strSql.Append("   empresasURL =  '" + _vo.empresasURL + "' ,  ");
                strSql.Append("   empresasUsuarios =   " + _vo.empresasUsuarios + " ,  ");
                strSql.Append("   empresasDataCadastro = CONVERT(DATETIME, '" + _vo.empresasDataCadastro + "', 103) ,  ");
                strSql.Append("   empresasDataLimite = CONVERT(DATETIME, '" + _vo.empresasDataLimite + "', 103) ,  ");
                strSql.Append("   empresasVersao =  '" + _vo.empresasVersao + "' ,  ");
                strSql.Append("   empresasLiberada =   " + _vo.empresasLiberada + "   ");

                strSql.Append(" WHERE ( empresasID =   " + _vo.empresasID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.EMPRESASVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM EMPRESAS  ");
                strSql.Append(" WHERE ( empresasID = " + _vo.empresasID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }

    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class FAVORITOSBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosID.
        /// </summary>
        /// <param name="_favoritosID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosID(int _favoritosID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosID =   " + _favoritosID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosID.
        /// </summary>
        /// <param name="_favoritosID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosID(int _favoritosID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosID =   " + _favoritosID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosEmpresaID.
        /// </summary>
        /// <param name="_favoritosEmpresaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosEmpresaID(int _favoritosEmpresaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosEmpresaID =   " + _favoritosEmpresaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosEmpresaID.
        /// </summary>
        /// <param name="_favoritosEmpresaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosEmpresaID(int _favoritosEmpresaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosEmpresaID =   " + _favoritosEmpresaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosURL.
        /// </summary>
        /// <param name="_favoritosURL">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosURL(string _favoritosURL)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosURL =  '" + _favoritosURL + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosURL.
        /// </summary>
        /// <param name="_favoritosURL">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosURL(string _favoritosURL, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosURL =  '" + _favoritosURL + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosDataCadastro.
        /// </summary>
        /// <param name="_favoritosDataCadastro">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosDataCadastro(DateTime _favoritosDataCadastro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosDataCadastro = CONVERT(DATETIME, '" + _favoritosDataCadastro + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosDataCadastro.
        /// </summary>
        /// <param name="_favoritosDataCadastro">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosDataCadastro(DateTime _favoritosDataCadastro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosDataCadastro = CONVERT(DATETIME, '" + _favoritosDataCadastro + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosNome.
        /// </summary>
        /// <param name="_favoritosNome">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosNome(string _favoritosNome)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosNome =  '" + _favoritosNome + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por favoritosNome.
        /// </summary>
        /// <param name="_favoritosNome">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_favoritosNome(string _favoritosNome, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" favoritosID, favoritosEmpresaID, favoritosURL, favoritosDataCadastro, favoritosNome  ");
                strSql.Append(" FROM  FAVORITOS  ");
                strSql.Append(" WHERE (  favoritosNome =  '" + _favoritosNome + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FAVORITOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.FAVORITOSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  FAVORITOS  ");
                strSql.Append(" (");

                strSql.Append(" favoritosEmpresaID, ");
                strSql.Append(" favoritosURL, ");
                strSql.Append(" favoritosDataCadastro, ");
                strSql.Append(" favoritosNome ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.favoritosEmpresaID + " , ");
                strSql.Append("  '" + _vo.favoritosURL + "' , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.favoritosDataCadastro + "', 103) , ");
                strSql.Append("  '" + _vo.favoritosNome + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.FAVORITOSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  FAVORITOS  ");
                strSql.Append(" SET ");

                strSql.Append("   favoritosEmpresaID =   " + _vo.favoritosEmpresaID + " ,  ");
                strSql.Append("   favoritosURL =  '" + _vo.favoritosURL + "' ,  ");
                strSql.Append("   favoritosDataCadastro = CONVERT(DATETIME, '" + _vo.favoritosDataCadastro + "', 103) ,  ");
                strSql.Append("   favoritosNome =  '" + _vo.favoritosNome + "'   ");

                strSql.Append(" WHERE ( favoritosID =   " + _vo.favoritosID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.FAVORITOSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM FAVORITOS  ");
                strSql.Append(" WHERE ( favoritosID = " + _vo.favoritosID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class FUNCIONARIOSBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioID.
        /// </summary>
        /// <param name="_funcionarioID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioID(int _funcionarioID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioID =   " + _funcionarioID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioID.
        /// </summary>
        /// <param name="_funcionarioID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioID(int _funcionarioID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioID =   " + _funcionarioID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEmpresaID.
        /// </summary>
        /// <param name="_funcionarioEmpresaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEmpresaID(int _funcionarioEmpresaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEmpresaID =   " + _funcionarioEmpresaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEmpresaID.
        /// </summary>
        /// <param name="_funcionarioEmpresaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEmpresaID(int _funcionarioEmpresaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEmpresaID =   " + _funcionarioEmpresaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNOME.
        /// </summary>
        /// <param name="_funcionarioNOME">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNOME(string _funcionarioNOME)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioNOME =  '" + _funcionarioNOME + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNOME.
        /// </summary>
        /// <param name="_funcionarioNOME">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNOME(string _funcionarioNOME, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioNOME =  '" + _funcionarioNOME + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEndereco.
        /// </summary>
        /// <param name="_funcionarioEndereco">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEndereco(string _funcionarioEndereco)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEndereco =  '" + _funcionarioEndereco + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEndereco.
        /// </summary>
        /// <param name="_funcionarioEndereco">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEndereco(string _funcionarioEndereco, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEndereco =  '" + _funcionarioEndereco + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioBairro.
        /// </summary>
        /// <param name="_funcionarioBairro">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioBairro(string _funcionarioBairro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioBairro =  '" + _funcionarioBairro + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioBairro.
        /// </summary>
        /// <param name="_funcionarioBairro">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioBairro(string _funcionarioBairro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioBairro =  '" + _funcionarioBairro + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCidade.
        /// </summary>
        /// <param name="_funcionarioCidade">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCidade(string _funcionarioCidade)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCidade =  '" + _funcionarioCidade + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCidade.
        /// </summary>
        /// <param name="_funcionarioCidade">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCidade(string _funcionarioCidade, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCidade =  '" + _funcionarioCidade + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEstado.
        /// </summary>
        /// <param name="_funcionarioEstado">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEstado(string _funcionarioEstado)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEstado =  '" + _funcionarioEstado + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEstado.
        /// </summary>
        /// <param name="_funcionarioEstado">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEstado(string _funcionarioEstado, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEstado =  '" + _funcionarioEstado + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCep.
        /// </summary>
        /// <param name="_funcionarioCep">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCep(string _funcionarioCep)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCep =  '" + _funcionarioCep + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCep.
        /// </summary>
        /// <param name="_funcionarioCep">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCep(string _funcionarioCep, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCep =  '" + _funcionarioCep + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioTelefone.
        /// </summary>
        /// <param name="_funcionarioTelefone">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioTelefone(string _funcionarioTelefone)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioTelefone =  '" + _funcionarioTelefone + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioTelefone.
        /// </summary>
        /// <param name="_funcionarioTelefone">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioTelefone(string _funcionarioTelefone, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioTelefone =  '" + _funcionarioTelefone + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCelular.
        /// </summary>
        /// <param name="_funcionarioCelular">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCelular(string _funcionarioCelular)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCelular =  '" + _funcionarioCelular + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCelular.
        /// </summary>
        /// <param name="_funcionarioCelular">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCelular(string _funcionarioCelular, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCelular =  '" + _funcionarioCelular + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEMail.
        /// </summary>
        /// <param name="_funcionarioEMail">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEMail(string _funcionarioEMail)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEMail =  '" + _funcionarioEMail + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioEMail.
        /// </summary>
        /// <param name="_funcionarioEMail">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioEMail(string _funcionarioEMail, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioEMail =  '" + _funcionarioEMail + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioIdentidade.
        /// </summary>
        /// <param name="_funcionarioIdentidade">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioIdentidade(string _funcionarioIdentidade)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioIdentidade =  '" + _funcionarioIdentidade + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioIdentidade.
        /// </summary>
        /// <param name="_funcionarioIdentidade">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioIdentidade(string _funcionarioIdentidade, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioIdentidade =  '" + _funcionarioIdentidade + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCPF.
        /// </summary>
        /// <param name="_funcionarioCPF">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCPF(string _funcionarioCPF)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCPF =  '" + _funcionarioCPF + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCPF.
        /// </summary>
        /// <param name="_funcionarioCPF">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCPF(string _funcionarioCPF, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCPF =  '" + _funcionarioCPF + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioNascimento.
        /// </summary>
        /// <param name="_funcionarioNascimento">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioNascimento(DateTime _funcionarioNascimento)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioNascimento = CONVERT(DATETIME, '" + _funcionarioNascimento + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
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
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioNascimento = CONVERT(DATETIME, '" + _funcionarioNascimento + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCargo.
        /// </summary>
        /// <param name="_funcionarioCargo">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCargo(string _funcionarioCargo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCargo =  '" + _funcionarioCargo + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCargo.
        /// </summary>
        /// <param name="_funcionarioCargo">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCargo(string _funcionarioCargo, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCargo =  '" + _funcionarioCargo + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioSalario.
        /// </summary>
        /// <param name="_funcionarioSalario">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioSalario(float _funcionarioSalario)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioSalario =   " + _funcionarioSalario + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioSalario.
        /// </summary>
        /// <param name="_funcionarioSalario">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioSalario(float _funcionarioSalario, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioSalario =   " + _funcionarioSalario + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioAdmissao.
        /// </summary>
        /// <param name="_funcionarioAdmissao">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioAdmissao(DateTime _funcionarioAdmissao)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioAdmissao = CONVERT(DATETIME, '" + _funcionarioAdmissao + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioAdmissao.
        /// </summary>
        /// <param name="_funcionarioAdmissao">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioAdmissao(DateTime _funcionarioAdmissao, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioAdmissao = CONVERT(DATETIME, '" + _funcionarioAdmissao + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioDiaPagamento.
        /// </summary>
        /// <param name="_funcionarioDiaPagamento">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioDiaPagamento(Int32 _funcionarioDiaPagamento)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioDiaPagamento =   " + _funcionarioDiaPagamento + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioDiaPagamento.
        /// </summary>
        /// <param name="_funcionarioDiaPagamento">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioDiaPagamento(Int32 _funcionarioDiaPagamento, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioDiaPagamento =   " + _funcionarioDiaPagamento + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioFoto.
        /// </summary>
        /// <param name="_funcionarioFoto">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioFoto(Byte _funcionarioFoto)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioFoto =  '" + _funcionarioFoto + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioFoto.
        /// </summary>
        /// <param name="_funcionarioFoto">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioFoto(Byte _funcionarioFoto, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioFoto =  '" + _funcionarioFoto + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioOBS.
        /// </summary>
        /// <param name="_funcionarioOBS">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioOBS(StringBuilder _funcionarioOBS)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioOBS =  '" + _funcionarioOBS + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioOBS.
        /// </summary>
        /// <param name="_funcionarioOBS">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioOBS(StringBuilder _funcionarioOBS, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioOBS =  '" + _funcionarioOBS + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioInativo.
        /// </summary>
        /// <param name="_funcionarioInativo">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioInativo(byte _funcionarioInativo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioInativo =   " + _funcionarioInativo + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioInativo.
        /// </summary>
        /// <param name="_funcionarioInativo">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioInativo(byte _funcionarioInativo, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioInativo =   " + _funcionarioInativo + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCBO.
        /// </summary>
        /// <param name="_funcionarioCBO">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCBO(string _funcionarioCBO)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCBO =  '" + _funcionarioCBO + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioCBO.
        /// </summary>
        /// <param name="_funcionarioCBO">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioCBO(string _funcionarioCBO, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioCBO =  '" + _funcionarioCBO + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioSetor.
        /// </summary>
        /// <param name="_funcionarioSetor">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioSetor(int _funcionarioSetor)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioSetor =   " + _funcionarioSetor + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por funcionarioSetor.
        /// </summary>
        /// <param name="_funcionarioSetor">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_funcionarioSetor(int _funcionarioSetor, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" funcionarioID, funcionarioEmpresaID, funcionarioNOME, funcionarioEndereco, funcionarioBairro, funcionarioCidade, funcionarioEstado, funcionarioCep, funcionarioTelefone, funcionarioCelular, funcionarioEMail, funcionarioIdentidade, funcionarioCPF, funcionarioNascimento, funcionarioCargo, funcionarioSalario, funcionarioAdmissao, funcionarioDiaPagamento, funcionarioFoto, funcionarioOBS, funcionarioInativo, funcionarioCBO, funcionarioSetor  ");
                strSql.Append(" FROM  FUNCIONARIOS  ");
                strSql.Append(" WHERE (  funcionarioSetor =   " + _funcionarioSetor + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "FUNCIONARIOS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.FUNCIONARIOSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  FUNCIONARIOS  ");
                strSql.Append(" (");

                strSql.Append(" funcionarioEmpresaID, ");
                strSql.Append(" funcionarioNOME, ");
                strSql.Append(" funcionarioEndereco, ");
                strSql.Append(" funcionarioBairro, ");
                strSql.Append(" funcionarioCidade, ");
                strSql.Append(" funcionarioEstado, ");
                strSql.Append(" funcionarioCep, ");
                strSql.Append(" funcionarioTelefone, ");
                strSql.Append(" funcionarioCelular, ");
                strSql.Append(" funcionarioEMail, ");
                strSql.Append(" funcionarioIdentidade, ");
                strSql.Append(" funcionarioCPF, ");
                strSql.Append(" funcionarioNascimento, ");
                strSql.Append(" funcionarioCargo, ");
                strSql.Append(" funcionarioSalario, ");
                strSql.Append(" funcionarioAdmissao, ");
                strSql.Append(" funcionarioDiaPagamento, ");
                strSql.Append(" funcionarioFoto, ");
                strSql.Append(" funcionarioOBS, ");
                strSql.Append(" funcionarioInativo, ");
                strSql.Append(" funcionarioCBO, ");
                strSql.Append(" funcionarioSetor ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.funcionarioEmpresaID + " , ");
                strSql.Append("  '" + _vo.funcionarioNOME + "' , ");
                strSql.Append("  '" + _vo.funcionarioEndereco + "' , ");
                strSql.Append("  '" + _vo.funcionarioBairro + "' , ");
                strSql.Append("  '" + _vo.funcionarioCidade + "' , ");
                strSql.Append("  '" + _vo.funcionarioEstado + "' , ");
                strSql.Append("  '" + _vo.funcionarioCep + "' , ");
                strSql.Append("  '" + _vo.funcionarioTelefone + "' , ");
                strSql.Append("  '" + _vo.funcionarioCelular + "' , ");
                strSql.Append("  '" + _vo.funcionarioEMail + "' , ");
                strSql.Append("  '" + _vo.funcionarioIdentidade + "' , ");
                strSql.Append("  '" + _vo.funcionarioCPF + "' , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.funcionarioNascimento + "', 103) , ");
                strSql.Append("  '" + _vo.funcionarioCargo + "' , ");
                strSql.Append(" " + _vo.funcionarioSalario + " , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.funcionarioAdmissao + "', 103) , ");
                strSql.Append(" " + _vo.funcionarioDiaPagamento + " , ");
                strSql.Append("  '" + _vo.funcionarioFoto + "' , ");
                strSql.Append("  '" + _vo.funcionarioOBS + "' , ");
                strSql.Append(" " + _vo.funcionarioInativo + " , ");
                strSql.Append("  '" + _vo.funcionarioCBO + "' , ");
                strSql.Append(" " + _vo.funcionarioSetor + "  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.FUNCIONARIOSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  FUNCIONARIOS  ");
                strSql.Append(" SET ");

                strSql.Append("   funcionarioEmpresaID =   " + _vo.funcionarioEmpresaID + " ,  ");
                strSql.Append("   funcionarioNOME =  '" + _vo.funcionarioNOME + "' ,  ");
                strSql.Append("   funcionarioEndereco =  '" + _vo.funcionarioEndereco + "' ,  ");
                strSql.Append("   funcionarioBairro =  '" + _vo.funcionarioBairro + "' ,  ");
                strSql.Append("   funcionarioCidade =  '" + _vo.funcionarioCidade + "' ,  ");
                strSql.Append("   funcionarioEstado =  '" + _vo.funcionarioEstado + "' ,  ");
                strSql.Append("   funcionarioCep =  '" + _vo.funcionarioCep + "' ,  ");
                strSql.Append("   funcionarioTelefone =  '" + _vo.funcionarioTelefone + "' ,  ");
                strSql.Append("   funcionarioCelular =  '" + _vo.funcionarioCelular + "' ,  ");
                strSql.Append("   funcionarioEMail =  '" + _vo.funcionarioEMail + "' ,  ");
                strSql.Append("   funcionarioIdentidade =  '" + _vo.funcionarioIdentidade + "' ,  ");
                strSql.Append("   funcionarioCPF =  '" + _vo.funcionarioCPF + "' ,  ");
                strSql.Append("   funcionarioNascimento = CONVERT(DATETIME, '" + _vo.funcionarioNascimento + "', 103) ,  ");
                strSql.Append("   funcionarioCargo =  '" + _vo.funcionarioCargo + "' ,  ");
                strSql.Append("   funcionarioSalario =   " + _vo.funcionarioSalario + " ,  ");
                strSql.Append("   funcionarioAdmissao = CONVERT(DATETIME, '" + _vo.funcionarioAdmissao + "', 103) ,  ");
                strSql.Append("   funcionarioDiaPagamento =   " + _vo.funcionarioDiaPagamento + " ,  ");
                strSql.Append("   funcionarioFoto =  '" + _vo.funcionarioFoto + "' ,  ");
                strSql.Append("   funcionarioOBS =  '" + _vo.funcionarioOBS + "' ,  ");
                strSql.Append("   funcionarioInativo =   " + _vo.funcionarioInativo + " ,  ");
                strSql.Append("   funcionarioCBO =  '" + _vo.funcionarioCBO + "' ,  ");
                strSql.Append("   funcionarioSetor =   " + _vo.funcionarioSetor + "   ");

                strSql.Append(" WHERE ( funcionarioID =   " + _vo.funcionarioID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.FUNCIONARIOSVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM FUNCIONARIOS  ");
                strSql.Append(" WHERE ( funcionarioID = " + _vo.funcionarioID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class MENUBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuID.
        /// </summary>
        /// <param name="_menuID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuID(int _menuID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuID =   " + _menuID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuID.
        /// </summary>
        /// <param name="_menuID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuID(int _menuID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuID =   " + _menuID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuEmpresaID.
        /// </summary>
        /// <param name="_menuEmpresaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuEmpresaID(int _menuEmpresaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuEmpresaID =   " + _menuEmpresaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuEmpresaID.
        /// </summary>
        /// <param name="_menuEmpresaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuEmpresaID(int _menuEmpresaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuEmpresaID =   " + _menuEmpresaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuNome.
        /// </summary>
        /// <param name="_menuNome">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuNome(string _menuNome)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuNome =  '" + _menuNome + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuNome.
        /// </summary>
        /// <param name="_menuNome">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuNome(string _menuNome, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuNome =  '" + _menuNome + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuDescricao.
        /// </summary>
        /// <param name="_menuDescricao">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuDescricao(string _menuDescricao)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuDescricao =  '" + _menuDescricao + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuDescricao.
        /// </summary>
        /// <param name="_menuDescricao">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuDescricao(string _menuDescricao, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuDescricao =  '" + _menuDescricao + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuIdPai.
        /// </summary>
        /// <param name="_menuIdPai">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuIdPai(int _menuIdPai)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuIdPai =   " + _menuIdPai + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuIdPai.
        /// </summary>
        /// <param name="_menuIdPai">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuIdPai(int _menuIdPai, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuIdPai =   " + _menuIdPai + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuLink.
        /// </summary>
        /// <param name="_menuLink">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuLink(string _menuLink)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuLink =  '" + _menuLink + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por menuLink.
        /// </summary>
        /// <param name="_menuLink">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_menuLink(string _menuLink, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" menuID, menuEmpresaID, menuNome, menuDescricao, menuIdPai, menuLink  ");
                strSql.Append(" FROM  MENU  ");
                strSql.Append(" WHERE (  menuLink =  '" + _menuLink + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "MENU");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.MENUVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  MENU  ");
                strSql.Append(" (");

                strSql.Append(" menuEmpresaID, ");
                strSql.Append(" menuNome, ");
                strSql.Append(" menuDescricao, ");
                strSql.Append(" menuIdPai, ");
                strSql.Append(" menuLink ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.menuEmpresaID + " , ");
                strSql.Append("  '" + _vo.menuNome + "' , ");
                strSql.Append("  '" + _vo.menuDescricao + "' , ");
                strSql.Append(" " + _vo.menuIdPai + " , ");
                strSql.Append("  '" + _vo.menuLink + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.MENUVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  MENU  ");
                strSql.Append(" SET ");

                strSql.Append("   menuEmpresaID =   " + _vo.menuEmpresaID + " ,  ");
                strSql.Append("   menuNome =  '" + _vo.menuNome + "' ,  ");
                strSql.Append("   menuDescricao =  '" + _vo.menuDescricao + "' ,  ");
                strSql.Append("   menuIdPai =   " + _vo.menuIdPai + " ,  ");
                strSql.Append("   menuLink =  '" + _vo.menuLink + "'   ");

                strSql.Append(" WHERE ( menuID =   " + _vo.menuID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.MENUVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM MENU  ");
                strSql.Append(" WHERE ( menuID = " + _vo.menuID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }


    /// <summary>
    /// Classe BO: Business Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class SISTEMASBO
    {

        // Atributos
        private portalDO.portalDO objDO = null;
        private StringBuilder strSql = null;

        //Métodos
        /// <summary>
        /// Seleciona todos os registros e retorna um DataSet.
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet FindAll()
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com ordenação e retorna um DataSet.
        /// </summary>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindAll(string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros com filtro e ordenação.
        /// </summary>
        /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindByWhere(string _filtro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE ( " + _filtro + " ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasID.
        /// </summary>
        /// <param name="_sistemasID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasID(int _sistemasID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasID =   " + _sistemasID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasID.
        /// </summary>
        /// <param name="_sistemasID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasID(int _sistemasID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasID =   " + _sistemasID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasEmpresaID.
        /// </summary>
        /// <param name="_sistemasEmpresaID">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasEmpresaID(int _sistemasEmpresaID)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasEmpresaID =   " + _sistemasEmpresaID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasEmpresaID.
        /// </summary>
        /// <param name="_sistemasEmpresaID">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasEmpresaID(int _sistemasEmpresaID, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasEmpresaID =   " + _sistemasEmpresaID + "  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasURL.
        /// </summary>
        /// <param name="_sistemasURL">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasURL(string _sistemasURL)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasURL =  '" + _sistemasURL + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasURL.
        /// </summary>
        /// <param name="_sistemasURL">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasURL(string _sistemasURL, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasURL =  '" + _sistemasURL + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasDataCadastro.
        /// </summary>
        /// <param name="_sistemasDataCadastro">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasDataCadastro(DateTime _sistemasDataCadastro)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasDataCadastro = CONVERT(DATETIME, '" + _sistemasDataCadastro + "', 103)  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasDataCadastro.
        /// </summary>
        /// <param name="_sistemasDataCadastro">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasDataCadastro(DateTime _sistemasDataCadastro, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasDataCadastro = CONVERT(DATETIME, '" + _sistemasDataCadastro + "', 103)  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasNome.
        /// </summary>
        /// <param name="_sistemasNome">filtro da consulta</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasNome(string _sistemasNome)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasNome =  '" + _sistemasNome + "'  ) ");

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Seleciona todos os registros por sistemasNome.
        /// </summary>
        /// <param name="_sistemasNome">filtro da consulta</param>
        /// <param name="_orderby">campo de ordenação</param>
        /// <returns>DataSet</returns>
        public DataSet FindBy_sistemasNome(string _sistemasNome, string _orderby)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" SELECT ");
                // colunas
                strSql.Append(" sistemasID, sistemasEmpresaID, sistemasURL, sistemasDataCadastro, sistemasNome  ");
                strSql.Append(" FROM  SISTEMAS  ");
                strSql.Append(" WHERE (  sistemasNome =  '" + _sistemasNome + "'  ) ");
                strSql.Append(" ORDER BY " + _orderby);

                objDO = new portalDO.portalDO();

                // executa consulta e retorna um DataSet
                return objDO.GetDataSet(strSql.ToString(), "SISTEMAS");
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Insere os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Insert(portalVO.SISTEMASVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" INSERT INTO  SISTEMAS  ");
                strSql.Append(" (");

                strSql.Append(" sistemasEmpresaID, ");
                strSql.Append(" sistemasURL, ");
                strSql.Append(" sistemasDataCadastro, ");
                strSql.Append(" sistemasNome ");
                strSql.Append(" ) ");
                strSql.Append(" VALUES (");
                strSql.Append(" " + _vo.sistemasEmpresaID + " , ");
                strSql.Append("  '" + _vo.sistemasURL + "' , ");
                strSql.Append("  CONVERT(DATETIME, '" + _vo.sistemasDataCadastro + "', 103) , ");
                strSql.Append("  '" + _vo.sistemasNome + "'  ");
                strSql.Append(" ) ");


                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Atualiza os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Update(portalVO.SISTEMASVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" UPDATE  SISTEMAS  ");
                strSql.Append(" SET ");

                strSql.Append("   sistemasEmpresaID =   " + _vo.sistemasEmpresaID + " ,  ");
                strSql.Append("   sistemasURL =  '" + _vo.sistemasURL + "' ,  ");
                strSql.Append("   sistemasDataCadastro = CONVERT(DATETIME, '" + _vo.sistemasDataCadastro + "', 103) ,  ");
                strSql.Append("   sistemasNome =  '" + _vo.sistemasNome + "'   ");

                strSql.Append(" WHERE ( sistemasID =   " + _vo.sistemasID + "  ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

        /// <summary>
        /// Deleta os registros do banco e retorna o número de linhas afetadas.
        /// </summary>
        /// <param name="_vo">objetos vo do banco</param>
        /// <returns>int</returns>
        public int Delete(portalVO.SISTEMASVO _vo)
        {
            try
            {
                strSql = new StringBuilder();
                strSql.Append(" DELETE FROM SISTEMAS  ");
                strSql.Append(" WHERE ( sistemasID = " + _vo.sistemasID + " ) ");

                objDO = new portalDO.portalDO();

                // executa comando e retorna o número de linhas afetadas.
                return objDO.ExecutaQuery(strSql.ToString());
            }
            catch (Exception er)
            {
                throw new Exception("Aconteceu um erro:" + er.Message.ToString());
            }
            finally
            {
                strSql = null;
            }
        }

    }

}