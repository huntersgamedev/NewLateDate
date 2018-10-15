using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {

    private static AudioManager myManagerInstance;
    public float bpm;
    private float beatInterval, beatTimer , beatIntervalD8, beatTimerD8;
    public static bool beatFull , beatD8;
    public static int beatCountFull, beatCountd8;

    public Image manImage;
    public bool CanHit;
    

    private void Awake()
    {
        if (myManagerInstance != null && myManagerInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            myManagerInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BeatDetection();
	}

    void BeatDetection()
    {
        //full beat
        beatFull = false;
       // manImage.color = Color.white;
        beatInterval = 60 / bpm;
        beatTimer += Time.deltaTime;
        if(beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            beatFull = true;
            beatCountFull++;
            Debug.Log("Full Beat");
            CanHit = true;
            StartCoroutine(ChangeColor());
           //anImage.color = Color.green;
        }
        //divided beat
        beatD8 = false;
        beatIntervalD8 = beatInterval / 8;
        beatTimerD8 += Time.deltaTime;
        if(beatTimerD8>= beatIntervalD8)
        {
            beatTimerD8 -= beatIntervalD8;
            beatD8 = true;
            beatCountd8++;
            Debug.Log("Eighth Beat");
        }
    }


    IEnumerator ChangeColor()
    {
        manImage.color = Color.green;
        yield return new WaitForSeconds(0.5f);
        manImage.color = Color.white;
        CanHit = false;
    }
}
