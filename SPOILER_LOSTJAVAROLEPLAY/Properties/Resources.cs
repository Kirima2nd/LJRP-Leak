/*
 * Leaked by Kirima
 * Date: 4/14/2021
 * Time: 10:59 PM
 * 
 * Got pwn'ed lol!
 */
 
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SPOILER_LOSTJAVAROLEPLAY.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (resourceMan == null)
				{
					ResourceManager resourceManager = (resourceMan = new ResourceManager("SPOILER_LOSTJAVAROLEPLAY.Properties.Resources", typeof(Resources).Assembly));
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		internal static Bitmap _20201020_074157
		{
			get
			{
				object @object = ResourceManager.GetObject("20201020_074157", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap download
		{
			get
			{
				object @object = ResourceManager.GetObject("download", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap GTA_V_city_buildings_art_picture_3840x2160
		{
			get
			{
				object @object = ResourceManager.GetObject("GTA-V-city-buildings-art-picture_3840x2160", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap lostjava
		{
			get
			{
				object @object = ResourceManager.GetObject("lostjava", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
