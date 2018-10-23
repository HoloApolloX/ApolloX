using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMoonOnSelect : MonoBehaviour {

    void OnSelect()
    {
        MoonLandingManager.ChangeScene();
    }
}
