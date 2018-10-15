using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour {

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

    IEnumerator NextScene()
    {
        
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
