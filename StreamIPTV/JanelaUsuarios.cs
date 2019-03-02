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

	public partial class JanelaUsuarios : Form {
		private RegistroUsuario registroUsuario = new RegistroUsuario();
		
		public JanelaUsuarios() {
			InitializeComponent();
			
			/*
			#region Cambiara para Inicializar
            Usuario usuario = new Usuario();
            usuario.LoginUsuario = "admin";
            usuario.SenhaUsuario = "admin";
            usuario.NomeUsuario = "Alexandra Miguel Raibolt da Silva";

            registroUsuario.AdicionarU(usuario);
            #endregion
			*/
			
            Atualizar();
		}
		
		private void Atualizar() {
            listView.Items.Clear();
            
            int i = 1;
            
            foreach (Usuario usuario in registroUsuario.ObterUsuarios(textBoxFiltro.Text)) {
               ListViewItem item = new ListViewItem(i.ToString("000"));
                item.Tag = usuario;
                item.SubItems.Add(usuario.IdUsuario.ToString());
                item.SubItems.Add(usuario.LoginUsuario);
                item.SubItems.Add(usuario.NomeUsuario);
                listView.Items.Add(item);
                i++;
            }
        }

        private void Acao(object sender, EventArgs e) {
			/* Botão Filtrar e TextBox Filtro */
			if(sender == buttonFiltrar || sender == textBoxFiltro) {
                Atualizar();
			} /* Botão Adicionar*/
			else if (sender == buttonAdicionar) {
				Usuario usuario = new Usuario();
	                
	        	if(JanelaUsuario.Executar(usuario)) {
	        		registroUsuario.AdicionarU(usuario);
	       			textBoxFiltro.Clear();
	                Atualizar();
	             }
			} /* Botão Alterar */
			else if (sender == buttonAlterar) {
				if(listView.SelectedItems.Count != 1) {
	            	MessageBox.Show("Selecione um usuário para alterar!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
	                Usuario usuario = (Usuario)listView.SelectedItems[0].Tag;
	                int IdUsuarioVelha = usuario.IdUsuario;
	                    
	                if(JanelaUsuario.Executar(usuario)) {
	                    registroUsuario.AlterarU(IdUsuarioVelha, usuario);
	                    textBoxFiltro.Clear();
	                    Atualizar();
	                }
	            }
			} /* Botão Excluir */
			else if (sender == buttonExcluir) {
				if(listView.SelectedItems.Count != 1) {
	            	MessageBox.Show("Selecione um usuário para excluir!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
	            	Usuario usuario = (Usuario)listView.SelectedItems[0].Tag;
	                    
	                if (MessageBox.Show("Tem certeza que deseja excluir este usuário: " + usuario.LoginUsuario + "?", "Excluir Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {
	                	registroUsuario.ExcluirU(usuario.IdUsuario);
	                    Atualizar();
	                }
	            }
			}	
        }
		
		private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            Acao(buttonAlterar, e);
        }

		void ButtonVoltarClick(object sender, EventArgs e) {
			this.Visible = false;
				
			/* Chama a Janela Canais */
			JanelaCanais janelaCanais = new JanelaCanais();
			janelaCanais.Show();
		}
		
		void ButtonSobreClick(object sender, EventArgs e) {
			/* Chama a Janela Sobre */
			JanelaSobre janelaSobre = new JanelaSobre();
			janelaSobre.Show();
		}
	}
}