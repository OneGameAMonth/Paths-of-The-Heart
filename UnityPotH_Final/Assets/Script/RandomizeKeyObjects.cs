using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeKeyObjects : MonoBehaviour {
    public GameObject spotligth;
    public string findModelsNamed;
    private bool hasStarted = false;

	// Use this for initialization
	void Start () {
        var keyList = GameObject.FindGameObjectsWithTag("Knife");

        int idx = Random.Range(0, keyList.Length - 1);

        Debug.Log(idx);
        Debug.Log(keyList[idx].name);
        spotligth.transform.position = keyList[idx].transform.TransformPoint(Vector3.zero);


        /*spotligth.transform.position = new Vector3(keyList[idx].transform.position.x,
            keyList[idx].transform.position.y-10, keyList[idx].transform.position.z);*/
        //-44.50751
        for (int i = 0; i < keyList.Length; i++)
        {
            if (i != idx) keyList[i].SetActive(false);
        }

        hasStarted = false;
	}
	
	// Update is called once per frame
	void Update () {


	}
}
