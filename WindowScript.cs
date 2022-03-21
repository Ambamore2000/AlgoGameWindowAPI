using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Window.Types;

/* We created this scrip in order to load game object dynamically on runtime because when we tried to previously directly load a unity scene, 
we were have conflciting issues with the UI scene. */

/* One of the big issue was that the UI secne was duplicating the avatar when the error was loading. */
/* We created this scence because when we loaded a scence during the execution it didn't complete the rest of the lines of the code.*/
namespace Window {
	public class WindowScript : MonoBehaviour {
		
		private readonly GameObject[] gOList = new GameObject[6];
		private int currIndex;
		
		private static string TitleString = "TITLE";
		private static string DescriptionString = "DESCRIPTION";

		private GameObject CreateGO(string newObjectName, 
			Transform parentTransform) {
			GameObject newGameObject = new GameObject(newObjectName);
			gOList[currIndex++] = newGameObject;
			newGameObject.transform.SetParent(parentTransform);
			return newGameObject;
		}

		private static void AddRectTransformComponent(GameObject newGameObject, 
			int length, int height) {
			RectTransform newRectTransform = 
				newGameObject.AddComponent<RectTransform>();
			newRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, length);
			newRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
		}

		private static void AddColor(GameObject newGameObject, Color color) {
			Image newImage = newGameObject.AddComponent<Image>();
			newImage.GetComponent<Image>().color = color;
		}
		private static void ScaleAndPositionGameObject(GameObject newGameObject, int x, int y, int z) {
			newGameObject.transform.localScale = new Vector3(1, 1, 1);
			newGameObject.transform.localPosition = new Vector3(x, y, z);
		}

		private static void AddTextComponent(GameObject newGameObject, string text, int fontSize, 
			FontStyle fontStyle, Font font, TextAnchor alignment, 
			HorizontalWrapMode horizontalOverflow, VerticalWrapMode verticalOverflow) {
			Text newText = newGameObject.AddComponent<Text>();
			newText.text = text;
			newText.fontSize = fontSize;
			newText.fontStyle = fontStyle;
			newText.font = font;
			newText.alignment = alignment;
			newText.horizontalOverflow = horizontalOverflow;
			newText.verticalOverflow = verticalOverflow;
		}

		private static void AddRawImageComponent(GameObject newGameObject, Texture texture) {
			RawImage newRawImage = newGameObject.AddComponent<RawImage>();
			newRawImage.texture = texture;
		}
		
		private static void AddButtonComponent(GameObject newGameObject, UnityAction listener) {
			Button newButton = newGameObject.AddComponent<Button>();
			newButton.onClick.AddListener(listener);
		}
		public void LoadErrorDisplay(WindowPreset preset) {

			if (GameObject.Find("WindowDisplay"))
				DestroyImmediate(GameObject.Find("WindowDisplay"));
			
			GameObject windowDisplayGO = CreateGO("WindowDisplay", gameObject.transform);
			ScaleAndPositionGameObject(windowDisplayGO, 0, 0, 0);

			Transform parentTransform = windowDisplayGO.transform;
			
			/* Create Window Game Object */

			GameObject windowGO = CreateGO("Window", parentTransform);
			AddRectTransformComponent(windowGO, preset.mainWindowLength, preset.mainWindowHeight);
			AddColor(windowGO, preset.mainWindowColor);
			ScaleAndPositionGameObject(windowGO, preset.mainWindowX, preset.mainWindowY, preset.mainWindowZ);
			
			/* Create Title Box Game Object */

			GameObject titleBoxGO = CreateGO("Title Box", parentTransform);
			AddRectTransformComponent(titleBoxGO, preset.titleBoxLength, preset.titleBoxHeight);
			AddColor(titleBoxGO, preset.titleBoxColor);
			ScaleAndPositionGameObject(titleBoxGO, preset.titleBoxX, preset.titleBoxY, preset.titleBoxZ);

			/* Create Title Text Game Object */

			GameObject titleTextGO = CreateGO("Title Text", parentTransform);
			AddTextComponent(titleTextGO, TitleString, preset.titleTextFontSize, 
				preset.titleTextFontStyle, preset.titleTextFont, preset.titleTextAnchor, 
				preset.titleTextHorizontalWrapMode, preset.titleTextVerticalWrapMode);
			ScaleAndPositionGameObject(titleTextGO, preset.titleTextX, preset.titleTextY, preset.titleTextZ);
			
			/* Create Description Text Game Object */
			
			GameObject descriptionTextGO = CreateGO("Description Text", parentTransform);
			AddTextComponent(descriptionTextGO, DescriptionString, preset.descriptionTextFontSize, 
				preset.descriptionTextFontStyle, preset.descriptionTextFont, 
				preset.descriptionTextAnchor, preset.descriptionTextHorizontalWrapMode, 
				preset.descriptionTextVerticalWrapMode);
			ScaleAndPositionGameObject(descriptionTextGO, preset.descriptionTextX, preset.descriptionTextY, preset.descriptionTextZ);
			
			/* Create Close Button Game Object */
			
			/* In order to have the close function on the event clicks, it passes the close button listener 'function for the event' */
			
			GameObject closeButtonGO = CreateGO("Close Button", parentTransform);
			AddRectTransformComponent(closeButtonGO, preset.closeButtonLength, preset.closeButtonHeight);
			AddRawImageComponent(closeButtonGO, Resources.Load<Texture>("Images/errorClose"));
			AddButtonComponent(closeButtonGO, CloseButton);
			ScaleAndPositionGameObject(closeButtonGO, preset.closeButtonX, preset.closeButtonY, preset.closeButtonZ);

		}
		private void CloseButton() {
			foreach (GameObject t in gOList) {
				DestroyImmediate(t);
			}
			currIndex = 0;
		}

		public static void SetMessage(string title, string description) {
			TitleString = title;
			DescriptionString = description;
		}
	}
	
}
