using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TropicalSistema.include.model;

namespace TropicalSistema.include.controller {

    /**
     * Controlador de Requisições de Clientes 
     * @author Cauê dos Santos Silva
     */
    class ControllerCliente {

        public List<Cliente> buscaCliente(string sNomeCliente)
        {
            Cliente oCliente = new Cliente();
            oCliente.setNome(sNomeCliente);

            return oCliente.buscaUsuario();
        }

    }
}
