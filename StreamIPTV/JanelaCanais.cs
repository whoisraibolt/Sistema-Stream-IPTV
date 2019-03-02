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

    public partial class JanelaCanais : Form {
        private RegistroCanal registroCanal = new RegistroCanal();
        
        public JanelaCanais() {
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
            } /* Botão Adicionar */
            else if (sender == buttonAdicionar) {
                Canal canal = new Canal();
                    
                if(JanelaCanal.Executar(canal)) {
                    registroCanal.AdicionarC(canal);
                    textBoxFiltro.Clear();
                    Atualizar();
                 }
            } /* Botão Alterar */
            else if (sender == buttonAlterar) {
                if(listView.SelectedItems.Count != 1) {
                    MessageBox.Show("Selecione um canal para alterar!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    Canal canal = (Canal)listView.SelectedItems[0].Tag;
                    int IdCanalVelha = canal.IdCanal;
                        
                    if(JanelaCanal.Executar(canal)) {
                        registroCanal.AlterarC(IdCanalVelha, canal);
                        textBoxFiltro.Clear();
                        Atualizar();
                    }
                }
            } /* Botão Excluir */
            else if (sender == buttonExcluir) {
                if(listView.SelectedItems.Count != 1) {
                    MessageBox.Show("Selecione um canal para excluir!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    Canal canal = (Canal)listView.SelectedItems[0].Tag;
                        
                    if (MessageBox.Show("Tem certeza que deseja excluir este canal: " + canal.NomeCanal + "?", "Excluir Canal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {
                        registroCanal.ExcluirC(canal.IdCanal);
                        Atualizar();
                    }
                }
            }   
        }
        
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            Canal canal = (Canal)listView.SelectedItems[0].Tag;
        	String URL = canal.URLCanal;
            System.Diagnostics.Process.Start(URL);
        }

        void ButtonVoltarClick(object sender, EventArgs e) {
            this.Visible = false;
                
            /* Chama a Janela Inicial */
            JanelaInicial janelaInicial = new JanelaInicial();
            janelaInicial.Show();
        }
        
        void ButtonSobreClick(object sender, EventArgs e) {
            /* Chama a Janela Sobre */
            JanelaSobre janelaSobre = new JanelaSobre();
            janelaSobre.Show();
        }

        void ButtonUsuariosClick(object sender, EventArgs e) {
            this.Visible = false;
                
            /* Chama a Janela Usuários */
            JanelaUsuarios janelaUsuarios = new JanelaUsuarios();
            janelaUsuarios.Show();
        }
    }
}