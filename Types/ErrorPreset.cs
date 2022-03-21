using UnityEngine;

namespace Window.Types {
	
	public class ErrorPreset : WindowPreset {

		public ErrorPreset() {
			mainWindowLength = 900;
			mainWindowHeight = 900;
			
			titleBoxLength = 800;
			titleBoxHeight = 800;

			titleTextFontSize = 70;
			titleTextX = 0;
			titleTextY = 320;
			titleTextZ = 0;

			descriptionTextFontSize = 60;
			descriptionTextX = -300;
			descriptionTextY = 130;
			descriptionTextZ = 0;

			closeButtonLength = 120;
			closeButtonHeight = 90;
			closeButtonX = 320;
			closeButtonY = -340;
			closeButtonZ = 0;
		}
		
	}
	
}
