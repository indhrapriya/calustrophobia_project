using UnityEngine;
using System.Collections;

public class Menutest : MonoBehaviour {
	private string widthTextValue = "";
	private string heightTextValue = "";
	private string lengthTextValue = "";
	private string peopleTextValue = "";
	private string widthLabel 	= "Width";
	private string heightLabel 	= "Height";
	private string lengthLabel 	= "Length";
	private string peopleLabel 	= "People";
	private void OnGUI(){
		if (GUI.Button (new Rect ((Screen.width / 2) - 100, (Screen.height / 2) + 100, 200, 30), "Options")) {

		}

		GUI.TextField (new Rect ((Screen.width / 2) - 100, (Screen.height / 2) - 100, 200, 30), widthTextValue, 20);
		GUI.TextField (new Rect ((Screen.width / 2) - 100, (Screen.height / 2) - 50, 200, 30), heightTextValue, 1);
		GUI.TextField (new Rect ((Screen.width / 2) - 100, (Screen.height / 2) - 0, 200, 30), lengthTextValue, 1);
		GUI.TextField (new Rect ((Screen.width / 2) - 100, (Screen.height / 2) + 50, 200, 30), peopleTextValue, 1);
		GUI.Label (new Rect ((Screen.width / 2) - 200, (Screen.height / 2) -100, 200, 30), widthLabel);
		GUI.Label (new Rect ((Screen.width / 2) - 200, (Screen.height / 2) -50, 200, 30), heightLabel);
		GUI.Label (new Rect ((Screen.width / 2) - 200, (Screen.height / 2) -0, 200, 30), lengthLabel);
		GUI.Label (new Rect ((Screen.width / 2) - 200, (Screen.height / 2) + 50, 200, 30), peopleLabel);

		
	}

}
