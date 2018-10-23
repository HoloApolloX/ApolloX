using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartApolloOnSelect : MonoBehaviour {

    void OnSelect()
    {
        LaunchManager.StartApollo();
    }
}
