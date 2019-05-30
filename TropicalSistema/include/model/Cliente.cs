using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalSistema.include.model {

    /**
     * Modelo de dados de Cliente
     * @author Cauê dos Santos Silva
     */
    class Cliente : Conexao {

        public int codigo { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string empresa { get; set; }
        public string tipo { get; set; }

        public void setCodigo(int iCodigo) {
            this.codigo = iCodigo;
        }

        public int getCodigo() {
            return this.codigo;
        }

        public void setNome(string sNome) {
            this.nome = sNome;
        }

        public string getNome() {
            return this.nome;
        }

        public void setTelefone(string sTelefone) {
            this.telefone = sTelefone;
        }

        public string getTelefone() {
            return this.telefone;
        }

        public void setEmpresa(string sEmpresa) {
            this.empresa = sEmpresa;
        }

        public string getEmpresa() {
            return this.empresa;
        }

        public void setTipo(string iTipo) {
            this.tipo = iTipo;
        }

        public string getTipo() {
            return this.tipo;
        }

        protected override void processaDadosInclusao() {
            
        }

        protected override void processaDadosAlteracao() {
            
        }

        protected override void processaDadosExclusao() {
            
        }

        /************ METODOS IMPLEMENTADOS ***************/

        public List<Cliente> buscaUsuario() {
            List<Cliente> aUsuarios = new List<Cliente>();

            try
            {
                string sSql = @"SELECT * 
                                  FROM tbcliente 
                                 WHERE clinome ILIKE '%' || @nome || '%'";

                this.insertParameters(createArray("@nome", this.getNome(), "1"));
                this.executeCommand(sSql);

                NpgsqlDataReader oData = this.getDataReader();
                while (oData.Read())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.setCodigo((int)oData["clicodigo"]);
                    oCliente.setNome((string)oData["clinome"]);
                    oCliente.setEmpresa((string)oData["cliempresa"]);
                    oCliente.setTelefone((string)oData["clitelefone"]);
                    oCliente.setTipo((oData["clitipo"].ToString() == "0") ? "NORMAL" : "MENSALISTA");

                    aUsuarios.Add(oCliente);
                }
            }
            catch (NpgsqlException oEx)
            {
                Console.WriteLine("Erro de SQL: " + oEx.Message);
            }

            return aUsuarios;
        }
    }
}



