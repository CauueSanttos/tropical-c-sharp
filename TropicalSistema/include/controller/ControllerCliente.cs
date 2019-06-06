using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TropicalSistema.include.model;
using TropicalSistema.include.view;

namespace TropicalSistema.include.controller {

    /**
     * Controlador de Requisições de Clientes 
     * @author Cauê dos Santos Silva
     */
    class ControllerCliente {

        public List<Cliente> buscaCliente(string sNomeCliente) {
            Cliente oCliente = new Cliente();
            oCliente.setNome(sNomeCliente);

            return oCliente.buscaUsuario();
        }

        public void processaDadosInclusao(string sNomeCliente, string sEmpresa, string sTelefone, int iTipo) {
            Cliente oModelCliente = new Cliente();

            oModelCliente.setNome(sNomeCliente);
            oModelCliente.setEmpresa(sEmpresa);
            oModelCliente.setTelefone(sTelefone);
            oModelCliente.setTipo(iTipo == 1 ? "NORMAL" : "MENSALISTA");
            oModelCliente.processaDados(1);

            MessageBox.Show("O Cliente foi incluído com sucesso");
        }

        public void criaTelaIncluir() {
            FrmIncluir oForm = new FrmIncluir();
            oForm.ShowDialog();
        }

        public void criaTelaGerenciar(string sCodigoCliente) {
            FrmGerenciar oForm = new FrmGerenciar(sCodigoCliente);
            oForm.ShowDialog();
        }

    }
}
