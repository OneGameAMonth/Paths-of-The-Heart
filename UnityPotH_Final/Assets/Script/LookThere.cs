using UnityEngine;
using System.Collections;

public class LookThere : MonoBehaviour {
    public GameObject firstGoal;
    public GameObject secondGoal;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (firstGoal.activeSelf)
            this.transform.LookAt(firstGoal.transform);
        else this.transform.LookAt(secondGoal.transform);

	}
}
