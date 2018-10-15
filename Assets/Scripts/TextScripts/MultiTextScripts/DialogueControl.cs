using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueControl : MonoBehaviour {

    [SerializeField] public Text Atext;
    [SerializeField] public Text Btext;
    [SerializeField] public Text Ctext;
    [SerializeField] public Text AIresponse;

    private static string currentPos = "Sally";


    //A
    private string SallyA = "Hi Iana.";

    private string SallyAA = "Well most people are idiots.";
    private string SallyAB = "I actually wasn't sure what your name was.";
    private string SallyAC = "I was actually trying to mispronounce it. ";

    private string SallyAAA = "Pizza.";
    private string SallyAAB = "Nothing. ";
    private string SallyAAC = "Poutine?";

    private string SallyABA = "Pizza.";
    private string SallyABB = "Nothing.";
    private string SallyABC = "Poutine?";

    private string SallyACA = "Pizza.";
    private string SallyACB = "Nothing.";
    private string SallyACC = "Poutine?";


    //B
    private string SallyB = "Hi Jana.";

    private string SallyBA = "Well most people are idiots.";
    private string SallyBB = "I actually wasn't sure what your name was.";
    private string SallyBC = "I was actually trying to mispronounce it.";

    private string SallyBAA = "Pizza.";
    private string SallyBAB = "Nothing.";
    private string SallyBAC = "Poutine?";

    private string SallyBBA = "Pizza.";
    private string SallyBBB = "Nothing";
    private string SallyBBC = "Poutine.";

    private string SallyBCA = "Pizza.";
    private string SallyBCB = "Nothing.";
    private string SallyBCC = "Poutine?";


    //C
    private string SallyC = "Hi.";

    private string SallyCA = "Well most people are idiots. ";
    private string SallyCB = "I actually wasn't sure what your name was.";
    private string SallyCC = "I was actually trying to mispronounce it.";

    private string SallyCAA = "Pizza.";
    private string SallyCAB = "Nothing.";
    private string SallyCAC = "Poutine.";

    private string SallyCBA = "Pizza.";
    private string SallyCBB = "Nothing.";
    private string SallyCBC = "Poutine.";

    private string SallyCCA = "Pizza.";
    private string SallyCCB = "Nothing.";
    private string SallyCCC = "Poutine.";






    public string SallyReplyStart = "Hi there!";


    //A
    private string SallyReplyA = "You got my name right! Most people mispronounce it.";

    private string SallyReplyAA = "You're damn right! What should we order for dinner?";
    private string SallyReplyAB = "Well atleast you're honest. What should we order for dinner?";
    private string SallyReplyAC = "You sound like an asshole. What should we get to eat?";

    private string SallyReplyAAA = "Well we can but I feel like you haven't looked at my bio.";
    private string SallyReplyAAB = "Well we can but I feel like you haven't looked at my bio.";
    private string SallyReplyAAC = "Wow, you must have looked at my bio.";

    private string SallyReplyABA = "Well we can but I feel like you haven't looked at my bio.";
    private string SallyReplyABB = "Well we can but I feel like you haven't looked at my bio.";
    private string SallyReplyABC = "Wow, you must have looked at my bio.";

    private string SallyReplyACA = "Well we can but I feel like you haven't looked at my bio.";
    private string SallyReplyACB = "Well we can but I feel like you haven't looked at my bio.";
    private string SallyReplyACC = "Wow, you must have looked at my bio.";

    //B
    private string SallyReplyB = "You Idiot, my name is Iana!";

    private string SallyReplyBA = "You're damn right! What should we order for dinner?";
    private string SallyReplyBB = "Well atleast you're honest. What should we order for dinner?";
    private string SallyReplyBC = "You sound like an asshole. What should we get to eat?";

    private string SallyReplyBBA = "Well we can but I feel like you havnt looked at my bio.";
    private string SallyReplyBBB = "Well we can but I feel like you havnt looked at my bio.";
    private string SallyReplyBBC = "Wow, you must have looked at my bio";

    private string SallyReplyBAA = "Well we can but I feel like you havnt looked at my bio.";
    private string SallyReplyBAB = "Well we can but I feel like you havnt looked at my bio.";
    private string SallyReplyBAC = "Wow, you must have looked at my bio";

    private string SallyReplyBCA = "Well we can but I feel like you havnt looked at my bio.";
    private string SallyReplyBCB = "Well we can but I feel like you havnt looked at my bio.";
    private string SallyReplyBCC = "Wow, you must have looked at my bio";


    //C
    private string SallyReplyC = "That's a shitty opener.";

    private string SallyReplyCA = "You're damn right! What should we order for dinner?";
    private string SallyReplyCB = "Well atleast you're honest. What should we order for dinner?";
    private string SallyReplyCC = "You sound like an asshole. What should we get to eat?";

    private string SallyReplyCAA = "Well we can but I feel like you haven't looked at my bio";
    private string SallyReplyCAB = "Well we can but I feel like you haven't looked at my bio";
    private string SallyReplyCAC = "Wow, you must have looked at my bio.";

    private string SallyReplyCBA = "Well we can but I feel like you haven't looked at my bio";
    private string SallyReplyCBB = "Well we can but I feel like you haven't looked at my bio";
    private string SallyReplyCBC = "Wow, you must have looked at my bio.";

    private string SallyReplyCCA = "Well we can but I feel like you haven't looked at my bio";
    private string SallyReplyCCB = "Well we can but I feel like you haven't looked at my bio";
    private string SallyReplyCCC = "Wow, you must have looked at my bio.";

    public static int SallySync = 0;

    // Use this for initialization
    void Start () {
        Atext.GetComponent<Text>().text = SallyA;
        Btext.GetComponent<Text>().text = SallyB;
        Ctext.GetComponent<Text>().text = SallyC;
        AIresponse.GetComponent<Text>().text = SallyReplyStart;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        //currentPos += gameObject.name;
        //Debug.Log(gameObject.name);

        //if (currentPos == "SallyA")
        //{
        //    Atext.GetComponent<Text>().text = SallyAA;
        //    Btext.GetComponent<Text>().text = SallyAB;
        //    Ctext.GetComponent<Text>().text = SallyAC;
        //    AIresponse.GetComponent<Text>().text = SallyReplyA;
        //}
    }


    public void SetText()
    {

        currentPos += gameObject.name;
        Debug.Log(gameObject.name);


        //A
        //tier 1
        if (currentPos == "SallyA")
        {
            Atext.GetComponent<Text>().text = SallyAA;
            Btext.GetComponent<Text>().text = SallyAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyA;
        }

        //tier 2
        if (currentPos == "SallyAA")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAA;
        }
        if (currentPos == "SallyAB")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAB;

        }
        if (currentPos == "SallyAC")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAC;
        }

        //tier 3
        if (currentPos == "SallyAAA")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAAA;
        }
        if (currentPos == "SallyAAB")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAAB;
        }
        if (currentPos == "SallyAAC")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAAC;
        }




        //B
        //tier 1
        if (currentPos == "SallyB")
        {
            Atext.GetComponent<Text>().text = SallyBA;
            Btext.GetComponent<Text>().text = SallyBB;
            Ctext.GetComponent<Text>().text = SallyBC;
            AIresponse.GetComponent<Text>().text = SallyReplyB;
        }

        //tier 2
        if (currentPos == "SallyBA")
        {
            Atext.GetComponent<Text>().text = SallyBAA;
            Btext.GetComponent<Text>().text = SallyBAB;
            Ctext.GetComponent<Text>().text = SallyBAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBA;
        }
        if (currentPos == "SallyBB")
        {
            Atext.GetComponent<Text>().text = SallyBAA;
            Btext.GetComponent<Text>().text = SallyBAB;
            Ctext.GetComponent<Text>().text = SallyBAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBB;
        }
        if (currentPos == "SallyBC")
        {
            Atext.GetComponent<Text>().text = SallyBAA;
            Btext.GetComponent<Text>().text = SallyBAB;
            Ctext.GetComponent<Text>().text = SallyBAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBC;
        }

        //tier 3
        if (currentPos == "SallyBBA")
        {
            Atext.GetComponent<Text>().text = SallyBAA;
            Btext.GetComponent<Text>().text = SallyBAB;
            Ctext.GetComponent<Text>().text = SallyBAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBBA;
        }
        if (currentPos == "SallyBBB")
        {
            Atext.GetComponent<Text>().text = SallyBAA;
            Btext.GetComponent<Text>().text = SallyBAB;
            Ctext.GetComponent<Text>().text = SallyBAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBBB;
        }
        if (currentPos == "SallyBBC")
        {
            Atext.GetComponent<Text>().text = SallyBAA;
            Btext.GetComponent<Text>().text = SallyBAB;
            Ctext.GetComponent<Text>().text = SallyBAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBBC;
        }





        //C
        //tier 1
        if (currentPos == "SallyC")
        {
            Atext.GetComponent<Text>().text = SallyCA;
            Btext.GetComponent<Text>().text = SallyCB;
            Ctext.GetComponent<Text>().text = SallyCC;
            AIresponse.GetComponent<Text>().text = SallyReplyC;
        }

        //tier 2
        if (currentPos == "SallyCA")
        {
            Atext.GetComponent<Text>().text = SallyCAA;
            Btext.GetComponent<Text>().text = SallyCAB;
            Ctext.GetComponent<Text>().text = SallyCAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCA;
        }
        if (currentPos == "SallyCB")
        {
            Atext.GetComponent<Text>().text = SallyCAA;
            Btext.GetComponent<Text>().text = SallyCAB;
            Ctext.GetComponent<Text>().text = SallyCAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCB;
        }
        if (currentPos == "SallyCC")
        {
            Atext.GetComponent<Text>().text = SallyCAA;
            Btext.GetComponent<Text>().text = SallyCAB;
            Ctext.GetComponent<Text>().text = SallyCAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCC;
        }


        //tier 3
        if (currentPos == "SallyCCA")
        {
            Atext.GetComponent<Text>().text = SallyCAA;
            Btext.GetComponent<Text>().text = SallyCAB;
            Ctext.GetComponent<Text>().text = SallyCAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCCA;
        }
        if (currentPos == "SallyCCB")
        {
            Atext.GetComponent<Text>().text = SallyCAA;
            Btext.GetComponent<Text>().text = SallyCAB;
            Ctext.GetComponent<Text>().text = SallyCAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCCB;
        }
        if (currentPos == "SallyCCC")
        {
            Atext.GetComponent<Text>().text = SallyCAA;
            Btext.GetComponent<Text>().text = SallyCAB;
            Ctext.GetComponent<Text>().text = SallyCAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCCC;
        }

    }
}
