using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TropicalSistema.include.model;

namespace TropicalSistema.include.controller {

    class ControllerGerencia {
    
        public bool validaLoginGerencia(string sUsuario, string sSenha) {
            bool bRetorno = false;

            if ((sUsuario.Length != 0) && (sSenha.Length != 0)) {
                Gerencia oGerencia = new Gerencia();
                oGerencia.setUser(sUsuario);
                oGerencia.setSenha(sSenha);
                bRetorno = oGerencia.validaLoginGerencia();
            } else {
                MessageBox.Show("Por favor, informe todos os campos!!!");
            }
            return bRetorno;
        }
    }
}
