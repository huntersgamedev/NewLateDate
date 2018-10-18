using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    private static AudioManager myManagerInstance;
    public float bpm;
    private float beatInterval, beatTimer , beatIntervalD2, beatTimerD2, beatIntervalD8, beatTimerD8;
    public static bool beatFull , beatD2, beatD8;
    public static int beatCountFull, beatCountD2, beatCountd8;

    public Image manImage;
    public Image clothingManImage;
    public bool CanHit;
    public bool CanHitHalf;

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
        //Half Beat
        beatD2 = false;
        beatIntervalD2 = beatInterval / 2;
        beatTimerD2 += Time.deltaTime;
        if (beatTimerD2 >= beatIntervalD2)
        {
            beatTimerD2 -= beatIntervalD2;
            beatD2 = true;
            beatCountD2++;
            CanHitHalf = true;
            StartCoroutine(ChangeClothingColor());
            Debug.Log("Half Beat");
        }
        //Eight beat
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
        if (SceneManager.GetActiveScene().name == "BaseScene" || SceneManager.GetActiveScene().name == "BaseScene neil 1")
        {
            manImage.color = Color.green;
            yield return new WaitForSeconds(0.5f);
            manImage.color = Color.white;
            CanHit = false;
        }
    }

    IEnumerator ChangeClothingColor()
    {
        if (SceneManager.GetActiveScene().name == "BaseScene" || SceneManager.GetActiveScene().name == "BaseScene neil 1")
        {
            clothingManImage.color = Color.green;
            yield return new WaitForSeconds(0.2f);
            clothingManImage.color = Color.white;
            CanHitHalf = false;
        }
    }
}

