using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour {

    public float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(AudioManager.beatCountFull);
        if (AudioManager.beatCountFull >= 60)
        {

            StartCoroutine(NextScene());
        }

        
	}

    //player colliding with door triggers
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit Door");
            StartCoroutine(NextScene());
        }
    }

    public IEnumerator NextScene()
    {
        
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
