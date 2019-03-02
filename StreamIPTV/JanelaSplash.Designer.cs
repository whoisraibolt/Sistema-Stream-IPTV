/*
 * Created by SharpDevelop.
 * User: Alexandra
 * Date: 9/19/2017
 * Time: 11:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StreamIPTV
{
	partial class JanelaSplash
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label label;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaSplash));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.label = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// pictureBox
			// 
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(761, 469);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(131, 343);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(499, 23);
			this.progressBar.TabIndex = 1;
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.Color.Red;
			this.label.Location = new System.Drawing.Point(12, 437);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(424, 23);
			this.label.TabIndex = 2;
			this.label.Text = "Desenvolvido por: Alexandra Miguel Raibolt da Silva";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label);
			this.panel.Controls.Add(this.progressBar);
			this.panel.Controls.Add(this.pictureBox);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(761, 469);
			this.panel.TabIndex = 0;
			// 
			// JanelaSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(761, 469);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "JanelaSplash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stream IPTV";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
