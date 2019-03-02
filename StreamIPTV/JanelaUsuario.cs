/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
  
using System;
using System.Linq;
using System.Windows.Forms;
using StreamIPTV.Negocio;

namespace StreamIPTV {

	public partial class JanelaUsuario : Form {
		
		private JanelaUsuario() {
			InitializeComponent();
		}
		
		private static JanelaUsuario _instancia = null;
		
        public static bool Executar(Usuario usuario) {
			if(_instancia == null) {
               _instancia = new JanelaUsuario();
			}
			
            _instancia.AtualizarTela(usuario);
            bool r = _instancia.ShowDialog() == DialogResult.OK;
            
	        if(r) {
	        	 _instancia.AtualizarUsuario(usuario);
	        }
            
            return r;
        }

        private void AtualizarTela(Usuario usuario) {
            textBoxLogin.Text = usuario.LoginUsuario;
            textBoxSenha.Text = usuario.SenhaUsuario;
            textBoxNome.Text = usuario.NomeUsuario;
        }

        private void AtualizarUsuario(Usuario usuario) {
            usuario.LoginUsuario = textBoxLogin.Text;
            usuario.SenhaUsuario = textBoxSenha.Text;
            usuario.NomeUsuario = textBoxNome.Text;
        }
		
		void ButtonCancelarClick(object sender, EventArgs e) {
			this.Visible = false;
		}
	}
}