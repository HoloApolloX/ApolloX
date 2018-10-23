using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinyOnClick : MonoBehaviour {
    void OnSelect()
    {
        SceneManager.LoadScene("DestinyScene");
    }
}
