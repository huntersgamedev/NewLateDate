using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private AudioManager audioManager;

	// Use this for initialization
	void Start () {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
         }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && audioManager.CanHit == true)
        {
            Debug.Log("Hit Beat");

        }
        else if (Input.GetKeyDown(KeyCode.Space) && audioManager.CanHit == false)
        {
            Debug.Log("Missed Beat");
        }
		
	}
}
