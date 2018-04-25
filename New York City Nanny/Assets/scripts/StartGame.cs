using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public AudioClip doorknob;
       

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Start")){
            SceneManager.LoadScene("Mainroom");
            
        }
    }
}
