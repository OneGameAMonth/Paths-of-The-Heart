using UnityEngine;
using System.Collections;

public class KeyTrigger : MonoBehaviour {
	
	public Light[] Lights;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider collision) {
		Debug.Log("Collision name: " + collision.gameObject.name);
        //Destroy(collision.gameObject);		
		if(collision.gameObject.name == "Player")
		{
			Debug.Log("Collision Key");
			PlayerScript.IsKeyOK = true;
			foreach(var l in Lights)
			{
				l.enabled = false;
			}
		}

        var doorList = GameObject.FindGameObjectsWithTag("Door");

        for (int i = 0; i < doorList.Length; i++)
        {
            doorList[i].SetActive(false);
        }

        var keyList = GameObject.FindGameObjectsWithTag("Knife");
        
        for (int i = 0; i < keyList.Length; i++)
        {
            keyList[i].SetActive(false);
        }

        this.gameObject.SetActive(false);
    }
}
