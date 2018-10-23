using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoonLandingManager : MonoBehaviour {

    public static MoonLandingManager Instance { get; private set; }

    public GameObject lunar;
    public GameObject lunarLight;
    float timeLeft = 15.0f;

    // Use this for initialization
    void Start () {

    }

    void Awake()
    {
        Instance = this;
    }

    public static void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update () {
        if (lunar.transform.position.y >= 160)
        {
            lunar.transform.position = new Vector3(lunar.transform.position.x, lunar.transform.position.y - 0.3f, lunar.transform.position.z);
        }
        else if (lunar.transform.position.y < 160 && lunar.transform.position.y >= 150)
        {
            lunar.transform.position = new Vector3(lunar.transform.position.x, lunar.transform.position.y - 0.1f, lunar.transform.position.z);
        }
        else if (lunar.transform.position.y < 150 && lunar.transform.position.y >= 138)
        {
            lunar.transform.position = new Vector3(lunar.transform.position.x, lunar.transform.position.y - 0.05f, lunar.transform.position.z);
        }

        lunarLight.transform.Rotate(lunarLight.transform.rotation.x, lunarLight.transform.rotation.y + 2, lunarLight.transform.rotation.z);

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("MoonExplorationScene");
            timeLeft = 10000;
            //lunarLight.transform.Rotate(lunarLight.transform.rotation.x, lunarLight.transform.rotation.y + 40, lunarLight.transform.rotation.z);
        }
    }
}
