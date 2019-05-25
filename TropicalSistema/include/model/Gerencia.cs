using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TropicalSistema.include.model {

    /**
     * Modelo de dados da Gerência
     * @author Cauê dos Santos Silva
     */
    class Gerencia : Conexao {

        private int codigo;
        private string user;
        private string senha;

        public void setCodigo(int iCodigo) {
            this.codigo = iCodigo;
        }

        public int getCodigo() {
            return this.codigo;
        }

        public void setUser(string sUser) {
            this.user = sUser;
        }

        public string getUser() {
            return this.user;
        }

        public void setSenha(string sSenha) {
            this.senha = sSenha;
        }

        public string getSenha() {
            return this.senha;
        }

        protected override void processaDadosInclusao() {
            
        }

        protected override void processaDadosAlteracao() {
            
        }

        protected override void processaDadosExclusao() {
            
        }

        /***************** MÉTODOS IMPLEMENTADOS *****************/

        public bool validaLoginGerencia() {
            try {
                string sSql = @"SELECT *
                                  FROM public.tbgerencia
                                 WHERE geruser = @user 
                                   AND gersenha = @senha";

                this.insertParameters(createArray("@user", this.getUser(), "1"));
                this.insertParameters(createArray("@senha", this.getSenha(), "1"));
                this.executeCommand(sSql);

                NpgsqlDataReader oDataReader = this.getDataReader();
                oDataReader.Read();
                return oDataReader.HasRows;
            } catch (NpgsqlException oEx) {
                Console.WriteLine("Erro de SQL: " + oEx.Message);
            }
            return false;
        }
    }
}
