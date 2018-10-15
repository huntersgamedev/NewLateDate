using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RythmUI : MonoBehaviour {
    //angryMeterControlls
    public Image AngryIndicator;
    private float FullMeterX= 597.3f;
    private float EmptyMeterX = 66.8f;
    private float MoveAmount;
    public Image Profile;
    public Image InputFeedback;
    public Sprite GoodFeedback;
    public Sprite BadFeedback;

    //timer
    float addOneTimer = 0;
    const float AddOnevisibleTimer = .5f;



    // Use this for initialization
    void Start () {
        // AngryIndicator.transform.position = new Vector3(CurrentPosition,AngryIndicator.transform.position.y,AngryIndicator.transform.position.z));

        angryMeterControl(GameManger.currentAngry);
        
    }
	
	// Update is called once per frame
	void Update () {
        //Testing Meter
        if(addOneTimer >= 0)
        {
            addOneTimer -= Time.deltaTime;

            if(addOneTimer<= 0)
            {
                InputFeedback.GetComponent<Image>().enabled = false;
            }
        }

      
	}



    public void angryMeterControl(float amountChanged)
    {
        
        //calculates the amount to move the meter
        MoveAmount = amountChanged * 5.305f;

        //if the meter is within the max and min move it
        if (AngryIndicator.transform.position.x+MoveAmount<FullMeterX &&
        AngryIndicator.transform.position.x+MoveAmount> EmptyMeterX)
        {
            

            AngryIndicator.transform.position = new Vector3(AngryIndicator.transform.position.x + MoveAmount, AngryIndicator.transform.position.y, AngryIndicator.transform.position.z);
        }

        //if the meter is below the minimum set it to the minimum
        else if (AngryIndicator.transform.position.x + MoveAmount < EmptyMeterX)
        {
            AngryIndicator.transform.position = new Vector3(EmptyMeterX, AngryIndicator.transform.position.y, AngryIndicator.transform.position.z);
        }
        //if the meter is above the maximum set it to the maximum
        else if ( AngryIndicator.transform.position.x + MoveAmount > FullMeterX)
        {
            AngryIndicator.transform.position = new Vector3(FullMeterX, AngryIndicator.transform.position.y, AngryIndicator.transform.position.z);
        }


        

      

    }

    public void TurnOn(bool On)
    {
        if (On == true)
        {
            Profile.GetComponent<Image>().enabled = true;
        }

        else
        {
            Profile.GetComponent<Image>().enabled = false;
        }

        
    }


    public void setFeedback(bool good)
    {
        addOneTimer = AddOnevisibleTimer;
        InputFeedback.GetComponent<Image>().enabled=true;

        if (good == true)
        {
            InputFeedback.GetComponent<Image>().sprite = GoodFeedback;
        }

        else
        {
            InputFeedback.GetComponent<Image>().sprite = BadFeedback;
        }
    }

}
