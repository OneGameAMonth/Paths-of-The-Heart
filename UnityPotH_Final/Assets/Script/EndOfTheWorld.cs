using UnityEngine;
using System.Collections;

public class EndOfTheWorld : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        CameraFade.StartAlphaFade(Color.white, true, 2f, 2f, () => { Application.LoadLevel("MainMenu"); });
    }


}
