using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextOnSelect : MonoBehaviour {

    void OnSelect()
    {
        MoonExplorationManager.ChangeState();
    }
}
