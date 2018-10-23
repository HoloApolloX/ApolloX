using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LaunchManager : MonoBehaviour {

    public static LaunchManager Instance { get; private set; }

    public GameObject saturn;
    public ParticleSystem particleSystem;
    public static bool has_Started = true;
    public bool is_Partic_Enabled = true;
    float exp = 0.001f;
	// Use this for initialization
	void Start () {
            particleSystem.Stop();
    }
    void Awake()
    {
        Instance = this;
    }

    public static void StartApollo()
    {
        has_Started = false;
    }

    // Update is called once per frame
    void Update () {
        if (!has_Started)
        {
            exp += 0.0002f;
            transform.position = new Vector3(transform.position.x, transform.position.y + exp, transform.position.z);

            if (is_Partic_Enabled)
            {
                particleSystem.Play();
                is_Partic_Enabled = false;
            }
        }

        if (saturn.transform.position.y > 35)
        {
            SceneManager.LoadScene("MoonLandingScene");
        }

    }
}
