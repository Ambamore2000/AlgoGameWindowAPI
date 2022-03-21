
# Window API Usage

This usage guide will go over how to use the Window API and also create new window presets.

## Table of Contents

- [Display Window](#display-window)
- [Window Preset](#window-preset)

## Display Window

The following code example is how you would display a window in a script:

```csharp
WindowAPI.DisplayWindow(new ErrorPreset(), "ERROR:\nWall Error", "Blocked by Wall");
```

The DisplayWindow() function takes in the arguments: (WindowPreset preset, string titleString, string descriptionString)

## Window Preset

The following is the ErrorPreset.cs, which demonstrates an example of how to use the preset.

```csharp
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
```

This diagram showcases the different attributes you can change to create a new preset:

![alt text](https://i.imgur.com/lOvfgsC.jpg)
