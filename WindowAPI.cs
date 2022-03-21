using UnityEngine;
using UnityEngine.SceneManagement;
using Window.Types;

namespace Window {
	
	public static class WindowAPI {
		public static void DisplayWindow(WindowPreset preset, string titleString, string descriptionString) {
			WindowScript.SetMessage(titleString, descriptionString);

			GameObject.Find("Canvas").AddComponent<WindowScript>().LoadErrorDisplay(preset);
		}
		
	}
	
}