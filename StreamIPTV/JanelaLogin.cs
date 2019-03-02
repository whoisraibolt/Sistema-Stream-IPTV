/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StreamIPTV {
	
	public partial class JanelaLogin : Form {
		
		public JanelaLogin() {
			InitializeComponent();
		}
		
		void ButtonCancelarClick(object sender, EventArgs e) {
			this.Visible = false;
			
			/* Chama a Janela Inicial */
			JanelaInicial janelaInicial = new JanelaInicial();
			janelaInicial.Show();
		}
		
		void ButtonOKClick(object sender, EventArgs e) {
			this.Visible = false;
			
			/* Chama a Janela Canais */
			JanelaCanais janelaCanais = new JanelaCanais();
			janelaCanais.Show();
		}
	}
}