using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Enrando en el objeto");
		var module01 = GameObject.Find("Module01");
		var components = module01.GetComponents<Component>();
		//var Wall_048 = GameObject.Find("Module01/Wall_048");
		//Debug.Log("Wall48: " + Wall_048.
		foreach(var c in components)
		{
			if(c.name.StartsWith("Wall_"))
			{
				Debug.Log(c + ": " + c.name);			
				//c.collider = new MeshCollider();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
