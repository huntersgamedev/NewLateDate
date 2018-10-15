using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

    float AngryMeter=100f;
    public static float currentAngry=50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            FindObjectOfType<RythmUI>().TurnOn(true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            FindObjectOfType<RythmUI>().TurnOn(false);
        }
		
	}

    // call this when you want to add or take away from angry meter
    public void changeAngryMeter(float amount)
    {
        //adds the amount to the angry meter if it's above 100 set it back to 100
        //if it's below or = to 0 put in loose condition and make sure it's at 0;
        currentAngry = currentAngry + amount;

        if (currentAngry > 50)
        {
            currentAngry = 50;
        }
        else
        {
           FindObjectOfType<RythmUI>().angryMeterControl(amount);
        }
           if (currentAngry <= 0)
        {
            //can also put loose condition
            currentAngry = 0;
        }


    }
    
}
