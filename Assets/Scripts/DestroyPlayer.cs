using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

    int destructionTimer;

	// Use this for initialization
	void Start () {
        destructionTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (destructionTimer < 120)
        {
            destructionTimer += 1;
        }

	}
}
