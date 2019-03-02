/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
 
using System;
using System.Windows.Forms;

namespace StreamIPTV {
	
	public partial class JanelaSplash : Form {
		
		public JanelaSplash() {
			InitializeComponent();
		}
		
		void TimerTick(object sender, EventArgs e) {
			if(progressBar.Value < 100) {
				progressBar.Value = progressBar.Value + 2;
			} else {
				timer.Enabled = false;
				this.Visible = false;
				
				/* Chama a Janela Inicial */
				JanelaInicial janelaInicial = new JanelaInicial();
				janelaInicial.Show();
			}
		}
	}
}