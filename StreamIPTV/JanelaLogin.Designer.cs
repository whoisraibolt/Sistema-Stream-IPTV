/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 9/19/2017
 * Time: 1:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StreamIPTV
{
	partial class JanelaLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelSenha;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxSenha;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Panel panel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaLogin));
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelSenha = new System.Windows.Forms.Label();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxSenha = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelLogin
			// 
			this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogin.Location = new System.Drawing.Point(141, 110);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(51, 23);
			this.labelLogin.TabIndex = 7;
			this.labelLogin.Text = "Login:";
			// 
			// labelSenha
			// 
			this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSenha.Location = new System.Drawing.Point(135, 147);
			this.labelSenha.Name = "labelSenha";
			this.labelSenha.Size = new System.Drawing.Size(57, 23);
			this.labelSenha.TabIndex = 8;
			this.labelSenha.Text = "Senha:";
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(192, 109);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(153, 20);
			this.textBoxLogin.TabIndex = 9;
			// 
			// textBoxSenha
			// 
			this.textBoxSenha.Location = new System.Drawing.Point(192, 146);
			this.textBoxSenha.Name = "textBoxSenha";
			this.textBoxSenha.Size = new System.Drawing.Size(153, 20);
			this.textBoxSenha.TabIndex = 10;
			this.textBoxSenha.UseSystemPasswordChar = true;
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.Color.ForestGreen;
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
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
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
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel.Controls.Add(this.buttonCancelar);
			this.panel.Controls.Add(this.buttonOK);
			this.panel.Controls.Add(this.textBoxSenha);
			this.panel.Controls.Add(this.textBoxLogin);
			this.panel.Controls.Add(this.labelSenha);
			this.panel.Controls.Add(this.labelLogin);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(487, 306);
			this.panel.TabIndex = 0;
			// 
			// JanelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(487, 306);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "JanelaLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream IPTV - Login";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
