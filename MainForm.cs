/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 8/15/2008
 * Time: 12:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MD5_Generator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void fileRadioButtonClicked(object sender, System.EventArgs e)
		{
			textBox1.Enabled = false;
		    
		    
		}
		
		void textRadioButtonClicked(object sender, System.EventArgs e)
		{
			textBox1.Enabled = true;
		}
		
		void generateMD5ButtonClicked(object sender, System.EventArgs e)
		{
			
			if (textBox1.Text.Length >0) {
				if (enterTextManuallyButton.Checked)
				{
					
					MD5ResultTextBox.Text = Compute_MD5Hash_FromText(textBox1.Text);
				}
				else 
				{
					// if file button is checked and a file has been selected
					MD5ResultTextBox.Text = Compute_MD5Hash_FromFile(textBox1.Text);
				}
				
				compareButton.Enabled = true;
				compareTextBox.Enabled = true;
			}
			else {
				MessageBox.Show("Text Box Is Empty.", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			
		}

		void copyToClipboarButtonClicked(object sender, System.EventArgs e)
		{
			Clipboard.SetText(MD5ResultTextBox.Text);
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			textBox1.Enabled = false;
			enterTextManuallyButton.Checked = false;				
		}
		
			
		
		
		void CompareButtonClick(object sender, EventArgs e)
		{
			if (compareTextBox.Text.Length <= 0)
               MessageBox.Show("'Compare To Text' Box Is Empty.", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           	else
           	{
           	
           		if (MD5ResultTextBox.Text.ToUpper().CompareTo(compareTextBox.Text.ToUpper()) == 0)
                   MessageBox.Show("Strings are equal.", "MD5 Compare Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
               	else
                   MessageBox.Show("Strings are NOT equal.", "MD5 Compare Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
           	}
		}
	}
}
