using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Web.UI.MobileControls;
using System.Collections;
using System.Data.SqlClient;

namespace portal.LIB
{
    /// <summary>
    /// Autor: Marcos
    /// classe para abrigar atributos de endereçamento
    /// </summary> 
    /// <param name="texto">atributos de endereçamento</param>
    /// <returns>atributos de endereçamento</returns>
    public class Endereco
    {
        //Atributos
        private String _retorno = string.Empty;
        private String _tipo_logradouro = string.Empty;
        private String _logradouro = string.Empty;
        private String _bairro = string.Empty;
        private String _uf_sigla = string.Empty;
        private String _uf_decricao = string.Empty;
        private String _cidade = string.Empty;
        private String _cep = string.Empty;
        private String _codigo_ibge = string.Empty;
        private String _origem = string.Empty;

        //Propiedades
        public String Retorno
        {
            get { return _retorno; }
            set { _retorno = value; }
        }
        public String Tipo_logradouro
        {
            get { return _tipo_logradouro; }
            set { _tipo_logradouro = value; }
        }
        public String Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }
        public String Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public String Uf_sigla
        {
            get { return _uf_sigla; }
            set { _uf_sigla = value; }
        }
        public String Uf_descricao
        {
            get { return _uf_decricao; }
            set { _uf_decricao = value; }
        }
        public String Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public String Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }
        public String Codigo_ibge
        {
            get { return _codigo_ibge; }
            set { _codigo_ibge = value; }
        }
        public String Origem
        {
            get { return _origem; }
            set { _origem = value; }
        }

        public Endereco() { }
    }

    /// <summary>
    /// Autor: Marcos
    /// </summary> 
    /// <param name=""></param>
    /// <returns></returns>
    public class CepService
    {
        public static Endereco getCepLocal(String _logradouro, String _cidade)
        {
            Endereco endereco = new Endereco();
            DataSet ds = new DataSet();

            StringBuilder query = new StringBuilder();
            query.Append(" SELECT       TIPOS.TIPO_DESCRICAO, LOGRADOUROS.LOGRADOURO_DESCRICAO, BAIRROS.BAIRRO_DESCRICAO, CIDADES.CIDADE_DESCRICAO,CIDADES.CIDADE_IBGE, UFS.UF_SIGLA, ");
            query.Append("              UFS.UF_DESCRICAO, LOGRADOUROS.LOGRADOURO_CEP");
            query.Append(" FROM         BAIRROS INNER JOIN");
            query.Append("              LOGRADOUROS ON BAIRROS.BAIRRO_ID = LOGRADOUROS.BAIRRO_ID INNER JOIN");
            query.Append("              CIDADES ON LOGRADOUROS.CIDADE_ID = CIDADES.CIDADE_ID INNER JOIN");
            query.Append("              TIPOS ON LOGRADOUROS.TIPO_ID = TIPOS.TIPO_ID INNER JOIN");
            query.Append("              UFS ON LOGRADOUROS.UF_ID = UFS.UF_ID");
            query.Append(" WHERE        (LOGRADOUROS.LOGRADOURO_DESCRICAO = '" + _logradouro.Trim() + "' AND CIDADES.CIDADE_DESCRICAO = '" + _cidade.Trim() + "' )");

            portal.DAL.ENDERECOS_LOGRADOUROS cep = new portal.DAL.ENDERECOS_LOGRADOUROS();
            ds = cep.FindQueryDataSet(query.ToString());

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    endereco.Retorno = "1";
                    endereco.Tipo_logradouro = ds.Tables[0].Rows[0]["TIPO_DESCRICAO"].ToString();
                    endereco.Logradouro = ds.Tables[0].Rows[0]["LOGRADOURO_DESCRICAO"].ToString();
                    endereco.Bairro = ds.Tables[0].Rows[0]["BAIRRO_DESCRICAO"].ToString();
                    endereco.Cidade = ds.Tables[0].Rows[0]["CIDADE_DESCRICAO"].ToString();
                    endereco.Uf_sigla = ds.Tables[0].Rows[0]["UF_SIGLA"].ToString();
                    endereco.Uf_descricao = ds.Tables[0].Rows[0]["UF_DESCRICAO"].ToString();
                    endereco.Cep = ds.Tables[0].Rows[0]["LOGRADOURO_CEP"].ToString();
                    endereco.Codigo_ibge = ds.Tables[0].Rows[0]["CIDADE_IBGE"].ToString();
                    endereco.Origem = "Base de dados local";
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            return endereco;
        }
        public static Endereco getCepLocal(String _cep)
        {
            Endereco endereco = new Endereco();
            DataSet ds = new DataSet();
            
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT       TIPOS.TIPO_DESCRICAO, LOGRADOUROS.LOGRADOURO_DESCRICAO, BAIRROS.BAIRRO_DESCRICAO, CIDADES.CIDADE_DESCRICAO,CIDADES.CIDADE_IBGE, UFS.UF_SIGLA, ");
            query.Append("              UFS.UF_DESCRICAO, LOGRADOUROS.LOGRADOURO_CEP");
            query.Append(" FROM         BAIRROS INNER JOIN");
            query.Append("              LOGRADOUROS ON BAIRROS.BAIRRO_ID = LOGRADOUROS.BAIRRO_ID INNER JOIN");
            query.Append("              CIDADES ON LOGRADOUROS.CIDADE_ID = CIDADES.CIDADE_ID INNER JOIN");
            query.Append("              TIPOS ON LOGRADOUROS.TIPO_ID = TIPOS.TIPO_ID INNER JOIN");
            query.Append("              UFS ON LOGRADOUROS.UF_ID = UFS.UF_ID");
            query.Append(" WHERE        (LOGRADOUROS.LOGRADOURO_CEP = '" + _cep.Replace("-", "").Trim() + "')");

            portal.DAL.ENDERECOS_LOGRADOUROS cep = new portal.DAL.ENDERECOS_LOGRADOUROS();
            ds = cep.FindQueryDataSet(query.ToString());
            
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    endereco.Retorno = "1";
                    endereco.Tipo_logradouro = ds.Tables[0].Rows[0]["TIPO_DESCRICAO"].ToString();
                    endereco.Logradouro = ds.Tables[0].Rows[0]["LOGRADOURO_DESCRICAO"].ToString();
                    endereco.Bairro = ds.Tables[0].Rows[0]["BAIRRO_DESCRICAO"].ToString();
                    endereco.Cidade = ds.Tables[0].Rows[0]["CIDADE_DESCRICAO"].ToString();
                    endereco.Uf_sigla = ds.Tables[0].Rows[0]["UF_SIGLA"].ToString();
                    endereco.Uf_descricao = ds.Tables[0].Rows[0]["UF_DESCRICAO"].ToString();
                    endereco.Cep = ds.Tables[0].Rows[0]["LOGRADOURO_CEP"].ToString();
                    endereco.Codigo_ibge = ds.Tables[0].Rows[0]["CIDADE_IBGE"].ToString();
                    endereco.Origem = "Base de dados local";
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            return endereco;

        }
        public static Endereco getCepBuscarCep(String _cep)
        {
            _cep = _cep.Insert(5, "-");
            Endereco endereco = new Endereco();
            DataSet ds = new DataSet();
            //10 consultas por minuto
            ds.ReadXml("http://www.buscarcep.com.br/?cep=" + _cep.Trim() + "&formato=xml&chave=1M6DaQyZ6h5kIQRHB9/SPwPTANro330");
            /*
            <cep>45200130</cep>
            <uf>BA</uf>
            <cidade>Jequié</cidade>
            <bairro>Centro</bairro>
            <tipo_logradouro>Avenida</tipo_logradouro>
            <complemento>-até 324/325</complemento>
            <logradouro>Franz Gedeon</logradouro>
            <ibge_uf>Franz Gedeon</ibge_uf>
            <ibge_municipio>Franz Gedeon</ibge_municipio>
            <resultado>1</resultado>
            <resultado_txt>sucesso - cep completo</resultado_txt>
             */
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    endereco.Retorno = "1";
                    endereco.Tipo_logradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();
                    endereco.Logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString() + ds.Tables[0].Rows[0]["complemento"].ToString();
                    endereco.Bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                    endereco.Cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                    endereco.Uf_sigla = ds.Tables[0].Rows[0]["uf"].ToString();
                    endereco.Uf_descricao = string.Empty;
                    endereco.Cep = _cep;
                    endereco.Codigo_ibge = ds.Tables[0].Rows[0]["ibge_municipio"].ToString();
                    endereco.Origem = "http://www.buscarcep.com.br";
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            return endereco;
        }
        public static Endereco getCepRepublicaVirtual(String _cep)
        {
            Endereco endereco = new Endereco();
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + _cep.Replace("-", "").Trim() + "&formato=xml");
            /*
            <uf>RS</uf>
            <cidade>Porto Alegre</cidade>
            <bairro>Passo D'Areia</bairro>
            <tipo_logradouro>Avenida</tipo_logradouro>
            <logradouro>Assis Brasil</logradouro>
            <resultado>1</resultado>
            <resultado_txt>sucesso - cep completo</resultado_txt>
             */
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    endereco.Retorno = "1";
                    endereco.Tipo_logradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();
                    endereco.Logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString();
                    endereco.Bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                    endereco.Cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                    endereco.Uf_sigla = ds.Tables[0].Rows[0]["uf"].ToString();
                    endereco.Uf_descricao = string.Empty;
                    endereco.Cep = _cep;
                    endereco.Codigo_ibge = string.Empty;
                    endereco.Origem = "http://cep.republicavirtual.com.br";
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            return endereco;
        }
        public static Endereco getCepLivre(String _cep)
        {
            _cep = _cep.Insert(5, "-");
            Endereco endereco = new Endereco();
            DataSet ds = new DataSet();
            ds.ReadXml("http://ceplivre.pc2consultoria.com/index.php?module=cep&cep="+_cep.Trim()+"&formato=xml");
            /*
            <uf>RS</uf>
            <cidade>Porto Alegre</cidade>
            <bairro>Passo D'Areia</bairro>
            <tipo_logradouro>Avenida</tipo_logradouro>
            <logradouro>Assis Brasil</logradouro>
            <resultado>1</resultado>
            <resultado_txt>sucesso - cep completo</resultado_txt>
             */
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    endereco.Retorno = "1";
                    endereco.Tipo_logradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();
                    endereco.Logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString();
                    endereco.Bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                    endereco.Cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                    endereco.Uf_sigla = ds.Tables[0].Rows[0]["estado_sigla"].ToString();
                    endereco.Uf_descricao = string.Empty;
                    endereco.Cep = _cep;
                    endereco.Codigo_ibge = ds.Tables[0].Rows[0]["codigo_ibge"].ToString();
                    endereco.Origem = "http://ceplivre.pc2consultoria.com";
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            return endereco;
        }
        public static Endereco getCepLivre(String _logradouro, String _cidade)
        {
            Endereco endereco = new Endereco();
            DataSet ds = new DataSet();
            ds.ReadXml("http://ceplivre.pc2consultoria.com/index.php?module=cep&logradouro=" + _logradouro.Trim() + "&cidade=" + _cidade.Trim() + "&formato=xml"); 
            /*
            <uf>RS</uf>
            <cidade>Porto Alegre</cidade>
            <bairro>Passo D'Areia</bairro>
            <tipo_logradouro>Avenida</tipo_logradouro>
            <logradouro>Assis Brasil</logradouro>
            <resultado>1</resultado>
            <resultado_txt>sucesso - cep completo</resultado_txt>
             */
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        endereco.Retorno = "1";
                        endereco.Tipo_logradouro = ds.Tables[0].Rows[i]["tipo_logradouro"].ToString();
                        endereco.Logradouro = ds.Tables[0].Rows[i]["logradouro"].ToString();
                        endereco.Bairro = ds.Tables[0].Rows[i]["bairro"].ToString();
                        endereco.Cidade = ds.Tables[0].Rows[i]["cidade"].ToString();
                        endereco.Uf_sigla = ds.Tables[0].Rows[i]["estado_sigla"].ToString();
                        endereco.Uf_descricao = ds.Tables[0].Rows[i]["estado"].ToString();
                        endereco.Cep = String.Empty; //ds.Tables[0].Rows[0]["cep"].ToString();
                        endereco.Codigo_ibge = ds.Tables[0].Rows[i]["codigo_ibge"].ToString();
                        endereco.Origem = "http://ceplivre.pc2consultoria.com";
                    }
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            return endereco;
        }
        public static Endereco getCepWs(String _cep)
        {
            //Instanciado o meu webService
            WsCEP.wscep service = new WsCEP.wscep();
            //Método cep(string c) que recebe uma string cep e retorna um dataset.
            DataSet ds = service.cep(_cep);
            //Instanciando um objeto do tipo endereço, no caso o objeto que será retornado.
            Endereco endereco = new Endereco();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    endereco.Retorno = "1";
                    endereco.Tipo_logradouro = string.Empty;
                    endereco.Tipo_logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString();
                    endereco.Logradouro = ds.Tables[0].Rows[0]["nome"].ToString();
                    endereco.Bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                    endereco.Cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                    endereco.Uf_sigla = ds.Tables[0].Rows[0]["UF"].ToString();
                    endereco.Uf_descricao = string.Empty;
                    endereco.Cep = _cep;
                    endereco.Codigo_ibge = string.Empty;
                    endereco.Origem = "http://www.bronzebusiness.com.br";
                }
                else
                {
                    endereco.Retorno = "0";
                }
            }
            //Retornando o meu Objeto do tipo endereço.
            return endereco;
        }
        public static List<Endereco> getCEP(String _cep)
        {
            _cep = _cep.Replace("-", "").Trim();

            Endereco endereco = new Endereco();
            List<Endereco> lista = new List<Endereco>();
            lista.Add(getCepLocal(_cep));
            if (lista[0].Retorno != "1")
            {
                //lista.Clear();
                //lista.Add(getCepBuscarCep(_cep));
                //if (lista[0].Retorno != "1")
                //{
                    lista.Clear();
                    lista.Add(getCepRepublicaVirtual(_cep));
                    if (lista[0].Retorno != "1")
                    {
                        lista.Clear();
                        lista.Add(getCepLivre(_cep));
                        if (lista[0].Retorno != "1")
                        {
                            lista.Clear();
                            lista.Add(getCepWs(_cep));
                        }
                        else
                        {
                            endereco.Retorno = "0";
                            endereco.Tipo_logradouro = string.Empty;
                            endereco.Logradouro = string.Empty;
                            endereco.Bairro = string.Empty;
                            endereco.Cidade = string.Empty;
                            endereco.Uf_sigla = string.Empty;
                            endereco.Uf_descricao = string.Empty;
                            endereco.Cep = string.Empty;
                            endereco.Codigo_ibge = string.Empty;
                            endereco.Origem = string.Empty;
                        }
                    }
                //}

                if (lista[0].Retorno == "1")
                {
                    TAB.ENDERECOS_UF _ufs = new TAB.ENDERECOS_UF();
                    TAB.ENDERECOS_CIDADES _cidades = new TAB.ENDERECOS_CIDADES();
                    TAB.ENDERECOS_BAIRRO _bairros = new TAB.ENDERECOS_BAIRRO();
                    TAB.ENDERECOS_TIPO _tipos = new TAB.ENDERECOS_TIPO();
                    TAB.ENDERECOS_LOGRADOUROS _logradouros = new TAB.ENDERECOS_LOGRADOUROS();

                    DAL.ENDERECOS_UF DAL_UFS = new DAL.ENDERECOS_UF();
                    DAL.ENDERECOS_CIDADES DAL_CIDADES = new DAL.ENDERECOS_CIDADES();
                    DAL.ENDERECOS_BAIRRO DAL_BAIRROS = new DAL.ENDERECOS_BAIRRO();
                    DAL.ENDERECOS_TIPO DAL_TIPOS = new DAL.ENDERECOS_TIPO();
                    DAL.ENDERECOS_LOGRADOUROS DAL_LOGRADOUROS = new DAL.ENDERECOS_LOGRADOUROS();
                    
                    DataSet ds = new DataSet();
                    
                    _ufs.UF_SIGLA = lista[0].Uf_sigla;
                    _ufs.UF_DESCRICAO = lista[0].Uf_descricao;
                    ds = DAL_UFS.FindBy_UF_SIGLA(_ufs.UF_SIGLA);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _ufs.UF_ID = ds.Tables[0].Rows[0].Field<Int32>("UF_ID");
                    }
                    else
                    {
                        _ufs.UF_ID = DAL_UFS.InsertId(_ufs);
                    }

                    _cidades.CIDADE_DESCRICAO = lista[0].Cidade;
                    _cidades.CIDADE_IBGE = lista[0].Codigo_ibge;
                    ds = DAL_CIDADES.FindBy_CIDADE_DESCRICAO(_cidades.CIDADE_DESCRICAO);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _cidades.CIDADE_ID = ds.Tables[0].Rows[0].Field<Int32>("CIDADE_ID");
                    }
                    else
                    {
                        _cidades.CIDADE_ID = DAL_CIDADES.InsertId(_cidades);
                    }

                    _bairros.BAIRRO_DESCRICAO = lista[0].Bairro;
                    ds = DAL_BAIRROS.FindBy_BAIRRO_DESCRICAO(_bairros.BAIRRO_DESCRICAO);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _bairros.BAIRRO_ID = ds.Tables[0].Rows[0].Field<Int32>("BAIRRO_ID");
                    }
                    else
                    {
                        _bairros.BAIRRO_ID = DAL_BAIRROS.InsertId(_bairros);
                    }

                    _tipos.TIPO_DESCRICAO = lista[0].Tipo_logradouro;
                    ds = DAL_TIPOS.FindBy_TIPO_DESCRICAO(_tipos.TIPO_DESCRICAO);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _tipos.TIPO_ID = ds.Tables[0].Rows[0].Field<Int32>("TIPO_ID");
                    }
                    else
                    {
                        _tipos.TIPO_ID = DAL_TIPOS.InsertId(_tipos);
                    }
                    
                    _logradouros.LOGRADOURO_DESCRICAO = lista[0].Logradouro;
                    _logradouros.LOGRADOURO_CEP = lista[0].Cep;
                    _logradouros.UF_ID = _ufs.UF_ID;
                    _logradouros.CIDADE_ID = _cidades.CIDADE_ID;
                    _logradouros.BAIRRO_ID = _bairros.BAIRRO_ID;
                    _logradouros.TIPO_ID = _tipos.TIPO_ID;
                    _logradouros.LOGRADOURO_DESCRICAO = lista[0].Logradouro;

                    ds = DAL_LOGRADOUROS.FindBy_LOGRADOURO_DESCRICAO(_logradouros.LOGRADOURO_DESCRICAO);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _logradouros.LOGRADOURO_ID = ds.Tables[0].Rows[0].Field<Int32>("LOGRADOURO_ID");
                    }
                    else
                    {
                        DAL_LOGRADOUROS.Insert(_logradouros);
                    }
                }

            }
            return lista;

        }
        public static List<Endereco> getCEP(String _logradouro, String _cidade)
        {
            Endereco endereco = new Endereco();
            List<Endereco> lista = new List<Endereco>();
            lista.Add(getCepLocal(_logradouro, _cidade));

            if (lista[0].Retorno != "1")
            {
                lista.Clear();
                lista.Add(getCepLivre(_logradouro, _cidade));
            }
            else
            {
                endereco.Retorno = "0";
                endereco.Tipo_logradouro = string.Empty;
                endereco.Logradouro = string.Empty;
                endereco.Bairro = string.Empty;
                endereco.Cidade = string.Empty;
                endereco.Uf_sigla = string.Empty;
                endereco.Uf_descricao = string.Empty;
                endereco.Cep = string.Empty;
                endereco.Codigo_ibge = string.Empty;
                endereco.Origem = string.Empty;
            }

            if (lista[0].Retorno == "1")
            {
                TAB.ENDERECOS_UF _ufs = new TAB.ENDERECOS_UF();
                TAB.ENDERECOS_CIDADES _cidades = new TAB.ENDERECOS_CIDADES();
                TAB.ENDERECOS_BAIRRO _bairros = new TAB.ENDERECOS_BAIRRO();
                TAB.ENDERECOS_TIPO _tipos = new TAB.ENDERECOS_TIPO();
                TAB.ENDERECOS_LOGRADOUROS _logradouros = new TAB.ENDERECOS_LOGRADOUROS();

                DAL.ENDERECOS_UF DAL_UFS = new DAL.ENDERECOS_UF();
                DAL.ENDERECOS_CIDADES DAL_CIDADES = new DAL.ENDERECOS_CIDADES();
                DAL.ENDERECOS_BAIRRO DAL_BAIRROS = new DAL.ENDERECOS_BAIRRO();
                DAL.ENDERECOS_TIPO DAL_TIPOS = new DAL.ENDERECOS_TIPO();
                DAL.ENDERECOS_LOGRADOUROS DAL_LOGRADOUROS = new DAL.ENDERECOS_LOGRADOUROS();

                DataSet ds = new DataSet();

                _ufs.UF_SIGLA = lista[0].Uf_sigla;
                _ufs.UF_DESCRICAO = lista[0].Uf_descricao;
                ds = DAL_UFS.FindBy_UF_SIGLA(_ufs.UF_SIGLA);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _ufs.UF_ID = ds.Tables[0].Rows[0].Field<Int32>("UF_ID");
                }
                else
                {
                    _ufs.UF_ID = DAL_UFS.InsertId(_ufs);
                }

                _cidades.CIDADE_DESCRICAO = lista[0].Cidade;
                _cidades.CIDADE_IBGE = lista[0].Codigo_ibge;
                ds = DAL_CIDADES.FindBy_CIDADE_DESCRICAO(_cidades.CIDADE_DESCRICAO);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _cidades.CIDADE_ID = ds.Tables[0].Rows[0].Field<Int32>("CIDADE_ID");
                }
                else
                {
                    _cidades.CIDADE_ID = DAL_CIDADES.InsertId(_cidades);
                }

                _bairros.BAIRRO_DESCRICAO = lista[0].Bairro;
                ds = DAL_BAIRROS.FindBy_BAIRRO_DESCRICAO(_bairros.BAIRRO_DESCRICAO);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _bairros.BAIRRO_ID = ds.Tables[0].Rows[0].Field<Int32>("BAIRRO_ID");
                }
                else
                {
                    _bairros.BAIRRO_ID = DAL_BAIRROS.InsertId(_bairros);
                }

                _tipos.TIPO_DESCRICAO = lista[0].Tipo_logradouro;
                ds = DAL_TIPOS.FindBy_TIPO_DESCRICAO(_tipos.TIPO_DESCRICAO);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _tipos.TIPO_ID = ds.Tables[0].Rows[0].Field<Int32>("TIPO_ID");
                }
                else
                {
                    _tipos.TIPO_ID = DAL_TIPOS.InsertId(_tipos);
                }

                _logradouros.LOGRADOURO_DESCRICAO = lista[0].Logradouro;
                _logradouros.LOGRADOURO_CEP = lista[0].Cep;
                _logradouros.UF_ID = _ufs.UF_ID;
                _logradouros.CIDADE_ID = _cidades.CIDADE_ID;
                _logradouros.BAIRRO_ID = _bairros.BAIRRO_ID;
                _logradouros.TIPO_ID = _tipos.TIPO_ID;
                _logradouros.LOGRADOURO_DESCRICAO = lista[0].Logradouro;

                ds = DAL_LOGRADOUROS.FindBy_LOGRADOURO_DESCRICAO(_logradouros.LOGRADOURO_DESCRICAO);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _logradouros.LOGRADOURO_ID = ds.Tables[0].Rows[0].Field<Int32>("LOGRADOURO_ID");
                }
                else
                {
                    DAL_LOGRADOUROS.Insert(_logradouros);
                }
            }


            return lista;
        }

        public CepService(String _cep) { }
    }
    

}
