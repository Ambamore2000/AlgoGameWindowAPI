using UnityEngine;

namespace Window.Types {
	
	public class WindowPreset {
		
		public int mainWindowLength;
		public int mainWindowHeight;
		public Color mainWindowColor;
		public int mainWindowX;
		public int mainWindowY;
		public int mainWindowZ;
		
		public int titleBoxLength;
		public int titleBoxHeight;
		public Color titleBoxColor;
		public int titleBoxX;
		public int titleBoxY;
		public int titleBoxZ;
		
		public int titleTextFontSize;
		public readonly FontStyle titleTextFontStyle;
		public readonly Font titleTextFont;
		public readonly TextAnchor titleTextAnchor;
		public readonly HorizontalWrapMode titleTextHorizontalWrapMode;
		public readonly VerticalWrapMode titleTextVerticalWrapMode;
		public int titleTextX;
		public int titleTextY;
		public int titleTextZ;
		
		public int descriptionTextFontSize;
		public readonly FontStyle descriptionTextFontStyle;
		public readonly Font descriptionTextFont;
		public readonly TextAnchor descriptionTextAnchor;
		public readonly HorizontalWrapMode descriptionTextHorizontalWrapMode;
		public readonly VerticalWrapMode descriptionTextVerticalWrapMode;
		public int descriptionTextX;
		public int descriptionTextY;
		public int descriptionTextZ;
		
		public int closeButtonLength;
		public int closeButtonHeight;
		public int closeButtonX;
		public int closeButtonY;
		public int closeButtonZ;
		
		protected WindowPreset() {
			mainWindowLength = 1920;
			mainWindowHeight = 1440;
			mainWindowColor = new Color32(128, 128, 255, 255);
			mainWindowX = 0;
			mainWindowY = 0;
			mainWindowZ = 0;
			
			titleBoxLength = 1520;
			titleBoxHeight = 1240;
			titleBoxColor = new Color32(165,165, 255,255);
			titleBoxX = 0;
			titleBoxY = 0;
			titleBoxZ = 0;

			titleTextFontSize = 150;
			titleTextFontStyle = FontStyle.Bold;
			titleTextFont = (Font) Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
			titleTextAnchor = TextAnchor.UpperCenter;
			titleTextHorizontalWrapMode = HorizontalWrapMode.Overflow;
			titleTextVerticalWrapMode = VerticalWrapMode.Overflow;
			titleTextX = 0;
			titleTextY = 540;
			titleTextZ = 0;

			descriptionTextFontSize = 120;
			descriptionTextFontStyle = FontStyle.Normal;
			descriptionTextFont = (Font) Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
			descriptionTextAnchor = TextAnchor.UpperLeft;
			descriptionTextHorizontalWrapMode = HorizontalWrapMode.Overflow;
			descriptionTextVerticalWrapMode = VerticalWrapMode.Overflow;
			descriptionTextX = -675;
			descriptionTextY = 200;
			descriptionTextZ = 0;

			closeButtonLength = 125;
			closeButtonHeight = 125;
			closeButtonX = 870;
			closeButtonY = 630;
			closeButtonZ = 0;
		}
		
	}
	
}