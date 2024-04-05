using System;
using System.Collections.Generic;
using System.Text;

namespace portalVO
{

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class AUDITORIAVO
    {
        // Atributos
        private int _auditoriaID;
        private int _auditoriaEmpresaID;
        private DateTime _auditoriaData;
        private DateTime _auditoriaInicio;
        private DateTime _auditoriaFim;
        private string _auditoriaUsuario;
        private string _auditoriaPerfil;
        private StringBuilder _auditoriaAcoes;
        private string _auditoriaTerminal;
        private string _auditoriaIP;

        // Propriedades
        public int auditoriaID
        {
            get { return _auditoriaID; }
            set { _auditoriaID = value; }
        }
        public int auditoriaEmpresaID
        {
            get { return _auditoriaEmpresaID; }
            set { _auditoriaEmpresaID = value; }
        }
        public DateTime auditoriaData
        {
            get { return _auditoriaData; }
            set { _auditoriaData = value; }
        }
        public DateTime auditoriaInicio
        {
            get { return _auditoriaInicio; }
            set { _auditoriaInicio = value; }
        }
        public DateTime auditoriaFim
        {
            get { return _auditoriaFim; }
            set { _auditoriaFim = value; }
        }
        public string auditoriaUsuario
        {
            get { return _auditoriaUsuario; }
            set { _auditoriaUsuario = value; }
        }
        public string auditoriaPerfil
        {
            get { return _auditoriaPerfil; }
            set { _auditoriaPerfil = value; }
        }
        public StringBuilder auditoriaAcoes
        {
            get { return _auditoriaAcoes; }
            set { _auditoriaAcoes = value; }
        }
        public string auditoriaTerminal
        {
            get { return _auditoriaTerminal; }
            set { _auditoriaTerminal = value; }
        }
        public string auditoriaIP
        {
            get { return _auditoriaIP; }
            set { _auditoriaIP = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class BAIRROVO
    {
        // Atributos
        private int _CIDADE_CODIGO;
        private int _BAIRRO_CODIGO;
        private string _BAIRRO_DESCRICAO;

        // Propriedades
        public int CIDADE_CODIGO
        {
            get { return _CIDADE_CODIGO; }
            set { _CIDADE_CODIGO = value; }
        }
        public int BAIRRO_CODIGO
        {
            get { return _BAIRRO_CODIGO; }
            set { _BAIRRO_CODIGO = value; }
        }
        public string BAIRRO_DESCRICAO
        {
            get { return _BAIRRO_DESCRICAO; }
            set { _BAIRRO_DESCRICAO = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class CIDADEVO
    {
        // Atributos
        private int _UF_CODIGO;
        private int _CIDADE_CODIGO;
        private string _CIDADE_DESCRICAO;
        private string _CIDADE_CEP;

        // Propriedades
        public int UF_CODIGO
        {
            get { return _UF_CODIGO; }
            set { _UF_CODIGO = value; }
        }
        public int CIDADE_CODIGO
        {
            get { return _CIDADE_CODIGO; }
            set { _CIDADE_CODIGO = value; }
        }
        public string CIDADE_DESCRICAO
        {
            get { return _CIDADE_DESCRICAO; }
            set { _CIDADE_DESCRICAO = value; }
        }
        public string CIDADE_CEP
        {
            get { return _CIDADE_CEP; }
            set { _CIDADE_CEP = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class DOWNLOADSVO
    {
        // Atributos
        private int _downloadID;
        private int _downloadEmpresaID;
        private string _downloadLocal;
        private DateTime _downloadDataCadastro;
        private string _downloadNome;

        // Propriedades
        public int downloadID
        {
            get { return _downloadID; }
            set { _downloadID = value; }
        }
        public int downloadEmpresaID
        {
            get { return _downloadEmpresaID; }
            set { _downloadEmpresaID = value; }
        }
        public string downloadLocal
        {
            get { return _downloadLocal; }
            set { _downloadLocal = value; }
        }
        public DateTime downloadDataCadastro
        {
            get { return _downloadDataCadastro; }
            set { _downloadDataCadastro = value; }
        }
        public string downloadNome
        {
            get { return _downloadNome; }
            set { _downloadNome = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class EMPRESASVO
    {
        // Atributos
        private int _empresasID;
        private string _empresasNomeFantasia;
        private string _empresasNomeSocial;
        private string _empresasContato;
        private string _empresasEndereco;
        private string _empresasEnderecoNr;
        private string _empresasBairro;
        private string _empresasEstado;
        private string _empresasCNPJ;
        private string _empresasIE;
        private string _empresasURL;
        private int _empresasUsuarios;
        private DateTime _empresasDataCadastro;
        private DateTime _empresasDataLimite;
        private string _empresasVersao;
        private byte _empresasLiberada;

        // Propriedades
        public int empresasID
        {
            get { return _empresasID; }
            set { _empresasID = value; }
        }
        public string empresasNomeFantasia
        {
            get { return _empresasNomeFantasia; }
            set { _empresasNomeFantasia = value; }
        }
        public string empresasNomeSocial
        {
            get { return _empresasNomeSocial; }
            set { _empresasNomeSocial = value; }
        }
        public string empresasContato
        {
            get { return _empresasContato; }
            set { _empresasContato = value; }
        }
        public string empresasEndereco
        {
            get { return _empresasEndereco; }
            set { _empresasEndereco = value; }
        }
        public string empresasEnderecoNr
        {
            get { return _empresasEnderecoNr; }
            set { _empresasEnderecoNr = value; }
        }
        public string empresasBairro
        {
            get { return _empresasBairro; }
            set { _empresasBairro = value; }
        }
        public string empresasEstado
        {
            get { return _empresasEstado; }
            set { _empresasEstado = value; }
        }
        public string empresasCNPJ
        {
            get { return _empresasCNPJ; }
            set { _empresasCNPJ = value; }
        }
        public string empresasIE
        {
            get { return _empresasIE; }
            set { _empresasIE = value; }
        }
        public string empresasURL
        {
            get { return _empresasURL; }
            set { _empresasURL = value; }
        }
        public int empresasUsuarios
        {
            get { return _empresasUsuarios; }
            set { _empresasUsuarios = value; }
        }
        public DateTime empresasDataCadastro
        {
            get { return _empresasDataCadastro; }
            set { _empresasDataCadastro = value; }
        }
        public DateTime empresasDataLimite
        {
            get { return _empresasDataLimite; }
            set { _empresasDataLimite = value; }
        }
        public string empresasVersao
        {
            get { return _empresasVersao; }
            set { _empresasVersao = value; }
        }
        public byte empresasLiberada
        {
            get { return _empresasLiberada; }
            set { _empresasLiberada = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class ENDERECOVO
    {
        // Atributos
        private int _BAIRRO_CODIGO;
        private int _ENDERECO_CODIGO;
        private string _ENDERECO_CEP;
        private string _ENDERECO_LOGRADOURO;
        private string _ENDERECO_COMPLEMENTO;

        // Propriedades
        public int BAIRRO_CODIGO
        {
            get { return _BAIRRO_CODIGO; }
            set { _BAIRRO_CODIGO = value; }
        }
        public int ENDERECO_CODIGO
        {
            get { return _ENDERECO_CODIGO; }
            set { _ENDERECO_CODIGO = value; }
        }
        public string ENDERECO_CEP
        {
            get { return _ENDERECO_CEP; }
            set { _ENDERECO_CEP = value; }
        }
        public string ENDERECO_LOGRADOURO
        {
            get { return _ENDERECO_LOGRADOURO; }
            set { _ENDERECO_LOGRADOURO = value; }
        }
        public string ENDERECO_COMPLEMENTO
        {
            get { return _ENDERECO_COMPLEMENTO; }
            set { _ENDERECO_COMPLEMENTO = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class FAVORITOSVO
    {
        // Atributos
        private int _favoritosID;
        private int _favoritosEmpresaID;
        private string _favoritosURL;
        private DateTime _favoritosDataCadastro;
        private string _favoritosNome;

        // Propriedades
        public int favoritosID
        {
            get { return _favoritosID; }
            set { _favoritosID = value; }
        }
        public int favoritosEmpresaID
        {
            get { return _favoritosEmpresaID; }
            set { _favoritosEmpresaID = value; }
        }
        public string favoritosURL
        {
            get { return _favoritosURL; }
            set { _favoritosURL = value; }
        }
        public DateTime favoritosDataCadastro
        {
            get { return _favoritosDataCadastro; }
            set { _favoritosDataCadastro = value; }
        }
        public string favoritosNome
        {
            get { return _favoritosNome; }
            set { _favoritosNome = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class FUNCIONARIOSVO
    {
        // Atributos
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

        // Propriedades
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
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class MENUVO
    {
        // Atributos
        private int _menuID;
        private int _menuEmpresaID;
        private string _menuNome;
        private string _menuDescricao;
        private int _menuIdPai;
        private string _menuLink;

        // Propriedades
        public int menuID
        {
            get { return _menuID; }
            set { _menuID = value; }
        }
        public int menuEmpresaID
        {
            get { return _menuEmpresaID; }
            set { _menuEmpresaID = value; }
        }
        public string menuNome
        {
            get { return _menuNome; }
            set { _menuNome = value; }
        }
        public string menuDescricao
        {
            get { return _menuDescricao; }
            set { _menuDescricao = value; }
        }
        public int menuIdPai
        {
            get { return _menuIdPai; }
            set { _menuIdPai = value; }
        }
        public string menuLink
        {
            get { return _menuLink; }
            set { _menuLink = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class SISTEMASVO
    {
        // Atributos
        private int _sistemasID;
        private int _sistemasEmpresaID;
        private string _sistemasURL;
        private DateTime _sistemasDataCadastro;
        private string _sistemasNome;

        // Propriedades
        public int sistemasID
        {
            get { return _sistemasID; }
            set { _sistemasID = value; }
        }
        public int sistemasEmpresaID
        {
            get { return _sistemasEmpresaID; }
            set { _sistemasEmpresaID = value; }
        }
        public string sistemasURL
        {
            get { return _sistemasURL; }
            set { _sistemasURL = value; }
        }
        public DateTime sistemasDataCadastro
        {
            get { return _sistemasDataCadastro; }
            set { _sistemasDataCadastro = value; }
        }
        public string sistemasNome
        {
            get { return _sistemasNome; }
            set { _sistemasNome = value; }
        }
    }

    /// <summary>
    /// Classe VO: Value Objects
    /// Criador: Marcos Morais de Sousa
    /// Criada em 03/08/2010
    /// Contato: mmstec@gmail.com
    /// </summary>
    public class UFVO
    {
        // Atributos
        private int _UF_CODIGO;
        private string _UF_SIGLA;
        private string _UF_DESCRICAO;

        // Propriedades
        public int UF_CODIGO
        {
            get { return _UF_CODIGO; }
            set { _UF_CODIGO = value; }
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
}
