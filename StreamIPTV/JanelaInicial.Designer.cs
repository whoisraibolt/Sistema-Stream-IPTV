/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 9/19/2017
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StreamIPTV
{
	partial class JanelaInicial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonSobre;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TextBox textBoxFiltro;
		private System.Windows.Forms.Button buttonFiltrar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaInicial));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonSobre = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.textBoxFiltro = new System.Windows.Forms.TextBox();
			this.buttonFiltrar = new System.Windows.Forms.Button();
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
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
			this.splitContainer.Panel1.Controls.Add(this.buttonLogin);
			this.splitContainer.Panel1.Controls.Add(this.buttonSobre);
			this.splitContainer.Panel1.Controls.Add(this.label);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainer.Panel2.Controls.Add(this.textBoxFiltro);
			this.splitContainer.Panel2.Controls.Add(this.buttonFiltrar);
			this.splitContainer.Panel2.Controls.Add(this.listView);
			this.splitContainer.Size = new System.Drawing.Size(1047, 639);
			this.splitContainer.SplitterDistance = 52;
			this.splitContainer.TabIndex = 0;
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.Gray;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
			this.buttonLogin.Location = new System.Drawing.Point(807, 15);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 4;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
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
			// textBoxFiltro
			// 
			this.textBoxFiltro.Location = new System.Drawing.Point(323, 13);
			this.textBoxFiltro.Name = "textBoxFiltro";
			this.textBoxFiltro.Size = new System.Drawing.Size(243, 20);
			this.textBoxFiltro.TabIndex = 14;
			this.textBoxFiltro.TextChanged += new System.EventHandler(this.Acao);
			// 
			// buttonFiltrar
			// 
			this.buttonFiltrar.BackColor = System.Drawing.Color.Gray;
			this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFiltrar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buttonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltrar.Image")));
			this.buttonFiltrar.Location = new System.Drawing.Point(572, 10);
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
			this.buttonFiltrar.TabIndex = 13;
			this.buttonFiltrar.Text = "Filtrar";
			this.buttonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonFiltrar.UseVisualStyleBackColor = false;
			this.buttonFiltrar.TextChanged += new System.EventHandler(this.Acao);
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4,
			this.columnHeader5,
			this.columnHeader6});
			this.listView.FullRowSelect = true;
			this.listView.GridLines = true;
			this.listView.Location = new System.Drawing.Point(38, 42);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(970, 504);
			this.listView.TabIndex = 2;
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
			this.columnHeader3.Text = "Logo";
			this.columnHeader3.Width = 145;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Nome";
			this.columnHeader4.Width = 150;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Grupo";
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "URL";
			this.columnHeader6.Width = 400;
			// 
			// JanelaInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(1047, 639);
			this.Controls.Add(this.splitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "JanelaInicial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream IPTV - Inicial";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
