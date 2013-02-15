using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {
	
	public GameObject[] Modules;
	
	// Use this for initialization
	void Start () {
		//if(Modules != null && Modules.Length)
		Shuffle(Modules);
        Screen.showCursor = false;
        GameObject.Find("End").transform.position = GameObject.Find("Ella1").transform.position;
		
	}
	
	void OnMouseDown () {
    	// Lock the cursor
    	Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Shuffle(GameObject[] mods) 
	{
		var vect = new Vector3[mods.Length];
		for (int i = 0; i < mods.Length; i++) 
		{			
			var pos = mods[i].transform.position;
			vect[i] = new Vector3(pos.x, pos.y, pos.z);
			//Debug.Log("P1: " + Modules[i].transform.position + "  P2: " + vect[i]);
		}
		
		for (int i = 0; i < mods.Length; i++) 
		{
			var temp = vect[i];
			var randomIndex = Random.Range(0, mods.Length);
			vect[i] = vect[randomIndex];
			vect[randomIndex] = temp;
		}
		for (int i = 0; i < mods.Length; i++) 
		{			
			Modules[i].transform.position = vect[i];			
		}
	}
}
