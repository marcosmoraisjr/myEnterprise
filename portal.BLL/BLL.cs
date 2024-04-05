using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using portal.TAB;
using portal.DAL;

namespace portal.BLL
{

#region classe AUDITORIAS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class AUDITORIAS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.AUDITORIAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.AUDITORIAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.AUDITORIAS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindByWhere(_filtro);
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
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_ID(int _AUDITORIA_ID)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_ID(_AUDITORIA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_DATA e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_DATA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_DATA(DateTime _AUDITORIA_DATA)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_DATA(_AUDITORIA_DATA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_HORA e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_HORA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_HORA(DateTime _AUDITORIA_HORA)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_HORA(_AUDITORIA_HORA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_USUARIO e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_USUARIO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_USUARIO(string _AUDITORIA_USUARIO)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_USUARIO(_AUDITORIA_USUARIO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_PERFIL e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_PERFIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_PERFIL(string _AUDITORIA_PERFIL)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_PERFIL(_AUDITORIA_PERFIL);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_MODULO e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_MODULO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_MODULO(string _AUDITORIA_MODULO)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_MODULO(_AUDITORIA_MODULO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_ACAO e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_ACAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_ACAO(StringBuilder _AUDITORIA_ACAO)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_ACAO(_AUDITORIA_ACAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_ANTES e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_ANTES">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_ANTES(StringBuilder _AUDITORIA_ANTES)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_ANTES(_AUDITORIA_ANTES);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_DEPOIS e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_DEPOIS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_DEPOIS(StringBuilder _AUDITORIA_DEPOIS)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_DEPOIS(_AUDITORIA_DEPOIS);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por AUDITORIA_TERMINAL e retorna um DataSet.
      /// </summary>
      /// <param name="_AUDITORIA_TERMINAL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_AUDITORIA_TERMINAL(string _AUDITORIA_TERMINAL)
      {
          DAL.AUDITORIAS cmd = new DAL.AUDITORIAS();
          return cmd.FindBy_AUDITORIA_TERMINAL(_AUDITORIA_TERMINAL);
      }
  }

#endregion

#region classe DOWNLOADS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class DOWNLOADS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.DOWNLOADS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.DOWNLOADS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.DOWNLOADS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindByWhere(_filtro);
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
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_ID(int _DOWNLOAD_ID)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindBy_DOWNLOAD_ID(_DOWNLOAD_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_LINK(string _DOWNLOAD_LINK)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindBy_DOWNLOAD_LINK(_DOWNLOAD_LINK);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_INCLUSAO(DateTime _DOWNLOAD_INCLUSAO)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindBy_DOWNLOAD_INCLUSAO(_DOWNLOAD_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por DOWNLOAD_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_DOWNLOAD_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_DOWNLOAD_DESCRICAO(string _DOWNLOAD_DESCRICAO)
      {
          DAL.DOWNLOADS cmd = new DAL.DOWNLOADS();
          return cmd.FindBy_DOWNLOAD_DESCRICAO(_DOWNLOAD_DESCRICAO);
      }
  }

#endregion

#region classe EMPRESAS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class EMPRESAS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.EMPRESAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.EMPRESAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.EMPRESAS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindByWhere(_filtro);
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
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ID(int _EMPRESA_ID)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_ID(_EMPRESA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_CODIGO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_CODIGO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_CODIGO(string _EMPRESA_CODIGO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_CODIGO(_EMPRESA_CODIGO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_NOME_FANTASIA e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_NOME_FANTASIA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_NOME_FANTASIA(string _EMPRESA_NOME_FANTASIA)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_NOME_FANTASIA(_EMPRESA_NOME_FANTASIA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_NOME_RAZAO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_NOME_RAZAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_NOME_RAZAO(string _EMPRESA_NOME_RAZAO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_NOME_RAZAO(_EMPRESA_NOME_RAZAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_CONTATO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_CONTATO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_CONTATO(string _EMPRESA_CONTATO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_CONTATO(_EMPRESA_CONTATO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ENDERECO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ENDERECO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ENDERECO(string _EMPRESA_ENDERECO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_ENDERECO(_EMPRESA_ENDERECO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_ENDERECO_NR e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_ENDERECO_NR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_ENDERECO_NR(string _EMPRESA_ENDERECO_NR)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_ENDERECO_NR(_EMPRESA_ENDERECO_NR);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_BAIRRO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_BAIRRO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_BAIRRO(string _EMPRESA_BAIRRO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_BAIRRO(_EMPRESA_BAIRRO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_UF e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_UF">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_UF(string _EMPRESA_UF)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_UF(_EMPRESA_UF);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_CNPJ e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_CNPJ">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_CNPJ(string _EMPRESA_CNPJ)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_CNPJ(_EMPRESA_CNPJ);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_IE e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_IE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_IE(string _EMPRESA_IE)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_IE(_EMPRESA_IE);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_WEB e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_WEB">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_WEB(string _EMPRESA_WEB)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_WEB(_EMPRESA_WEB);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_INCLUSAO(DateTime _EMPRESA_INCLUSAO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_INCLUSAO(_EMPRESA_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_EXPIRA e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_EXPIRA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_EXPIRA(DateTime _EMPRESA_EXPIRA)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_EXPIRA(_EMPRESA_EXPIRA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por EMPRESA_VESAO e retorna um DataSet.
      /// </summary>
      /// <param name="_EMPRESA_VESAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_EMPRESA_VESAO(string _EMPRESA_VESAO)
      {
          DAL.EMPRESAS cmd = new DAL.EMPRESAS();
          return cmd.FindBy_EMPRESA_VESAO(_EMPRESA_VESAO);
      }
  }

#endregion

#region classe ENDERECOS_BAIRRO

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_BAIRRO
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.ENDERECOS_BAIRRO registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.ENDERECOS_BAIRRO registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.ENDERECOS_BAIRRO registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindByWhere(_filtro);
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
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por BAIRRO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_BAIRRO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_BAIRRO_ID(int _BAIRRO_ID)
      {
          DAL.ENDERECOS_BAIRRO cmd = new DAL.ENDERECOS_BAIRRO();
          return cmd.FindBy_BAIRRO_ID(_BAIRRO_ID);
      }
  }

#endregion

#region classe ENDERECOS_CIDADES

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_CIDADES
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.ENDERECOS_CIDADES registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.ENDERECOS_CIDADES registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.ENDERECOS_CIDADES registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindByWhere(_filtro);
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
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_ID(int _CIDADE_ID)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindBy_CIDADE_ID(_CIDADE_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_DESCRICAO(string _CIDADE_DESCRICAO)
      {
          DAL.ENDERECOS_CIDADES cmd = new DAL.ENDERECOS_CIDADES();
          return cmd.FindBy_CIDADE_DESCRICAO(_CIDADE_DESCRICAO);
      }
  }

#endregion

#region classe ENDERECOS_LOGRADOUROS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_LOGRADOUROS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.ENDERECOS_LOGRADOUROS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.ENDERECOS_LOGRADOUROS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.ENDERECOS_LOGRADOUROS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindByWhere(_filtro);
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
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por LOGRADOURO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_LOGRADOURO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_LOGRADOURO_ID(int _LOGRADOURO_ID)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindBy_LOGRADOURO_ID(_LOGRADOURO_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por LOGRADOURO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_LOGRADOURO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_LOGRADOURO_DESCRICAO(string _LOGRADOURO_DESCRICAO)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindBy_LOGRADOURO_DESCRICAO(_LOGRADOURO_DESCRICAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por LOGRADOURO_CEP e retorna um DataSet.
      /// </summary>
      /// <param name="_LOGRADOURO_CEP">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_LOGRADOURO_CEP(string _LOGRADOURO_CEP)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindBy_LOGRADOURO_CEP(_LOGRADOURO_CEP);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por TIPO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_TIPO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_TIPO_ID(int _TIPO_ID)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindBy_TIPO_ID(_TIPO_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por BAIRRO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_BAIRRO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_BAIRRO_ID(int _BAIRRO_ID)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindBy_BAIRRO_ID(_BAIRRO_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por CIDADE_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_CIDADE_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_CIDADE_ID(int _CIDADE_ID)
      {
          DAL.ENDERECOS_LOGRADOUROS cmd = new DAL.ENDERECOS_LOGRADOUROS();
          return cmd.FindBy_CIDADE_ID(_CIDADE_ID);
      }
  }

#endregion

#region classe ENDERECOS_TIPO

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_TIPO
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.ENDERECOS_TIPO registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.ENDERECOS_TIPO registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.ENDERECOS_TIPO registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindByWhere(_filtro);
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
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por TIPO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_TIPO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_TIPO_ID(int _TIPO_ID)
      {
          DAL.ENDERECOS_TIPO cmd = new DAL.ENDERECOS_TIPO();
          return cmd.FindBy_TIPO_ID(_TIPO_ID);
      }
  }

#endregion

#region classe ENDERECOS_UF

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class ENDERECOS_UF
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.ENDERECOS_UF registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.ENDERECOS_UF registro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.ENDERECOS_UF registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindByWhere(_filtro);
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
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por UF_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_UF_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_UF_ID(int _UF_ID)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindBy_UF_ID(_UF_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por UF_SIGLA e retorna um DataSet.
      /// </summary>
      /// <param name="_UF_SIGLA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_UF_SIGLA(string _UF_SIGLA)
      {
          DAL.ENDERECOS_UF cmd = new DAL.ENDERECOS_UF();
          return cmd.FindBy_UF_SIGLA(_UF_SIGLA);
      }
  }

#endregion

#region classe FAVORITOS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class FAVORITOS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.FAVORITOS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.FAVORITOS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.FAVORITOS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindByWhere(_filtro);
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
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_ID(int _FAVORITO_ID)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindBy_FAVORITO_ID(_FAVORITO_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_LINK(string _FAVORITO_LINK)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindBy_FAVORITO_LINK(_FAVORITO_LINK);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_INCLUSAO(DateTime _FAVORITO_INCLUSAO)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindBy_FAVORITO_INCLUSAO(_FAVORITO_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FAVORITO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_FAVORITO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FAVORITO_DESCRICAO(string _FAVORITO_DESCRICAO)
      {
          DAL.FAVORITOS cmd = new DAL.FAVORITOS();
          return cmd.FindBy_FAVORITO_DESCRICAO(_FAVORITO_DESCRICAO);
      }
  }

#endregion

#region classe FERIADOS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class FERIADOS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.FERIADOS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.FERIADOS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.FERIADOS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindByWhere(_filtro);
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
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_ID(int _FERIADO_ID)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindBy_FERIADO_ID(_FERIADO_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_DATA e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_DATA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_DATA(DateTime _FERIADO_DATA)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindBy_FERIADO_DATA(_FERIADO_DATA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_DESCRICAO(string _FERIADO_DESCRICAO)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindBy_FERIADO_DESCRICAO(_FERIADO_DESCRICAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por FERIADO_FIXO e retorna um DataSet.
      /// </summary>
      /// <param name="_FERIADO_FIXO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_FERIADO_FIXO(byte _FERIADO_FIXO)
      {
          DAL.FERIADOS cmd = new DAL.FERIADOS();
          return cmd.FindBy_FERIADO_FIXO(_FERIADO_FIXO);
      }
  }

#endregion

#region classe FUNCIONARIOS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class FUNCIONARIOS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.FUNCIONARIOS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.FUNCIONARIOS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.FUNCIONARIOS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindByWhere(_filtro);
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
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioID e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioID(int _funcionarioID)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioID(_funcionarioID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEmpresaID e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEmpresaID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEmpresaID(int _funcionarioEmpresaID)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioEmpresaID(_funcionarioEmpresaID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioNOME e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioNOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioNOME(string _funcionarioNOME)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioNOME(_funcionarioNOME);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEndereco e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEndereco">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEndereco(string _funcionarioEndereco)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioEndereco(_funcionarioEndereco);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioBairro e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioBairro">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioBairro(string _funcionarioBairro)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioBairro(_funcionarioBairro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCidade e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCidade">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCidade(string _funcionarioCidade)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioCidade(_funcionarioCidade);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEstado e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEstado">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEstado(string _funcionarioEstado)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioEstado(_funcionarioEstado);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCep e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCep">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCep(string _funcionarioCep)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioCep(_funcionarioCep);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioTelefone e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioTelefone">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioTelefone(string _funcionarioTelefone)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioTelefone(_funcionarioTelefone);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCelular e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCelular">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCelular(string _funcionarioCelular)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioCelular(_funcionarioCelular);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioEMail e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioEMail">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioEMail(string _funcionarioEMail)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioEMail(_funcionarioEMail);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioIdentidade e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioIdentidade">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioIdentidade(string _funcionarioIdentidade)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioIdentidade(_funcionarioIdentidade);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCPF e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCPF">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCPF(string _funcionarioCPF)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioCPF(_funcionarioCPF);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioNascimento e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioNascimento">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioNascimento(DateTime _funcionarioNascimento)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioNascimento(_funcionarioNascimento);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCargo e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCargo">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCargo(string _funcionarioCargo)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioCargo(_funcionarioCargo);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioSalario e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioSalario">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioSalario(float _funcionarioSalario)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioSalario(_funcionarioSalario);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioAdmissao e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioAdmissao">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioAdmissao(DateTime _funcionarioAdmissao)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioAdmissao(_funcionarioAdmissao);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioDiaPagamento e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioDiaPagamento">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioDiaPagamento(Int32 _funcionarioDiaPagamento)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioDiaPagamento(_funcionarioDiaPagamento);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioFoto e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioFoto">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioFoto(Byte _funcionarioFoto)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioFoto(_funcionarioFoto);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioOBS e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioOBS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioOBS(StringBuilder _funcionarioOBS)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioOBS(_funcionarioOBS);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioInativo e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioInativo">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioInativo(byte _funcionarioInativo)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioInativo(_funcionarioInativo);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por funcionarioCBO e retorna um DataSet.
      /// </summary>
      /// <param name="_funcionarioCBO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_funcionarioCBO(string _funcionarioCBO)
      {
          DAL.FUNCIONARIOS cmd = new DAL.FUNCIONARIOS();
          return cmd.FindBy_funcionarioCBO(_funcionarioCBO);
      }
  }

#endregion

#region classe MENU

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class MENU
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.MENU registro)
      {
          //aqui entra os tratamentos necessários
          DAL.MENU cmd = new DAL.MENU();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.MENU registro)
      {
          //aqui entra os tratamentos necessários
          DAL.MENU cmd = new DAL.MENU();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.MENU registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.MENU cmd = new DAL.MENU();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.MENU cmd = new DAL.MENU();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.MENU cmd = new DAL.MENU();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindByWhere(_filtro);
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
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por MENU_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_ID(int _MENU_ID)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindBy_MENU_ID(_MENU_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por MENU_NOME e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_NOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_NOME(string _MENU_NOME)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindBy_MENU_NOME(_MENU_NOME);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por MENU_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_DESCRICAO(string _MENU_DESCRICAO)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindBy_MENU_DESCRICAO(_MENU_DESCRICAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por MENU_PAI e retorna um DataSet.
      /// </summary>
      /// <param name="_MENU_PAI">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_MENU_PAI(int _MENU_PAI)
      {
          DAL.MENU cmd = new DAL.MENU();
          return cmd.FindBy_MENU_PAI(_MENU_PAI);
      }
  }

#endregion

#region classe PESSOAS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.PESSOAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.PESSOAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.PESSOAS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindByWhere(_filtro);
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
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_ID(_PESSOA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CODIGO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CODIGO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CODIGO(string _PESSOA_CODIGO)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_CODIGO(_PESSOA_CODIGO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_NOME e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_NOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_NOME(string _PESSOA_NOME)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_NOME(_PESSOA_NOME);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ENDERECO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ENDERECO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ENDERECO(string _PESSOA_ENDERECO)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_ENDERECO(_PESSOA_ENDERECO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ENDERECO_NR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ENDERECO_NR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ENDERECO_NR(string _PESSOA_ENDERECO_NR)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_ENDERECO_NR(_PESSOA_ENDERECO_NR);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_BAIRRO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_BAIRRO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_BAIRRO(string _PESSOA_BAIRRO)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_BAIRRO(_PESSOA_BAIRRO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CIDADE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CIDADE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CIDADE(string _PESSOA_CIDADE)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_CIDADE(_PESSOA_CIDADE);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ESTADO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ESTADO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ESTADO(string _PESSOA_ESTADO)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_ESTADO(_PESSOA_ESTADO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CEP e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CEP">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CEP(string _PESSOA_CEP)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_CEP(_PESSOA_CEP);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_TELEFONE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_TELEFONE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_TELEFONE(string _PESSOA_TELEFONE)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_TELEFONE(_PESSOA_TELEFONE);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_EMAIL e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_EMAIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_EMAIL(string _PESSOA_EMAIL)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_EMAIL(_PESSOA_EMAIL);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_WEB e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_WEB">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_WEB(string _PESSOA_WEB)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_WEB(_PESSOA_WEB);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_NASCIMENTO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_NASCIMENTO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_NASCIMENTO(DateTime _PESSOA_NASCIMENTO)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_NASCIMENTO(_PESSOA_NASCIMENTO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_RENDA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_RENDA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_RENDA(float _PESSOA_RENDA)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_RENDA(_PESSOA_RENDA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_INCLUSAO(DateTime _PESSOA_INCLUSAO)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_INCLUSAO(_PESSOA_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_TAG_CLIENTE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_TAG_CLIENTE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_TAG_CLIENTE(byte _PESSOA_TAG_CLIENTE)
      {
          DAL.PESSOAS cmd = new DAL.PESSOAS();
          return cmd.FindBy_PESSOA_TAG_CLIENTE(_PESSOA_TAG_CLIENTE);
      }
  }

#endregion

#region classe PESSOAS_CLIENTE

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS_CLIENTE
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.PESSOAS_CLIENTE registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.PESSOAS_CLIENTE registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.PESSOAS_CLIENTE registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindByWhere(_filtro);
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
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindBy_PESSOA_ID(_PESSOA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_CLIENTE_LIMITECRED e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_CLIENTE_LIMITECRED">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_CLIENTE_LIMITECRED(float _PESSOA_CLIENTE_LIMITECRED)
      {
          DAL.PESSOAS_CLIENTE cmd = new DAL.PESSOAS_CLIENTE();
          return cmd.FindBy_PESSOA_CLIENTE_LIMITECRED(_PESSOA_CLIENTE_LIMITECRED);
      }
  }

#endregion

#region classe PESSOAS_FISICA

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS_FISICA
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.PESSOAS_FISICA registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.PESSOAS_FISICA registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.PESSOAS_FISICA registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindByWhere(_filtro);
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
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_ID(_PESSOA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_CELULAR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_CELULAR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_CELULAR(string _PESSOA_FISICA_CELULAR)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_CELULAR(_PESSOA_FISICA_CELULAR);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_CPF e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_CPF">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_CPF(string _PESSOA_FISICA_CPF)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_CPF(_PESSOA_FISICA_CPF);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_RG e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_RG">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_RG(string _PESSOA_FISICA_RG)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_RG(_PESSOA_FISICA_RG);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_EMPRESA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_EMPRESA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_EMPRESA(string _PESSOA_FISICA_EMPRESA)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_EMPRESA(_PESSOA_FISICA_EMPRESA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_CARGO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_CARGO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_CARGO(string _PESSOA_FISICA_CARGO)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_CARGO(_PESSOA_FISICA_CARGO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_SETOR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_SETOR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_SETOR(int _PESSOA_FISICA_SETOR)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_SETOR(_PESSOA_FISICA_SETOR);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ADMISSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ADMISSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ADMISSAO(DateTime _PESSOA_FISICA_ADMISSAO)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_ADMISSAO(_PESSOA_FISICA_ADMISSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_DIAPG e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_DIAPG">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_DIAPG(Int32 _PESSOA_FISICA_DIAPG)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_DIAPG(_PESSOA_FISICA_DIAPG);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FOTO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FOTO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FOTO(Byte _PESSOA_FISICA_FOTO)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_FOTO(_PESSOA_FISICA_FOTO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ENTRADA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ENTRADA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ENTRADA(DateTime _PESSOA_FISICA_ENTRADA)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_ENTRADA(_PESSOA_FISICA_ENTRADA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_SAIDA e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_SAIDA">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_SAIDA(DateTime _PESSOA_FISICA_SAIDA)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_SAIDA(_PESSOA_FISICA_SAIDA);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ALMOCOINICIO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ALMOCOINICIO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ALMOCOINICIO(DateTime _PESSOA_FISICA_ALMOCOINICIO)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_ALMOCOINICIO(_PESSOA_FISICA_ALMOCOINICIO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_ALMOCOFIM e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_ALMOCOFIM">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_ALMOCOFIM(DateTime _PESSOA_FISICA_ALMOCOFIM)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_ALMOCOFIM(_PESSOA_FISICA_ALMOCOFIM);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_OBS e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_OBS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_OBS(StringBuilder _PESSOA_FISICA_OBS)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_OBS(_PESSOA_FISICA_OBS);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FILIACAO_PAI e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FILIACAO_PAI">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FILIACAO_PAI(string _PESSOA_FISICA_FILIACAO_PAI)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_FILIACAO_PAI(_PESSOA_FISICA_FILIACAO_PAI);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FILIACAO_MAE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FILIACAO_MAE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FILIACAO_MAE(string _PESSOA_FISICA_FILIACAO_MAE)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_FILIACAO_MAE(_PESSOA_FISICA_FILIACAO_MAE);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FUNCIONARIO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FUNCIONARIO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FUNCIONARIO(byte _PESSOA_FISICA_FUNCIONARIO)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_FUNCIONARIO(_PESSOA_FISICA_FUNCIONARIO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_FISICA_FUNCIONARIO_DEMISSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_FISICA_FUNCIONARIO_DEMISSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_FISICA_FUNCIONARIO_DEMISSAO(DateTime _PESSOA_FISICA_FUNCIONARIO_DEMISSAO)
      {
          DAL.PESSOAS_FISICA cmd = new DAL.PESSOAS_FISICA();
          return cmd.FindBy_PESSOA_FISICA_FUNCIONARIO_DEMISSAO(_PESSOA_FISICA_FUNCIONARIO_DEMISSAO);
      }
  }

#endregion

#region classe PESSOAS_JURIDICA

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class PESSOAS_JURIDICA
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.PESSOAS_JURIDICA registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.PESSOAS_JURIDICA registro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.PESSOAS_JURIDICA registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindByWhere(_filtro);
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
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_ID(int _PESSOA_ID)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_ID(_PESSOA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_RAZAO e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_RAZAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_RAZAO(string _PESSOA_JURIDICA_RAZAO)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_RAZAO(_PESSOA_JURIDICA_RAZAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_CNPJ e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_CNPJ">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_CNPJ(string _PESSOA_JURIDICA_CNPJ)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_CNPJ(_PESSOA_JURIDICA_CNPJ);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_IE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_IE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_IE(string _PESSOA_JURIDICA_IE)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_IE(_PESSOA_JURIDICA_IE);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_FAX e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_FAX">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_FAX(string _PESSOA_JURIDICA_FAX)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_FAX(_PESSOA_JURIDICA_FAX);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_OBS e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_OBS">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_OBS(StringBuilder _PESSOA_JURIDICA_OBS)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_OBS(_PESSOA_JURIDICA_OBS);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_ATIVIDADE e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_ATIVIDADE">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_ATIVIDADE(string _PESSOA_JURIDICA_ATIVIDADE)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_ATIVIDADE(_PESSOA_JURIDICA_ATIVIDADE);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por PESSOA_JURIDICA_FORNECEDOR e retorna um DataSet.
      /// </summary>
      /// <param name="_PESSOA_JURIDICA_FORNECEDOR">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_PESSOA_JURIDICA_FORNECEDOR(byte _PESSOA_JURIDICA_FORNECEDOR)
      {
          DAL.PESSOAS_JURIDICA cmd = new DAL.PESSOAS_JURIDICA();
          return cmd.FindBy_PESSOA_JURIDICA_FORNECEDOR(_PESSOA_JURIDICA_FORNECEDOR);
      }
  }

#endregion

#region classe SISTEMAS

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class SISTEMAS
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.SISTEMAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.SISTEMAS registro)
      {
          //aqui entra os tratamentos necessários
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.SISTEMAS registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindByWhere(_filtro);
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
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_ID(int _SISTEMA_ID)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindBy_SISTEMA_ID(_SISTEMA_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_LINK(string _SISTEMA_LINK)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindBy_SISTEMA_LINK(_SISTEMA_LINK);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_INCLUSAO(DateTime _SISTEMA_INCLUSAO)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindBy_SISTEMA_INCLUSAO(_SISTEMA_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SISTEMA_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SISTEMA_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SISTEMA_DESCRICAO(string _SISTEMA_DESCRICAO)
      {
          DAL.SISTEMAS cmd = new DAL.SISTEMAS();
          return cmd.FindBy_SISTEMA_DESCRICAO(_SISTEMA_DESCRICAO);
      }
  }

#endregion

#region classe SOLICITACOES

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class SOLICITACOES
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.SOLICITACOES registro)
      {
          //aqui entra os tratamentos necessários
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.SOLICITACOES registro)
      {
          //aqui entra os tratamentos necessários
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.SOLICITACOES registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindByWhere(_filtro);
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
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindByWhere(_filtro, _orderby);
      }
      
      public object FindByWhere(String _filtro, String _orderby, String _direction)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindByWhere(_filtro, _orderby, _direction);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_ID(int _SOLICITACAO_ID)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_ID(_SOLICITACAO_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_REMETENTE_NOME e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_REMETENTE_NOME">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_REMETENTE_NOME(string _SOLICITACAO_REMETENTE_NOME)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_REMETENTE_NOME(_SOLICITACAO_REMETENTE_NOME);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_REMETENTE_EMAIL e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_REMETENTE_EMAIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_REMETENTE_EMAIL(string _SOLICITACAO_REMETENTE_EMAIL)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_REMETENTE_EMAIL(_SOLICITACAO_REMETENTE_EMAIL);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_ASSUNTO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_ASSUNTO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_ASSUNTO(string _SOLICITACAO_ASSUNTO)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_ASSUNTO(_SOLICITACAO_ASSUNTO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_DESCRICAO(string _SOLICITACAO_DESCRICAO)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_DESCRICAO(_SOLICITACAO_DESCRICAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_INCLUSAO(DateTime _SOLICITACAO_INCLUSAO)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_INCLUSAO(_SOLICITACAO_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_SITUACAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_SITUACAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_SITUACAO(byte _SOLICITACAO_SITUACAO)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_SITUACAO(_SOLICITACAO_SITUACAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_DESTINATARIO_EMAIL e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_DESTINATARIO_EMAIL">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_DESTINATARIO_EMAIL(string _SOLICITACAO_DESTINATARIO_EMAIL)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_DESTINATARIO_EMAIL(_SOLICITACAO_DESTINATARIO_EMAIL);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SOLICITACAO_CONCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SOLICITACAO_CONCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SOLICITACAO_CONCLUSAO(DateTime _SOLICITACAO_CONCLUSAO)
      {
          DAL.SOLICITACOES cmd = new DAL.SOLICITACOES();
          return cmd.FindBy_SOLICITACAO_CONCLUSAO(_SOLICITACAO_CONCLUSAO);
      }

     
  }

#endregion

#region classe SUPORTES

  /// <summary>
  /// Classe BLL: Business Logic Layer
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
  public class SUPORTES
  {
      //MÉTODOS

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco
      /// </summary>
      /// <returns>Void</returns>
      public void Insert(TAB.SUPORTES registro)
      {
          //aqui entra os tratamentos necessários
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          cmd.Insert(registro);
      }

      /// <summary>
      /// MARCOS:
      /// Insere os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int InsertId(TAB.SUPORTES registro)
      {
          //aqui entra os tratamentos necessários
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.InsertId(registro);
      }

      /// <summary>
      /// MARCOS:
      /// atualiza os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Update(TAB.SUPORTES registro, string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          cmd.Update(registro,_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco.
      /// </summary>
      /// <returns>Void</returns>
      public void Delete(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          cmd.Delete(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Apaga os registros do banco e retorna o número de linhas afetadas.
      /// </summary>
      /// <returns>Void</returns>
      public int DeleteId(string _filtro)
      {
          //aqui entra os tratamentos necessários
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.DeleteId(_filtro);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataSet.
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindQueryDataSet(string _query)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindQueryDataSet(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros passados por query e retorna um DataTable..
      /// </summary>
      /// <param name="filtro da consulta</param>
      /// <returns>DataTable</returns>
      public DataTable FindQueryDataTable(string _query)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindQueryDataTable(_query);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <returns>DataSet</returns>
      public DataSet FindAll()
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindAll();
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindAll(_orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param="_orderby">campo de ordenação</param>
      /// <param="_asc|desc">acendente|descendente</param>
      /// <returns>DataSet</returns>
      public DataSet FindAll(String _orderby, String _asc)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindAll(_orderby, _asc);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros e retorna um DataSet.
      /// </summary>
      /// <param name="_filtro ("id_campo = 1 AND campo1 = 'texto' OR campo2 LIKE 'r%'")">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindByWhere(string _filtro)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindByWhere(_filtro);
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
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindByWhere(_filtro, _orderby);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_ID e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_ID">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_ID(int _SUPORTE_ID)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindBy_SUPORTE_ID(_SUPORTE_ID);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_LINK e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_LINK">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_LINK(string _SUPORTE_LINK)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindBy_SUPORTE_LINK(_SUPORTE_LINK);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_INCLUSAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_INCLUSAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_INCLUSAO(DateTime _SUPORTE_INCLUSAO)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindBy_SUPORTE_INCLUSAO(_SUPORTE_INCLUSAO);
      }

      /// <summary>
      /// MARCOS:
      /// Seleciona todos os registros por SUPORTE_DESCRICAO e retorna um DataSet.
      /// </summary>
      /// <param name="_SUPORTE_DESCRICAO">filtro da consulta</param>
      /// <returns>DataSet</returns>
      public DataSet FindBy_SUPORTE_DESCRICAO(string _SUPORTE_DESCRICAO)
      {
          DAL.SUPORTES cmd = new DAL.SUPORTES();
          return cmd.FindBy_SUPORTE_DESCRICAO(_SUPORTE_DESCRICAO);
      }
  }

#endregion

}
