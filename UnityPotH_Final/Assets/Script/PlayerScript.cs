using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public GameObject Goal;	
	public GameObject Key;
	public GameObject[] Doors;
	public GameObject[] Modules;
	public GUIText Log;
	private bool isDead = false;
	
	float DistIni;
	
	static public bool IsKeyOK;
	
	// Use this for initialization
	void Start () {
		DistIni = Vector3.Distance(transform.position, Key.transform.position);
		IsKeyOK = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if((transform.position.y <= -5) && !isDead) 
		{
			Application.LoadLevel("MainMenu");
			
			//CameraFade.StartAlphaFade(Color.clear, true, 2f, 2f, () => { Application.LoadLevel("MainMenu"); });
			
			//isDead = true;
		}
		
		if(!IsKeyOK)
		{
			var distAct = Vector3.Distance(transform.position, Key.transform.position);
			Log.text = "Distance Key: " + distAct;
			float factor = 1f + (1f - (distAct /DistIni));
			if(factor >= 1)
				Goal.audio.pitch = factor;
		}
		else
		{
			/*RaycastHit hit;
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
	        if (Physics.Raycast(transform.position, fwd, out hit, 3))
			{
				//Debug.Log("There is something in front of the object! " + hit.collider.name);
				if(hit.collider.name == "End")
				{
					Log.text = "Ganaste!!!!";
					Application.LoadLevel("MainMenu");
				}
			
				foreach(var d in Doors)
				{
					if(hit.collider.name == d.name)
					{
						d.renderer.enabled = false;
						d.collider.enabled = false;
					}				
				}
			}*/
		}	
		
		
		
		/*var ray  = Camera.main.ScreenPointToRay (Input.mousePosition);
	    RaycastHit hit;
	    if (collider.Raycast (ray, out hit, 10)) {
	        Debug.DrawLine (ray.origin, hit.point);
			Debug.Log("There is something in front of the object!");
		}*/   
	}	
}
