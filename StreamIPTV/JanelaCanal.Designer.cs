/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 9/29/2017
 * Time: 11:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StreamIPTV
{
	partial class JanelaCanal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox textBoxCodigo;
		private System.Windows.Forms.TextBox textBoxGrupo;
		private System.Windows.Forms.Label labelCodigo;
		private System.Windows.Forms.Label labelGrupo;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TextBox textBoxURL;
		private System.Windows.Forms.Label labelURL;
		private System.Windows.Forms.TextBox textBoxNome;
		private System.Windows.Forms.Label labelNome;
		private System.Windows.Forms.Panel panelLogo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCanal));
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxCodigo = new System.Windows.Forms.TextBox();
			this.textBoxGrupo = new System.Windows.Forms.TextBox();
			this.labelCodigo = new System.Windows.Forms.Label();
			this.labelGrupo = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.textBoxURL = new System.Windows.Forms.TextBox();
			this.labelURL = new System.Windows.Forms.Label();
			this.textBoxNome = new System.Windows.Forms.TextBox();
			this.labelNome = new System.Windows.Forms.Label();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.BackColor = System.Drawing.Color.Red;
			this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
			this.buttonCancelar.Location = new System.Drawing.Point(244, 261);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(83, 23);
			this.buttonCancelar.TabIndex = 12;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonCancelar.UseVisualStyleBackColor = false;
			this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelarClick);
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOK.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
			this.buttonOK.Location = new System.Drawing.Point(163, 261);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "OK";
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonOK.UseVisualStyleBackColor = false;
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Location = new System.Drawing.Point(200, 136);
			this.textBoxCodigo.Name = "textBoxCodigo";
			this.textBoxCodigo.Size = new System.Drawing.Size(84, 20);
			this.textBoxCodigo.TabIndex = 10;
			this.textBoxCodigo.UseSystemPasswordChar = true;
			// 
			// textBoxGrupo
			// 
			this.textBoxGrupo.Location = new System.Drawing.Point(76, 100);
			this.textBoxGrupo.Name = "textBoxGrupo";
			this.textBoxGrupo.Size = new System.Drawing.Size(208, 20);
			this.textBoxGrupo.TabIndex = 9;
			// 
			// labelCodigo
			// 
			this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCodigo.Location = new System.Drawing.Point(25, 136);
			this.labelCodigo.Name = "labelCodigo";
			this.labelCodigo.Size = new System.Drawing.Size(182, 23);
			this.labelCodigo.TabIndex = 8;
			this.labelCodigo.Text = "Código de Desbloqueio:";
			// 
			// labelGrupo
			// 
			this.labelGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGrupo.Location = new System.Drawing.Point(25, 100);
			this.labelGrupo.Name = "labelGrupo";
			this.labelGrupo.Size = new System.Drawing.Size(62, 23);
			this.labelGrupo.TabIndex = 7;
			this.labelGrupo.Text = "Grupo:";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel.Controls.Add(this.panelLogo);
			this.panel.Controls.Add(this.textBoxURL);
			this.panel.Controls.Add(this.labelURL);
			this.panel.Controls.Add(this.textBoxNome);
			this.panel.Controls.Add(this.labelNome);
			this.panel.Controls.Add(this.buttonCancelar);
			this.panel.Controls.Add(this.buttonOK);
			this.panel.Controls.Add(this.textBoxCodigo);
			this.panel.Controls.Add(this.textBoxGrupo);
			this.panel.Controls.Add(this.labelCodigo);
			this.panel.Controls.Add(this.labelGrupo);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(487, 306);
			this.panel.TabIndex = 2;
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panelLogo.Location = new System.Drawing.Point(303, 64);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(150, 92);
			this.panelLogo.TabIndex = 17;
			// 
			// textBoxURL
			// 
			this.textBoxURL.Location = new System.Drawing.Point(65, 168);
			this.textBoxURL.Name = "textBoxURL";
			this.textBoxURL.Size = new System.Drawing.Size(388, 20);
			this.textBoxURL.TabIndex = 16;
			// 
			// labelURL
			// 
			this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelURL.Location = new System.Drawing.Point(25, 169);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(43, 23);
			this.labelURL.TabIndex = 15;
			this.labelURL.Text = "URL:";
			// 
			// textBoxNome
			// 
			this.textBoxNome.Location = new System.Drawing.Point(76, 64);
			this.textBoxNome.Name = "textBoxNome";
			this.textBoxNome.Size = new System.Drawing.Size(208, 20);
			this.textBoxNome.TabIndex = 14;
			// 
			// labelNome
			// 
			this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNome.Location = new System.Drawing.Point(25, 65);
			this.labelNome.Name = "labelNome";
			this.labelNome.Size = new System.Drawing.Size(62, 23);
			this.labelNome.TabIndex = 13;
			this.labelNome.Text = "Nome:";
			// 
			// JanelaCanal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(487, 306);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "JanelaCanal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream IPTV - Registro Canal";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
