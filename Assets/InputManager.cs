using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private AudioManager audioManager;
    public float offset;
    private GameObject player;

	// Use this for initialization
	void Start () {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space) && audioManager.CanHit == true)
        //{
        //    Debug.Log("Hit Beat");

        //}
        //else if (Input.GetKeyDown(KeyCode.Space) && audioManager.CanHit == false)
        //{
        //    Debug.Log("Missed Beat");
        //}



        if (Input.GetKeyDown(KeyCode.W) && audioManager.CanHit == true)
        {
            player.transform.position += new Vector3(-offset, 0, 0);
            FindObjectOfType<GameManger>().changeAngryMeter(2);
            FindObjectOfType<RythmUI>().setFeedback(true);

        }
        else if (Input.GetKeyDown(KeyCode.S) && audioManager.CanHit == true)
        {
            player.transform.position += new Vector3(offset, 0, 0);
            FindObjectOfType<GameManger>().changeAngryMeter(2);
            FindObjectOfType<RythmUI>().setFeedback(true);
        }
        else if (Input.GetKeyDown(KeyCode.A) && audioManager.CanHit == true)
        {
            player.transform.position += new Vector3(0, 0, -offset);
            FindObjectOfType<GameManger>().changeAngryMeter(2);
            FindObjectOfType<RythmUI>().setFeedback(true);
        }
        else if (Input.GetKeyDown(KeyCode.D) && audioManager.CanHit == true)
        {
            player.transform.position += new Vector3(0, 0, offset);
            FindObjectOfType<GameManger>().changeAngryMeter(2);
            FindObjectOfType<RythmUI>().setFeedback(true);
        }
        else if(Input.anyKeyDown && audioManager.CanHit == false)
        {
            FindObjectOfType<GameManger>().changeAngryMeter(-5);
            FindObjectOfType<RythmUI>().setFeedback(false);
        }

    }
}
