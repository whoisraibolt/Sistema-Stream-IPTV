/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 9/28/2017
 * Time: 11:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StreamIPTV
{
	partial class JanelaUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Button buttonSobre;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button buttonVoltar;
		private System.Windows.Forms.Button buttonExcluir;
		private System.Windows.Forms.Button buttonAlterar;
		private System.Windows.Forms.Button buttonAdicionar;
		private System.Windows.Forms.TextBox textBoxFiltro;
		private System.Windows.Forms.Button buttonFiltrar;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		
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
			System.Windows.Forms.ColumnHeader columnHeader1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaUsuarios));
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonSobre = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.buttonFiltrar = new System.Windows.Forms.Button();
			this.textBoxFiltro = new System.Windows.Forms.TextBox();
			this.buttonVoltar = new System.Windows.Forms.Button();
			this.buttonExcluir = new System.Windows.Forms.Button();
			this.buttonAlterar = new System.Windows.Forms.Button();
			this.buttonAdicionar = new System.Windows.Forms.Button();
			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "#";
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4});
			this.listView.FullRowSelect = true;
			this.listView.GridLines = true;
			this.listView.Location = new System.Drawing.Point(160, 40);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(706, 504);
			this.listView.TabIndex = 1;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ID";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Login";
			this.columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Nome";
			this.columnHeader4.Width = 380;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.BackColor = System.Drawing.Color.Red;
			this.splitContainer.Panel1.Controls.Add(this.buttonSobre);
			this.splitContainer.Panel1.Controls.Add(this.label);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainer.Panel2.Controls.Add(this.buttonFiltrar);
			this.splitContainer.Panel2.Controls.Add(this.textBoxFiltro);
			this.splitContainer.Panel2.Controls.Add(this.buttonVoltar);
			this.splitContainer.Panel2.Controls.Add(this.buttonExcluir);
			this.splitContainer.Panel2.Controls.Add(this.buttonAlterar);
			this.splitContainer.Panel2.Controls.Add(this.buttonAdicionar);
			this.splitContainer.Panel2.Controls.Add(this.listView);
			this.splitContainer.Size = new System.Drawing.Size(1047, 639);
			this.splitContainer.SplitterDistance = 52;
			this.splitContainer.TabIndex = 2;
			// 
			// buttonSobre
			// 
			this.buttonSobre.BackColor = System.Drawing.Color.Gray;
			this.buttonSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSobre.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonSobre.Image = ((System.Drawing.Image)(resources.GetObject("buttonSobre.Image")));
			this.buttonSobre.Location = new System.Drawing.Point(888, 15);
			this.buttonSobre.Name = "buttonSobre";
			this.buttonSobre.Size = new System.Drawing.Size(75, 23);
			this.buttonSobre.TabIndex = 4;
			this.buttonSobre.Text = "Sobre";
			this.buttonSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonSobre.UseVisualStyleBackColor = false;
			this.buttonSobre.Click += new System.EventHandler(this.ButtonSobreClick);
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label.Location = new System.Drawing.Point(68, 14);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(119, 23);
			this.label.TabIndex = 1;
			this.label.Text = "Bem-vindo(a)";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonFiltrar
			// 
			this.buttonFiltrar.BackColor = System.Drawing.Color.Gray;
			this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFiltrar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltrar.Image")));
			this.buttonFiltrar.Location = new System.Drawing.Point(710, 11);
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
			this.buttonFiltrar.TabIndex = 12;
			this.buttonFiltrar.Text = "Filtrar";
			this.buttonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonFiltrar.UseVisualStyleBackColor = false;
			this.buttonFiltrar.Click += new System.EventHandler(this.Acao);
			// 
			// textBoxFiltro
			// 
			this.textBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.textBoxFiltro.Location = new System.Drawing.Point(463, 13);
			this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.textBoxFiltro.Name = "textBoxFiltro";
			this.textBoxFiltro.Size = new System.Drawing.Size(243, 20);
			this.textBoxFiltro.TabIndex = 8;
			this.textBoxFiltro.TextChanged += new System.EventHandler(this.Acao);
			// 
			// buttonVoltar
			// 
			this.buttonVoltar.BackColor = System.Drawing.Color.Gray;
			this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonVoltar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonVoltar.Image = ((System.Drawing.Image)(resources.GetObject("buttonVoltar.Image")));
			this.buttonVoltar.Location = new System.Drawing.Point(791, 11);
			this.buttonVoltar.Name = "buttonVoltar";
			this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
			this.buttonVoltar.TabIndex = 5;
			this.buttonVoltar.Text = "Voltar";
			this.buttonVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonVoltar.UseVisualStyleBackColor = false;
			this.buttonVoltar.Click += new System.EventHandler(this.ButtonVoltarClick);
			// 
			// buttonExcluir
			// 
			this.buttonExcluir.BackColor = System.Drawing.Color.Red;
			this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExcluir.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
			this.buttonExcluir.Location = new System.Drawing.Point(333, 11);
			this.buttonExcluir.Name = "buttonExcluir";
			this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
			this.buttonExcluir.TabIndex = 7;
			this.buttonExcluir.Text = "Excluir";
			this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonExcluir.UseVisualStyleBackColor = false;
			this.buttonExcluir.Click += new System.EventHandler(this.Acao);
			// 
			// buttonAlterar
			// 
			this.buttonAlterar.BackColor = System.Drawing.Color.DodgerBlue;
			this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAlterar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAlterar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.Image")));
			this.buttonAlterar.Location = new System.Drawing.Point(252, 11);
			this.buttonAlterar.Name = "buttonAlterar";
			this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
			this.buttonAlterar.TabIndex = 6;
			this.buttonAlterar.Text = "Alterar";
			this.buttonAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonAlterar.UseVisualStyleBackColor = false;
			this.buttonAlterar.Click += new System.EventHandler(this.Acao);
			// 
			// buttonAdicionar
			// 
			this.buttonAdicionar.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdicionar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionar.Image")));
			this.buttonAdicionar.Location = new System.Drawing.Point(160, 11);
			this.buttonAdicionar.Name = "buttonAdicionar";
			this.buttonAdicionar.Size = new System.Drawing.Size(86, 23);
			this.buttonAdicionar.TabIndex = 5;
			this.buttonAdicionar.Text = "Adicionar";
			this.buttonAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonAdicionar.UseVisualStyleBackColor = false;
			this.buttonAdicionar.Click += new System.EventHandler(this.Acao);
			// 
			// JanelaUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(1047, 639);
			this.Controls.Add(this.splitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "JanelaUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream IPTV - Usuários";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
