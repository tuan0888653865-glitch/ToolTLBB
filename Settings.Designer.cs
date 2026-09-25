using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SmartBot.Properties
{
	// Token: 0x02000137 RID: 311
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00016C55 File Offset: 0x00014E55
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04001392 RID: 5010
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
