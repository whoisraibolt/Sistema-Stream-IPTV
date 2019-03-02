/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StreamIPTV {

	public partial class JanelaSobre : Form {
		
		public JanelaSobre() {
			InitializeComponent();
		}
		
		void ButtonOKClick(object sender, EventArgs e) {
			this.Visible = false;
		}
	}
}
