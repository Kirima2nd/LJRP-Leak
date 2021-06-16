/*
 * Leaked by Kirima
 * Date: 4/14/2021
 * Time: 10:59 PM
 * 
 * Got pwn'ed lol!
 */
 
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;
using SPOILER_LOSTJAVAROLEPLAY.Properties;


namespace SPOILER_LOSTJAVAROLEPLAY
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string[] data { get; set; }
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			// pake ini, soalnya terlalu idiot
			ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
			WebClient webClient = new WebClient();
			timer1.Start();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{          
			string tmp;
			
			WebClient webClient = new WebClient();
			
			tmp = webClient.DownloadString("https://raw.githubusercontent.com/Kirima2nd/LJRP-Leak/main/info/data.txt");
			
			if (tmp == null) {
				MessageBox.Show("Data tidak ada, entah di patch atau emang ga update lagi", "Lost Java Roleplay", MessageBoxButtons.OK);
				Close();
				Application.Exit();
			}

			data = tmp.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);		
			MessageBox.Show("Launcher Latest Version", "Lost Java Roleplay", MessageBoxButtons.OK);
			
			string text = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP").GetValue("gta_sa_exe").ToString();
			text = text.Substring(0, text.LastIndexOf("\\") + 1);
			
			textBox1.Text = Registry.CurrentUser.OpenSubKey("Software\\SAMP", writable: true).GetValue("PlayerName").ToString();
			
			if (!File.Exists(text + "gta_sa.exe"))
			{
				MessageBox.Show("Tidak ada gta_sa.exe dan Folder GTA\n" + text + "\nReinstall client SAMP, atau reinstall GTA SA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Close();
				Application.Exit();
			}
			else if (!File.Exists(text + "samp.exe"))
			{
				MessageBox.Show("Buka samp.exe:\n" + text + "\nInstall ulang SAMP.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Close();
				Application.Exit();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string text = data[0];
			string text2 = data[1];
			
			string text3 = Registry.CurrentUser.OpenSubKey("Software\\\\SAMP").GetValue("gta_sa_exe").ToString();
			text3 = text3.Substring(0, text3.LastIndexOf("\\") + 1);
			
			Registry.CurrentUser.OpenSubKey("Software\\SAMP", writable: true).SetValue("PlayerName", textBox1.Text);
			Process.Start(text3 + "samp.exe", text + " " + text2);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.lostjavaroleplay.com/");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.instagram.com/ljrp.id/");
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			string text = label5.Text;
			string text2 = text.Substring(0, 1);
			string text3 = text.Substring(1, text.Length - 1);
			string text4 = text3 + text2;
			label5.Text = text4;
		}

		private void label5_Click(object sender, EventArgs e)
		{
		}
	}
}
