using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour {


    public static SpaceManager Instance { get; private set; }

    void Start()
    {

    }

    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update () {
		
	}


}
