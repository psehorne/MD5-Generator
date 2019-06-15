/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 8/15/2008
 * Time: 2:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
//using System.Windows.Forms;
//using System.Drawing;


namespace MD5_Generator
{
	public partial class MainForm
	{
	
 
		 private string Compute_MD5Hash_FromFile(string FileNameAndPath)
		     {
	          	         	
	          	MD5 md5 = new MD5CryptoServiceProvider();
	          	
	          	FileStream f = new FileStream(
					FileNameAndPath, 
					FileMode.Open, 
					FileAccess.Read, 
					FileShare.Read, 
					8192);

				///calculating the md5
				Byte[] hash = md5.ComputeHash(f);

				f.Close();
				
				
				StringBuilder buff = new StringBuilder();

				foreach (Byte hashByte in hash)
					buff.Append(hashByte.ToString("X2").ToUpper());
				
				return buff.ToString();

	
		     } 
		     
		 
		 private string Compute_MD5Hash_FromText(string str)
		     {
		 	
	 			// convert the string into bytes
				UTF8Encoding enc = new UTF8Encoding();
				byte[] unicodeText = enc.GetBytes(str);
					
				return Compute_MD5Hash_FromBytes(unicodeText);	

		     } 
		 
		 private string Compute_MD5Hash_FromBytes(byte[] str)
		 {
		 	MD5 md5 = new MD5CryptoServiceProvider();
			Byte[] hash = md5.ComputeHash(str);
			StringBuilder buff = new StringBuilder();
			foreach (Byte hashByte in hash)
					buff.Append(hashByte.ToString("X2").ToUpper());
			return buff.ToString();	
		 }
		     	     
	}

}
