using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter(Collision collision) {
		Debug.Log("Collision: " + collision.gameObject.name);
        foreach (ContactPoint contact in collision.contacts) {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
	}
}
