/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 9/19/2017
 * Time: 12:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StreamIPTV
{
	partial class JanelaSobre
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.GroupBox groupBoxAutores;
		private System.Windows.Forms.GroupBox groupBoxAplicacao;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.RichTextBox richTextBoxAplicação;
		private System.Windows.Forms.RichTextBox richTextBoxAutores;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaSobre));
			this.buttonOK = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.groupBoxAutores = new System.Windows.Forms.GroupBox();
			this.richTextBoxAutores = new System.Windows.Forms.RichTextBox();
			this.groupBoxAplicacao = new System.Windows.Forms.GroupBox();
			this.richTextBoxAplicação = new System.Windows.Forms.RichTextBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panel.SuspendLayout();
			this.groupBoxAutores.SuspendLayout();
			this.groupBoxAplicacao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOK.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
			this.buttonOK.Location = new System.Drawing.Point(203, 261);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "OK";
			this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel.Controls.Add(this.groupBoxAutores);
			this.panel.Controls.Add(this.groupBoxAplicacao);
			this.panel.Controls.Add(this.pictureBox);
			this.panel.Controls.Add(this.buttonOK);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(487, 306);
			this.panel.TabIndex = 1;
			// 
			// groupBoxAutores
			// 
			this.groupBoxAutores.Controls.Add(this.richTextBoxAutores);
			this.groupBoxAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxAutores.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.groupBoxAutores.Location = new System.Drawing.Point(239, 143);
			this.groupBoxAutores.Name = "groupBoxAutores";
			this.groupBoxAutores.Size = new System.Drawing.Size(227, 100);
			this.groupBoxAutores.TabIndex = 14;
			this.groupBoxAutores.TabStop = false;
			this.groupBoxAutores.Text = "Autores:";
			// 
			// richTextBoxAutores
			// 
			this.richTextBoxAutores.BackColor = System.Drawing.SystemColors.ControlLight;
			this.richTextBoxAutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBoxAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBoxAutores.ForeColor = System.Drawing.Color.Red;
			this.richTextBoxAutores.Location = new System.Drawing.Point(6, 16);
			this.richTextBoxAutores.Name = "richTextBoxAutores";
			this.richTextBoxAutores.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextBoxAutores.Size = new System.Drawing.Size(215, 79);
			this.richTextBoxAutores.TabIndex = 0;
			this.richTextBoxAutores.Text = "Alexandra Miguel Raibolt da Silva\n(alexandra.raibolt@gmail.com)";
			// 
			// groupBoxAplicacao
			// 
			this.groupBoxAplicacao.Controls.Add(this.richTextBoxAplicação);
			this.groupBoxAplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxAplicacao.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.groupBoxAplicacao.Location = new System.Drawing.Point(239, 23);
			this.groupBoxAplicacao.Name = "groupBoxAplicacao";
			this.groupBoxAplicacao.Size = new System.Drawing.Size(227, 100);
			this.groupBoxAplicacao.TabIndex = 13;
			this.groupBoxAplicacao.TabStop = false;
			this.groupBoxAplicacao.Text = "O que é a aplicação:";
			// 
			// richTextBoxAplicação
			// 
			this.richTextBoxAplicação.BackColor = System.Drawing.SystemColors.ControlLight;
			this.richTextBoxAplicação.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBoxAplicação.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBoxAplicação.ForeColor = System.Drawing.Color.Red;
			this.richTextBoxAplicação.Location = new System.Drawing.Point(6, 19);
			this.richTextBoxAplicação.Name = "richTextBoxAplicação";
			this.richTextBoxAplicação.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextBoxAplicação.Size = new System.Drawing.Size(215, 75);
			this.richTextBoxAplicação.TabIndex = 0;
			this.richTextBoxAplicação.Text = resources.GetString("richTextBoxAplicação.Text");
			// 
			// pictureBox
			// 
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(22, 97);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(194, 78);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 12;
			this.pictureBox.TabStop = false;
			// 
			// JanelaSobre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(487, 306);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "JanelaSobre";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream IPTV - Sobre";
			this.panel.ResumeLayout(false);
			this.groupBoxAutores.ResumeLayout(false);
			this.groupBoxAplicacao.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
