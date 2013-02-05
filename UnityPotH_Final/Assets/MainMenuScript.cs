using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
    public GUISkin newSkin;
    public Texture2D logoTexture;
	//public Texture2D buttonPlay;
	public GUIStyle buttonPlay;		
	public GUIStyle buttonHelp;
	public GUIStyle buttonCredit;
	public GUIStyle buttonExit;
	//public GUITexture backgroundTexture;
	public Texture backgroundTexture;

    void Start()
    {
        Screen.showCursor = true;
    }

    void theFirstMenu()
    {
		float relativeLogoX = (467 * Screen.width) / 1280;
		float relativeLogoY = (134 * Screen.height) / 720;
		
		float relativeBtnX = ((150 * Screen.width) / 1280);
		float relativeBtnY = ((42.31f * Screen.width) / 720); 
			
        //layout start
		GUI.BeginGroup(new Rect(0, 0, Screen.width, Screen.height));
		
        //the menu background box
        //GUI.Box(new Rect(0, 0, 300, 200), "");

        //logo picture
        //GUI.Label(new Rect((Screen.width/2) - (relativeLogoX/2), relativeLogoY*0.5f, relativeLogoX, relativeLogoY), logoTexture);
		
		//Texture T = GetComponent("BG");
		//GUI.DrawTexture(new Rect(0,0,0,0), T, ScaleMode.StretchToFill);
			
        ///Main menu buttons
        //game play button
		if (GUI.Button(new Rect((Screen.width/2) - (relativeBtnX/2), (relativeLogoY*2) + relativeBtnY, relativeBtnX, relativeBtnY), "", buttonPlay))
		{
			Application.LoadLevel("scene01");
			Debug.Log("Scene01 LOad");
		}
		
        //if (GUI.Button(new Rect(55, 100, 180, 40), "Start game"))
        //{
          //  MainMenuScript script = (MainMenuScript)GetComponent("MainMenuScript");
            //script.enabled = false;
            //MapMenuScript script2 = (MapMenuScript)GetComponent("MapMenuScript");
            //script2.enabled = true;
        //}
		//help button
		if (GUI.Button(new Rect((Screen.width/2) - (relativeBtnX/2), (relativeLogoY*2) + relativeBtnY*2, relativeBtnX, relativeBtnY), "", buttonHelp))
		{
			MainMenuScript script = (MainMenuScript)GetComponent("MainMenuScript");
            script.enabled = false;
            HelpMenuScript script2 = (HelpMenuScript)GetComponent("HelpMenuScript");
            script2.enabled = true;
		}
		//credit button
		if (GUI.Button(new Rect((Screen.width/2) - (relativeBtnX/2), (relativeLogoY*2) + relativeBtnY*3, relativeBtnX, relativeBtnY), "", buttonCredit))
		{
			MainMenuScript script = (MainMenuScript)GetComponent("MainMenuScript");
            script.enabled = false;
            CreditMenuScript script2 = (CreditMenuScript)GetComponent("CreditMenuScript");
            script2.enabled = true;
		}
		//exit button
        if (GUI.Button(new Rect((Screen.width/2) - (relativeBtnX/2), (relativeLogoY*2) + relativeBtnY*4, relativeBtnX, relativeBtnY), "", buttonExit)) 
        {
            Application.Quit();
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
		
        //execute theFirstMenu function
        theFirstMenu();
    }
}
