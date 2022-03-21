using UnityEngine;

namespace Window.Types {
	
	public class DebugPreset : WindowPreset {

		public DebugPreset() {
			mainWindowLength = 470;
			mainWindowHeight = 850;
			mainWindowX = 130;
			mainWindowY = 100;
			mainWindowZ = 0;
			
			titleBoxLength = 410;
			titleBoxHeight = 700;
			titleBoxX = 130;
			titleBoxY = 100;
			titleBoxZ = 0;

			titleTextFontSize = 70;
			titleTextX = 125;
			titleTextY = 430;
			titleTextZ = 0;

			descriptionTextFontSize = 50;
			descriptionTextX = 0;
			descriptionTextY = 275;
			descriptionTextZ = 0;

			closeButtonLength = 50;
			closeButtonHeight = 50;
			closeButtonX = 320;
			closeButtonY = 480;
			closeButtonZ = 0;
		}
		
	}
	
}