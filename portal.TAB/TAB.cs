using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace portal.TAB
{

      /// <summary>
      /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
      /// Criador: Marcos Morais de Sousa
      /// Criada em 16/09/2010
      /// Contato: mmstec@gmail.com
      /// </summary>
      public class AUDITORIAS
      {
            // ATRIBUTOS
            private int _AUDITORIA_ID;
            private DateTime _AUDITORIA_DATA;
            private DateTime _AUDITORIA_HORA;
            private string _AUDITORIA_USUARIO;
            private string _AUDITORIA_PERFIL;
            private string _AUDITORIA_MODULO;
            private StringBuilder _AUDITORIA_ACAO;
            private StringBuilder _AUDITORIA_ANTES;
            private StringBuilder _AUDITORIA_DEPOIS;
            private string _AUDITORIA_TERMINAL;
            private string _AUDITORIA_IP;

            // PROPIEDADES
            public int AUDITORIA_ID
            {
                  get { return _AUDITORIA_ID; }
                  set { _AUDITORIA_ID = value; }
            }
            public DateTime AUDITORIA_DATA
            {
                  get { return _AUDITORIA_DATA; }
                  set { _AUDITORIA_DATA = value; }
            }
            public DateTime AUDITORIA_HORA
            {
                  get { return _AUDITORIA_HORA; }
                  set { _AUDITORIA_HORA = value; }
            }
            public string AUDITORIA_USUARIO
            {
                  get { return _AUDITORIA_USUARIO; }
                  set { _AUDITORIA_USUARIO = value; }
            }
            public string AUDITORIA_PERFIL
            {
                  get { return _AUDITORIA_PERFIL; }
                  set { _AUDITORIA_PERFIL = value; }
            }
            public string AUDITORIA_MODULO
            {
                  get { return _AUDITORIA_MODULO; }
                  set { _AUDITORIA_MODULO = value; }
            }
            public StringBuilder AUDITORIA_ACAO
            {
                  get { return _AUDITORIA_ACAO; }
                  set { _AUDITORIA_ACAO = value; }
            }
            public StringBuilder AUDITORIA_ANTES
            {
                  get { return _AUDITORIA_ANTES; }
                  set { _AUDITORIA_ANTES = value; }
            }
            public StringBuilder AUDITORIA_DEPOIS
            {
                  get { return _AUDITORIA_DEPOIS; }
                  set { _AUDITORIA_DEPOIS = value; }
            }
            public string AUDITORIA_TERMINAL
            {
                  get { return _AUDITORIA_TERMINAL; }
                  set { _AUDITORIA_TERMINAL = value; }
            }
            public string AUDITORIA_IP
            {
                  get { return _AUDITORIA_IP; }
                  set { _AUDITORIA_IP = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class DOWNLOADS
      {
            // ATRIBUTOS
            private int _DOWNLOAD_ID;
            private string _DOWNLOAD_LINK;
            private DateTime _DOWNLOAD_INCLUSAO;
            private string _DOWNLOAD_DESCRICAO;
            private byte _DOWNLOAD_ATIVO;

            // PROPIEDADES
            public int DOWNLOAD_ID
            {
                  get { return _DOWNLOAD_ID; }
                  set { _DOWNLOAD_ID = value; }
            }
            public string DOWNLOAD_LINK
            {
                  get { return _DOWNLOAD_LINK; }
                  set { _DOWNLOAD_LINK = value; }
            }
            public DateTime DOWNLOAD_INCLUSAO
            {
                  get { return _DOWNLOAD_INCLUSAO; }
                  set { _DOWNLOAD_INCLUSAO = value; }
            }
            public string DOWNLOAD_DESCRICAO
            {
                  get { return _DOWNLOAD_DESCRICAO; }
                  set { _DOWNLOAD_DESCRICAO = value; }
            }
            public byte DOWNLOAD_ATIVO
            {
                  get { return _DOWNLOAD_ATIVO; }
                  set { _DOWNLOAD_ATIVO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class EMPRESAS
      {
            // ATRIBUTOS
            private int _EMPRESA_ID;
            private string _EMPRESA_CODIGO;
            private string _EMPRESA_NOME_FANTASIA;
            private string _EMPRESA_NOME_RAZAO;
            private string _EMPRESA_CONTATO;
            private string _EMPRESA_ENDERECO;
            private string _EMPRESA_ENDERECO_NR;
            private string _EMPRESA_BAIRRO;
            private string _EMPRESA_UF;
            private string _EMPRESA_CNPJ;
            private string _EMPRESA_IE;
            private string _EMPRESA_WEB;
            private DateTime _EMPRESA_INCLUSAO;
            private DateTime _EMPRESA_EXPIRA;
            private string _EMPRESA_VESAO;
            private byte _EMPRESA_ATIVA;

            // PROPIEDADES
            public int EMPRESA_ID
            {
                  get { return _EMPRESA_ID; }
                  set { _EMPRESA_ID = value; }
            }
            public string EMPRESA_CODIGO
            {
                  get { return _EMPRESA_CODIGO; }
                  set { _EMPRESA_CODIGO = value; }
            }
            public string EMPRESA_NOME_FANTASIA
            {
                  get { return _EMPRESA_NOME_FANTASIA; }
                  set { _EMPRESA_NOME_FANTASIA = value; }
            }
            public string EMPRESA_NOME_RAZAO
            {
                  get { return _EMPRESA_NOME_RAZAO; }
                  set { _EMPRESA_NOME_RAZAO = value; }
            }
            public string EMPRESA_CONTATO
            {
                  get { return _EMPRESA_CONTATO; }
                  set { _EMPRESA_CONTATO = value; }
            }
            public string EMPRESA_ENDERECO
            {
                  get { return _EMPRESA_ENDERECO; }
                  set { _EMPRESA_ENDERECO = value; }
            }
            public string EMPRESA_ENDERECO_NR
            {
                  get { return _EMPRESA_ENDERECO_NR; }
                  set { _EMPRESA_ENDERECO_NR = value; }
            }
            public string EMPRESA_BAIRRO
            {
                  get { return _EMPRESA_BAIRRO; }
                  set { _EMPRESA_BAIRRO = value; }
            }
            public string EMPRESA_UF
            {
                  get { return _EMPRESA_UF; }
                  set { _EMPRESA_UF = value; }
            }
            public string EMPRESA_CNPJ
            {
                  get { return _EMPRESA_CNPJ; }
                  set { _EMPRESA_CNPJ = value; }
            }
            public string EMPRESA_IE
            {
                  get { return _EMPRESA_IE; }
                  set { _EMPRESA_IE = value; }
            }
            public string EMPRESA_WEB
            {
                  get { return _EMPRESA_WEB; }
                  set { _EMPRESA_WEB = value; }
            }
            public DateTime EMPRESA_INCLUSAO
            {
                  get { return _EMPRESA_INCLUSAO; }
                  set { _EMPRESA_INCLUSAO = value; }
            }
            public DateTime EMPRESA_EXPIRA
            {
                  get { return _EMPRESA_EXPIRA; }
                  set { _EMPRESA_EXPIRA = value; }
            }
            public string EMPRESA_VESAO
            {
                  get { return _EMPRESA_VESAO; }
                  set { _EMPRESA_VESAO = value; }
            }
            public byte EMPRESA_ATIVA
            {
                  get { return _EMPRESA_ATIVA; }
                  set { _EMPRESA_ATIVA = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class ENDERECOS_BAIRRO
      {
            // ATRIBUTOS
            private int _BAIRRO_ID;
            private string _BAIRRO_DESCRICAO;

            // PROPIEDADES
            public int BAIRRO_ID
            {
                  get { return _BAIRRO_ID; }
                  set { _BAIRRO_ID = value; }
            }
            public string BAIRRO_DESCRICAO
            {
                  get { return _BAIRRO_DESCRICAO; }
                  set { _BAIRRO_DESCRICAO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class ENDERECOS_CIDADES
      {
            // ATRIBUTOS
            private int _CIDADE_ID;
            private string _CIDADE_DESCRICAO;
            private string _CIDADE_IBGE;

            // PROPIEDADES
            public int CIDADE_ID
            {
                  get { return _CIDADE_ID; }
                  set { _CIDADE_ID = value; }
            }
            public string CIDADE_DESCRICAO
            {
                  get { return _CIDADE_DESCRICAO; }
                  set { _CIDADE_DESCRICAO = value; }
            }
            public string CIDADE_IBGE
            {
                  get { return _CIDADE_IBGE; }
                  set { _CIDADE_IBGE = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class ENDERECOS_LOGRADOUROS
      {
            // ATRIBUTOS
            private int _LOGRADOURO_ID;
            private string _LOGRADOURO_DESCRICAO;
            private string _LOGRADOURO_CEP;
            private int _TIPO_ID;
            private int _BAIRRO_ID;
            private int _CIDADE_ID;
            private int _UF_ID;

            // PROPIEDADES
            public int LOGRADOURO_ID
            {
                  get { return _LOGRADOURO_ID; }
                  set { _LOGRADOURO_ID = value; }
            }
            public string LOGRADOURO_DESCRICAO
            {
                  get { return _LOGRADOURO_DESCRICAO; }
                  set { _LOGRADOURO_DESCRICAO = value; }
            }
            public string LOGRADOURO_CEP
            {
                  get { return _LOGRADOURO_CEP; }
                  set { _LOGRADOURO_CEP = value; }
            }
            public int TIPO_ID
            {
                  get { return _TIPO_ID; }
                  set { _TIPO_ID = value; }
            }
            public int BAIRRO_ID
            {
                  get { return _BAIRRO_ID; }
                  set { _BAIRRO_ID = value; }
            }
            public int CIDADE_ID
            {
                  get { return _CIDADE_ID; }
                  set { _CIDADE_ID = value; }
            }
            public int UF_ID
            {
                  get { return _UF_ID; }
                  set { _UF_ID = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class ENDERECOS_TIPO
      {
            // ATRIBUTOS
            private int _TIPO_ID;
            private string _TIPO_DESCRICAO;

            // PROPIEDADES
            public int TIPO_ID
            {
                  get { return _TIPO_ID; }
                  set { _TIPO_ID = value; }
            }
            public string TIPO_DESCRICAO
            {
                  get { return _TIPO_DESCRICAO; }
                  set { _TIPO_DESCRICAO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class ENDERECOS_UF
      {
            // ATRIBUTOS
            private int _UF_ID;
            private string _UF_SIGLA;
            private string _UF_DESCRICAO;

            // PROPIEDADES
            public int UF_ID
            {
                  get { return _UF_ID; }
                  set { _UF_ID = value; }
            }
            public string UF_SIGLA
            {
                  get { return _UF_SIGLA; }
                  set { _UF_SIGLA = value; }
            }
            public string UF_DESCRICAO
            {
                  get { return _UF_DESCRICAO; }
                  set { _UF_DESCRICAO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class FAVORITOS
      {
            // ATRIBUTOS
            private int _FAVORITO_ID;
            private string _FAVORITO_LINK;
            private DateTime _FAVORITO_INCLUSAO;
            private string _FAVORITO_DESCRICAO;
            private byte _FAVORITO_ATIVO;

            // PROPIEDADES
            public int FAVORITO_ID
            {
                  get { return _FAVORITO_ID; }
                  set { _FAVORITO_ID = value; }
            }
            public string FAVORITO_LINK
            {
                  get { return _FAVORITO_LINK; }
                  set { _FAVORITO_LINK = value; }
            }
            public DateTime FAVORITO_INCLUSAO
            {
                  get { return _FAVORITO_INCLUSAO; }
                  set { _FAVORITO_INCLUSAO = value; }
            }
            public string FAVORITO_DESCRICAO
            {
                  get { return _FAVORITO_DESCRICAO; }
                  set { _FAVORITO_DESCRICAO = value; }
            }
            public byte FAVORITO_ATIVO
            {
                  get { return _FAVORITO_ATIVO; }
                  set { _FAVORITO_ATIVO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class FERIADOS
      {
            // ATRIBUTOS
            private int _FERIADO_ID;
            private DateTime _FERIADO_DATA;
            private string _FERIADO_DESCRICAO;
            private byte _FERIADO_FIXO;
            private int _FERIADO_GRUPO;

            // PROPIEDADES
            public int FERIADO_ID
            {
                  get { return _FERIADO_ID; }
                  set { _FERIADO_ID = value; }
            }
            public DateTime FERIADO_DATA
            {
                  get { return _FERIADO_DATA; }
                  set { _FERIADO_DATA = value; }
            }
            public string FERIADO_DESCRICAO
            {
                  get { return _FERIADO_DESCRICAO; }
                  set { _FERIADO_DESCRICAO = value; }
            }
            public byte FERIADO_FIXO
            {
                  get { return _FERIADO_FIXO; }
                  set { _FERIADO_FIXO = value; }
            }
            public int FERIADO_GRUPO
            {
                  get { return _FERIADO_GRUPO; }
                  set { _FERIADO_GRUPO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class FUNCIONARIOS
      {
            // ATRIBUTOS
            private int _funcionarioID;
            private int _funcionarioEmpresaID;
            private string _funcionarioNOME;
            private string _funcionarioEndereco;
            private string _funcionarioBairro;
            private string _funcionarioCidade;
            private string _funcionarioEstado;
            private string _funcionarioCep;
            private string _funcionarioTelefone;
            private string _funcionarioCelular;
            private string _funcionarioEMail;
            private string _funcionarioIdentidade;
            private string _funcionarioCPF;
            private DateTime _funcionarioNascimento;
            private string _funcionarioCargo;
            private float _funcionarioSalario;
            private DateTime _funcionarioAdmissao;
            private Int32 _funcionarioDiaPagamento;
            private Byte _funcionarioFoto;
            private StringBuilder _funcionarioOBS;
            private byte _funcionarioInativo;
            private string _funcionarioCBO;
            private int _funcionarioSetor;

            // PROPIEDADES
            public int funcionarioID
            {
                  get { return _funcionarioID; }
                  set { _funcionarioID = value; }
            }
            public int funcionarioEmpresaID
            {
                  get { return _funcionarioEmpresaID; }
                  set { _funcionarioEmpresaID = value; }
            }
            public string funcionarioNOME
            {
                  get { return _funcionarioNOME; }
                  set { _funcionarioNOME = value; }
            }
            public string funcionarioEndereco
            {
                  get { return _funcionarioEndereco; }
                  set { _funcionarioEndereco = value; }
            }
            public string funcionarioBairro
            {
                  get { return _funcionarioBairro; }
                  set { _funcionarioBairro = value; }
            }
            public string funcionarioCidade
            {
                  get { return _funcionarioCidade; }
                  set { _funcionarioCidade = value; }
            }
            public string funcionarioEstado
            {
                  get { return _funcionarioEstado; }
                  set { _funcionarioEstado = value; }
            }
            public string funcionarioCep
            {
                  get { return _funcionarioCep; }
                  set { _funcionarioCep = value; }
            }
            public string funcionarioTelefone
            {
                  get { return _funcionarioTelefone; }
                  set { _funcionarioTelefone = value; }
            }
            public string funcionarioCelular
            {
                  get { return _funcionarioCelular; }
                  set { _funcionarioCelular = value; }
            }
            public string funcionarioEMail
            {
                  get { return _funcionarioEMail; }
                  set { _funcionarioEMail = value; }
            }
            public string funcionarioIdentidade
            {
                  get { return _funcionarioIdentidade; }
                  set { _funcionarioIdentidade = value; }
            }
            public string funcionarioCPF
            {
                  get { return _funcionarioCPF; }
                  set { _funcionarioCPF = value; }
            }
            public DateTime funcionarioNascimento
            {
                  get { return _funcionarioNascimento; }
                  set { _funcionarioNascimento = value; }
            }
            public string funcionarioCargo
            {
                  get { return _funcionarioCargo; }
                  set { _funcionarioCargo = value; }
            }
            public float funcionarioSalario
            {
                  get { return _funcionarioSalario; }
                  set { _funcionarioSalario = value; }
            }
            public DateTime funcionarioAdmissao
            {
                  get { return _funcionarioAdmissao; }
                  set { _funcionarioAdmissao = value; }
            }
            public Int32 funcionarioDiaPagamento
            {
                  get { return _funcionarioDiaPagamento; }
                  set { _funcionarioDiaPagamento = value; }
            }
            public Byte funcionarioFoto
            {
                  get { return _funcionarioFoto; }
                  set { _funcionarioFoto = value; }
            }
            public StringBuilder funcionarioOBS
            {
                  get { return _funcionarioOBS; }
                  set { _funcionarioOBS = value; }
            }
            public byte funcionarioInativo
            {
                  get { return _funcionarioInativo; }
                  set { _funcionarioInativo = value; }
            }
            public string funcionarioCBO
            {
                  get { return _funcionarioCBO; }
                  set { _funcionarioCBO = value; }
            }
            public int funcionarioSetor
            {
                  get { return _funcionarioSetor; }
                  set { _funcionarioSetor = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class MENU
      {
            // ATRIBUTOS
            private int _MENU_ID;
            private string _MENU_NOME;
            private string _MENU_DESCRICAO;
            private int _MENU_PAI;
            private string _MENU_LINK;

            // PROPIEDADES
            public int MENU_ID
            {
                  get { return _MENU_ID; }
                  set { _MENU_ID = value; }
            }
            public string MENU_NOME
            {
                  get { return _MENU_NOME; }
                  set { _MENU_NOME = value; }
            }
            public string MENU_DESCRICAO
            {
                  get { return _MENU_DESCRICAO; }
                  set { _MENU_DESCRICAO = value; }
            }
            public int MENU_PAI
            {
                  get { return _MENU_PAI; }
                  set { _MENU_PAI = value; }
            }
            public string MENU_LINK
            {
                  get { return _MENU_LINK; }
                  set { _MENU_LINK = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class PESSOAS
      {
            // ATRIBUTOS
            private int _PESSOA_ID;
            private string _PESSOA_CODIGO;
            private string _PESSOA_NOME;
            private string _PESSOA_ENDERECO;
            private string _PESSOA_ENDERECO_NR;
            private string _PESSOA_BAIRRO;
            private string _PESSOA_CIDADE;
            private string _PESSOA_ESTADO;
            private string _PESSOA_CEP;
            private string _PESSOA_TELEFONE;
            private string _PESSOA_EMAIL;
            private string _PESSOA_WEB;
            private DateTime _PESSOA_NASCIMENTO;
            private float _PESSOA_RENDA;
            private DateTime _PESSOA_INCLUSAO;
            private byte _PESSOA_TAG_CLIENTE;
            private byte _PESSOA_TAG_EMPRESA;

            // PROPIEDADES
            public int PESSOA_ID
            {
                  get { return _PESSOA_ID; }
                  set { _PESSOA_ID = value; }
            }
            public string PESSOA_CODIGO
            {
                  get { return _PESSOA_CODIGO; }
                  set { _PESSOA_CODIGO = value; }
            }
            public string PESSOA_NOME
            {
                  get { return _PESSOA_NOME; }
                  set { _PESSOA_NOME = value; }
            }
            public string PESSOA_ENDERECO
            {
                  get { return _PESSOA_ENDERECO; }
                  set { _PESSOA_ENDERECO = value; }
            }
            public string PESSOA_ENDERECO_NR
            {
                  get { return _PESSOA_ENDERECO_NR; }
                  set { _PESSOA_ENDERECO_NR = value; }
            }
            public string PESSOA_BAIRRO
            {
                  get { return _PESSOA_BAIRRO; }
                  set { _PESSOA_BAIRRO = value; }
            }
            public string PESSOA_CIDADE
            {
                  get { return _PESSOA_CIDADE; }
                  set { _PESSOA_CIDADE = value; }
            }
            public string PESSOA_ESTADO
            {
                  get { return _PESSOA_ESTADO; }
                  set { _PESSOA_ESTADO = value; }
            }
            public string PESSOA_CEP
            {
                  get { return _PESSOA_CEP; }
                  set { _PESSOA_CEP = value; }
            }
            public string PESSOA_TELEFONE
            {
                  get { return _PESSOA_TELEFONE; }
                  set { _PESSOA_TELEFONE = value; }
            }
            public string PESSOA_EMAIL
            {
                  get { return _PESSOA_EMAIL; }
                  set { _PESSOA_EMAIL = value; }
            }
            public string PESSOA_WEB
            {
                  get { return _PESSOA_WEB; }
                  set { _PESSOA_WEB = value; }
            }
            public DateTime PESSOA_NASCIMENTO
            {
                  get { return _PESSOA_NASCIMENTO; }
                  set { _PESSOA_NASCIMENTO = value; }
            }
            public float PESSOA_RENDA
            {
                  get { return _PESSOA_RENDA; }
                  set { _PESSOA_RENDA = value; }
            }
            public DateTime PESSOA_INCLUSAO
            {
                  get { return _PESSOA_INCLUSAO; }
                  set { _PESSOA_INCLUSAO = value; }
            }
            public byte PESSOA_TAG_CLIENTE
            {
                  get { return _PESSOA_TAG_CLIENTE; }
                  set { _PESSOA_TAG_CLIENTE = value; }
            }
            public byte PESSOA_TAG_EMPRESA
            {
                  get { return _PESSOA_TAG_EMPRESA; }
                  set { _PESSOA_TAG_EMPRESA = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class PESSOAS_CLIENTE
      {
            // ATRIBUTOS
            private int _PESSOA_ID;
            private float _PESSOA_CLIENTE_LIMITECRED;
            private byte _PESSOA_CLIENTE_ATIVO;

            // PROPIEDADES
            public int PESSOA_ID
            {
                  get { return _PESSOA_ID; }
                  set { _PESSOA_ID = value; }
            }
            public float PESSOA_CLIENTE_LIMITECRED
            {
                  get { return _PESSOA_CLIENTE_LIMITECRED; }
                  set { _PESSOA_CLIENTE_LIMITECRED = value; }
            }
            public byte PESSOA_CLIENTE_ATIVO
            {
                  get { return _PESSOA_CLIENTE_ATIVO; }
                  set { _PESSOA_CLIENTE_ATIVO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class PESSOAS_FISICA
      {
            // ATRIBUTOS
            private int _PESSOA_ID;
            private string _PESSOA_FISICA_CELULAR;
            private string _PESSOA_FISICA_CPF;
            private string _PESSOA_FISICA_RG;
            private string _PESSOA_FISICA_EMPRESA;
            private string _PESSOA_FISICA_CARGO;
            private int _PESSOA_FISICA_SETOR;
            private DateTime _PESSOA_FISICA_ADMISSAO;
            private Int32 _PESSOA_FISICA_DIAPG;
            private Byte _PESSOA_FISICA_FOTO;
            private DateTime _PESSOA_FISICA_ENTRADA;
            private DateTime _PESSOA_FISICA_SAIDA;
            private DateTime _PESSOA_FISICA_ALMOCOINICIO;
            private DateTime _PESSOA_FISICA_ALMOCOFIM;
            private StringBuilder _PESSOA_FISICA_OBS;
            private string _PESSOA_FISICA_FILIACAO_PAI;
            private string _PESSOA_FISICA_FILIACAO_MAE;
            private byte _PESSOA_FISICA_FUNCIONARIO;
            private DateTime _PESSOA_FISICA_FUNCIONARIO_DEMISSAO;
            private byte _PESSOA_FISICA_FUNCIONARIO_ATIVO;

            // PROPIEDADES
            public int PESSOA_ID
            {
                  get { return _PESSOA_ID; }
                  set { _PESSOA_ID = value; }
            }
            public string PESSOA_FISICA_CELULAR
            {
                  get { return _PESSOA_FISICA_CELULAR; }
                  set { _PESSOA_FISICA_CELULAR = value; }
            }
            public string PESSOA_FISICA_CPF
            {
                  get { return _PESSOA_FISICA_CPF; }
                  set { _PESSOA_FISICA_CPF = value; }
            }
            public string PESSOA_FISICA_RG
            {
                  get { return _PESSOA_FISICA_RG; }
                  set { _PESSOA_FISICA_RG = value; }
            }
            public string PESSOA_FISICA_EMPRESA
            {
                  get { return _PESSOA_FISICA_EMPRESA; }
                  set { _PESSOA_FISICA_EMPRESA = value; }
            }
            public string PESSOA_FISICA_CARGO
            {
                  get { return _PESSOA_FISICA_CARGO; }
                  set { _PESSOA_FISICA_CARGO = value; }
            }
            public int PESSOA_FISICA_SETOR
            {
                  get { return _PESSOA_FISICA_SETOR; }
                  set { _PESSOA_FISICA_SETOR = value; }
            }
            public DateTime PESSOA_FISICA_ADMISSAO
            {
                  get { return _PESSOA_FISICA_ADMISSAO; }
                  set { _PESSOA_FISICA_ADMISSAO = value; }
            }
            public Int32 PESSOA_FISICA_DIAPG
            {
                  get { return _PESSOA_FISICA_DIAPG; }
                  set { _PESSOA_FISICA_DIAPG = value; }
            }
            public Byte PESSOA_FISICA_FOTO
            {
                  get { return _PESSOA_FISICA_FOTO; }
                  set { _PESSOA_FISICA_FOTO = value; }
            }
            public DateTime PESSOA_FISICA_ENTRADA
            {
                  get { return _PESSOA_FISICA_ENTRADA; }
                  set { _PESSOA_FISICA_ENTRADA = value; }
            }
            public DateTime PESSOA_FISICA_SAIDA
            {
                  get { return _PESSOA_FISICA_SAIDA; }
                  set { _PESSOA_FISICA_SAIDA = value; }
            }
            public DateTime PESSOA_FISICA_ALMOCOINICIO
            {
                  get { return _PESSOA_FISICA_ALMOCOINICIO; }
                  set { _PESSOA_FISICA_ALMOCOINICIO = value; }
            }
            public DateTime PESSOA_FISICA_ALMOCOFIM
            {
                  get { return _PESSOA_FISICA_ALMOCOFIM; }
                  set { _PESSOA_FISICA_ALMOCOFIM = value; }
            }
            public StringBuilder PESSOA_FISICA_OBS
            {
                  get { return _PESSOA_FISICA_OBS; }
                  set { _PESSOA_FISICA_OBS = value; }
            }
            public string PESSOA_FISICA_FILIACAO_PAI
            {
                  get { return _PESSOA_FISICA_FILIACAO_PAI; }
                  set { _PESSOA_FISICA_FILIACAO_PAI = value; }
            }
            public string PESSOA_FISICA_FILIACAO_MAE
            {
                  get { return _PESSOA_FISICA_FILIACAO_MAE; }
                  set { _PESSOA_FISICA_FILIACAO_MAE = value; }
            }
            public byte PESSOA_FISICA_FUNCIONARIO
            {
                  get { return _PESSOA_FISICA_FUNCIONARIO; }
                  set { _PESSOA_FISICA_FUNCIONARIO = value; }
            }
            public DateTime PESSOA_FISICA_FUNCIONARIO_DEMISSAO
            {
                  get { return _PESSOA_FISICA_FUNCIONARIO_DEMISSAO; }
                  set { _PESSOA_FISICA_FUNCIONARIO_DEMISSAO = value; }
            }
            public byte PESSOA_FISICA_FUNCIONARIO_ATIVO
            {
                  get { return _PESSOA_FISICA_FUNCIONARIO_ATIVO; }
                  set { _PESSOA_FISICA_FUNCIONARIO_ATIVO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class PESSOAS_JURIDICA
      {
            // ATRIBUTOS
            private int _PESSOA_ID;
            private string _PESSOA_JURIDICA_RAZAO;
            private string _PESSOA_JURIDICA_CNPJ;
            private string _PESSOA_JURIDICA_IE;
            private string _PESSOA_JURIDICA_FAX;
            private StringBuilder _PESSOA_JURIDICA_OBS;
            private string _PESSOA_JURIDICA_ATIVIDADE;
            private byte _PESSOA_JURIDICA_FORNECEDOR;
            private byte _PESSOA_JURIDICA_FORNCEDOR_ATIVO;

            // PROPIEDADES
            public int PESSOA_ID
            {
                  get { return _PESSOA_ID; }
                  set { _PESSOA_ID = value; }
            }
            public string PESSOA_JURIDICA_RAZAO
            {
                  get { return _PESSOA_JURIDICA_RAZAO; }
                  set { _PESSOA_JURIDICA_RAZAO = value; }
            }
            public string PESSOA_JURIDICA_CNPJ
            {
                  get { return _PESSOA_JURIDICA_CNPJ; }
                  set { _PESSOA_JURIDICA_CNPJ = value; }
            }
            public string PESSOA_JURIDICA_IE
            {
                  get { return _PESSOA_JURIDICA_IE; }
                  set { _PESSOA_JURIDICA_IE = value; }
            }
            public string PESSOA_JURIDICA_FAX
            {
                  get { return _PESSOA_JURIDICA_FAX; }
                  set { _PESSOA_JURIDICA_FAX = value; }
            }
            public StringBuilder PESSOA_JURIDICA_OBS
            {
                  get { return _PESSOA_JURIDICA_OBS; }
                  set { _PESSOA_JURIDICA_OBS = value; }
            }
            public string PESSOA_JURIDICA_ATIVIDADE
            {
                  get { return _PESSOA_JURIDICA_ATIVIDADE; }
                  set { _PESSOA_JURIDICA_ATIVIDADE = value; }
            }
            public byte PESSOA_JURIDICA_FORNECEDOR
            {
                  get { return _PESSOA_JURIDICA_FORNECEDOR; }
                  set { _PESSOA_JURIDICA_FORNECEDOR = value; }
            }
            public byte PESSOA_JURIDICA_FORNCEDOR_ATIVO
            {
                  get { return _PESSOA_JURIDICA_FORNCEDOR_ATIVO; }
                  set { _PESSOA_JURIDICA_FORNCEDOR_ATIVO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class SISTEMAS
      {
            // ATRIBUTOS
            private int _SISTEMA_ID;
            private string _SISTEMA_LINK;
            private DateTime _SISTEMA_INCLUSAO;
            private string _SISTEMA_DESCRICAO;
            private byte _SISTEMA_ATIVO;

            // PROPIEDADES
            public int SISTEMA_ID
            {
                  get { return _SISTEMA_ID; }
                  set { _SISTEMA_ID = value; }
            }
            public string SISTEMA_LINK
            {
                  get { return _SISTEMA_LINK; }
                  set { _SISTEMA_LINK = value; }
            }
            public DateTime SISTEMA_INCLUSAO
            {
                  get { return _SISTEMA_INCLUSAO; }
                  set { _SISTEMA_INCLUSAO = value; }
            }
            public string SISTEMA_DESCRICAO
            {
                  get { return _SISTEMA_DESCRICAO; }
                  set { _SISTEMA_DESCRICAO = value; }
            }
            public byte SISTEMA_ATIVO
            {
                  get { return _SISTEMA_ATIVO; }
                  set { _SISTEMA_ATIVO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class SOLICITACOES
      {
            // ATRIBUTOS
            private int _SOLICITACAO_ID;
            private string _SOLICITACAO_REMETENTE_NOME;
            private string _SOLICITACAO_REMETENTE_EMAIL;
            private string _SOLICITACAO_ASSUNTO;
            private string _SOLICITACAO_DESCRICAO;
            private DateTime _SOLICITACAO_INCLUSAO;
            private byte _SOLICITACAO_SITUACAO;
            private string _SOLICITACAO_DESTINATARIO_EMAIL;
            private DateTime _SOLICITACAO_CONCLUSAO;
            private string _SOLICITACAO_OBSERVACAO;

            // PROPIEDADES
            public int SOLICITACAO_ID
            {
                  get { return _SOLICITACAO_ID; }
                  set { _SOLICITACAO_ID = value; }
            }
            public string SOLICITACAO_REMETENTE_NOME
            {
                  get { return _SOLICITACAO_REMETENTE_NOME; }
                  set { _SOLICITACAO_REMETENTE_NOME = value; }
            }
            public string SOLICITACAO_REMETENTE_EMAIL
            {
                  get { return _SOLICITACAO_REMETENTE_EMAIL; }
                  set { _SOLICITACAO_REMETENTE_EMAIL = value; }
            }
            public string SOLICITACAO_ASSUNTO
            {
                  get { return _SOLICITACAO_ASSUNTO; }
                  set { _SOLICITACAO_ASSUNTO = value; }
            }
            public string SOLICITACAO_DESCRICAO
            {
                  get { return _SOLICITACAO_DESCRICAO; }
                  set { _SOLICITACAO_DESCRICAO = value; }
            }
            public DateTime SOLICITACAO_INCLUSAO
            {
                  get { return _SOLICITACAO_INCLUSAO; }
                  set { _SOLICITACAO_INCLUSAO = value; }
            }
            public byte SOLICITACAO_SITUACAO
            {
                  get { return _SOLICITACAO_SITUACAO; }
                  set { _SOLICITACAO_SITUACAO = value; }
            }
            public string SOLICITACAO_DESTINATARIO_EMAIL
            {
                  get { return _SOLICITACAO_DESTINATARIO_EMAIL; }
                  set { _SOLICITACAO_DESTINATARIO_EMAIL = value; }
            }
            public DateTime SOLICITACAO_CONCLUSAO
            {
                  get { return _SOLICITACAO_CONCLUSAO; }
                  set { _SOLICITACAO_CONCLUSAO = value; }
            }
            public string SOLICITACAO_OBSERVACAO
            {
                  get { return _SOLICITACAO_OBSERVACAO; }
                  set { _SOLICITACAO_OBSERVACAO = value; }
            }
      }

  /// <summary>
  /// Classe DAL<MODELOS>: Data Access Logic <Tabelas>
  /// Criador: Marcos Morais de Sousa
  /// Criada em 16/09/2010
  /// Contato: mmstec@gmail.com
  /// </summary>
      public class SUPORTES
      {
            // ATRIBUTOS
            private int _SUPORTE_ID;
            private string _SUPORTE_LINK;
            private DateTime _SUPORTE_INCLUSAO;
            private string _SUPORTE_DESCRICAO;
            private byte _SUPORTE_ATIVO;

            // PROPIEDADES
            public int SUPORTE_ID
            {
                  get { return _SUPORTE_ID; }
                  set { _SUPORTE_ID = value; }
            }
            public string SUPORTE_LINK
            {
                  get { return _SUPORTE_LINK; }
                  set { _SUPORTE_LINK = value; }
            }
            public DateTime SUPORTE_INCLUSAO
            {
                  get { return _SUPORTE_INCLUSAO; }
                  set { _SUPORTE_INCLUSAO = value; }
            }
            public string SUPORTE_DESCRICAO
            {
                  get { return _SUPORTE_DESCRICAO; }
                  set { _SUPORTE_DESCRICAO = value; }
            }
            public byte SUPORTE_ATIVO
            {
                  get { return _SUPORTE_ATIVO; }
                  set { _SUPORTE_ATIVO = value; }
            }
      }
}
