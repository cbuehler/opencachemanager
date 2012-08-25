// 
//  Copyright 2011  campbelk
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;

namespace ocmgtk
{


	[System.ComponentModel.ToolboxItem(true)]
	public partial class CleanupPage2 : Gtk.Bin
	{
		CleanupManager mgr;
		
		public int LogLimit
		{
			get { return int.Parse(limitEntry.Text);}
		}

		public CleanupPage2 ()
		{
			this.Build ();
			
		}
		protected virtual void OnCompactToggle (object sender, System.EventArgs e)
		{
			mgr = (this.Parent as CleanupAssistant).Manager;
			mgr.compactDB = compactCheck.Active;
		}
		
		protected virtual void OnBackupToggle (object sender, System.EventArgs e)
		{
			mgr = (this.Parent as CleanupAssistant).Manager;
			mgr.backupDB = backupCheck.Active;
		}
		
		protected virtual void OnLimitToggle (object sender, System.EventArgs e)
		{
			mgr = (this.Parent as CleanupAssistant).Manager;
			mgr.purgeLogs = logLimitCheck.Active;
		}
	}
}
