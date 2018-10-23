using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CupolaOnClick : MonoBehaviour {

    void OnSelect()
    {
        SceneManager.LoadScene("CupolaScene");
    }
}
