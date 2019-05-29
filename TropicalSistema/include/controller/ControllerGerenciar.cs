using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TropicalSistema.include.view;

namespace TropicalSistema.include.controller {

    class ControllerGerenciar {

        public void openForm(string sCodigoCliente) {
            FrmGerenciar oForm = new FrmGerenciar(sCodigoCliente);
            oForm.ShowDialog();
        }
    }
}
