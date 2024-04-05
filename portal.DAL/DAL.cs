using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using portal.TAB;

namespace portal.DAL
{

#region classe AUDITORIAS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class AUDITORIAS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.AUDITORIAS"></param>
  public int InsertId(TAB.AUDITORIAS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO AUDITORIAS (");
      query.Append(" AUDITORIA_DATA, ");
      query.Append(" AUDITORIA_HORA, ");
      query.Append(" AUDITORIA_USUARIO, ");
      query.Append(" AUDITORIA_PERFIL, ");
      query.Append(" AUDITORIA_MODULO, ");
      query.Append(" AUDITORIA_ACAO, ");
      query.Append(" AUDITORIA_ANTES, ");
      query.Append(" AUDITORIA_DEPOIS, ");
      query.Append(" AUDITORIA_TERMINAL, ");
      query.Append(" AUDITORIA_IP ");
      query.Append(") VALUES (");
      query.Append(" @AUDITORIA_DATA, ");
      query.Append(" @AUDITORIA_HORA, ");
      query.Append(" @AUDITORIA_USUARIO, ");
      query.Append(" @AUDITORIA_PERFIL, ");
      query.Append(" @AUDITORIA_MODULO, ");
      query.Append(" @AUDITORIA_ACAO, ");
      query.Append(" @AUDITORIA_ANTES, ");
      query.Append(" @AUDITORIA_DEPOIS, ");
      query.Append(" @AUDITORIA_TERMINAL, ");
      query.Append(" @AUDITORIA_IP ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@AUDITORIA_DATA", registro.AUDITORIA_DATA);
                  cmd.Parameters.AddWithValue("@AUDITORIA_HORA", registro.AUDITORIA_HORA);
                  cmd.Parameters.AddWithValue("@AUDITORIA_USUARIO", registro.AUDITORIA_USUARIO);
                  cmd.Parameters.AddWithValue("@AUDITORIA_PERFIL", registro.AUDITORIA_PERFIL);
                  cmd.Parameters.AddWithValue("@AUDITORIA_MODULO", registro.AUDITORIA_MODULO);
                  cmd.Parameters.AddWithValue("@AUDITORIA_ACAO", registro.AUDITORIA_ACAO);
                  cmd.Parameters.AddWithValue("@AUDITORIA_ANTES", registro.AUDITORIA_ANTES);
                  cmd.Parameters.AddWithValue("@AUDITORIA_DEPOIS", registro.AUDITORIA_DEPOIS);
                  cmd.Parameters.AddWithValue("@AUDITORIA_TERMINAL", registro.AUDITORIA_TERMINAL);
                  cmd.Parameters.AddWithValue("@AUDITORIA_IP", registro.AUDITORIA_IP);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="AUDITORIAS"></param>
  public void Insert(TAB.AUDITORIAS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO AUDITORIAS (");
      query.Append(" AUDITORIA_DATA, ");
      query.Append(" AUDITORIA_HORA, ");
      query.Append(" AUDITORIA_USUARIO, ");
      query.Append(" AUDITORIA_PERFIL, ");
      query.Append(" AUDITORIA_MODULO, ");
      query.Append(" AUDITORIA_ACAO, ");
      query.Append(" AUDITORIA_ANTES, ");
      query.Append(" AUDITORIA_DEPOIS, ");
      query.Append(" AUDITORIA_TERMINAL, ");
      query.Append(" AUDITORIA_IP ");
      query.Append(") VALUES (");
      query.Append(" @AUDITORIA_DATA, ");
      query.Append(" @AUDITORIA_HORA, ");
      query.Append(" @AUDITORIA_USUARIO, ");
      query.Append(" @AUDITORIA_PERFIL, ");
      query.Append(" @AUDITORIA_MODULO, ");
      query.Append(" @AUDITORIA_ACAO, ");
      query.Append(" @AUDITORIA_ANTES, ");
      query.Append(" @AUDITORIA_DEPOIS, ");
      query.Append(" @AUDITORIA_TERMINAL, ");
      query.Append(" @AUDITORIA_IP ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@AUDITORIA_DATA", registro.AUDITORIA_DATA);
              cmd.Parameters.AddWithValue("@AUDITORIA_HORA", registro.AUDITORIA_HORA);
              cmd.Parameters.AddWithValue("@AUDITORIA_USUARIO", registro.AUDITORIA_USUARIO);
              cmd.Parameters.AddWithValue("@AUDITORIA_PERFIL", registro.AUDITORIA_PERFIL);
              cmd.Parameters.AddWithValue("@AUDITORIA_MODULO", registro.AUDITORIA_MODULO);
              cmd.Parameters.AddWithValue("@AUDITORIA_ACAO", registro.AUDITORIA_ACAO);
              cmd.Parameters.AddWithValue("@AUDITORIA_ANTES", registro.AUDITORIA_ANTES);
              cmd.Parameters.AddWithValue("@AUDITORIA_DEPOIS", registro.AUDITORIA_DEPOIS);
              cmd.Parameters.AddWithValue("@AUDITORIA_TERMINAL", registro.AUDITORIA_TERMINAL);
              cmd.Parameters.AddWithValue("@AUDITORIA_IP", registro.AUDITORIA_IP);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.AUDITORIAS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM AUDITORIAS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM AUDITORIAS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="AUDITORIAS"></param>
  public void Update(TAB.AUDITORIAS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE AUDITORIAS SET ");
      query.Append(" AUDITORIA_DATA=@AUDITORIA_DATA, ");
      query.Append(" AUDITORIA_HORA=@AUDITORIA_HORA, ");
      query.Append(" AUDITORIA_USUARIO=@AUDITORIA_USUARIO, ");
      query.Append(" AUDITORIA_PERFIL=@AUDITORIA_PERFIL, ");
      query.Append(" AUDITORIA_MODULO=@AUDITORIA_MODULO, ");
      query.Append(" AUDITORIA_ACAO=@AUDITORIA_ACAO, ");
      query.Append(" AUDITORIA_ANTES=@AUDITORIA_ANTES, ");
      query.Append(" AUDITORIA_DEPOIS=@AUDITORIA_DEPOIS, ");
      query.Append(" AUDITORIA_TERMINAL=@AUDITORIA_TERMINAL, ");
      query.Append(" AUDITORIA_IP=@AUDITORIA_IP ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@AUDITORIA_ID", registro.AUDITORIA_ID);
                  cmd.Parameters.AddWithValue("@AUDITORIA_DATA", registro.AUDITORIA_DATA);
                  cmd.Parameters.AddWithValue("@AUDITORIA_HORA", registro.AUDITORIA_HORA);
                  cmd.Parameters.AddWithValue("@AUDITORIA_USUARIO", registro.AUDITORIA_USUARIO);
                  cmd.Parameters.AddWithValue("@AUDITORIA_PERFIL", registro.AUDITORIA_PERFIL);
                  cmd.Parameters.AddWithValue("@AUDITORIA_MODULO", registro.AUDITORIA_MODULO);
                  cmd.Parameters.AddWithValue("@AUDITORIA_ACAO", registro.AUDITORIA_ACAO);
                  cmd.Parameters.AddWithValue("@AUDITORIA_ANTES", registro.AUDITORIA_ANTES);
                  cmd.Parameters.AddWithValue("@AUDITORIA_DEPOIS", registro.AUDITORIA_DEPOIS);
                  cmd.Parameters.AddWithValue("@AUDITORIA_TERMINAL", registro.AUDITORIA_TERMINAL);
                  cmd.Parameters.AddWithValue("@AUDITORIA_IP", registro.AUDITORIA_IP);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP ");
          query.Append("FROM AUDITORIAS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP ");
          query.Append("FROM AUDITORIAS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP ");
          query.Append("FROM AUDITORIAS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_ID(int _AUDITORIA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_ID =   " + _AUDITORIA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_DATA e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_DATA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_DATA(DateTime _AUDITORIA_DATA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_DATA = CONVERT(DATETIME, '" + _AUDITORIA_DATA + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_HORA e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_HORA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_HORA(DateTime _AUDITORIA_HORA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_HORA = CONVERT(DATETIME, '" + _AUDITORIA_HORA + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_USUARIO e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_USUARIO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_USUARIO(string _AUDITORIA_USUARIO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_USUARIO =  '" + _AUDITORIA_USUARIO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_PERFIL e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_PERFIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_PERFIL(string _AUDITORIA_PERFIL)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_PERFIL =  '" + _AUDITORIA_PERFIL + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_MODULO e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_MODULO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_MODULO(string _AUDITORIA_MODULO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_MODULO =  '" + _AUDITORIA_MODULO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_ACAO e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_ACAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_ACAO(StringBuilder _AUDITORIA_ACAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_ACAO =  '" + _AUDITORIA_ACAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_ANTES e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_ANTES">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_ANTES(StringBuilder _AUDITORIA_ANTES)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_ANTES =  '" + _AUDITORIA_ANTES + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_DEPOIS e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_DEPOIS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_DEPOIS(StringBuilder _AUDITORIA_DEPOIS)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_DEPOIS =  '" + _AUDITORIA_DEPOIS + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_TERMINAL e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_TERMINAL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_TERMINAL(string _AUDITORIA_TERMINAL)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_TERMINAL =  '" + _AUDITORIA_TERMINAL + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_IP e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_IP">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_IP(string _AUDITORIA_IP)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" AUDITORIA_ID, ");
          query.Append(" AUDITORIA_DATA, ");
          query.Append(" AUDITORIA_HORA, ");
          query.Append(" AUDITORIA_USUARIO, ");
          query.Append(" AUDITORIA_PERFIL, ");
          query.Append(" AUDITORIA_MODULO, ");
          query.Append(" AUDITORIA_ACAO, ");
          query.Append(" AUDITORIA_ANTES, ");
          query.Append(" AUDITORIA_DEPOIS, ");
          query.Append(" AUDITORIA_TERMINAL, ");
          query.Append(" AUDITORIA_IP, ");
          query.Append(" AUDITORIA_IP ");
          query.Append(" FROM AUDITORIAS ");
          query.Append(" WHERE (  AUDITORIA_IP =  '" + _AUDITORIA_IP + "'  ) ");

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
  }

#endregion

#region classe DOWNLOADS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class DOWNLOADS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.DOWNLOADS"></param>
  public int InsertId(TAB.DOWNLOADS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO DOWNLOADS (");
      query.Append(" DOWNLOAD_LINK, ");
      query.Append(" DOWNLOAD_INCLUSAO, ");
      query.Append(" DOWNLOAD_DESCRICAO, ");
      query.Append(" DOWNLOAD_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @DOWNLOAD_LINK, ");
      query.Append(" @DOWNLOAD_INCLUSAO, ");
      query.Append(" @DOWNLOAD_DESCRICAO, ");
      query.Append(" @DOWNLOAD_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@DOWNLOAD_LINK", registro.DOWNLOAD_LINK);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_INCLUSAO", registro.DOWNLOAD_INCLUSAO);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_DESCRICAO", registro.DOWNLOAD_DESCRICAO);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_ATIVO", registro.DOWNLOAD_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="DOWNLOADS"></param>
  public void Insert(TAB.DOWNLOADS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO DOWNLOADS (");
      query.Append(" DOWNLOAD_LINK, ");
      query.Append(" DOWNLOAD_INCLUSAO, ");
      query.Append(" DOWNLOAD_DESCRICAO, ");
      query.Append(" DOWNLOAD_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @DOWNLOAD_LINK, ");
      query.Append(" @DOWNLOAD_INCLUSAO, ");
      query.Append(" @DOWNLOAD_DESCRICAO, ");
      query.Append(" @DOWNLOAD_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@DOWNLOAD_LINK", registro.DOWNLOAD_LINK);
              cmd.Parameters.AddWithValue("@DOWNLOAD_INCLUSAO", registro.DOWNLOAD_INCLUSAO);
              cmd.Parameters.AddWithValue("@DOWNLOAD_DESCRICAO", registro.DOWNLOAD_DESCRICAO);
              cmd.Parameters.AddWithValue("@DOWNLOAD_ATIVO", registro.DOWNLOAD_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.DOWNLOADS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM DOWNLOADS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM DOWNLOADS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="DOWNLOADS"></param>
  public void Update(TAB.DOWNLOADS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE DOWNLOADS SET ");
      query.Append(" DOWNLOAD_LINK=@DOWNLOAD_LINK, ");
      query.Append(" DOWNLOAD_INCLUSAO=@DOWNLOAD_INCLUSAO, ");
      query.Append(" DOWNLOAD_DESCRICAO=@DOWNLOAD_DESCRICAO, ");
      query.Append(" DOWNLOAD_ATIVO=@DOWNLOAD_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@DOWNLOAD_ID", registro.DOWNLOAD_ID);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_LINK", registro.DOWNLOAD_LINK);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_INCLUSAO", registro.DOWNLOAD_INCLUSAO);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_DESCRICAO", registro.DOWNLOAD_DESCRICAO);
                  cmd.Parameters.AddWithValue("@DOWNLOAD_ATIVO", registro.DOWNLOAD_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append("FROM DOWNLOADS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append("FROM DOWNLOADS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append("FROM DOWNLOADS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_ID(int _DOWNLOAD_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE (  DOWNLOAD_ID =   " + _DOWNLOAD_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_LINK(string _DOWNLOAD_LINK)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE (  DOWNLOAD_LINK =  '" + _DOWNLOAD_LINK + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_INCLUSAO(DateTime _DOWNLOAD_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE (  DOWNLOAD_INCLUSAO = CONVERT(DATETIME, '" + _DOWNLOAD_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_DESCRICAO(string _DOWNLOAD_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE (  DOWNLOAD_DESCRICAO =  '" + _DOWNLOAD_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_ATIVO(byte _DOWNLOAD_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" DOWNLOAD_ID, ");
          query.Append(" DOWNLOAD_LINK, ");
          query.Append(" DOWNLOAD_INCLUSAO, ");
          query.Append(" DOWNLOAD_DESCRICAO, ");
          query.Append(" DOWNLOAD_ATIVO, ");
          query.Append(" DOWNLOAD_ATIVO ");
          query.Append(" FROM DOWNLOADS ");
          query.Append(" WHERE (  DOWNLOAD_ATIVO =   " + _DOWNLOAD_ATIVO + "  ) ");

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
  }

#endregion

#region classe EMPRESAS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class EMPRESAS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.EMPRESAS"></param>
  public int InsertId(TAB.EMPRESAS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO EMPRESAS (");
      query.Append(" EMPRESA_CODIGO, ");
      query.Append(" EMPRESA_NOME_FANTASIA, ");
      query.Append(" EMPRESA_NOME_RAZAO, ");
      query.Append(" EMPRESA_CONTATO, ");
      query.Append(" EMPRESA_ENDERECO, ");
      query.Append(" EMPRESA_ENDERECO_NR, ");
      query.Append(" EMPRESA_BAIRRO, ");
      query.Append(" EMPRESA_UF, ");
      query.Append(" EMPRESA_CNPJ, ");
      query.Append(" EMPRESA_IE, ");
      query.Append(" EMPRESA_WEB, ");
      query.Append(" EMPRESA_INCLUSAO, ");
      query.Append(" EMPRESA_EXPIRA, ");
      query.Append(" EMPRESA_VESAO, ");
      query.Append(" EMPRESA_ATIVA ");
      query.Append(") VALUES (");
      query.Append(" @EMPRESA_CODIGO, ");
      query.Append(" @EMPRESA_NOME_FANTASIA, ");
      query.Append(" @EMPRESA_NOME_RAZAO, ");
      query.Append(" @EMPRESA_CONTATO, ");
      query.Append(" @EMPRESA_ENDERECO, ");
      query.Append(" @EMPRESA_ENDERECO_NR, ");
      query.Append(" @EMPRESA_BAIRRO, ");
      query.Append(" @EMPRESA_UF, ");
      query.Append(" @EMPRESA_CNPJ, ");
      query.Append(" @EMPRESA_IE, ");
      query.Append(" @EMPRESA_WEB, ");
      query.Append(" @EMPRESA_INCLUSAO, ");
      query.Append(" @EMPRESA_EXPIRA, ");
      query.Append(" @EMPRESA_VESAO, ");
      query.Append(" @EMPRESA_ATIVA ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@EMPRESA_CODIGO", registro.EMPRESA_CODIGO);
                  cmd.Parameters.AddWithValue("@EMPRESA_NOME_FANTASIA", registro.EMPRESA_NOME_FANTASIA);
                  cmd.Parameters.AddWithValue("@EMPRESA_NOME_RAZAO", registro.EMPRESA_NOME_RAZAO);
                  cmd.Parameters.AddWithValue("@EMPRESA_CONTATO", registro.EMPRESA_CONTATO);
                  cmd.Parameters.AddWithValue("@EMPRESA_ENDERECO", registro.EMPRESA_ENDERECO);
                  cmd.Parameters.AddWithValue("@EMPRESA_ENDERECO_NR", registro.EMPRESA_ENDERECO_NR);
                  cmd.Parameters.AddWithValue("@EMPRESA_BAIRRO", registro.EMPRESA_BAIRRO);
                  cmd.Parameters.AddWithValue("@EMPRESA_UF", registro.EMPRESA_UF);
                  cmd.Parameters.AddWithValue("@EMPRESA_CNPJ", registro.EMPRESA_CNPJ);
                  cmd.Parameters.AddWithValue("@EMPRESA_IE", registro.EMPRESA_IE);
                  cmd.Parameters.AddWithValue("@EMPRESA_WEB", registro.EMPRESA_WEB);
                  cmd.Parameters.AddWithValue("@EMPRESA_INCLUSAO", registro.EMPRESA_INCLUSAO);
                  cmd.Parameters.AddWithValue("@EMPRESA_EXPIRA", registro.EMPRESA_EXPIRA);
                  cmd.Parameters.AddWithValue("@EMPRESA_VESAO", registro.EMPRESA_VESAO);
                  cmd.Parameters.AddWithValue("@EMPRESA_ATIVA", registro.EMPRESA_ATIVA);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="EMPRESAS"></param>
  public void Insert(TAB.EMPRESAS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO EMPRESAS (");
      query.Append(" EMPRESA_CODIGO, ");
      query.Append(" EMPRESA_NOME_FANTASIA, ");
      query.Append(" EMPRESA_NOME_RAZAO, ");
      query.Append(" EMPRESA_CONTATO, ");
      query.Append(" EMPRESA_ENDERECO, ");
      query.Append(" EMPRESA_ENDERECO_NR, ");
      query.Append(" EMPRESA_BAIRRO, ");
      query.Append(" EMPRESA_UF, ");
      query.Append(" EMPRESA_CNPJ, ");
      query.Append(" EMPRESA_IE, ");
      query.Append(" EMPRESA_WEB, ");
      query.Append(" EMPRESA_INCLUSAO, ");
      query.Append(" EMPRESA_EXPIRA, ");
      query.Append(" EMPRESA_VESAO, ");
      query.Append(" EMPRESA_ATIVA ");
      query.Append(") VALUES (");
      query.Append(" @EMPRESA_CODIGO, ");
      query.Append(" @EMPRESA_NOME_FANTASIA, ");
      query.Append(" @EMPRESA_NOME_RAZAO, ");
      query.Append(" @EMPRESA_CONTATO, ");
      query.Append(" @EMPRESA_ENDERECO, ");
      query.Append(" @EMPRESA_ENDERECO_NR, ");
      query.Append(" @EMPRESA_BAIRRO, ");
      query.Append(" @EMPRESA_UF, ");
      query.Append(" @EMPRESA_CNPJ, ");
      query.Append(" @EMPRESA_IE, ");
      query.Append(" @EMPRESA_WEB, ");
      query.Append(" @EMPRESA_INCLUSAO, ");
      query.Append(" @EMPRESA_EXPIRA, ");
      query.Append(" @EMPRESA_VESAO, ");
      query.Append(" @EMPRESA_ATIVA ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@EMPRESA_CODIGO", registro.EMPRESA_CODIGO);
              cmd.Parameters.AddWithValue("@EMPRESA_NOME_FANTASIA", registro.EMPRESA_NOME_FANTASIA);
              cmd.Parameters.AddWithValue("@EMPRESA_NOME_RAZAO", registro.EMPRESA_NOME_RAZAO);
              cmd.Parameters.AddWithValue("@EMPRESA_CONTATO", registro.EMPRESA_CONTATO);
              cmd.Parameters.AddWithValue("@EMPRESA_ENDERECO", registro.EMPRESA_ENDERECO);
              cmd.Parameters.AddWithValue("@EMPRESA_ENDERECO_NR", registro.EMPRESA_ENDERECO_NR);
              cmd.Parameters.AddWithValue("@EMPRESA_BAIRRO", registro.EMPRESA_BAIRRO);
              cmd.Parameters.AddWithValue("@EMPRESA_UF", registro.EMPRESA_UF);
              cmd.Parameters.AddWithValue("@EMPRESA_CNPJ", registro.EMPRESA_CNPJ);
              cmd.Parameters.AddWithValue("@EMPRESA_IE", registro.EMPRESA_IE);
              cmd.Parameters.AddWithValue("@EMPRESA_WEB", registro.EMPRESA_WEB);
              cmd.Parameters.AddWithValue("@EMPRESA_INCLUSAO", registro.EMPRESA_INCLUSAO);
              cmd.Parameters.AddWithValue("@EMPRESA_EXPIRA", registro.EMPRESA_EXPIRA);
              cmd.Parameters.AddWithValue("@EMPRESA_VESAO", registro.EMPRESA_VESAO);
              cmd.Parameters.AddWithValue("@EMPRESA_ATIVA", registro.EMPRESA_ATIVA);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.EMPRESAS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM EMPRESAS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM EMPRESAS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="EMPRESAS"></param>
  public void Update(TAB.EMPRESAS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE EMPRESAS SET ");
      query.Append(" EMPRESA_CODIGO=@EMPRESA_CODIGO, ");
      query.Append(" EMPRESA_NOME_FANTASIA=@EMPRESA_NOME_FANTASIA, ");
      query.Append(" EMPRESA_NOME_RAZAO=@EMPRESA_NOME_RAZAO, ");
      query.Append(" EMPRESA_CONTATO=@EMPRESA_CONTATO, ");
      query.Append(" EMPRESA_ENDERECO=@EMPRESA_ENDERECO, ");
      query.Append(" EMPRESA_ENDERECO_NR=@EMPRESA_ENDERECO_NR, ");
      query.Append(" EMPRESA_BAIRRO=@EMPRESA_BAIRRO, ");
      query.Append(" EMPRESA_UF=@EMPRESA_UF, ");
      query.Append(" EMPRESA_CNPJ=@EMPRESA_CNPJ, ");
      query.Append(" EMPRESA_IE=@EMPRESA_IE, ");
      query.Append(" EMPRESA_WEB=@EMPRESA_WEB, ");
      query.Append(" EMPRESA_INCLUSAO=@EMPRESA_INCLUSAO, ");
      query.Append(" EMPRESA_EXPIRA=@EMPRESA_EXPIRA, ");
      query.Append(" EMPRESA_VESAO=@EMPRESA_VESAO, ");
      query.Append(" EMPRESA_ATIVA=@EMPRESA_ATIVA ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@EMPRESA_ID", registro.EMPRESA_ID);
                  cmd.Parameters.AddWithValue("@EMPRESA_CODIGO", registro.EMPRESA_CODIGO);
                  cmd.Parameters.AddWithValue("@EMPRESA_NOME_FANTASIA", registro.EMPRESA_NOME_FANTASIA);
                  cmd.Parameters.AddWithValue("@EMPRESA_NOME_RAZAO", registro.EMPRESA_NOME_RAZAO);
                  cmd.Parameters.AddWithValue("@EMPRESA_CONTATO", registro.EMPRESA_CONTATO);
                  cmd.Parameters.AddWithValue("@EMPRESA_ENDERECO", registro.EMPRESA_ENDERECO);
                  cmd.Parameters.AddWithValue("@EMPRESA_ENDERECO_NR", registro.EMPRESA_ENDERECO_NR);
                  cmd.Parameters.AddWithValue("@EMPRESA_BAIRRO", registro.EMPRESA_BAIRRO);
                  cmd.Parameters.AddWithValue("@EMPRESA_UF", registro.EMPRESA_UF);
                  cmd.Parameters.AddWithValue("@EMPRESA_CNPJ", registro.EMPRESA_CNPJ);
                  cmd.Parameters.AddWithValue("@EMPRESA_IE", registro.EMPRESA_IE);
                  cmd.Parameters.AddWithValue("@EMPRESA_WEB", registro.EMPRESA_WEB);
                  cmd.Parameters.AddWithValue("@EMPRESA_INCLUSAO", registro.EMPRESA_INCLUSAO);
                  cmd.Parameters.AddWithValue("@EMPRESA_EXPIRA", registro.EMPRESA_EXPIRA);
                  cmd.Parameters.AddWithValue("@EMPRESA_VESAO", registro.EMPRESA_VESAO);
                  cmd.Parameters.AddWithValue("@EMPRESA_ATIVA", registro.EMPRESA_ATIVA);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append("FROM EMPRESAS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append("FROM EMPRESAS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append("FROM EMPRESAS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ID(int _EMPRESA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_ID =   " + _EMPRESA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_CODIGO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_CODIGO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_CODIGO(string _EMPRESA_CODIGO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_CODIGO =  '" + _EMPRESA_CODIGO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_NOME_FANTASIA e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_NOME_FANTASIA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_NOME_FANTASIA(string _EMPRESA_NOME_FANTASIA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_NOME_FANTASIA =  '" + _EMPRESA_NOME_FANTASIA + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_NOME_RAZAO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_NOME_RAZAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_NOME_RAZAO(string _EMPRESA_NOME_RAZAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_NOME_RAZAO =  '" + _EMPRESA_NOME_RAZAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_CONTATO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_CONTATO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_CONTATO(string _EMPRESA_CONTATO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_CONTATO =  '" + _EMPRESA_CONTATO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ENDERECO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ENDERECO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ENDERECO(string _EMPRESA_ENDERECO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_ENDERECO =  '" + _EMPRESA_ENDERECO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ENDERECO_NR e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ENDERECO_NR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ENDERECO_NR(string _EMPRESA_ENDERECO_NR)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_ENDERECO_NR =  '" + _EMPRESA_ENDERECO_NR + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_BAIRRO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_BAIRRO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_BAIRRO(string _EMPRESA_BAIRRO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_BAIRRO =  '" + _EMPRESA_BAIRRO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_UF e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_UF">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_UF(string _EMPRESA_UF)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_UF =  '" + _EMPRESA_UF + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_CNPJ e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_CNPJ">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_CNPJ(string _EMPRESA_CNPJ)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_CNPJ =  '" + _EMPRESA_CNPJ + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_IE e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_IE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_IE(string _EMPRESA_IE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_IE =  '" + _EMPRESA_IE + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_WEB e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_WEB">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_WEB(string _EMPRESA_WEB)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_WEB =  '" + _EMPRESA_WEB + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_INCLUSAO(DateTime _EMPRESA_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_INCLUSAO = CONVERT(DATETIME, '" + _EMPRESA_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_EXPIRA e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_EXPIRA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_EXPIRA(DateTime _EMPRESA_EXPIRA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_EXPIRA = CONVERT(DATETIME, '" + _EMPRESA_EXPIRA + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_VESAO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_VESAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_VESAO(string _EMPRESA_VESAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_VESAO =  '" + _EMPRESA_VESAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ATIVA e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ATIVA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ATIVA(byte _EMPRESA_ATIVA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" EMPRESA_ID, ");
          query.Append(" EMPRESA_CODIGO, ");
          query.Append(" EMPRESA_NOME_FANTASIA, ");
          query.Append(" EMPRESA_NOME_RAZAO, ");
          query.Append(" EMPRESA_CONTATO, ");
          query.Append(" EMPRESA_ENDERECO, ");
          query.Append(" EMPRESA_ENDERECO_NR, ");
          query.Append(" EMPRESA_BAIRRO, ");
          query.Append(" EMPRESA_UF, ");
          query.Append(" EMPRESA_CNPJ, ");
          query.Append(" EMPRESA_IE, ");
          query.Append(" EMPRESA_WEB, ");
          query.Append(" EMPRESA_INCLUSAO, ");
          query.Append(" EMPRESA_EXPIRA, ");
          query.Append(" EMPRESA_VESAO, ");
          query.Append(" EMPRESA_ATIVA, ");
          query.Append(" EMPRESA_ATIVA ");
          query.Append(" FROM EMPRESAS ");
          query.Append(" WHERE (  EMPRESA_ATIVA =   " + _EMPRESA_ATIVA + "  ) ");

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
  }

#endregion

#region classe ENDERECOS_BAIRRO
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_BAIRRO
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.ENDERECOS_BAIRRO"></param>
  public int InsertId(TAB.ENDERECOS_BAIRRO registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_BAIRRO (");
      query.Append(" BAIRRO_DESCRICAO ");
      query.Append(") VALUES (");
      query.Append(" @BAIRRO_DESCRICAO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@BAIRRO_DESCRICAO", registro.BAIRRO_DESCRICAO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="ENDERECOS_BAIRRO"></param>
  public void Insert(TAB.ENDERECOS_BAIRRO registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_BAIRRO (");
      query.Append(" BAIRRO_DESCRICAO ");
      query.Append(") VALUES (");
      query.Append(" @BAIRRO_DESCRICAO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@BAIRRO_DESCRICAO", registro.BAIRRO_DESCRICAO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.ENDERECOS_BAIRRO"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_BAIRRO ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_BAIRRO ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="ENDERECOS_BAIRRO"></param>
  public void Update(TAB.ENDERECOS_BAIRRO registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE ENDERECOS_BAIRRO SET ");
      query.Append(" BAIRRO_DESCRICAO=@BAIRRO_DESCRICAO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@BAIRRO_ID", registro.BAIRRO_ID);
                  cmd.Parameters.AddWithValue("@BAIRRO_DESCRICAO", registro.BAIRRO_DESCRICAO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append("FROM ENDERECOS_BAIRRO ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append("FROM ENDERECOS_BAIRRO ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append("FROM ENDERECOS_BAIRRO ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_BAIRRO ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_BAIRRO ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por BAIRRO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_BAIRRO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_BAIRRO_ID(int _BAIRRO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_BAIRRO ");
          query.Append(" WHERE (  BAIRRO_ID =   " + _BAIRRO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por BAIRRO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_BAIRRO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_BAIRRO_DESCRICAO(string _BAIRRO_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" BAIRRO_DESCRICAO, ");
          query.Append(" BAIRRO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_BAIRRO ");
          query.Append(" WHERE (  BAIRRO_DESCRICAO =  '" + _BAIRRO_DESCRICAO + "'  ) ");

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
  }

#endregion

#region classe ENDERECOS_CIDADES
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_CIDADES
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.ENDERECOS_CIDADES"></param>
  public int InsertId(TAB.ENDERECOS_CIDADES registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_CIDADES (");
      query.Append(" CIDADE_DESCRICAO, ");
      query.Append(" CIDADE_IBGE ");
      query.Append(") VALUES (");
      query.Append(" @CIDADE_DESCRICAO, ");
      query.Append(" @CIDADE_IBGE ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@CIDADE_DESCRICAO", registro.CIDADE_DESCRICAO);
                  cmd.Parameters.AddWithValue("@CIDADE_IBGE", registro.CIDADE_IBGE);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="ENDERECOS_CIDADES"></param>
  public void Insert(TAB.ENDERECOS_CIDADES registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_CIDADES (");
      query.Append(" CIDADE_DESCRICAO, ");
      query.Append(" CIDADE_IBGE ");
      query.Append(") VALUES (");
      query.Append(" @CIDADE_DESCRICAO, ");
      query.Append(" @CIDADE_IBGE ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@CIDADE_DESCRICAO", registro.CIDADE_DESCRICAO);
              cmd.Parameters.AddWithValue("@CIDADE_IBGE", registro.CIDADE_IBGE);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.ENDERECOS_CIDADES"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_CIDADES ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_CIDADES ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="ENDERECOS_CIDADES"></param>
  public void Update(TAB.ENDERECOS_CIDADES registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE ENDERECOS_CIDADES SET ");
      query.Append(" CIDADE_DESCRICAO=@CIDADE_DESCRICAO, ");
      query.Append(" CIDADE_IBGE=@CIDADE_IBGE ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@CIDADE_ID", registro.CIDADE_ID);
                  cmd.Parameters.AddWithValue("@CIDADE_DESCRICAO", registro.CIDADE_DESCRICAO);
                  cmd.Parameters.AddWithValue("@CIDADE_IBGE", registro.CIDADE_IBGE);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE ");
          query.Append("FROM ENDERECOS_CIDADES ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE ");
          query.Append("FROM ENDERECOS_CIDADES ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE ");
          query.Append("FROM ENDERECOS_CIDADES ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE ");
          query.Append(" FROM ENDERECOS_CIDADES ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE ");
          query.Append(" FROM ENDERECOS_CIDADES ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_ID(int _CIDADE_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE, ");
          query.Append(" CIDADE_IBGE ");
          query.Append(" FROM ENDERECOS_CIDADES ");
          query.Append(" WHERE (  CIDADE_ID =   " + _CIDADE_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_DESCRICAO(string _CIDADE_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE, ");
          query.Append(" CIDADE_IBGE ");
          query.Append(" FROM ENDERECOS_CIDADES ");
          query.Append(" WHERE (  CIDADE_DESCRICAO =  '" + _CIDADE_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_IBGE e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_IBGE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_IBGE(string _CIDADE_IBGE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" CIDADE_ID, ");
          query.Append(" CIDADE_DESCRICAO, ");
          query.Append(" CIDADE_IBGE, ");
          query.Append(" CIDADE_IBGE ");
          query.Append(" FROM ENDERECOS_CIDADES ");
          query.Append(" WHERE (  CIDADE_IBGE =  '" + _CIDADE_IBGE + "'  ) ");

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
  }

#endregion

#region classe ENDERECOS_LOGRADOUROS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_LOGRADOUROS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.ENDERECOS_LOGRADOUROS"></param>
  public int InsertId(TAB.ENDERECOS_LOGRADOUROS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_LOGRADOUROS (");
      query.Append(" LOGRADOURO_DESCRICAO, ");
      query.Append(" LOGRADOURO_CEP, ");
      query.Append(" TIPO_ID, ");
      query.Append(" BAIRRO_ID, ");
      query.Append(" CIDADE_ID, ");
      query.Append(" UF_ID ");
      query.Append(") VALUES (");
      query.Append(" @LOGRADOURO_DESCRICAO, ");
      query.Append(" @LOGRADOURO_CEP, ");
      query.Append(" @TIPO_ID, ");
      query.Append(" @BAIRRO_ID, ");
      query.Append(" @CIDADE_ID, ");
      query.Append(" @UF_ID ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@LOGRADOURO_DESCRICAO", registro.LOGRADOURO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@LOGRADOURO_CEP", registro.LOGRADOURO_CEP);
                  cmd.Parameters.AddWithValue("@TIPO_ID", registro.TIPO_ID);
                  cmd.Parameters.AddWithValue("@BAIRRO_ID", registro.BAIRRO_ID);
                  cmd.Parameters.AddWithValue("@CIDADE_ID", registro.CIDADE_ID);
                  cmd.Parameters.AddWithValue("@UF_ID", registro.UF_ID);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="ENDERECOS_LOGRADOUROS"></param>
  public void Insert(TAB.ENDERECOS_LOGRADOUROS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_LOGRADOUROS (");
      query.Append(" LOGRADOURO_DESCRICAO, ");
      query.Append(" LOGRADOURO_CEP, ");
      query.Append(" TIPO_ID, ");
      query.Append(" BAIRRO_ID, ");
      query.Append(" CIDADE_ID, ");
      query.Append(" UF_ID ");
      query.Append(") VALUES (");
      query.Append(" @LOGRADOURO_DESCRICAO, ");
      query.Append(" @LOGRADOURO_CEP, ");
      query.Append(" @TIPO_ID, ");
      query.Append(" @BAIRRO_ID, ");
      query.Append(" @CIDADE_ID, ");
      query.Append(" @UF_ID ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@LOGRADOURO_DESCRICAO", registro.LOGRADOURO_DESCRICAO);
              cmd.Parameters.AddWithValue("@LOGRADOURO_CEP", registro.LOGRADOURO_CEP);
              cmd.Parameters.AddWithValue("@TIPO_ID", registro.TIPO_ID);
              cmd.Parameters.AddWithValue("@BAIRRO_ID", registro.BAIRRO_ID);
              cmd.Parameters.AddWithValue("@CIDADE_ID", registro.CIDADE_ID);
              cmd.Parameters.AddWithValue("@UF_ID", registro.UF_ID);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.ENDERECOS_LOGRADOUROS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_LOGRADOUROS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_LOGRADOUROS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="ENDERECOS_LOGRADOUROS"></param>
  public void Update(TAB.ENDERECOS_LOGRADOUROS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE ENDERECOS_LOGRADOUROS SET ");
      query.Append(" LOGRADOURO_DESCRICAO=@LOGRADOURO_DESCRICAO, ");
      query.Append(" LOGRADOURO_CEP=@LOGRADOURO_CEP, ");
      query.Append(" TIPO_ID=@TIPO_ID, ");
      query.Append(" BAIRRO_ID=@BAIRRO_ID, ");
      query.Append(" CIDADE_ID=@CIDADE_ID, ");
      query.Append(" UF_ID=@UF_ID ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@LOGRADOURO_ID", registro.LOGRADOURO_ID);
                  cmd.Parameters.AddWithValue("@LOGRADOURO_DESCRICAO", registro.LOGRADOURO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@LOGRADOURO_CEP", registro.LOGRADOURO_CEP);
                  cmd.Parameters.AddWithValue("@TIPO_ID", registro.TIPO_ID);
                  cmd.Parameters.AddWithValue("@BAIRRO_ID", registro.BAIRRO_ID);
                  cmd.Parameters.AddWithValue("@CIDADE_ID", registro.CIDADE_ID);
                  cmd.Parameters.AddWithValue("@UF_ID", registro.UF_ID);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID ");
          query.Append("FROM ENDERECOS_LOGRADOUROS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID ");
          query.Append("FROM ENDERECOS_LOGRADOUROS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID ");
          query.Append("FROM ENDERECOS_LOGRADOUROS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por LOGRADOURO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_LOGRADOURO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_LOGRADOURO_ID(int _LOGRADOURO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  LOGRADOURO_ID =   " + _LOGRADOURO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por LOGRADOURO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_LOGRADOURO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_LOGRADOURO_DESCRICAO(string _LOGRADOURO_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  LOGRADOURO_DESCRICAO =  '" + _LOGRADOURO_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por LOGRADOURO_CEP e retorna um DataSet.
      /// </summary>
      /// <param name="_LOGRADOURO_CEP">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_LOGRADOURO_CEP(string _LOGRADOURO_CEP)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  LOGRADOURO_CEP =  '" + _LOGRADOURO_CEP + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por TIPO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_TIPO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_TIPO_ID(int _TIPO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  TIPO_ID =   " + _TIPO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por BAIRRO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_BAIRRO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_BAIRRO_ID(int _BAIRRO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  BAIRRO_ID =   " + _BAIRRO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_ID(int _CIDADE_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  CIDADE_ID =   " + _CIDADE_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por UF_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_UF_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_UF_ID(int _UF_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" LOGRADOURO_ID, ");
          query.Append(" LOGRADOURO_DESCRICAO, ");
          query.Append(" LOGRADOURO_CEP, ");
          query.Append(" TIPO_ID, ");
          query.Append(" BAIRRO_ID, ");
          query.Append(" CIDADE_ID, ");
          query.Append(" UF_ID, ");
          query.Append(" UF_ID ");
          query.Append(" FROM ENDERECOS_LOGRADOUROS ");
          query.Append(" WHERE (  UF_ID =   " + _UF_ID + "  ) ");

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
  }

#endregion

#region classe ENDERECOS_TIPO
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_TIPO
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.ENDERECOS_TIPO"></param>
  public int InsertId(TAB.ENDERECOS_TIPO registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_TIPO (");
      query.Append(" TIPO_DESCRICAO ");
      query.Append(") VALUES (");
      query.Append(" @TIPO_DESCRICAO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@TIPO_DESCRICAO", registro.TIPO_DESCRICAO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="ENDERECOS_TIPO"></param>
  public void Insert(TAB.ENDERECOS_TIPO registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_TIPO (");
      query.Append(" TIPO_DESCRICAO ");
      query.Append(") VALUES (");
      query.Append(" @TIPO_DESCRICAO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@TIPO_DESCRICAO", registro.TIPO_DESCRICAO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.ENDERECOS_TIPO"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_TIPO ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_TIPO ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="ENDERECOS_TIPO"></param>
  public void Update(TAB.ENDERECOS_TIPO registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE ENDERECOS_TIPO SET ");
      query.Append(" TIPO_DESCRICAO=@TIPO_DESCRICAO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@TIPO_ID", registro.TIPO_ID);
                  cmd.Parameters.AddWithValue("@TIPO_DESCRICAO", registro.TIPO_DESCRICAO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append("FROM ENDERECOS_TIPO ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append("FROM ENDERECOS_TIPO ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append("FROM ENDERECOS_TIPO ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_TIPO ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_TIPO ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por TIPO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_TIPO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_TIPO_ID(int _TIPO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_TIPO ");
          query.Append(" WHERE (  TIPO_ID =   " + _TIPO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por TIPO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_TIPO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_TIPO_DESCRICAO(string _TIPO_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" TIPO_ID, ");
          query.Append(" TIPO_DESCRICAO, ");
          query.Append(" TIPO_DESCRICAO ");
          query.Append(" FROM ENDERECOS_TIPO ");
          query.Append(" WHERE (  TIPO_DESCRICAO =  '" + _TIPO_DESCRICAO + "'  ) ");

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
  }

#endregion

#region classe ENDERECOS_UF
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_UF
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.ENDERECOS_UF"></param>
  public int InsertId(TAB.ENDERECOS_UF registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_UF (");
      query.Append(" UF_SIGLA, ");
      query.Append(" UF_DESCRICAO ");
      query.Append(") VALUES (");
      query.Append(" @UF_SIGLA, ");
      query.Append(" @UF_DESCRICAO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@UF_SIGLA", registro.UF_SIGLA);
                  cmd.Parameters.AddWithValue("@UF_DESCRICAO", registro.UF_DESCRICAO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="ENDERECOS_UF"></param>
  public void Insert(TAB.ENDERECOS_UF registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO ENDERECOS_UF (");
      query.Append(" UF_SIGLA, ");
      query.Append(" UF_DESCRICAO ");
      query.Append(") VALUES (");
      query.Append(" @UF_SIGLA, ");
      query.Append(" @UF_DESCRICAO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@UF_SIGLA", registro.UF_SIGLA);
              cmd.Parameters.AddWithValue("@UF_DESCRICAO", registro.UF_DESCRICAO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.ENDERECOS_UF"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_UF ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM ENDERECOS_UF ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="ENDERECOS_UF"></param>
  public void Update(TAB.ENDERECOS_UF registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE ENDERECOS_UF SET ");
      query.Append(" UF_SIGLA=@UF_SIGLA, ");
      query.Append(" UF_DESCRICAO=@UF_DESCRICAO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@UF_ID", registro.UF_ID);
                  cmd.Parameters.AddWithValue("@UF_SIGLA", registro.UF_SIGLA);
                  cmd.Parameters.AddWithValue("@UF_DESCRICAO", registro.UF_DESCRICAO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO ");
          query.Append("FROM ENDERECOS_UF ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO ");
          query.Append("FROM ENDERECOS_UF ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO ");
          query.Append("FROM ENDERECOS_UF ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO ");
          query.Append(" FROM ENDERECOS_UF ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO ");
          query.Append(" FROM ENDERECOS_UF ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por UF_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_UF_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_UF_ID(int _UF_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO, ");
          query.Append(" UF_DESCRICAO ");
          query.Append(" FROM ENDERECOS_UF ");
          query.Append(" WHERE (  UF_ID =   " + _UF_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por UF_SIGLA e retorna um DataSet.
      /// </summary>
      /// <param name="_UF_SIGLA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_UF_SIGLA(string _UF_SIGLA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO, ");
          query.Append(" UF_DESCRICAO ");
          query.Append(" FROM ENDERECOS_UF ");
          query.Append(" WHERE (  UF_SIGLA =  '" + _UF_SIGLA + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por UF_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_UF_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_UF_DESCRICAO(string _UF_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" UF_ID, ");
          query.Append(" UF_SIGLA, ");
          query.Append(" UF_DESCRICAO, ");
          query.Append(" UF_DESCRICAO ");
          query.Append(" FROM ENDERECOS_UF ");
          query.Append(" WHERE (  UF_DESCRICAO =  '" + _UF_DESCRICAO + "'  ) ");

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
  }

#endregion

#region classe FAVORITOS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class FAVORITOS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.FAVORITOS"></param>
  public int InsertId(TAB.FAVORITOS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO FAVORITOS (");
      query.Append(" FAVORITO_LINK, ");
      query.Append(" FAVORITO_INCLUSAO, ");
      query.Append(" FAVORITO_DESCRICAO, ");
      query.Append(" FAVORITO_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @FAVORITO_LINK, ");
      query.Append(" @FAVORITO_INCLUSAO, ");
      query.Append(" @FAVORITO_DESCRICAO, ");
      query.Append(" @FAVORITO_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@FAVORITO_LINK", registro.FAVORITO_LINK);
                  cmd.Parameters.AddWithValue("@FAVORITO_INCLUSAO", registro.FAVORITO_INCLUSAO);
                  cmd.Parameters.AddWithValue("@FAVORITO_DESCRICAO", registro.FAVORITO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@FAVORITO_ATIVO", registro.FAVORITO_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// AUTOR:    MARCOS 
  /// DATA:     12/10/2010
  /// NOME:     INSERT
  /// </summary>
  /// <param name="FAVORITOS"></param>
  public void Insert(TAB.FAVORITOS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO FAVORITOS (");
      query.Append(" FAVORITO_LINK, ");
      query.Append(" FAVORITO_INCLUSAO, ");
      query.Append(" FAVORITO_DESCRICAO, ");
      query.Append(" FAVORITO_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @FAVORITO_LINK, ");
      query.Append(" @FAVORITO_INCLUSAO, ");
      query.Append(" @FAVORITO_DESCRICAO, ");
      query.Append(" @FAVORITO_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@FAVORITO_LINK", registro.FAVORITO_LINK);
              cmd.Parameters.AddWithValue("@FAVORITO_INCLUSAO", registro.FAVORITO_INCLUSAO);
              cmd.Parameters.AddWithValue("@FAVORITO_DESCRICAO", registro.FAVORITO_DESCRICAO);
              cmd.Parameters.AddWithValue("@FAVORITO_ATIVO", registro.FAVORITO_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.FAVORITOS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM FAVORITOS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM FAVORITOS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="FAVORITOS"></param>
  public void Update(TAB.FAVORITOS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE FAVORITOS SET ");
      query.Append(" FAVORITO_LINK=@FAVORITO_LINK, ");
      query.Append(" FAVORITO_INCLUSAO=@FAVORITO_INCLUSAO, ");
      query.Append(" FAVORITO_DESCRICAO=@FAVORITO_DESCRICAO, ");
      query.Append(" FAVORITO_ATIVO=@FAVORITO_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@FAVORITO_ID", registro.FAVORITO_ID);
                  cmd.Parameters.AddWithValue("@FAVORITO_LINK", registro.FAVORITO_LINK);
                  cmd.Parameters.AddWithValue("@FAVORITO_INCLUSAO", registro.FAVORITO_INCLUSAO);
                  cmd.Parameters.AddWithValue("@FAVORITO_DESCRICAO", registro.FAVORITO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@FAVORITO_ATIVO", registro.FAVORITO_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append("FROM FAVORITOS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append("FROM FAVORITOS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append("FROM FAVORITOS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_ID(int _FAVORITO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE (  FAVORITO_ID =   " + _FAVORITO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_LINK(string _FAVORITO_LINK)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE (  FAVORITO_LINK =  '" + _FAVORITO_LINK + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_INCLUSAO(DateTime _FAVORITO_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE (  FAVORITO_INCLUSAO = CONVERT(DATETIME, '" + _FAVORITO_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_DESCRICAO(string _FAVORITO_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE (  FAVORITO_DESCRICAO =  '" + _FAVORITO_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_ATIVO(byte _FAVORITO_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FAVORITO_ID, ");
          query.Append(" FAVORITO_LINK, ");
          query.Append(" FAVORITO_INCLUSAO, ");
          query.Append(" FAVORITO_DESCRICAO, ");
          query.Append(" FAVORITO_ATIVO, ");
          query.Append(" FAVORITO_ATIVO ");
          query.Append(" FROM FAVORITOS ");
          query.Append(" WHERE (  FAVORITO_ATIVO =   " + _FAVORITO_ATIVO + "  ) ");

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
  }

#endregion

#region classe FERIADOS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class FERIADOS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.FERIADOS"></param>
  public int InsertId(TAB.FERIADOS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO FERIADOS (");
      query.Append(" FERIADO_DATA, ");
      query.Append(" FERIADO_DESCRICAO, ");
      query.Append(" FERIADO_FIXO, ");
      query.Append(" FERIADO_GRUPO ");
      query.Append(") VALUES (");
      query.Append(" @FERIADO_DATA, ");
      query.Append(" @FERIADO_DESCRICAO, ");
      query.Append(" @FERIADO_FIXO, ");
      query.Append(" @FERIADO_GRUPO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@FERIADO_DATA", registro.FERIADO_DATA);
                  cmd.Parameters.AddWithValue("@FERIADO_DESCRICAO", registro.FERIADO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@FERIADO_FIXO", registro.FERIADO_FIXO);
                  cmd.Parameters.AddWithValue("@FERIADO_GRUPO", registro.FERIADO_GRUPO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="FERIADOS"></param>
  public void Insert(TAB.FERIADOS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO FERIADOS (");
      query.Append(" FERIADO_DATA, ");
      query.Append(" FERIADO_DESCRICAO, ");
      query.Append(" FERIADO_FIXO, ");
      query.Append(" FERIADO_GRUPO ");
      query.Append(") VALUES (");
      query.Append(" @FERIADO_DATA, ");
      query.Append(" @FERIADO_DESCRICAO, ");
      query.Append(" @FERIADO_FIXO, ");
      query.Append(" @FERIADO_GRUPO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@FERIADO_DATA", registro.FERIADO_DATA);
              cmd.Parameters.AddWithValue("@FERIADO_DESCRICAO", registro.FERIADO_DESCRICAO);
              cmd.Parameters.AddWithValue("@FERIADO_FIXO", registro.FERIADO_FIXO);
              cmd.Parameters.AddWithValue("@FERIADO_GRUPO", registro.FERIADO_GRUPO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.FERIADOS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM FERIADOS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM FERIADOS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="FERIADOS"></param>
  public void Update(TAB.FERIADOS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE FERIADOS SET ");
      query.Append(" FERIADO_DATA=@FERIADO_DATA, ");
      query.Append(" FERIADO_DESCRICAO=@FERIADO_DESCRICAO, ");
      query.Append(" FERIADO_FIXO=@FERIADO_FIXO, ");
      query.Append(" FERIADO_GRUPO=@FERIADO_GRUPO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@FERIADO_ID", registro.FERIADO_ID);
                  cmd.Parameters.AddWithValue("@FERIADO_DATA", registro.FERIADO_DATA);
                  cmd.Parameters.AddWithValue("@FERIADO_DESCRICAO", registro.FERIADO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@FERIADO_FIXO", registro.FERIADO_FIXO);
                  cmd.Parameters.AddWithValue("@FERIADO_GRUPO", registro.FERIADO_GRUPO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append("FROM FERIADOS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append("FROM FERIADOS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append("FROM FERIADOS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_ID(int _FERIADO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE (  FERIADO_ID =   " + _FERIADO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_DATA e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_DATA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_DATA(DateTime _FERIADO_DATA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE (  FERIADO_DATA = CONVERT(DATETIME, '" + _FERIADO_DATA + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_DESCRICAO(string _FERIADO_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE (  FERIADO_DESCRICAO =  '" + _FERIADO_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_FIXO e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_FIXO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_FIXO(byte _FERIADO_FIXO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE (  FERIADO_FIXO =   " + _FERIADO_FIXO + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_GRUPO e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_GRUPO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_GRUPO(int _FERIADO_GRUPO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" FERIADO_ID, ");
          query.Append(" FERIADO_DATA, ");
          query.Append(" FERIADO_DESCRICAO, ");
          query.Append(" FERIADO_FIXO, ");
          query.Append(" FERIADO_GRUPO, ");
          query.Append(" FERIADO_GRUPO ");
          query.Append(" FROM FERIADOS ");
          query.Append(" WHERE (  FERIADO_GRUPO =   " + _FERIADO_GRUPO + "  ) ");

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
  }

#endregion

#region classe FUNCIONARIOS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class FUNCIONARIOS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.FUNCIONARIOS"></param>
  public int InsertId(TAB.FUNCIONARIOS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO FUNCIONARIOS (");
      query.Append(" funcionarioEmpresaID, ");
      query.Append(" funcionarioNOME, ");
      query.Append(" funcionarioEndereco, ");
      query.Append(" funcionarioBairro, ");
      query.Append(" funcionarioCidade, ");
      query.Append(" funcionarioEstado, ");
      query.Append(" funcionarioCep, ");
      query.Append(" funcionarioTelefone, ");
      query.Append(" funcionarioCelular, ");
      query.Append(" funcionarioEMail, ");
      query.Append(" funcionarioIdentidade, ");
      query.Append(" funcionarioCPF, ");
      query.Append(" funcionarioNascimento, ");
      query.Append(" funcionarioCargo, ");
      query.Append(" funcionarioSalario, ");
      query.Append(" funcionarioAdmissao, ");
      query.Append(" funcionarioDiaPagamento, ");
      query.Append(" funcionarioFoto, ");
      query.Append(" funcionarioOBS, ");
      query.Append(" funcionarioInativo, ");
      query.Append(" funcionarioCBO, ");
      query.Append(" funcionarioSetor ");
      query.Append(") VALUES (");
      query.Append(" @funcionarioEmpresaID, ");
      query.Append(" @funcionarioNOME, ");
      query.Append(" @funcionarioEndereco, ");
      query.Append(" @funcionarioBairro, ");
      query.Append(" @funcionarioCidade, ");
      query.Append(" @funcionarioEstado, ");
      query.Append(" @funcionarioCep, ");
      query.Append(" @funcionarioTelefone, ");
      query.Append(" @funcionarioCelular, ");
      query.Append(" @funcionarioEMail, ");
      query.Append(" @funcionarioIdentidade, ");
      query.Append(" @funcionarioCPF, ");
      query.Append(" @funcionarioNascimento, ");
      query.Append(" @funcionarioCargo, ");
      query.Append(" @funcionarioSalario, ");
      query.Append(" @funcionarioAdmissao, ");
      query.Append(" @funcionarioDiaPagamento, ");
      query.Append(" @funcionarioFoto, ");
      query.Append(" @funcionarioOBS, ");
      query.Append(" @funcionarioInativo, ");
      query.Append(" @funcionarioCBO, ");
      query.Append(" @funcionarioSetor ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@funcionarioEmpresaID", registro.funcionarioEmpresaID);
                  cmd.Parameters.AddWithValue("@funcionarioNOME", registro.funcionarioNOME);
                  cmd.Parameters.AddWithValue("@funcionarioEndereco", registro.funcionarioEndereco);
                  cmd.Parameters.AddWithValue("@funcionarioBairro", registro.funcionarioBairro);
                  cmd.Parameters.AddWithValue("@funcionarioCidade", registro.funcionarioCidade);
                  cmd.Parameters.AddWithValue("@funcionarioEstado", registro.funcionarioEstado);
                  cmd.Parameters.AddWithValue("@funcionarioCep", registro.funcionarioCep);
                  cmd.Parameters.AddWithValue("@funcionarioTelefone", registro.funcionarioTelefone);
                  cmd.Parameters.AddWithValue("@funcionarioCelular", registro.funcionarioCelular);
                  cmd.Parameters.AddWithValue("@funcionarioEMail", registro.funcionarioEMail);
                  cmd.Parameters.AddWithValue("@funcionarioIdentidade", registro.funcionarioIdentidade);
                  cmd.Parameters.AddWithValue("@funcionarioCPF", registro.funcionarioCPF);
                  cmd.Parameters.AddWithValue("@funcionarioNascimento", registro.funcionarioNascimento);
                  cmd.Parameters.AddWithValue("@funcionarioCargo", registro.funcionarioCargo);
                  cmd.Parameters.AddWithValue("@funcionarioSalario", registro.funcionarioSalario);
                  cmd.Parameters.AddWithValue("@funcionarioAdmissao", registro.funcionarioAdmissao);
                  cmd.Parameters.AddWithValue("@funcionarioDiaPagamento", registro.funcionarioDiaPagamento);
                  cmd.Parameters.AddWithValue("@funcionarioFoto", registro.funcionarioFoto);
                  cmd.Parameters.AddWithValue("@funcionarioOBS", registro.funcionarioOBS);
                  cmd.Parameters.AddWithValue("@funcionarioInativo", registro.funcionarioInativo);
                  cmd.Parameters.AddWithValue("@funcionarioCBO", registro.funcionarioCBO);
                  cmd.Parameters.AddWithValue("@funcionarioSetor", registro.funcionarioSetor);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="FUNCIONARIOS"></param>
  public void Insert(TAB.FUNCIONARIOS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO FUNCIONARIOS (");
      query.Append(" funcionarioEmpresaID, ");
      query.Append(" funcionarioNOME, ");
      query.Append(" funcionarioEndereco, ");
      query.Append(" funcionarioBairro, ");
      query.Append(" funcionarioCidade, ");
      query.Append(" funcionarioEstado, ");
      query.Append(" funcionarioCep, ");
      query.Append(" funcionarioTelefone, ");
      query.Append(" funcionarioCelular, ");
      query.Append(" funcionarioEMail, ");
      query.Append(" funcionarioIdentidade, ");
      query.Append(" funcionarioCPF, ");
      query.Append(" funcionarioNascimento, ");
      query.Append(" funcionarioCargo, ");
      query.Append(" funcionarioSalario, ");
      query.Append(" funcionarioAdmissao, ");
      query.Append(" funcionarioDiaPagamento, ");
      query.Append(" funcionarioFoto, ");
      query.Append(" funcionarioOBS, ");
      query.Append(" funcionarioInativo, ");
      query.Append(" funcionarioCBO, ");
      query.Append(" funcionarioSetor ");
      query.Append(") VALUES (");
      query.Append(" @funcionarioEmpresaID, ");
      query.Append(" @funcionarioNOME, ");
      query.Append(" @funcionarioEndereco, ");
      query.Append(" @funcionarioBairro, ");
      query.Append(" @funcionarioCidade, ");
      query.Append(" @funcionarioEstado, ");
      query.Append(" @funcionarioCep, ");
      query.Append(" @funcionarioTelefone, ");
      query.Append(" @funcionarioCelular, ");
      query.Append(" @funcionarioEMail, ");
      query.Append(" @funcionarioIdentidade, ");
      query.Append(" @funcionarioCPF, ");
      query.Append(" @funcionarioNascimento, ");
      query.Append(" @funcionarioCargo, ");
      query.Append(" @funcionarioSalario, ");
      query.Append(" @funcionarioAdmissao, ");
      query.Append(" @funcionarioDiaPagamento, ");
      query.Append(" @funcionarioFoto, ");
      query.Append(" @funcionarioOBS, ");
      query.Append(" @funcionarioInativo, ");
      query.Append(" @funcionarioCBO, ");
      query.Append(" @funcionarioSetor ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@funcionarioEmpresaID", registro.funcionarioEmpresaID);
              cmd.Parameters.AddWithValue("@funcionarioNOME", registro.funcionarioNOME);
              cmd.Parameters.AddWithValue("@funcionarioEndereco", registro.funcionarioEndereco);
              cmd.Parameters.AddWithValue("@funcionarioBairro", registro.funcionarioBairro);
              cmd.Parameters.AddWithValue("@funcionarioCidade", registro.funcionarioCidade);
              cmd.Parameters.AddWithValue("@funcionarioEstado", registro.funcionarioEstado);
              cmd.Parameters.AddWithValue("@funcionarioCep", registro.funcionarioCep);
              cmd.Parameters.AddWithValue("@funcionarioTelefone", registro.funcionarioTelefone);
              cmd.Parameters.AddWithValue("@funcionarioCelular", registro.funcionarioCelular);
              cmd.Parameters.AddWithValue("@funcionarioEMail", registro.funcionarioEMail);
              cmd.Parameters.AddWithValue("@funcionarioIdentidade", registro.funcionarioIdentidade);
              cmd.Parameters.AddWithValue("@funcionarioCPF", registro.funcionarioCPF);
              cmd.Parameters.AddWithValue("@funcionarioNascimento", registro.funcionarioNascimento);
              cmd.Parameters.AddWithValue("@funcionarioCargo", registro.funcionarioCargo);
              cmd.Parameters.AddWithValue("@funcionarioSalario", registro.funcionarioSalario);
              cmd.Parameters.AddWithValue("@funcionarioAdmissao", registro.funcionarioAdmissao);
              cmd.Parameters.AddWithValue("@funcionarioDiaPagamento", registro.funcionarioDiaPagamento);
              cmd.Parameters.AddWithValue("@funcionarioFoto", registro.funcionarioFoto);
              cmd.Parameters.AddWithValue("@funcionarioOBS", registro.funcionarioOBS);
              cmd.Parameters.AddWithValue("@funcionarioInativo", registro.funcionarioInativo);
              cmd.Parameters.AddWithValue("@funcionarioCBO", registro.funcionarioCBO);
              cmd.Parameters.AddWithValue("@funcionarioSetor", registro.funcionarioSetor);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.FUNCIONARIOS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM FUNCIONARIOS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM FUNCIONARIOS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="FUNCIONARIOS"></param>
  public void Update(TAB.FUNCIONARIOS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE FUNCIONARIOS SET ");
      query.Append(" funcionarioEmpresaID=@funcionarioEmpresaID, ");
      query.Append(" funcionarioNOME=@funcionarioNOME, ");
      query.Append(" funcionarioEndereco=@funcionarioEndereco, ");
      query.Append(" funcionarioBairro=@funcionarioBairro, ");
      query.Append(" funcionarioCidade=@funcionarioCidade, ");
      query.Append(" funcionarioEstado=@funcionarioEstado, ");
      query.Append(" funcionarioCep=@funcionarioCep, ");
      query.Append(" funcionarioTelefone=@funcionarioTelefone, ");
      query.Append(" funcionarioCelular=@funcionarioCelular, ");
      query.Append(" funcionarioEMail=@funcionarioEMail, ");
      query.Append(" funcionarioIdentidade=@funcionarioIdentidade, ");
      query.Append(" funcionarioCPF=@funcionarioCPF, ");
      query.Append(" funcionarioNascimento=@funcionarioNascimento, ");
      query.Append(" funcionarioCargo=@funcionarioCargo, ");
      query.Append(" funcionarioSalario=@funcionarioSalario, ");
      query.Append(" funcionarioAdmissao=@funcionarioAdmissao, ");
      query.Append(" funcionarioDiaPagamento=@funcionarioDiaPagamento, ");
      query.Append(" funcionarioFoto=@funcionarioFoto, ");
      query.Append(" funcionarioOBS=@funcionarioOBS, ");
      query.Append(" funcionarioInativo=@funcionarioInativo, ");
      query.Append(" funcionarioCBO=@funcionarioCBO, ");
      query.Append(" funcionarioSetor=@funcionarioSetor ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@funcionarioID", registro.funcionarioID);
                  cmd.Parameters.AddWithValue("@funcionarioEmpresaID", registro.funcionarioEmpresaID);
                  cmd.Parameters.AddWithValue("@funcionarioNOME", registro.funcionarioNOME);
                  cmd.Parameters.AddWithValue("@funcionarioEndereco", registro.funcionarioEndereco);
                  cmd.Parameters.AddWithValue("@funcionarioBairro", registro.funcionarioBairro);
                  cmd.Parameters.AddWithValue("@funcionarioCidade", registro.funcionarioCidade);
                  cmd.Parameters.AddWithValue("@funcionarioEstado", registro.funcionarioEstado);
                  cmd.Parameters.AddWithValue("@funcionarioCep", registro.funcionarioCep);
                  cmd.Parameters.AddWithValue("@funcionarioTelefone", registro.funcionarioTelefone);
                  cmd.Parameters.AddWithValue("@funcionarioCelular", registro.funcionarioCelular);
                  cmd.Parameters.AddWithValue("@funcionarioEMail", registro.funcionarioEMail);
                  cmd.Parameters.AddWithValue("@funcionarioIdentidade", registro.funcionarioIdentidade);
                  cmd.Parameters.AddWithValue("@funcionarioCPF", registro.funcionarioCPF);
                  cmd.Parameters.AddWithValue("@funcionarioNascimento", registro.funcionarioNascimento);
                  cmd.Parameters.AddWithValue("@funcionarioCargo", registro.funcionarioCargo);
                  cmd.Parameters.AddWithValue("@funcionarioSalario", registro.funcionarioSalario);
                  cmd.Parameters.AddWithValue("@funcionarioAdmissao", registro.funcionarioAdmissao);
                  cmd.Parameters.AddWithValue("@funcionarioDiaPagamento", registro.funcionarioDiaPagamento);
                  cmd.Parameters.AddWithValue("@funcionarioFoto", registro.funcionarioFoto);
                  cmd.Parameters.AddWithValue("@funcionarioOBS", registro.funcionarioOBS);
                  cmd.Parameters.AddWithValue("@funcionarioInativo", registro.funcionarioInativo);
                  cmd.Parameters.AddWithValue("@funcionarioCBO", registro.funcionarioCBO);
                  cmd.Parameters.AddWithValue("@funcionarioSetor", registro.funcionarioSetor);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor ");
          query.Append("FROM FUNCIONARIOS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor ");
          query.Append("FROM FUNCIONARIOS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor ");
          query.Append("FROM FUNCIONARIOS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioID e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioID(int _funcionarioID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioID =   " + _funcionarioID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEmpresaID e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEmpresaID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEmpresaID(int _funcionarioEmpresaID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioEmpresaID =   " + _funcionarioEmpresaID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioNOME e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioNOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioNOME(string _funcionarioNOME)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioNOME =  '" + _funcionarioNOME + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEndereco e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEndereco">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEndereco(string _funcionarioEndereco)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioEndereco =  '" + _funcionarioEndereco + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioBairro e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioBairro">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioBairro(string _funcionarioBairro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioBairro =  '" + _funcionarioBairro + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCidade e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCidade">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCidade(string _funcionarioCidade)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioCidade =  '" + _funcionarioCidade + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEstado e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEstado">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEstado(string _funcionarioEstado)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioEstado =  '" + _funcionarioEstado + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCep e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCep">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCep(string _funcionarioCep)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioCep =  '" + _funcionarioCep + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioTelefone e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioTelefone">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioTelefone(string _funcionarioTelefone)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioTelefone =  '" + _funcionarioTelefone + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCelular e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCelular">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCelular(string _funcionarioCelular)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioCelular =  '" + _funcionarioCelular + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEMail e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEMail">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEMail(string _funcionarioEMail)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioEMail =  '" + _funcionarioEMail + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioIdentidade e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioIdentidade">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioIdentidade(string _funcionarioIdentidade)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioIdentidade =  '" + _funcionarioIdentidade + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCPF e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCPF">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCPF(string _funcionarioCPF)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioCPF =  '" + _funcionarioCPF + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioNascimento e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioNascimento">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioNascimento(DateTime _funcionarioNascimento)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioNascimento = CONVERT(DATETIME, '" + _funcionarioNascimento + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCargo e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCargo">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCargo(string _funcionarioCargo)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioCargo =  '" + _funcionarioCargo + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioSalario e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioSalario">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioSalario(float _funcionarioSalario)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioSalario =   " + _funcionarioSalario + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioAdmissao e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioAdmissao">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioAdmissao(DateTime _funcionarioAdmissao)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioAdmissao = CONVERT(DATETIME, '" + _funcionarioAdmissao + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioDiaPagamento e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioDiaPagamento">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioDiaPagamento(Int32 _funcionarioDiaPagamento)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioDiaPagamento =   " + _funcionarioDiaPagamento + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioFoto e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioFoto">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioFoto(Byte _funcionarioFoto)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioFoto =  '" + _funcionarioFoto + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioOBS e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioOBS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioOBS(StringBuilder _funcionarioOBS)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioOBS =  '" + _funcionarioOBS + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioInativo e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioInativo">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioInativo(byte _funcionarioInativo)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioInativo =   " + _funcionarioInativo + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCBO e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCBO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCBO(string _funcionarioCBO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioCBO =  '" + _funcionarioCBO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioSetor e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioSetor">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioSetor(int _funcionarioSetor)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" funcionarioID, ");
          query.Append(" funcionarioEmpresaID, ");
          query.Append(" funcionarioNOME, ");
          query.Append(" funcionarioEndereco, ");
          query.Append(" funcionarioBairro, ");
          query.Append(" funcionarioCidade, ");
          query.Append(" funcionarioEstado, ");
          query.Append(" funcionarioCep, ");
          query.Append(" funcionarioTelefone, ");
          query.Append(" funcionarioCelular, ");
          query.Append(" funcionarioEMail, ");
          query.Append(" funcionarioIdentidade, ");
          query.Append(" funcionarioCPF, ");
          query.Append(" funcionarioNascimento, ");
          query.Append(" funcionarioCargo, ");
          query.Append(" funcionarioSalario, ");
          query.Append(" funcionarioAdmissao, ");
          query.Append(" funcionarioDiaPagamento, ");
          query.Append(" funcionarioFoto, ");
          query.Append(" funcionarioOBS, ");
          query.Append(" funcionarioInativo, ");
          query.Append(" funcionarioCBO, ");
          query.Append(" funcionarioSetor, ");
          query.Append(" funcionarioSetor ");
          query.Append(" FROM FUNCIONARIOS ");
          query.Append(" WHERE (  funcionarioSetor =   " + _funcionarioSetor + "  ) ");

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
  }

#endregion

#region classe MENU
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class MENU
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.MENU"></param>
  public int InsertId(TAB.MENU registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO MENU (");
      query.Append(" MENU_NOME, ");
      query.Append(" MENU_DESCRICAO, ");
      query.Append(" MENU_PAI, ");
      query.Append(" MENU_LINK ");
      query.Append(") VALUES (");
      query.Append(" @MENU_NOME, ");
      query.Append(" @MENU_DESCRICAO, ");
      query.Append(" @MENU_PAI, ");
      query.Append(" @MENU_LINK ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@MENU_NOME", registro.MENU_NOME);
                  cmd.Parameters.AddWithValue("@MENU_DESCRICAO", registro.MENU_DESCRICAO);
                  cmd.Parameters.AddWithValue("@MENU_PAI", registro.MENU_PAI);
                  cmd.Parameters.AddWithValue("@MENU_LINK", registro.MENU_LINK);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="MENU"></param>
  public void Insert(TAB.MENU registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO MENU (");
      query.Append(" MENU_NOME, ");
      query.Append(" MENU_DESCRICAO, ");
      query.Append(" MENU_PAI, ");
      query.Append(" MENU_LINK ");
      query.Append(") VALUES (");
      query.Append(" @MENU_NOME, ");
      query.Append(" @MENU_DESCRICAO, ");
      query.Append(" @MENU_PAI, ");
      query.Append(" @MENU_LINK ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@MENU_NOME", registro.MENU_NOME);
              cmd.Parameters.AddWithValue("@MENU_DESCRICAO", registro.MENU_DESCRICAO);
              cmd.Parameters.AddWithValue("@MENU_PAI", registro.MENU_PAI);
              cmd.Parameters.AddWithValue("@MENU_LINK", registro.MENU_LINK);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.MENU"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM MENU ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM MENU ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="MENU"></param>
  public void Update(TAB.MENU registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE MENU SET ");
      query.Append(" MENU_NOME=@MENU_NOME, ");
      query.Append(" MENU_DESCRICAO=@MENU_DESCRICAO, ");
      query.Append(" MENU_PAI=@MENU_PAI, ");
      query.Append(" MENU_LINK=@MENU_LINK ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@MENU_ID", registro.MENU_ID);
                  cmd.Parameters.AddWithValue("@MENU_NOME", registro.MENU_NOME);
                  cmd.Parameters.AddWithValue("@MENU_DESCRICAO", registro.MENU_DESCRICAO);
                  cmd.Parameters.AddWithValue("@MENU_PAI", registro.MENU_PAI);
                  cmd.Parameters.AddWithValue("@MENU_LINK", registro.MENU_LINK);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK ");
          query.Append("FROM MENU ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK ");
          query.Append("FROM MENU ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK ");
          query.Append("FROM MENU ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por MENU_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_ID(int _MENU_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE (  MENU_ID =   " + _MENU_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por MENU_NOME e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_NOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_NOME(string _MENU_NOME)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE (  MENU_NOME =  '" + _MENU_NOME + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por MENU_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_DESCRICAO(string _MENU_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE (  MENU_DESCRICAO =  '" + _MENU_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por MENU_PAI e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_PAI">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_PAI(int _MENU_PAI)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE (  MENU_PAI =   " + _MENU_PAI + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por MENU_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_LINK(string _MENU_LINK)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" MENU_ID, ");
          query.Append(" MENU_NOME, ");
          query.Append(" MENU_DESCRICAO, ");
          query.Append(" MENU_PAI, ");
          query.Append(" MENU_LINK, ");
          query.Append(" MENU_LINK ");
          query.Append(" FROM MENU ");
          query.Append(" WHERE (  MENU_LINK =  '" + _MENU_LINK + "'  ) ");

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
  }

#endregion

#region classe PESSOAS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.PESSOAS"></param>
  public int InsertId(TAB.PESSOAS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS (");
      query.Append(" PESSOA_CODIGO, ");
      query.Append(" PESSOA_NOME, ");
      query.Append(" PESSOA_ENDERECO, ");
      query.Append(" PESSOA_ENDERECO_NR, ");
      query.Append(" PESSOA_BAIRRO, ");
      query.Append(" PESSOA_CIDADE, ");
      query.Append(" PESSOA_ESTADO, ");
      query.Append(" PESSOA_CEP, ");
      query.Append(" PESSOA_TELEFONE, ");
      query.Append(" PESSOA_EMAIL, ");
      query.Append(" PESSOA_WEB, ");
      query.Append(" PESSOA_NASCIMENTO, ");
      query.Append(" PESSOA_RENDA, ");
      query.Append(" PESSOA_INCLUSAO, ");
      query.Append(" PESSOA_TAG_CLIENTE, ");
      query.Append(" PESSOA_TAG_EMPRESA ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_CODIGO, ");
      query.Append(" @PESSOA_NOME, ");
      query.Append(" @PESSOA_ENDERECO, ");
      query.Append(" @PESSOA_ENDERECO_NR, ");
      query.Append(" @PESSOA_BAIRRO, ");
      query.Append(" @PESSOA_CIDADE, ");
      query.Append(" @PESSOA_ESTADO, ");
      query.Append(" @PESSOA_CEP, ");
      query.Append(" @PESSOA_TELEFONE, ");
      query.Append(" @PESSOA_EMAIL, ");
      query.Append(" @PESSOA_WEB, ");
      query.Append(" @PESSOA_NASCIMENTO, ");
      query.Append(" @PESSOA_RENDA, ");
      query.Append(" @PESSOA_INCLUSAO, ");
      query.Append(" @PESSOA_TAG_CLIENTE, ");
      query.Append(" @PESSOA_TAG_EMPRESA ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@PESSOA_CODIGO", registro.PESSOA_CODIGO);
                  cmd.Parameters.AddWithValue("@PESSOA_NOME", registro.PESSOA_NOME);
                  cmd.Parameters.AddWithValue("@PESSOA_ENDERECO", registro.PESSOA_ENDERECO);
                  cmd.Parameters.AddWithValue("@PESSOA_ENDERECO_NR", registro.PESSOA_ENDERECO_NR);
                  cmd.Parameters.AddWithValue("@PESSOA_BAIRRO", registro.PESSOA_BAIRRO);
                  cmd.Parameters.AddWithValue("@PESSOA_CIDADE", registro.PESSOA_CIDADE);
                  cmd.Parameters.AddWithValue("@PESSOA_ESTADO", registro.PESSOA_ESTADO);
                  cmd.Parameters.AddWithValue("@PESSOA_CEP", registro.PESSOA_CEP);
                  cmd.Parameters.AddWithValue("@PESSOA_TELEFONE", registro.PESSOA_TELEFONE);
                  cmd.Parameters.AddWithValue("@PESSOA_EMAIL", registro.PESSOA_EMAIL);
                  cmd.Parameters.AddWithValue("@PESSOA_WEB", registro.PESSOA_WEB);
                  cmd.Parameters.AddWithValue("@PESSOA_NASCIMENTO", registro.PESSOA_NASCIMENTO);
                  cmd.Parameters.AddWithValue("@PESSOA_RENDA", registro.PESSOA_RENDA);
                  cmd.Parameters.AddWithValue("@PESSOA_INCLUSAO", registro.PESSOA_INCLUSAO);
                  cmd.Parameters.AddWithValue("@PESSOA_TAG_CLIENTE", registro.PESSOA_TAG_CLIENTE);
                  cmd.Parameters.AddWithValue("@PESSOA_TAG_EMPRESA", registro.PESSOA_TAG_EMPRESA);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="PESSOAS"></param>
  public void Insert(TAB.PESSOAS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS (");
      query.Append(" PESSOA_CODIGO, ");
      query.Append(" PESSOA_NOME, ");
      query.Append(" PESSOA_ENDERECO, ");
      query.Append(" PESSOA_ENDERECO_NR, ");
      query.Append(" PESSOA_BAIRRO, ");
      query.Append(" PESSOA_CIDADE, ");
      query.Append(" PESSOA_ESTADO, ");
      query.Append(" PESSOA_CEP, ");
      query.Append(" PESSOA_TELEFONE, ");
      query.Append(" PESSOA_EMAIL, ");
      query.Append(" PESSOA_WEB, ");
      query.Append(" PESSOA_NASCIMENTO, ");
      query.Append(" PESSOA_RENDA, ");
      query.Append(" PESSOA_INCLUSAO, ");
      query.Append(" PESSOA_TAG_CLIENTE, ");
      query.Append(" PESSOA_TAG_EMPRESA ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_CODIGO, ");
      query.Append(" @PESSOA_NOME, ");
      query.Append(" @PESSOA_ENDERECO, ");
      query.Append(" @PESSOA_ENDERECO_NR, ");
      query.Append(" @PESSOA_BAIRRO, ");
      query.Append(" @PESSOA_CIDADE, ");
      query.Append(" @PESSOA_ESTADO, ");
      query.Append(" @PESSOA_CEP, ");
      query.Append(" @PESSOA_TELEFONE, ");
      query.Append(" @PESSOA_EMAIL, ");
      query.Append(" @PESSOA_WEB, ");
      query.Append(" @PESSOA_NASCIMENTO, ");
      query.Append(" @PESSOA_RENDA, ");
      query.Append(" @PESSOA_INCLUSAO, ");
      query.Append(" @PESSOA_TAG_CLIENTE, ");
      query.Append(" @PESSOA_TAG_EMPRESA ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@PESSOA_CODIGO", registro.PESSOA_CODIGO);
              cmd.Parameters.AddWithValue("@PESSOA_NOME", registro.PESSOA_NOME);
              cmd.Parameters.AddWithValue("@PESSOA_ENDERECO", registro.PESSOA_ENDERECO);
              cmd.Parameters.AddWithValue("@PESSOA_ENDERECO_NR", registro.PESSOA_ENDERECO_NR);
              cmd.Parameters.AddWithValue("@PESSOA_BAIRRO", registro.PESSOA_BAIRRO);
              cmd.Parameters.AddWithValue("@PESSOA_CIDADE", registro.PESSOA_CIDADE);
              cmd.Parameters.AddWithValue("@PESSOA_ESTADO", registro.PESSOA_ESTADO);
              cmd.Parameters.AddWithValue("@PESSOA_CEP", registro.PESSOA_CEP);
              cmd.Parameters.AddWithValue("@PESSOA_TELEFONE", registro.PESSOA_TELEFONE);
              cmd.Parameters.AddWithValue("@PESSOA_EMAIL", registro.PESSOA_EMAIL);
              cmd.Parameters.AddWithValue("@PESSOA_WEB", registro.PESSOA_WEB);
              cmd.Parameters.AddWithValue("@PESSOA_NASCIMENTO", registro.PESSOA_NASCIMENTO);
              cmd.Parameters.AddWithValue("@PESSOA_RENDA", registro.PESSOA_RENDA);
              cmd.Parameters.AddWithValue("@PESSOA_INCLUSAO", registro.PESSOA_INCLUSAO);
              cmd.Parameters.AddWithValue("@PESSOA_TAG_CLIENTE", registro.PESSOA_TAG_CLIENTE);
              cmd.Parameters.AddWithValue("@PESSOA_TAG_EMPRESA", registro.PESSOA_TAG_EMPRESA);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.PESSOAS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="PESSOAS"></param>
  public void Update(TAB.PESSOAS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE PESSOAS SET ");
      query.Append(" PESSOA_CODIGO=@PESSOA_CODIGO, ");
      query.Append(" PESSOA_NOME=@PESSOA_NOME, ");
      query.Append(" PESSOA_ENDERECO=@PESSOA_ENDERECO, ");
      query.Append(" PESSOA_ENDERECO_NR=@PESSOA_ENDERECO_NR, ");
      query.Append(" PESSOA_BAIRRO=@PESSOA_BAIRRO, ");
      query.Append(" PESSOA_CIDADE=@PESSOA_CIDADE, ");
      query.Append(" PESSOA_ESTADO=@PESSOA_ESTADO, ");
      query.Append(" PESSOA_CEP=@PESSOA_CEP, ");
      query.Append(" PESSOA_TELEFONE=@PESSOA_TELEFONE, ");
      query.Append(" PESSOA_EMAIL=@PESSOA_EMAIL, ");
      query.Append(" PESSOA_WEB=@PESSOA_WEB, ");
      query.Append(" PESSOA_NASCIMENTO=@PESSOA_NASCIMENTO, ");
      query.Append(" PESSOA_RENDA=@PESSOA_RENDA, ");
      query.Append(" PESSOA_INCLUSAO=@PESSOA_INCLUSAO, ");
      query.Append(" PESSOA_TAG_CLIENTE=@PESSOA_TAG_CLIENTE, ");
      query.Append(" PESSOA_TAG_EMPRESA=@PESSOA_TAG_EMPRESA ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@PESSOA_ID", registro.PESSOA_ID);
                  cmd.Parameters.AddWithValue("@PESSOA_CODIGO", registro.PESSOA_CODIGO);
                  cmd.Parameters.AddWithValue("@PESSOA_NOME", registro.PESSOA_NOME);
                  cmd.Parameters.AddWithValue("@PESSOA_ENDERECO", registro.PESSOA_ENDERECO);
                  cmd.Parameters.AddWithValue("@PESSOA_ENDERECO_NR", registro.PESSOA_ENDERECO_NR);
                  cmd.Parameters.AddWithValue("@PESSOA_BAIRRO", registro.PESSOA_BAIRRO);
                  cmd.Parameters.AddWithValue("@PESSOA_CIDADE", registro.PESSOA_CIDADE);
                  cmd.Parameters.AddWithValue("@PESSOA_ESTADO", registro.PESSOA_ESTADO);
                  cmd.Parameters.AddWithValue("@PESSOA_CEP", registro.PESSOA_CEP);
                  cmd.Parameters.AddWithValue("@PESSOA_TELEFONE", registro.PESSOA_TELEFONE);
                  cmd.Parameters.AddWithValue("@PESSOA_EMAIL", registro.PESSOA_EMAIL);
                  cmd.Parameters.AddWithValue("@PESSOA_WEB", registro.PESSOA_WEB);
                  cmd.Parameters.AddWithValue("@PESSOA_NASCIMENTO", registro.PESSOA_NASCIMENTO);
                  cmd.Parameters.AddWithValue("@PESSOA_RENDA", registro.PESSOA_RENDA);
                  cmd.Parameters.AddWithValue("@PESSOA_INCLUSAO", registro.PESSOA_INCLUSAO);
                  cmd.Parameters.AddWithValue("@PESSOA_TAG_CLIENTE", registro.PESSOA_TAG_CLIENTE);
                  cmd.Parameters.AddWithValue("@PESSOA_TAG_EMPRESA", registro.PESSOA_TAG_EMPRESA);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append("FROM PESSOAS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append("FROM PESSOAS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append("FROM PESSOAS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_ID =   " + _PESSOA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CODIGO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CODIGO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CODIGO(string _PESSOA_CODIGO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_CODIGO =  '" + _PESSOA_CODIGO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_NOME e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_NOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_NOME(string _PESSOA_NOME)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_NOME =  '" + _PESSOA_NOME + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ENDERECO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ENDERECO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ENDERECO(string _PESSOA_ENDERECO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_ENDERECO =  '" + _PESSOA_ENDERECO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ENDERECO_NR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ENDERECO_NR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ENDERECO_NR(string _PESSOA_ENDERECO_NR)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_ENDERECO_NR =  '" + _PESSOA_ENDERECO_NR + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_BAIRRO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_BAIRRO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_BAIRRO(string _PESSOA_BAIRRO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_BAIRRO =  '" + _PESSOA_BAIRRO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CIDADE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CIDADE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CIDADE(string _PESSOA_CIDADE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_CIDADE =  '" + _PESSOA_CIDADE + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ESTADO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ESTADO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ESTADO(string _PESSOA_ESTADO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_ESTADO =  '" + _PESSOA_ESTADO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CEP e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CEP">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CEP(string _PESSOA_CEP)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_CEP =  '" + _PESSOA_CEP + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_TELEFONE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_TELEFONE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_TELEFONE(string _PESSOA_TELEFONE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_TELEFONE =  '" + _PESSOA_TELEFONE + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_EMAIL e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_EMAIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_EMAIL(string _PESSOA_EMAIL)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_EMAIL =  '" + _PESSOA_EMAIL + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_WEB e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_WEB">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_WEB(string _PESSOA_WEB)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_WEB =  '" + _PESSOA_WEB + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_NASCIMENTO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_NASCIMENTO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_NASCIMENTO(DateTime _PESSOA_NASCIMENTO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_NASCIMENTO = CONVERT(DATETIME, '" + _PESSOA_NASCIMENTO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_RENDA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_RENDA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_RENDA(float _PESSOA_RENDA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_RENDA =   " + _PESSOA_RENDA + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_INCLUSAO(DateTime _PESSOA_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_INCLUSAO = CONVERT(DATETIME, '" + _PESSOA_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_TAG_CLIENTE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_TAG_CLIENTE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_TAG_CLIENTE(byte _PESSOA_TAG_CLIENTE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_TAG_CLIENTE =   " + _PESSOA_TAG_CLIENTE + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_TAG_EMPRESA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_TAG_EMPRESA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_TAG_EMPRESA(byte _PESSOA_TAG_EMPRESA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CODIGO, ");
          query.Append(" PESSOA_NOME, ");
          query.Append(" PESSOA_ENDERECO, ");
          query.Append(" PESSOA_ENDERECO_NR, ");
          query.Append(" PESSOA_BAIRRO, ");
          query.Append(" PESSOA_CIDADE, ");
          query.Append(" PESSOA_ESTADO, ");
          query.Append(" PESSOA_CEP, ");
          query.Append(" PESSOA_TELEFONE, ");
          query.Append(" PESSOA_EMAIL, ");
          query.Append(" PESSOA_WEB, ");
          query.Append(" PESSOA_NASCIMENTO, ");
          query.Append(" PESSOA_RENDA, ");
          query.Append(" PESSOA_INCLUSAO, ");
          query.Append(" PESSOA_TAG_CLIENTE, ");
          query.Append(" PESSOA_TAG_EMPRESA, ");
          query.Append(" PESSOA_TAG_EMPRESA ");
          query.Append(" FROM PESSOAS ");
          query.Append(" WHERE (  PESSOA_TAG_EMPRESA =   " + _PESSOA_TAG_EMPRESA + "  ) ");

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
  }

#endregion

#region classe PESSOAS_CLIENTE
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS_CLIENTE
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.PESSOAS_CLIENTE"></param>
  public int InsertId(TAB.PESSOAS_CLIENTE registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS_CLIENTE (");
      query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
      query.Append(" PESSOA_CLIENTE_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_CLIENTE_LIMITECRED, ");
      query.Append(" @PESSOA_CLIENTE_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@PESSOA_CLIENTE_LIMITECRED", registro.PESSOA_CLIENTE_LIMITECRED);
                  cmd.Parameters.AddWithValue("@PESSOA_CLIENTE_ATIVO", registro.PESSOA_CLIENTE_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="PESSOAS_CLIENTE"></param>
  public void Insert(TAB.PESSOAS_CLIENTE registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS_CLIENTE (");
      query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
      query.Append(" PESSOA_CLIENTE_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_CLIENTE_LIMITECRED, ");
      query.Append(" @PESSOA_CLIENTE_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@PESSOA_CLIENTE_LIMITECRED", registro.PESSOA_CLIENTE_LIMITECRED);
              cmd.Parameters.AddWithValue("@PESSOA_CLIENTE_ATIVO", registro.PESSOA_CLIENTE_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.PESSOAS_CLIENTE"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS_CLIENTE ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS_CLIENTE ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="PESSOAS_CLIENTE"></param>
  public void Update(TAB.PESSOAS_CLIENTE registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE PESSOAS_CLIENTE SET ");
      query.Append(" PESSOA_CLIENTE_LIMITECRED=@PESSOA_CLIENTE_LIMITECRED, ");
      query.Append(" PESSOA_CLIENTE_ATIVO=@PESSOA_CLIENTE_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@PESSOA_ID", registro.PESSOA_ID);
                  cmd.Parameters.AddWithValue("@PESSOA_CLIENTE_LIMITECRED", registro.PESSOA_CLIENTE_LIMITECRED);
                  cmd.Parameters.AddWithValue("@PESSOA_CLIENTE_ATIVO", registro.PESSOA_CLIENTE_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append("FROM PESSOAS_CLIENTE ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append("FROM PESSOAS_CLIENTE ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append("FROM PESSOAS_CLIENTE ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append(" FROM PESSOAS_CLIENTE ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append(" FROM PESSOAS_CLIENTE ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append(" FROM PESSOAS_CLIENTE ");
          query.Append(" WHERE (  PESSOA_ID =   " + _PESSOA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CLIENTE_LIMITECRED e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CLIENTE_LIMITECRED">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CLIENTE_LIMITECRED(float _PESSOA_CLIENTE_LIMITECRED)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append(" FROM PESSOAS_CLIENTE ");
          query.Append(" WHERE (  PESSOA_CLIENTE_LIMITECRED =   " + _PESSOA_CLIENTE_LIMITECRED + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CLIENTE_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CLIENTE_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CLIENTE_ATIVO(byte _PESSOA_CLIENTE_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_CLIENTE_LIMITECRED, ");
          query.Append(" PESSOA_CLIENTE_ATIVO, ");
          query.Append(" PESSOA_CLIENTE_ATIVO ");
          query.Append(" FROM PESSOAS_CLIENTE ");
          query.Append(" WHERE (  PESSOA_CLIENTE_ATIVO =   " + _PESSOA_CLIENTE_ATIVO + "  ) ");

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
  }

#endregion

#region classe PESSOAS_FISICA
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS_FISICA
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.PESSOAS_FISICA"></param>
  public int InsertId(TAB.PESSOAS_FISICA registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS_FISICA (");
      query.Append(" PESSOA_FISICA_CELULAR, ");
      query.Append(" PESSOA_FISICA_CPF, ");
      query.Append(" PESSOA_FISICA_RG, ");
      query.Append(" PESSOA_FISICA_EMPRESA, ");
      query.Append(" PESSOA_FISICA_CARGO, ");
      query.Append(" PESSOA_FISICA_SETOR, ");
      query.Append(" PESSOA_FISICA_ADMISSAO, ");
      query.Append(" PESSOA_FISICA_DIAPG, ");
      query.Append(" PESSOA_FISICA_FOTO, ");
      query.Append(" PESSOA_FISICA_ENTRADA, ");
      query.Append(" PESSOA_FISICA_SAIDA, ");
      query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
      query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
      query.Append(" PESSOA_FISICA_OBS, ");
      query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
      query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_FISICA_CELULAR, ");
      query.Append(" @PESSOA_FISICA_CPF, ");
      query.Append(" @PESSOA_FISICA_RG, ");
      query.Append(" @PESSOA_FISICA_EMPRESA, ");
      query.Append(" @PESSOA_FISICA_CARGO, ");
      query.Append(" @PESSOA_FISICA_SETOR, ");
      query.Append(" @PESSOA_FISICA_ADMISSAO, ");
      query.Append(" @PESSOA_FISICA_DIAPG, ");
      query.Append(" @PESSOA_FISICA_FOTO, ");
      query.Append(" @PESSOA_FISICA_ENTRADA, ");
      query.Append(" @PESSOA_FISICA_SAIDA, ");
      query.Append(" @PESSOA_FISICA_ALMOCOINICIO, ");
      query.Append(" @PESSOA_FISICA_ALMOCOFIM, ");
      query.Append(" @PESSOA_FISICA_OBS, ");
      query.Append(" @PESSOA_FISICA_FILIACAO_PAI, ");
      query.Append(" @PESSOA_FISICA_FILIACAO_MAE, ");
      query.Append(" @PESSOA_FISICA_FUNCIONARIO, ");
      query.Append(" @PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
      query.Append(" @PESSOA_FISICA_FUNCIONARIO_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_CELULAR", registro.PESSOA_FISICA_CELULAR);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_CPF", registro.PESSOA_FISICA_CPF);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_RG", registro.PESSOA_FISICA_RG);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_EMPRESA", registro.PESSOA_FISICA_EMPRESA);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_CARGO", registro.PESSOA_FISICA_CARGO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_SETOR", registro.PESSOA_FISICA_SETOR);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ADMISSAO", registro.PESSOA_FISICA_ADMISSAO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_DIAPG", registro.PESSOA_FISICA_DIAPG);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FOTO", registro.PESSOA_FISICA_FOTO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ENTRADA", registro.PESSOA_FISICA_ENTRADA);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_SAIDA", registro.PESSOA_FISICA_SAIDA);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ALMOCOINICIO", registro.PESSOA_FISICA_ALMOCOINICIO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ALMOCOFIM", registro.PESSOA_FISICA_ALMOCOFIM);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_OBS", registro.PESSOA_FISICA_OBS);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FILIACAO_PAI", registro.PESSOA_FISICA_FILIACAO_PAI);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FILIACAO_MAE", registro.PESSOA_FISICA_FILIACAO_MAE);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO", registro.PESSOA_FISICA_FUNCIONARIO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO_DEMISSAO", registro.PESSOA_FISICA_FUNCIONARIO_DEMISSAO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO_ATIVO", registro.PESSOA_FISICA_FUNCIONARIO_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="PESSOAS_FISICA"></param>
  public void Insert(TAB.PESSOAS_FISICA registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS_FISICA (");
      query.Append(" PESSOA_FISICA_CELULAR, ");
      query.Append(" PESSOA_FISICA_CPF, ");
      query.Append(" PESSOA_FISICA_RG, ");
      query.Append(" PESSOA_FISICA_EMPRESA, ");
      query.Append(" PESSOA_FISICA_CARGO, ");
      query.Append(" PESSOA_FISICA_SETOR, ");
      query.Append(" PESSOA_FISICA_ADMISSAO, ");
      query.Append(" PESSOA_FISICA_DIAPG, ");
      query.Append(" PESSOA_FISICA_FOTO, ");
      query.Append(" PESSOA_FISICA_ENTRADA, ");
      query.Append(" PESSOA_FISICA_SAIDA, ");
      query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
      query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
      query.Append(" PESSOA_FISICA_OBS, ");
      query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
      query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_FISICA_CELULAR, ");
      query.Append(" @PESSOA_FISICA_CPF, ");
      query.Append(" @PESSOA_FISICA_RG, ");
      query.Append(" @PESSOA_FISICA_EMPRESA, ");
      query.Append(" @PESSOA_FISICA_CARGO, ");
      query.Append(" @PESSOA_FISICA_SETOR, ");
      query.Append(" @PESSOA_FISICA_ADMISSAO, ");
      query.Append(" @PESSOA_FISICA_DIAPG, ");
      query.Append(" @PESSOA_FISICA_FOTO, ");
      query.Append(" @PESSOA_FISICA_ENTRADA, ");
      query.Append(" @PESSOA_FISICA_SAIDA, ");
      query.Append(" @PESSOA_FISICA_ALMOCOINICIO, ");
      query.Append(" @PESSOA_FISICA_ALMOCOFIM, ");
      query.Append(" @PESSOA_FISICA_OBS, ");
      query.Append(" @PESSOA_FISICA_FILIACAO_PAI, ");
      query.Append(" @PESSOA_FISICA_FILIACAO_MAE, ");
      query.Append(" @PESSOA_FISICA_FUNCIONARIO, ");
      query.Append(" @PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
      query.Append(" @PESSOA_FISICA_FUNCIONARIO_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_CELULAR", registro.PESSOA_FISICA_CELULAR);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_CPF", registro.PESSOA_FISICA_CPF);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_RG", registro.PESSOA_FISICA_RG);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_EMPRESA", registro.PESSOA_FISICA_EMPRESA);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_CARGO", registro.PESSOA_FISICA_CARGO);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_SETOR", registro.PESSOA_FISICA_SETOR);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_ADMISSAO", registro.PESSOA_FISICA_ADMISSAO);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_DIAPG", registro.PESSOA_FISICA_DIAPG);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_FOTO", registro.PESSOA_FISICA_FOTO);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_ENTRADA", registro.PESSOA_FISICA_ENTRADA);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_SAIDA", registro.PESSOA_FISICA_SAIDA);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_ALMOCOINICIO", registro.PESSOA_FISICA_ALMOCOINICIO);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_ALMOCOFIM", registro.PESSOA_FISICA_ALMOCOFIM);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_OBS", registro.PESSOA_FISICA_OBS);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_FILIACAO_PAI", registro.PESSOA_FISICA_FILIACAO_PAI);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_FILIACAO_MAE", registro.PESSOA_FISICA_FILIACAO_MAE);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO", registro.PESSOA_FISICA_FUNCIONARIO);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO_DEMISSAO", registro.PESSOA_FISICA_FUNCIONARIO_DEMISSAO);
              cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO_ATIVO", registro.PESSOA_FISICA_FUNCIONARIO_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.PESSOAS_FISICA"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS_FISICA ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS_FISICA ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="PESSOAS_FISICA"></param>
  public void Update(TAB.PESSOAS_FISICA registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE PESSOAS_FISICA SET ");
      query.Append(" PESSOA_FISICA_CELULAR=@PESSOA_FISICA_CELULAR, ");
      query.Append(" PESSOA_FISICA_CPF=@PESSOA_FISICA_CPF, ");
      query.Append(" PESSOA_FISICA_RG=@PESSOA_FISICA_RG, ");
      query.Append(" PESSOA_FISICA_EMPRESA=@PESSOA_FISICA_EMPRESA, ");
      query.Append(" PESSOA_FISICA_CARGO=@PESSOA_FISICA_CARGO, ");
      query.Append(" PESSOA_FISICA_SETOR=@PESSOA_FISICA_SETOR, ");
      query.Append(" PESSOA_FISICA_ADMISSAO=@PESSOA_FISICA_ADMISSAO, ");
      query.Append(" PESSOA_FISICA_DIAPG=@PESSOA_FISICA_DIAPG, ");
      query.Append(" PESSOA_FISICA_FOTO=@PESSOA_FISICA_FOTO, ");
      query.Append(" PESSOA_FISICA_ENTRADA=@PESSOA_FISICA_ENTRADA, ");
      query.Append(" PESSOA_FISICA_SAIDA=@PESSOA_FISICA_SAIDA, ");
      query.Append(" PESSOA_FISICA_ALMOCOINICIO=@PESSOA_FISICA_ALMOCOINICIO, ");
      query.Append(" PESSOA_FISICA_ALMOCOFIM=@PESSOA_FISICA_ALMOCOFIM, ");
      query.Append(" PESSOA_FISICA_OBS=@PESSOA_FISICA_OBS, ");
      query.Append(" PESSOA_FISICA_FILIACAO_PAI=@PESSOA_FISICA_FILIACAO_PAI, ");
      query.Append(" PESSOA_FISICA_FILIACAO_MAE=@PESSOA_FISICA_FILIACAO_MAE, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO=@PESSOA_FISICA_FUNCIONARIO, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO=@PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
      query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO=@PESSOA_FISICA_FUNCIONARIO_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@PESSOA_ID", registro.PESSOA_ID);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_CELULAR", registro.PESSOA_FISICA_CELULAR);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_CPF", registro.PESSOA_FISICA_CPF);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_RG", registro.PESSOA_FISICA_RG);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_EMPRESA", registro.PESSOA_FISICA_EMPRESA);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_CARGO", registro.PESSOA_FISICA_CARGO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_SETOR", registro.PESSOA_FISICA_SETOR);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ADMISSAO", registro.PESSOA_FISICA_ADMISSAO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_DIAPG", registro.PESSOA_FISICA_DIAPG);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FOTO", registro.PESSOA_FISICA_FOTO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ENTRADA", registro.PESSOA_FISICA_ENTRADA);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_SAIDA", registro.PESSOA_FISICA_SAIDA);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ALMOCOINICIO", registro.PESSOA_FISICA_ALMOCOINICIO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_ALMOCOFIM", registro.PESSOA_FISICA_ALMOCOFIM);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_OBS", registro.PESSOA_FISICA_OBS);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FILIACAO_PAI", registro.PESSOA_FISICA_FILIACAO_PAI);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FILIACAO_MAE", registro.PESSOA_FISICA_FILIACAO_MAE);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO", registro.PESSOA_FISICA_FUNCIONARIO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO_DEMISSAO", registro.PESSOA_FISICA_FUNCIONARIO_DEMISSAO);
                  cmd.Parameters.AddWithValue("@PESSOA_FISICA_FUNCIONARIO_ATIVO", registro.PESSOA_FISICA_FUNCIONARIO_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append("FROM PESSOAS_FISICA ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append("FROM PESSOAS_FISICA ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append("FROM PESSOAS_FISICA ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_ID =   " + _PESSOA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_CELULAR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_CELULAR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_CELULAR(string _PESSOA_FISICA_CELULAR)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_CELULAR =  '" + _PESSOA_FISICA_CELULAR + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_CPF e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_CPF">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_CPF(string _PESSOA_FISICA_CPF)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_CPF =  '" + _PESSOA_FISICA_CPF + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_RG e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_RG">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_RG(string _PESSOA_FISICA_RG)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_RG =  '" + _PESSOA_FISICA_RG + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_EMPRESA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_EMPRESA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_EMPRESA(string _PESSOA_FISICA_EMPRESA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_EMPRESA =  '" + _PESSOA_FISICA_EMPRESA + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_CARGO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_CARGO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_CARGO(string _PESSOA_FISICA_CARGO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_CARGO =  '" + _PESSOA_FISICA_CARGO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_SETOR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_SETOR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_SETOR(int _PESSOA_FISICA_SETOR)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_SETOR =   " + _PESSOA_FISICA_SETOR + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ADMISSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ADMISSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ADMISSAO(DateTime _PESSOA_FISICA_ADMISSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_ADMISSAO = CONVERT(DATETIME, '" + _PESSOA_FISICA_ADMISSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_DIAPG e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_DIAPG">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_DIAPG(Int32 _PESSOA_FISICA_DIAPG)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_DIAPG =   " + _PESSOA_FISICA_DIAPG + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FOTO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FOTO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FOTO(Byte _PESSOA_FISICA_FOTO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_FOTO =  '" + _PESSOA_FISICA_FOTO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ENTRADA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ENTRADA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ENTRADA(DateTime _PESSOA_FISICA_ENTRADA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_ENTRADA = CONVERT(DATETIME, '" + _PESSOA_FISICA_ENTRADA + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_SAIDA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_SAIDA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_SAIDA(DateTime _PESSOA_FISICA_SAIDA)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_SAIDA = CONVERT(DATETIME, '" + _PESSOA_FISICA_SAIDA + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ALMOCOINICIO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ALMOCOINICIO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ALMOCOINICIO(DateTime _PESSOA_FISICA_ALMOCOINICIO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_ALMOCOINICIO = CONVERT(DATETIME, '" + _PESSOA_FISICA_ALMOCOINICIO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ALMOCOFIM e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ALMOCOFIM">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ALMOCOFIM(DateTime _PESSOA_FISICA_ALMOCOFIM)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_ALMOCOFIM = CONVERT(DATETIME, '" + _PESSOA_FISICA_ALMOCOFIM + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_OBS e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_OBS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_OBS(StringBuilder _PESSOA_FISICA_OBS)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_OBS =  '" + _PESSOA_FISICA_OBS + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FILIACAO_PAI e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FILIACAO_PAI">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FILIACAO_PAI(string _PESSOA_FISICA_FILIACAO_PAI)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_FILIACAO_PAI =  '" + _PESSOA_FISICA_FILIACAO_PAI + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FILIACAO_MAE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FILIACAO_MAE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FILIACAO_MAE(string _PESSOA_FISICA_FILIACAO_MAE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_FILIACAO_MAE =  '" + _PESSOA_FISICA_FILIACAO_MAE + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FUNCIONARIO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FUNCIONARIO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FUNCIONARIO(byte _PESSOA_FISICA_FUNCIONARIO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_FUNCIONARIO =   " + _PESSOA_FISICA_FUNCIONARIO + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FUNCIONARIO_DEMISSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FUNCIONARIO_DEMISSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FUNCIONARIO_DEMISSAO(DateTime _PESSOA_FISICA_FUNCIONARIO_DEMISSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_FUNCIONARIO_DEMISSAO = CONVERT(DATETIME, '" + _PESSOA_FISICA_FUNCIONARIO_DEMISSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FUNCIONARIO_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FUNCIONARIO_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FUNCIONARIO_ATIVO(byte _PESSOA_FISICA_FUNCIONARIO_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_FISICA_CELULAR, ");
          query.Append(" PESSOA_FISICA_CPF, ");
          query.Append(" PESSOA_FISICA_RG, ");
          query.Append(" PESSOA_FISICA_EMPRESA, ");
          query.Append(" PESSOA_FISICA_CARGO, ");
          query.Append(" PESSOA_FISICA_SETOR, ");
          query.Append(" PESSOA_FISICA_ADMISSAO, ");
          query.Append(" PESSOA_FISICA_DIAPG, ");
          query.Append(" PESSOA_FISICA_FOTO, ");
          query.Append(" PESSOA_FISICA_ENTRADA, ");
          query.Append(" PESSOA_FISICA_SAIDA, ");
          query.Append(" PESSOA_FISICA_ALMOCOINICIO, ");
          query.Append(" PESSOA_FISICA_ALMOCOFIM, ");
          query.Append(" PESSOA_FISICA_OBS, ");
          query.Append(" PESSOA_FISICA_FILIACAO_PAI, ");
          query.Append(" PESSOA_FISICA_FILIACAO_MAE, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_DEMISSAO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO, ");
          query.Append(" PESSOA_FISICA_FUNCIONARIO_ATIVO ");
          query.Append(" FROM PESSOAS_FISICA ");
          query.Append(" WHERE (  PESSOA_FISICA_FUNCIONARIO_ATIVO =   " + _PESSOA_FISICA_FUNCIONARIO_ATIVO + "  ) ");

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
  }

#endregion

#region classe PESSOAS_JURIDICA
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS_JURIDICA
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.PESSOAS_JURIDICA"></param>
  public int InsertId(TAB.PESSOAS_JURIDICA registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS_JURIDICA (");
      query.Append(" PESSOA_JURIDICA_RAZAO, ");
      query.Append(" PESSOA_JURIDICA_CNPJ, ");
      query.Append(" PESSOA_JURIDICA_IE, ");
      query.Append(" PESSOA_JURIDICA_FAX, ");
      query.Append(" PESSOA_JURIDICA_OBS, ");
      query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
      query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
      query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_JURIDICA_RAZAO, ");
      query.Append(" @PESSOA_JURIDICA_CNPJ, ");
      query.Append(" @PESSOA_JURIDICA_IE, ");
      query.Append(" @PESSOA_JURIDICA_FAX, ");
      query.Append(" @PESSOA_JURIDICA_OBS, ");
      query.Append(" @PESSOA_JURIDICA_ATIVIDADE, ");
      query.Append(" @PESSOA_JURIDICA_FORNECEDOR, ");
      query.Append(" @PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_RAZAO", registro.PESSOA_JURIDICA_RAZAO);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_CNPJ", registro.PESSOA_JURIDICA_CNPJ);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_IE", registro.PESSOA_JURIDICA_IE);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FAX", registro.PESSOA_JURIDICA_FAX);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_OBS", registro.PESSOA_JURIDICA_OBS);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_ATIVIDADE", registro.PESSOA_JURIDICA_ATIVIDADE);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FORNECEDOR", registro.PESSOA_JURIDICA_FORNECEDOR);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FORNCEDOR_ATIVO", registro.PESSOA_JURIDICA_FORNCEDOR_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="PESSOAS_JURIDICA"></param>
  public void Insert(TAB.PESSOAS_JURIDICA registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO PESSOAS_JURIDICA (");
      query.Append(" PESSOA_JURIDICA_RAZAO, ");
      query.Append(" PESSOA_JURIDICA_CNPJ, ");
      query.Append(" PESSOA_JURIDICA_IE, ");
      query.Append(" PESSOA_JURIDICA_FAX, ");
      query.Append(" PESSOA_JURIDICA_OBS, ");
      query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
      query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
      query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @PESSOA_JURIDICA_RAZAO, ");
      query.Append(" @PESSOA_JURIDICA_CNPJ, ");
      query.Append(" @PESSOA_JURIDICA_IE, ");
      query.Append(" @PESSOA_JURIDICA_FAX, ");
      query.Append(" @PESSOA_JURIDICA_OBS, ");
      query.Append(" @PESSOA_JURIDICA_ATIVIDADE, ");
      query.Append(" @PESSOA_JURIDICA_FORNECEDOR, ");
      query.Append(" @PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_RAZAO", registro.PESSOA_JURIDICA_RAZAO);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_CNPJ", registro.PESSOA_JURIDICA_CNPJ);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_IE", registro.PESSOA_JURIDICA_IE);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FAX", registro.PESSOA_JURIDICA_FAX);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_OBS", registro.PESSOA_JURIDICA_OBS);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_ATIVIDADE", registro.PESSOA_JURIDICA_ATIVIDADE);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FORNECEDOR", registro.PESSOA_JURIDICA_FORNECEDOR);
              cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FORNCEDOR_ATIVO", registro.PESSOA_JURIDICA_FORNCEDOR_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.PESSOAS_JURIDICA"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS_JURIDICA ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM PESSOAS_JURIDICA ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="PESSOAS_JURIDICA"></param>
  public void Update(TAB.PESSOAS_JURIDICA registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE PESSOAS_JURIDICA SET ");
      query.Append(" PESSOA_JURIDICA_RAZAO=@PESSOA_JURIDICA_RAZAO, ");
      query.Append(" PESSOA_JURIDICA_CNPJ=@PESSOA_JURIDICA_CNPJ, ");
      query.Append(" PESSOA_JURIDICA_IE=@PESSOA_JURIDICA_IE, ");
      query.Append(" PESSOA_JURIDICA_FAX=@PESSOA_JURIDICA_FAX, ");
      query.Append(" PESSOA_JURIDICA_OBS=@PESSOA_JURIDICA_OBS, ");
      query.Append(" PESSOA_JURIDICA_ATIVIDADE=@PESSOA_JURIDICA_ATIVIDADE, ");
      query.Append(" PESSOA_JURIDICA_FORNECEDOR=@PESSOA_JURIDICA_FORNECEDOR, ");
      query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO=@PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@PESSOA_ID", registro.PESSOA_ID);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_RAZAO", registro.PESSOA_JURIDICA_RAZAO);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_CNPJ", registro.PESSOA_JURIDICA_CNPJ);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_IE", registro.PESSOA_JURIDICA_IE);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FAX", registro.PESSOA_JURIDICA_FAX);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_OBS", registro.PESSOA_JURIDICA_OBS);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_ATIVIDADE", registro.PESSOA_JURIDICA_ATIVIDADE);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FORNECEDOR", registro.PESSOA_JURIDICA_FORNECEDOR);
                  cmd.Parameters.AddWithValue("@PESSOA_JURIDICA_FORNCEDOR_ATIVO", registro.PESSOA_JURIDICA_FORNCEDOR_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append("FROM PESSOAS_JURIDICA ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append("FROM PESSOAS_JURIDICA ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append("FROM PESSOAS_JURIDICA ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_ID =   " + _PESSOA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_RAZAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_RAZAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_RAZAO(string _PESSOA_JURIDICA_RAZAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_RAZAO =  '" + _PESSOA_JURIDICA_RAZAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_CNPJ e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_CNPJ">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_CNPJ(string _PESSOA_JURIDICA_CNPJ)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_CNPJ =  '" + _PESSOA_JURIDICA_CNPJ + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_IE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_IE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_IE(string _PESSOA_JURIDICA_IE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_IE =  '" + _PESSOA_JURIDICA_IE + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_FAX e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_FAX">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_FAX(string _PESSOA_JURIDICA_FAX)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_FAX =  '" + _PESSOA_JURIDICA_FAX + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_OBS e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_OBS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_OBS(StringBuilder _PESSOA_JURIDICA_OBS)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_OBS =  '" + _PESSOA_JURIDICA_OBS + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_ATIVIDADE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_ATIVIDADE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_ATIVIDADE(string _PESSOA_JURIDICA_ATIVIDADE)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_ATIVIDADE =  '" + _PESSOA_JURIDICA_ATIVIDADE + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_FORNECEDOR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_FORNECEDOR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_FORNECEDOR(byte _PESSOA_JURIDICA_FORNECEDOR)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_FORNECEDOR =   " + _PESSOA_JURIDICA_FORNECEDOR + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_FORNCEDOR_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_FORNCEDOR_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_FORNCEDOR_ATIVO(byte _PESSOA_JURIDICA_FORNCEDOR_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" PESSOA_ID, ");
          query.Append(" PESSOA_JURIDICA_RAZAO, ");
          query.Append(" PESSOA_JURIDICA_CNPJ, ");
          query.Append(" PESSOA_JURIDICA_IE, ");
          query.Append(" PESSOA_JURIDICA_FAX, ");
          query.Append(" PESSOA_JURIDICA_OBS, ");
          query.Append(" PESSOA_JURIDICA_ATIVIDADE, ");
          query.Append(" PESSOA_JURIDICA_FORNECEDOR, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO, ");
          query.Append(" PESSOA_JURIDICA_FORNCEDOR_ATIVO ");
          query.Append(" FROM PESSOAS_JURIDICA ");
          query.Append(" WHERE (  PESSOA_JURIDICA_FORNCEDOR_ATIVO =   " + _PESSOA_JURIDICA_FORNCEDOR_ATIVO + "  ) ");

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
  }

#endregion

#region classe SISTEMAS
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class SISTEMAS
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.SISTEMAS"></param>
  public int InsertId(TAB.SISTEMAS registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO SISTEMAS (");
      query.Append(" SISTEMA_LINK, ");
      query.Append(" SISTEMA_INCLUSAO, ");
      query.Append(" SISTEMA_DESCRICAO, ");
      query.Append(" SISTEMA_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @SISTEMA_LINK, ");
      query.Append(" @SISTEMA_INCLUSAO, ");
      query.Append(" @SISTEMA_DESCRICAO, ");
      query.Append(" @SISTEMA_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@SISTEMA_LINK", registro.SISTEMA_LINK);
                  cmd.Parameters.AddWithValue("@SISTEMA_INCLUSAO", registro.SISTEMA_INCLUSAO);
                  cmd.Parameters.AddWithValue("@SISTEMA_DESCRICAO", registro.SISTEMA_DESCRICAO);
                  cmd.Parameters.AddWithValue("@SISTEMA_ATIVO", registro.SISTEMA_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="SISTEMAS"></param>
  public void Insert(TAB.SISTEMAS registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO SISTEMAS (");
      query.Append(" SISTEMA_LINK, ");
      query.Append(" SISTEMA_INCLUSAO, ");
      query.Append(" SISTEMA_DESCRICAO, ");
      query.Append(" SISTEMA_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @SISTEMA_LINK, ");
      query.Append(" @SISTEMA_INCLUSAO, ");
      query.Append(" @SISTEMA_DESCRICAO, ");
      query.Append(" @SISTEMA_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@SISTEMA_LINK", registro.SISTEMA_LINK);
              cmd.Parameters.AddWithValue("@SISTEMA_INCLUSAO", registro.SISTEMA_INCLUSAO);
              cmd.Parameters.AddWithValue("@SISTEMA_DESCRICAO", registro.SISTEMA_DESCRICAO);
              cmd.Parameters.AddWithValue("@SISTEMA_ATIVO", registro.SISTEMA_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.SISTEMAS"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM SISTEMAS ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM SISTEMAS ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="SISTEMAS"></param>
  public void Update(TAB.SISTEMAS registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE SISTEMAS SET ");
      query.Append(" SISTEMA_LINK=@SISTEMA_LINK, ");
      query.Append(" SISTEMA_INCLUSAO=@SISTEMA_INCLUSAO, ");
      query.Append(" SISTEMA_DESCRICAO=@SISTEMA_DESCRICAO, ");
      query.Append(" SISTEMA_ATIVO=@SISTEMA_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@SISTEMA_ID", registro.SISTEMA_ID);
                  cmd.Parameters.AddWithValue("@SISTEMA_LINK", registro.SISTEMA_LINK);
                  cmd.Parameters.AddWithValue("@SISTEMA_INCLUSAO", registro.SISTEMA_INCLUSAO);
                  cmd.Parameters.AddWithValue("@SISTEMA_DESCRICAO", registro.SISTEMA_DESCRICAO);
                  cmd.Parameters.AddWithValue("@SISTEMA_ATIVO", registro.SISTEMA_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append("FROM SISTEMAS ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append("FROM SISTEMAS ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append("FROM SISTEMAS ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_ID(int _SISTEMA_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE (  SISTEMA_ID =   " + _SISTEMA_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_LINK(string _SISTEMA_LINK)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE (  SISTEMA_LINK =  '" + _SISTEMA_LINK + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_INCLUSAO(DateTime _SISTEMA_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE (  SISTEMA_INCLUSAO = CONVERT(DATETIME, '" + _SISTEMA_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_DESCRICAO(string _SISTEMA_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE (  SISTEMA_DESCRICAO =  '" + _SISTEMA_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_ATIVO(byte _SISTEMA_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SISTEMA_ID, ");
          query.Append(" SISTEMA_LINK, ");
          query.Append(" SISTEMA_INCLUSAO, ");
          query.Append(" SISTEMA_DESCRICAO, ");
          query.Append(" SISTEMA_ATIVO, ");
          query.Append(" SISTEMA_ATIVO ");
          query.Append(" FROM SISTEMAS ");
          query.Append(" WHERE (  SISTEMA_ATIVO =   " + _SISTEMA_ATIVO + "  ) ");

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
  }

#endregion

#region classe SOLICITACOES
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class SOLICITACOES
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.SOLICITACOES"></param>
  public int InsertId(TAB.SOLICITACOES registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO SOLICITACOES (");
      query.Append(" SOLICITACAO_REMETENTE_NOME, ");
      query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
      query.Append(" SOLICITACAO_ASSUNTO, ");
      query.Append(" SOLICITACAO_DESCRICAO, ");
      query.Append(" SOLICITACAO_INCLUSAO, ");
      query.Append(" SOLICITACAO_SITUACAO, ");
      query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
      query.Append(" SOLICITACAO_CONCLUSAO, ");
      query.Append(" SOLICITACAO_OBSERVACAO ");
      query.Append(") VALUES (");
      query.Append(" @SOLICITACAO_REMETENTE_NOME, ");
      query.Append(" @SOLICITACAO_REMETENTE_EMAIL, ");
      query.Append(" @SOLICITACAO_ASSUNTO, ");
      query.Append(" @SOLICITACAO_DESCRICAO, ");
      query.Append(" @SOLICITACAO_INCLUSAO, ");
      query.Append(" @SOLICITACAO_SITUACAO, ");
      query.Append(" @SOLICITACAO_DESTINATARIO_EMAIL, ");
      query.Append(" @SOLICITACAO_CONCLUSAO, ");
      query.Append(" @SOLICITACAO_OBSERVACAO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@SOLICITACAO_REMETENTE_NOME", registro.SOLICITACAO_REMETENTE_NOME);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_REMETENTE_EMAIL", registro.SOLICITACAO_REMETENTE_EMAIL);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_ASSUNTO", registro.SOLICITACAO_ASSUNTO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_DESCRICAO", registro.SOLICITACAO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_INCLUSAO", registro.SOLICITACAO_INCLUSAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_SITUACAO", registro.SOLICITACAO_SITUACAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_DESTINATARIO_EMAIL", registro.SOLICITACAO_DESTINATARIO_EMAIL);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_CONCLUSAO", registro.SOLICITACAO_CONCLUSAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_OBSERVACAO", registro.SOLICITACAO_OBSERVACAO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="SOLICITACOES"></param>
  public void Insert(TAB.SOLICITACOES registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO SOLICITACOES (");
      query.Append(" SOLICITACAO_REMETENTE_NOME, ");
      query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
      query.Append(" SOLICITACAO_ASSUNTO, ");
      query.Append(" SOLICITACAO_DESCRICAO, ");
      query.Append(" SOLICITACAO_INCLUSAO, ");
      query.Append(" SOLICITACAO_SITUACAO, ");
      query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
      query.Append(" SOLICITACAO_CONCLUSAO, ");
      query.Append(" SOLICITACAO_OBSERVACAO ");
      query.Append(") VALUES (");
      query.Append(" @SOLICITACAO_REMETENTE_NOME, ");
      query.Append(" @SOLICITACAO_REMETENTE_EMAIL, ");
      query.Append(" @SOLICITACAO_ASSUNTO, ");
      query.Append(" @SOLICITACAO_DESCRICAO, ");
      query.Append(" @SOLICITACAO_INCLUSAO, ");
      query.Append(" @SOLICITACAO_SITUACAO, ");
      query.Append(" @SOLICITACAO_DESTINATARIO_EMAIL, ");
      query.Append(" @SOLICITACAO_CONCLUSAO, ");
      query.Append(" @SOLICITACAO_OBSERVACAO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@SOLICITACAO_REMETENTE_NOME", registro.SOLICITACAO_REMETENTE_NOME);
              cmd.Parameters.AddWithValue("@SOLICITACAO_REMETENTE_EMAIL", registro.SOLICITACAO_REMETENTE_EMAIL);
              cmd.Parameters.AddWithValue("@SOLICITACAO_ASSUNTO", registro.SOLICITACAO_ASSUNTO);
              cmd.Parameters.AddWithValue("@SOLICITACAO_DESCRICAO", registro.SOLICITACAO_DESCRICAO);
              cmd.Parameters.AddWithValue("@SOLICITACAO_INCLUSAO", registro.SOLICITACAO_INCLUSAO);
              cmd.Parameters.AddWithValue("@SOLICITACAO_SITUACAO", registro.SOLICITACAO_SITUACAO);
              cmd.Parameters.AddWithValue("@SOLICITACAO_DESTINATARIO_EMAIL", registro.SOLICITACAO_DESTINATARIO_EMAIL);
              cmd.Parameters.AddWithValue("@SOLICITACAO_CONCLUSAO", registro.SOLICITACAO_CONCLUSAO);
              cmd.Parameters.AddWithValue("@SOLICITACAO_OBSERVACAO", registro.SOLICITACAO_OBSERVACAO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.SOLICITACOES"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM SOLICITACOES ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM SOLICITACOES ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="SOLICITACOES"></param>
  public void Update(TAB.SOLICITACOES registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE SOLICITACOES SET ");
      query.Append(" SOLICITACAO_REMETENTE_NOME=@SOLICITACAO_REMETENTE_NOME, ");
      query.Append(" SOLICITACAO_REMETENTE_EMAIL=@SOLICITACAO_REMETENTE_EMAIL, ");
      query.Append(" SOLICITACAO_ASSUNTO=@SOLICITACAO_ASSUNTO, ");
      query.Append(" SOLICITACAO_DESCRICAO=@SOLICITACAO_DESCRICAO, ");
      query.Append(" SOLICITACAO_INCLUSAO=@SOLICITACAO_INCLUSAO, ");
      query.Append(" SOLICITACAO_SITUACAO=@SOLICITACAO_SITUACAO, ");
      query.Append(" SOLICITACAO_DESTINATARIO_EMAIL=@SOLICITACAO_DESTINATARIO_EMAIL, ");
      query.Append(" SOLICITACAO_CONCLUSAO=@SOLICITACAO_CONCLUSAO, ");
      query.Append(" SOLICITACAO_OBSERVACAO=@SOLICITACAO_OBSERVACAO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@SOLICITACAO_ID", registro.SOLICITACAO_ID);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_REMETENTE_NOME", registro.SOLICITACAO_REMETENTE_NOME);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_REMETENTE_EMAIL", registro.SOLICITACAO_REMETENTE_EMAIL);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_ASSUNTO", registro.SOLICITACAO_ASSUNTO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_DESCRICAO", registro.SOLICITACAO_DESCRICAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_INCLUSAO", registro.SOLICITACAO_INCLUSAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_SITUACAO", registro.SOLICITACAO_SITUACAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_DESTINATARIO_EMAIL", registro.SOLICITACAO_DESTINATARIO_EMAIL);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_CONCLUSAO", registro.SOLICITACAO_CONCLUSAO);
                  cmd.Parameters.AddWithValue("@SOLICITACAO_OBSERVACAO", registro.SOLICITACAO_OBSERVACAO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append("FROM SOLICITACOES ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append("FROM SOLICITACOES ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append("FROM SOLICITACOES ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby, String _direction)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY " + _orderby + " " + _direction);

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_ID(int _SOLICITACAO_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_ID =   " + _SOLICITACAO_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_REMETENTE_NOME e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_REMETENTE_NOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_REMETENTE_NOME(string _SOLICITACAO_REMETENTE_NOME)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_REMETENTE_NOME =  '" + _SOLICITACAO_REMETENTE_NOME + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_REMETENTE_EMAIL e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_REMETENTE_EMAIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_REMETENTE_EMAIL(string _SOLICITACAO_REMETENTE_EMAIL)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_REMETENTE_EMAIL =  '" + _SOLICITACAO_REMETENTE_EMAIL + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_ASSUNTO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_ASSUNTO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_ASSUNTO(string _SOLICITACAO_ASSUNTO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_ASSUNTO =  '" + _SOLICITACAO_ASSUNTO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_DESCRICAO(string _SOLICITACAO_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_DESCRICAO =  '" + _SOLICITACAO_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_INCLUSAO(DateTime _SOLICITACAO_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_INCLUSAO = CONVERT(DATETIME, '" + _SOLICITACAO_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_SITUACAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_SITUACAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_SITUACAO(byte _SOLICITACAO_SITUACAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_SITUACAO =   " + _SOLICITACAO_SITUACAO + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_DESTINATARIO_EMAIL e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_DESTINATARIO_EMAIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_DESTINATARIO_EMAIL(string _SOLICITACAO_DESTINATARIO_EMAIL)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_DESTINATARIO_EMAIL =  '" + _SOLICITACAO_DESTINATARIO_EMAIL + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_CONCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_CONCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_CONCLUSAO(DateTime _SOLICITACAO_CONCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_CONCLUSAO = CONVERT(DATETIME, '" + _SOLICITACAO_CONCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_OBSERVACAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_OBSERVACAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_OBSERVACAO(string _SOLICITACAO_OBSERVACAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SOLICITACAO_ID, ");
          query.Append(" SOLICITACAO_REMETENTE_NOME, ");
          query.Append(" SOLICITACAO_REMETENTE_EMAIL, ");
          query.Append(" SOLICITACAO_ASSUNTO, ");
          query.Append(" SOLICITACAO_DESCRICAO, ");
          query.Append(" SOLICITACAO_INCLUSAO, ");
          query.Append(" SOLICITACAO_SITUACAO, ");
          query.Append(" SOLICITACAO_DESTINATARIO_EMAIL, ");
          query.Append(" SOLICITACAO_CONCLUSAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO, ");
          query.Append(" SOLICITACAO_OBSERVACAO ");
          query.Append(" FROM SOLICITACOES ");
          query.Append(" WHERE (  SOLICITACAO_OBSERVACAO =  '" + _SOLICITACAO_OBSERVACAO + "'  ) ");

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

     

  }

#endregion

#region classe SUPORTES
  /// <summary>
  /// Classe DAL: Data Access Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class SUPORTES
  {
      //MÉTODOS


  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="TAB.SUPORTES"></param>
  public int InsertId(TAB.SUPORTES registro)
  {
      int resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO SUPORTES (");
      query.Append(" SUPORTE_LINK, ");
      query.Append(" SUPORTE_INCLUSAO, ");
      query.Append(" SUPORTE_DESCRICAO, ");
      query.Append(" SUPORTE_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @SUPORTE_LINK, ");
      query.Append(" @SUPORTE_INCLUSAO, ");
      query.Append(" @SUPORTE_DESCRICAO, ");
      query.Append(" @SUPORTE_ATIVO ");
      query.Append(")SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  cmd.Parameters.AddWithValue("@SUPORTE_LINK", registro.SUPORTE_LINK);
                  cmd.Parameters.AddWithValue("@SUPORTE_INCLUSAO", registro.SUPORTE_INCLUSAO);
                  cmd.Parameters.AddWithValue("@SUPORTE_DESCRICAO", registro.SUPORTE_DESCRICAO);
                  cmd.Parameters.AddWithValue("@SUPORTE_ATIVO", registro.SUPORTE_ATIVO);
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível incluir o registro.");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// INSERT
  /// </summary>
  /// <param name="SUPORTES"></param>
  public void Insert(TAB.SUPORTES registro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append("INSERT INTO SUPORTES (");
      query.Append(" SUPORTE_LINK, ");
      query.Append(" SUPORTE_INCLUSAO, ");
      query.Append(" SUPORTE_DESCRICAO, ");
      query.Append(" SUPORTE_ATIVO ");
      query.Append(") VALUES (");
      query.Append(" @SUPORTE_LINK, ");
      query.Append(" @SUPORTE_INCLUSAO, ");
      query.Append(" @SUPORTE_DESCRICAO, ");
      query.Append(" @SUPORTE_ATIVO ");
      query.Append(") ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              cmd.CommandType = CommandType.Text;
              cmd.Parameters.AddWithValue("@SUPORTE_LINK", registro.SUPORTE_LINK);
              cmd.Parameters.AddWithValue("@SUPORTE_INCLUSAO", registro.SUPORTE_INCLUSAO);
              cmd.Parameters.AddWithValue("@SUPORTE_DESCRICAO", registro.SUPORTE_DESCRICAO);
              cmd.Parameters.AddWithValue("@SUPORTE_ATIVO", registro.SUPORTE_ATIVO);
              conn.Open();
              int resultado = cmd.ExecuteNonQuery();
              if (resultado != 1)
              {
                  throw new Exception("Não foi possível incluir o registro.");
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco e retorna o número de linhas afetadas
  /// </summary>
  /// <param name="TAB.SUPORTES"></param>
  public Int32 DeleteId(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM SUPORTES ");
      query.Append(" WHERE (" + _filtro + ")");
      query.Append(" ;SELECT SCOPE_IDENTITY() ");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = Convert.ToInt32(cmd.ExecuteScalar());
                  if (resultado == 0)
                  {
                      throw new Exception("Não foi possível apagar o registro..");
                  }
                  else
                  {
                      return resultado;
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// Deleta os registros do banco
  /// </summary>
  /// <param name="string filtro"></param>
  public void Delete(string _filtro)
  {
      var resultado = 0;
      var connect = dados.stringConnection;
      var query = new StringBuilder();

      query.Append(" DELETE FROM SUPORTES ");
      query.Append(" WHERE (" + _filtro + ")");

      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {
              try
              {
                  cmd.CommandType = CommandType.Text;
                  conn.Open();
                  resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível apagar o registro.");
                  }
              }
              catch (Exception Err)
              {
                  throw new Exception("Ocorreu um erro. Entre em contato com o administrador do sistema. "+Err.ToString());
              }
          }
      }
  }

  /// <summary>
  /// UPDATE 
  /// </summary>
  /// <param name="SUPORTES"></param>
  public void Update(TAB.SUPORTES registro, string _filtro)
  {
      var connect = dados.stringConnection;
      var query = new StringBuilder();
      query.Append("UPDATE SUPORTES SET ");
      query.Append(" SUPORTE_LINK=@SUPORTE_LINK, ");
      query.Append(" SUPORTE_INCLUSAO=@SUPORTE_INCLUSAO, ");
      query.Append(" SUPORTE_DESCRICAO=@SUPORTE_DESCRICAO, ");
      query.Append(" SUPORTE_ATIVO=@SUPORTE_ATIVO ");
      query.Append(" WHERE (" + _filtro + ")");
      using (var conn = new SqlConnection(connect))
      {
          using (var cmd = new SqlCommand(query.ToString(), conn))
          {

                  cmd.Parameters.AddWithValue("@SUPORTE_ID", registro.SUPORTE_ID);
                  cmd.Parameters.AddWithValue("@SUPORTE_LINK", registro.SUPORTE_LINK);
                  cmd.Parameters.AddWithValue("@SUPORTE_INCLUSAO", registro.SUPORTE_INCLUSAO);
                  cmd.Parameters.AddWithValue("@SUPORTE_DESCRICAO", registro.SUPORTE_DESCRICAO);
                  cmd.Parameters.AddWithValue("@SUPORTE_ATIVO", registro.SUPORTE_ATIVO);

                  conn.Open();
                  int resultado = cmd.ExecuteNonQuery();
                  if (resultado != 1)
                  {
                      throw new Exception("Não foi possível ALTERAR o registro.");
                  }
              }
          }
      }
      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          var connect = dados.stringConnection;
          var ds = new DataSet();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(ds);
                  return ds;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          var connect = dados.stringConnection;
          var dt = new DataTable();
          using (var conn = new SqlConnection(connect))
          {
              using (var cmd = new SqlCommand(_query.ToString(), conn))
              {
                  cmd.CommandType = CommandType.Text;
                  var da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
                  return dt;
              }
          }
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append("FROM SUPORTES ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      public DataSet FindAll(String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append("FROM SUPORTES ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet ordenado.
      /// </summary>
      /// <returns>DataSet</returns>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      public DataSet FindAll(String _orderby, String _asc)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append("SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append("FROM SUPORTES ORDER BY "+_orderby+"  "+_asc+"  ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE ( " + _filtro + " ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros com filtro e retorna um DataSet ordenado.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(String _filtro, String _orderby)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE ( " + _filtro + " ) ORDER BY "+_orderby+" ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_ID(int _SUPORTE_ID)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE (  SUPORTE_ID =   " + _SUPORTE_ID + "  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_LINK(string _SUPORTE_LINK)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE (  SUPORTE_LINK =  '" + _SUPORTE_LINK + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_INCLUSAO(DateTime _SUPORTE_INCLUSAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE (  SUPORTE_INCLUSAO = CONVERT(DATETIME, '" + _SUPORTE_INCLUSAO + "', 103)  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_DESCRICAO(string _SUPORTE_DESCRICAO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE (  SUPORTE_DESCRICAO =  '" + _SUPORTE_DESCRICAO + "'  ) ");

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
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_ATIVO e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_ATIVO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_ATIVO(byte _SUPORTE_ATIVO)
      {
          var connect = dados.stringConnection;
          var query = new StringBuilder();
          var ds = new DataSet();

          query.Append(" SELECT ");
          query.Append(" SUPORTE_ID, ");
          query.Append(" SUPORTE_LINK, ");
          query.Append(" SUPORTE_INCLUSAO, ");
          query.Append(" SUPORTE_DESCRICAO, ");
          query.Append(" SUPORTE_ATIVO, ");
          query.Append(" SUPORTE_ATIVO ");
          query.Append(" FROM SUPORTES ");
          query.Append(" WHERE (  SUPORTE_ATIVO =   " + _SUPORTE_ATIVO + "  ) ");

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
  }

#endregion

}
