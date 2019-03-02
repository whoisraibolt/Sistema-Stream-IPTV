/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
 
using System;
using System.Windows.Forms;

namespace StreamIPTV {
	
	internal sealed class Program {
		
		[STAThread]
		
		private static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new JanelaSplash());
		}
	}
}