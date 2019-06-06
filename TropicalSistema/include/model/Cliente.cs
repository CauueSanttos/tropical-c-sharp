using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return this.tipo == "NORMAL" ? "1" : "2";
        }


        protected override void processaDadosInclusao() {
            try {
                string sSql = $@"INSERT 
                                   INTO tbcliente(clinome, clitelefone, cliempresa, clitipo)
                                 VALUES ('{this.getNome()}', '{this.getTelefone()}', '{this.getEmpresa()}',  '{this.getTipo()}')";

                this.executeCommand(sSql);
            } catch (NpgsqlException oEx) {
                throw new Exception(oEx.Message);
            }
        }

        protected override void processaDadosAlteracao() {
            try {
                string sSql = $@"UPDATE tbcliente
	                                SET clinome='{this.getNome()}', clitelefone='{this.getTelefone()}', cliempresa='{this.getEmpresa()}', clitipo='{this.getTipo}'?
	                              WHERE clicodigo = {this.getCodigo()}";
            } catch (NpgsqlException oEx) {

            }
            
        }

        protected override void processaDadosExclusao() {
            
        }

        /************ METODOS IMPLEMENTADOS ***************/

        public List<Cliente> buscaUsuario() {
            List<Cliente> aUsuarios = new List<Cliente>();

            try
            {
                string teste = @"SELECT * FROM tbcliente WHERE clinome = @nome and clitipo = @tipo";

                string sSql = @"SELECT * 
                                  FROM tbcliente 
                                 WHERE clinome ILIKE '%' || @nome || '%'";

                this.insertParameters(createArray("@nome", this.getNome(), "1"));
                this.executeCommand(sSql);

                NpgsqlDataReader oData = this.getDataReader();
                while (oData.Read()){
                    Cliente oCliente = new Cliente();
                    oCliente.setCodigo((int)oData["clicodigo"]);
                    oCliente.setNome((string)oData["clinome"]);
                    oCliente.setEmpresa((string)oData["cliempresa"]);
                    oCliente.setTelefone((string)oData["clitelefone"]);
                    oCliente.setTipo(Convert.ToInt32(oData["clitipo"]) == 1 ? "NORMAL" : "MENSALISTA");

                    aUsuarios.Add(oCliente);
                }
            }
            catch (NpgsqlException oEx)
            {
                Console.WriteLine("Erro de SQL: " + oEx.Message);
            }

            return aUsuarios;
        }

        public Cliente getClienteGerenciar() {
            try {
                string sSql = $@"SELECT * 
                                   FROM tbcliente 
                                  WHERE clicodigo = {this.getCodigo()}";

                this.executeCommand(sSql);

                NpgsqlDataReader oData = this.getDataReader();
                while (oData.Read()) {
                    this.setNome((string)oData["clinome"]);
                    this.setEmpresa((string)oData["cliempresa"]);
                    this.setTelefone((string)oData["cliempresa"]);
                    this.setTipo((string)(oData["clitipo"] == "1" ? "NORMAL" : "MENSALISTA"));
                }
            } catch (NpgsqlException oEx) {
                Console.WriteLine("Erro de SQL: " + oEx.Message);
            }

            return this;
        }
    }
}



