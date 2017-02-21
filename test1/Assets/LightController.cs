using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public GameObject LightObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI () {

        float x = Screen.width / 2 - 50;
        float y = Screen.height / 2 - 50;
        
        if(GUI.Button(new Rect(x,y, 100, 100), "I am a button"))
        {
            Debug.Log(Time.time);
            bool l = LightObject.GetComponent<Light>().enabled;

            LightObject.GetComponent<Light>().enabled = !l ;


        }

    }

}
