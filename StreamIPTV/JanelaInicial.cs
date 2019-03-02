/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
 
using System;
using System.Windows.Forms;
using StreamIPTV.Negocio;

namespace StreamIPTV {
	
	public partial class JanelaInicial : Form {
		private RegistroCanal registroCanal = new RegistroCanal();
		
		public JanelaInicial() {
			InitializeComponent();
			Atualizar();
		}
		
		private void Atualizar() {
            listView.Items.Clear();
            
            int i = 1;
            
            foreach (Canal canal in registroCanal.ObterCanais(textBoxFiltro.Text)) {
               ListViewItem item = new ListViewItem(i.ToString("000"));
                item.Tag = canal;
                item.SubItems.Add(canal.IdCanal.ToString());
                item.SubItems.Add(canal.LogoCanal);
                item.SubItems.Add(canal.NomeCanal);
                item.SubItems.Add(canal.GrupoCanal);
                item.SubItems.Add(canal.URLCanal);
                listView.Items.Add(item);
                i++;
            }
        }
		
		private void Acao(object sender, EventArgs e) {
            /* Botão Filtrar e TextBox Filtro */
            if(sender == buttonFiltrar || sender == textBoxFiltro) {
                Atualizar();
            }
		}
		
		private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            Canal canal = (Canal)listView.SelectedItems[0].Tag;
        	String URL = canal.URLCanal;
            System.Diagnostics.Process.Start(URL);
        }
		
		void ButtonLoginClick(object sender, EventArgs e) {
			this.Visible = false;
			
			/* Chama a Janela Login */
			JanelaLogin janelaLogin = new JanelaLogin();
			janelaLogin.Show();
		}
		
		void ButtonSobreClick(object sender, EventArgs e) {
			/* Chama a Janela Sobre */
			JanelaSobre janelaSobre = new JanelaSobre();
			janelaSobre.Show();
		}
	}
}