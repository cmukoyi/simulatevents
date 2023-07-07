namespace EventSerializationTestApp
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxInputData = new System.Windows.Forms.TextBox();
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.textBoxResults = new System.Windows.Forms.TextBox();
			this.panelControls = new System.Windows.Forms.Panel();
			this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelTop.SuspendLayout();
			this.panelBottom.SuspendLayout();
			this.panelControls.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxInputData
			// 
			this.textBoxInputData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxInputData.Location = new System.Drawing.Point(0, 43);
			this.textBoxInputData.Multiline = true;
			this.textBoxInputData.Name = "textBoxInputData";
			this.textBoxInputData.Size = new System.Drawing.Size(680, 166);
			this.textBoxInputData.TabIndex = 0;
			this.textBoxInputData.TextChanged += new System.EventHandler(this.textBoxInputData_TextChanged);
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.textBoxInputData);
			this.panelTop.Controls.Add(this.panelControls);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(680, 209);
			this.panelTop.TabIndex = 1;
			// 
			// panelBottom
			// 
			this.panelBottom.Controls.Add(this.textBoxResults);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBottom.Location = new System.Drawing.Point(0, 209);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(680, 225);
			this.panelBottom.TabIndex = 2;
			// 
			// textBoxResults
			// 
			this.textBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxResults.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxResults.Location = new System.Drawing.Point(0, 0);
			this.textBoxResults.Multiline = true;
			this.textBoxResults.Name = "textBoxResults";
			this.textBoxResults.ReadOnly = true;
			this.textBoxResults.Size = new System.Drawing.Size(680, 225);
			this.textBoxResults.TabIndex = 0;
			// 
			// panelControls
			// 
			this.panelControls.Controls.Add(this.label1);
			this.panelControls.Controls.Add(this.comboBoxTemplates);
			this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControls.Location = new System.Drawing.Point(0, 0);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(680, 43);
			this.panelControls.TabIndex = 1;
			// 
			// comboBoxTemplates
			// 
			this.comboBoxTemplates.FormattingEnabled = true;
			this.comboBoxTemplates.Location = new System.Drawing.Point(95, 9);
			this.comboBoxTemplates.Name = "comboBoxTemplates";
			this.comboBoxTemplates.Size = new System.Drawing.Size(204, 21);
			this.comboBoxTemplates.TabIndex = 0;
			this.comboBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplates_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Template:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 434);
			this.Controls.Add(this.panelBottom);
			this.Controls.Add(this.panelTop);
			this.Name = "MainForm";
			this.Text = "Event Serialization Test App";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.panelControls.ResumeLayout(false);
			this.panelControls.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInputData;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.TextBox textBoxResults;
		private System.Windows.Forms.Panel panelControls;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxTemplates;
	}
}

