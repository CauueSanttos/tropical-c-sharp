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
    class Conexao {

        private NpgsqlConnection conexao;

        public Conexao() {
            NpgsqlConnection oConexao = null;

            if(this.getConexao() != null) {
                try {
                    oConexao = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = postgres; Database = tropical");
                    oConexao.Open();
                    this.setConexao(oConexao);
                } catch (NpgsqlException oEx) {
                    oConexao = null;
                    Console.WriteLine("Erro de conexão com o SGBD: " + oEx.Message);
                }
            }
        }

        public void setConexao(NpgsqlConnection oConexao) {
            this.conexao = oConexao;
        }

        public NpgsqlConnection getConexao() {
            return this.conexao;
        }

        public void closeConexao() {
            if(this.getConexao() != null) {
                try {

                } catch(NpgsqlException oEx) {
                    Console.WriteLine("Erro ao fechar a conexão com o SGBD: " + oEx.Message);
                }
            }
        }
    }

}