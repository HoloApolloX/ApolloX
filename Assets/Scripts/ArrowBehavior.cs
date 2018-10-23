using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehavior : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(gameObject.transform.rotation.y + 0.8f, 0 , 0);
    }
}
