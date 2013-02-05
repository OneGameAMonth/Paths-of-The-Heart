using UnityEngine;
using System.Collections;

public class CreditMenuScript : MonoBehaviour {
	public GUISkin newSkin;
	public Texture backgroundTexture;
	
	public GUIStyle buttonGoBack;
	
	void theHelpMenu() {
		float relativeBtnX = ((164 * Screen.width) / 1280);
		float relativeBtnY = ((44 * Screen.width) / 720);
		
		//layout start
		GUI.BeginGroup(new Rect(0, 0, Screen.width, Screen.height));
		
		//Go back
		if (GUI.Button(new Rect((Screen.width/2) - (relativeBtnX/2), Screen.height - (relativeBtnY * 1.2f), relativeBtnX, relativeBtnY), "", buttonGoBack))
        {
            MainMenuScript script = (MainMenuScript)GetComponent("MainMenuScript");
            script.enabled = true;
            CreditMenuScript script2 = (CreditMenuScript)GetComponent("CreditMenuScript");
            script2.enabled = false;
        }
		
		//layout end
        GUI.EndGroup();
	}
	
	void OnGUI()
    {
        //load GUI skin
        GUI.skin = newSkin;
		
		//Load Background
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture, ScaleMode.StretchToFill);
		
        //execute theMapMenu function
        theHelpMenu();
    }
}
