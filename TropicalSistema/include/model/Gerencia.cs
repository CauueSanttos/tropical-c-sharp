using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalSistema.include.model {

    /**
     * Modelo de dados da Gerência
     * @author Cauê dos Santos Silva
     */
    class Gerencia {

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
    }
}
