using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace portal.DAL
{


    public class dados
    {
        public static string stringConnection
        {
            get
            {
              	//return @"Data Source=BMC-01\SQLEXPRESS;Initial Catalog=portal;User ID=sa;Password=sa$123S;";
              	return ConfigurationManager.ConnectionStrings["ROTA"].ToString();
            }
        }

        //MÉTODOS
        /// <summary>
        /// MARCOS
        /// Método que retorna a conexão com  a base de dados.
        /// </summary>
        /// <returns></returns> 
        public static SqlConnection connection()
        {
            try
            {
                //Instância o sqlconnection com a string de conexão.
                //SqlConnection sqlconnection = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"].ToString());
                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["ROTA"].ToString());
                //Verifica se a conexão esta fechada.
                if (cnn.State == ConnectionState.Closed)
                {
                    //Abri a conexão.
                    cnn.Open();
                }
                //Retorna o sqlconnection.
                return cnn;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// MARCOS
        /// Método que retorna um datareader com o resultado da query.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public SqlDataReader retornarQuery(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(query, dados.connection());

                //Executa a query sql.
                var retornaQuery = comando.ExecuteReader();

                //Fecha a conexão.
                connection().Close();

                //Retorna o dataReader com o resultado
                return retornaQuery;

            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// MARCOS
        /// Método que retorna o resultado da consulta sql em um dataTable.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable retornarQueryDataTable(string query)
        {
            var connect = dados.stringConnection;
            var dt = new DataTable();

            using (var conn = new SqlConnection(connect))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// MARCOS
        /// Método que retorna o resultado da consulta sql em um dataTable.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet retornarQueryDataSet(string query)
        {
            var connect = dados.connection().ToString();//stringConnection;
            var ds = new DataSet();

            using (var conn = new SqlConnection(connect))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    var da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        /// <summary>
        /// MARCOS
        /// Método CRUD que executa a query sql.
        /// SELECT, INSERT, DELETE E UPDADE
        /// </summary>
        /// <param name="query"></param>
        public void executarQuery(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(query, dados.connection());
                //Executa a query sql.
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// MARCOS
        /// Método que executa a query sql e retorna o identity.
        /// </summary>
        /// <param name="query"></param>
        public int executarQueryIdentity(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(query, dados.connection());
                comando.CommandType = CommandType.Text;

                //Executa a query sql.

                //comando.ExecuteNonQuery();
                return Convert.ToInt32(comando.ExecuteScalar());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

