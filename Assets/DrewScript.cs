using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrewScript : MonoBehaviour {

    public Text textToEnhance;

    public void OnClick()
    {
        textToEnhance.color = new Color(1.0f,0.5f,0.5f,1.0f); 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
