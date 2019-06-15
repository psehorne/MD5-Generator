/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 8/15/2008
 * Time: 12:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MD5_Generator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.generateMD5Button = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.MD5ResultTextBox = new System.Windows.Forms.TextBox();
			this.loadFileButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.enterTextManuallyButton = new System.Windows.Forms.CheckBox();
			this.clearTextButton = new System.Windows.Forms.Button();
			this.copyToClipboarButton = new System.Windows.Forms.Button();
			this.compareButton = new System.Windows.Forms.Button();
			this.compareTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// generateMD5Button
			// 
			this.generateMD5Button.Location = new System.Drawing.Point(23, 255);
			this.generateMD5Button.Name = "generateMD5Button";
			this.generateMD5Button.Size = new System.Drawing.Size(104, 23);
			this.generateMD5Button.TabIndex = 2;
			this.generateMD5Button.Text = "Generate MD5";
			this.generateMD5Button.UseVisualStyleBackColor = true;
			this.generateMD5Button.Click += new System.EventHandler(this.generateMD5ButtonClicked);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(163, 52);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(293, 100);
			this.textBox1.TabIndex = 3;
			this.textBox1.WordWrap = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 51);
			this.label1.TabIndex = 4;
			this.label1.Text = "MD5 Generator v1.2.0.0207 09/12/2008\r\nCopyright @2008 Paul F. Sehorne\r\npaul@sehor" +
			"ne.org\r\n";
			// 
			// MD5ResultTextBox
			// 
			this.MD5ResultTextBox.Enabled = false;
			this.MD5ResultTextBox.Location = new System.Drawing.Point(133, 255);
			this.MD5ResultTextBox.Name = "MD5ResultTextBox";
			this.MD5ResultTextBox.Size = new System.Drawing.Size(263, 20);
			this.MD5ResultTextBox.TabIndex = 5;
			// 
			// loadFileButton
			// 
			this.loadFileButton.Location = new System.Drawing.Point(22, 19);
			this.loadFileButton.Name = "loadFileButton";
			this.loadFileButton.Size = new System.Drawing.Size(75, 23);
			this.loadFileButton.TabIndex = 6;
			this.loadFileButton.Text = "Load File";
			this.loadFileButton.UseVisualStyleBackColor = true;
			this.loadFileButton.Click += new System.EventHandler(this.LoadFileButtonClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.enterTextManuallyButton);
			this.groupBox1.Controls.Add(this.clearTextButton);
			this.groupBox1.Controls.Add(this.loadFileButton);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(22, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(491, 165);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// enterTextManuallyButton
			// 
			this.enterTextManuallyButton.Location = new System.Drawing.Point(22, 48);
			this.enterTextManuallyButton.Name = "enterTextManuallyButton";
			this.enterTextManuallyButton.Size = new System.Drawing.Size(125, 24);
			this.enterTextManuallyButton.TabIndex = 8;
			this.enterTextManuallyButton.Text = "Enter Text Manually";
			this.enterTextManuallyButton.UseVisualStyleBackColor = true;
			this.enterTextManuallyButton.CheckedChanged += new System.EventHandler(this.EnterTextManuallyButtonCheckedChanged);
			// 
			// clearTextButton
			// 
			this.clearTextButton.Location = new System.Drawing.Point(22, 80);
			this.clearTextButton.Name = "clearTextButton";
			this.clearTextButton.Size = new System.Drawing.Size(75, 23);
			this.clearTextButton.TabIndex = 7;
			this.clearTextButton.Text = "Reset";
			this.clearTextButton.UseVisualStyleBackColor = true;
			this.clearTextButton.Click += new System.EventHandler(this.clearTextButtonClicked);
			// 
			// copyToClipboarButton
			// 
			this.copyToClipboarButton.Location = new System.Drawing.Point(408, 252);
			this.copyToClipboarButton.Name = "copyToClipboarButton";
			this.copyToClipboarButton.Size = new System.Drawing.Size(105, 23);
			this.copyToClipboarButton.TabIndex = 9;
			this.copyToClipboarButton.Text = "Copy to Clipboard";
			this.copyToClipboarButton.UseVisualStyleBackColor = true;
			this.copyToClipboarButton.Click += new System.EventHandler(this.copyToClipboarButtonClicked);
			// 
			// compareButton
			// 
			this.compareButton.Location = new System.Drawing.Point(23, 292);
			this.compareButton.Name = "compareButton";
			this.compareButton.Size = new System.Drawing.Size(104, 23);
			this.compareButton.TabIndex = 10;
			this.compareButton.Text = "Compare To";
			this.compareButton.UseVisualStyleBackColor = true;
			this.compareButton.Click += new System.EventHandler(this.CompareButtonClick);
			// 
			// compareTextBox
			// 
			this.compareTextBox.Location = new System.Drawing.Point(133, 292);
			this.compareTextBox.Name = "compareTextBox";
			this.compareTextBox.Size = new System.Drawing.Size(263, 20);
			this.compareTextBox.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 327);
			this.Controls.Add(this.compareTextBox);
			this.Controls.Add(this.compareButton);
			this.Controls.Add(this.copyToClipboarButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.MD5ResultTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.generateMD5Button);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "MD5 Generator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox compareTextBox;
		private System.Windows.Forms.Button compareButton;
		private System.Windows.Forms.CheckBox enterTextManuallyButton;
		private System.Windows.Forms.Button clearTextButton;
		private System.Windows.Forms.Button copyToClipboarButton;
		private System.Windows.Forms.Button generateMD5Button;
		private System.Windows.Forms.TextBox MD5ResultTextBox;
		private System.Windows.Forms.Button loadFileButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		
		void GroupBox1Enter(object sender, System.EventArgs e)
		{
				
		}
		
		void LoadFileButtonClick(object sender, System.EventArgs e)
		{
			enterTextManuallyButton.Checked = false;
			textBox1.Enabled = false;
			openFileDialog1.InitialDirectory = @"C:\";
			openFileDialog1.Title = "Select a File";
			//if (
				openFileDialog1.ShowDialog(); // != DialogResult.Cancel)
   				textBox1.Text = openFileDialog1.FileName;
			//else
   			//	textBox1.Text = "";
		}
		
		void clearTextButtonClicked (object sender, System.EventArgs e)
		{
			textBox1.Text = "";
			MD5ResultTextBox.Text = "";
			compareTextBox.Text = "";
			compareButton.Enabled = false;
		}
		
		
		void EnterTextManuallyButtonCheckedChanged(object sender, System.EventArgs e)
		{
			if (textBox1.Enabled)
				textBox1.Enabled = false;
			else
				textBox1.Enabled = true;
		}
	}
}
