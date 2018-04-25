using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public Transform phoneOne;
    public GameObject Canvas1;
    public GameObject Canvas2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeScreen()
    {
        
        Canvas1.SetActive(false);
        Canvas2.SetActive(true);

        
    }
}
