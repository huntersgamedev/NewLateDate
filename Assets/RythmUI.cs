using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RythmUI : MonoBehaviour {
    //angryMeterControlls
    public Image AngryIndicator;
    private float FullMeterX= 597.3f;
    private float EmptyMeterX= 66.8f;
    public float testAmount;
    private float MoveAmount;  
       

	// Use this for initialization
	void Start () {
        // AngryIndicator.transform.position = new Vector3(CurrentPosition,AngryIndicator.transform.position.y,AngryIndicator.transform.position.z));

       
    }
	
	// Update is called once per frame
	void Update () {
        //Testing Meter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            angryMeterControl(testAmount);
        }
	}

    private void angryMeterControl(float amountChanged)
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



}
