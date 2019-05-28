using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalSistema.include.model {

    /**
     * Classe de conexão com o Banco de Dados
     * @author Cauê dos Santos Silva
     */
    abstract class Conexao {

        protected NpgsqlConnection conexao = null;
        protected NpgsqlCommand comand = null;
        protected NpgsqlDataReader dataReader = null;

        public void setConexao(NpgsqlConnection oConexao) {
            this.conexao = oConexao;
        }

        public NpgsqlConnection getConexao() {
            return this.conexao;
        }

        public void setCommand(NpgsqlConnection oConexao) {
            NpgsqlCommand oCommand = new NpgsqlCommand();
            oCommand.Connection = oConexao;

            this.comand = oCommand;
        }

        public NpgsqlCommand getCommand() {
            return this.comand;
        }   

        public void setDataReader(NpgsqlDataReader oDataReader) {
            this.dataReader = oDataReader;
        }

        public NpgsqlDataReader getDataReader() {
            return this.dataReader;
        }

        public Conexao() {
            NpgsqlConnection oConexao = null;

            if(this.getConexao() == null) {
                try {
                    oConexao = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = unidavi; Database = tropical");
                    oConexao.Open();
                    this.setConexao(oConexao);
                    this.setCommand(this.getConexao());
                }
                catch (NpgsqlException oEx) {
                    oConexao = null;
                    Console.WriteLine("Erro de conexão com o SGBD: " + oEx.Message);
                }
            }
        }

        /**
         * Realiza a criação dos arrays para inserir parametros
         */
        protected string[] createArray(string sNomeParametro, string sValor,string sTipoCast) {
            string[] aArray = new String[3];
            aArray[0] = sNomeParametro;
            aArray[1] = sValor;
            aArray[2] = sTipoCast;

            return aArray;
        }

        /**
         * Insere os parametros para maior facilidade na execução dos SQL's 
         * É recomendado utilizar um array com vários arrays para parametros
         * Exemplo: [[0 => '@nome', 1 => 'Caue', 2 => 'Cast'], [0 => '@nome', 1 => 'Maciel', 2 => 'Cast']]
         * 
         * TIPOS:
         *  Varchar   [1]
         *  Int       [2]
         */
        protected void insertParameters(String[] aParametro) {
            if (aParametro.Length > 0) {
                string sParametro = aParametro[0];
                string sValor = aParametro[1];

                switch (aParametro[2]) {
                    case "1":
                        this.getCommand().Parameters.Add(sParametro, NpgsqlTypes.NpgsqlDbType.Varchar).Value = sValor;
                        break;
                    case "2":
                        int iParametro = Convert.ToInt32(sValor);
                        this.getCommand().Parameters.Add(sParametro, NpgsqlTypes.NpgsqlDbType.Integer).Value = iParametro;
                        break;
                }
            } else {
                throw new Exception("Parametro informado é incorreto");
            }
        }

        /**
         * Realiza a execução do SQL
         */
        protected void executeCommand(string sSql) {
            this.getCommand().CommandText = sSql;
            this.setDataReader(this.getCommand().ExecuteReader());
        }

        public void closeConexao() {
            if(this.getConexao() != null) {
                try {
                    this.getConexao().Close();
                } catch(NpgsqlException oEx) {
                    Console.WriteLine("Erro ao fechar a conexão com o SGBD: " + oEx.Message);
                }
            }
        }

        protected abstract void processaDadosInclusao();
        protected abstract void processaDadosAlteracao();
        protected abstract void processaDadosExclusao();
    }

}