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

    public partial class JanelaCanal : Form {
        
        private JanelaCanal() {
            InitializeComponent();
        }
        
        private static JanelaCanal _instancia = null;
        
        public static bool Executar(Canal canal) {
            if(_instancia == null) {
               _instancia = new JanelaCanal();
            }
            
            _instancia.AtualizarTela(canal);
            bool r = _instancia.ShowDialog() == DialogResult.OK;
            if(r) {
                _instancia.AtualizarCanal(canal);
            }
            
            return r;
        }

        private void AtualizarTela(Canal canal) {
            // Logo
            textBoxNome.Text = canal.NomeCanal;
            textBoxGrupo.Text = canal.GrupoCanal;
            textBoxCodigo.Text = canal.CodigoDesbloqueioCanal;
            textBoxURL.Text = canal.URLCanal;
        }

        private void AtualizarCanal(Canal canal) {
        	// Logo
            canal.NomeCanal = textBoxNome.Text;
            canal.GrupoCanal = textBoxGrupo.Text;
            canal.CodigoDesbloqueioCanal = textBoxCodigo.Text;
            canal.URLCanal = textBoxURL.Text;
        }
        
        void ButtonCancelarClick(object sender, EventArgs e) {
            this.Visible = false;
        }
    }
}
