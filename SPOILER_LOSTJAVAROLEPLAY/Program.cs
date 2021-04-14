/*
 * Leaked by Kirima
 * Date: 4/14/2021
 * Time: 10:59 PM
 * 
 * Got pwn'ed lol!
 */
 
using System;
using System.Windows.Forms;

namespace SPOILER_LOSTJAVAROLEPLAY
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new MainForm());
		}
	}
}
