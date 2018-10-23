using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksOnSelect : MonoBehaviour {

    void OnSelect()
    {
        gameObject.SetActive(false);
        MoonExplorationManager.CollectRocks();
    }
}
