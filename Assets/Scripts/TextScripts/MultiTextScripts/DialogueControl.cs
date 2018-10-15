using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueControl : MonoBehaviour {

    [SerializeField] public Text Atext;
    [SerializeField] public Text Btext;
    [SerializeField] public Text Ctext;
    [SerializeField] public Text AIresponse;

    public static string currentPos = "Sally";
    public string SallyA = "What's your favorite color?";
    public string SallyAA = "Why do you like it?";
    public string SallyAB = "I thought girls liked pink.";
    public string SallyAC = "That's my favorite color too!";
    public string SallyAAA = "That's interesting.";
    public string SallyAAB = "You're not very girly";
    public string SallyAAC = "Wow I feel the same way.?";
    public string SallyABA = "Sorry, it was silly to think all girls like pink.";
    public string SallyACB = "Still think it's weird.";
    public string SallyABC = "It's also my favorite.";

    public string SallyB = "What's your favorite song?";
    public string SallyBA = "Why do you like it?";
    public string SallyBB = "I thought girls liked romantic songs.";
    public string SallyBC = "That's my favorite song too!";
    public string SallyBAA = "That's interesting.";
    public string SallyBAB = "Girls shouldn't listen to that.";
    public string SallyBAC = "Wow I feel the same way.?";
    public string SallyBBA = "Sorry, it was silly to think all girls like pop.";
    public string SallyBBB = "Still think it's weird.";
    public string SallyBBC = "It's also my favorite.";

    public string SallyC = "What's your favorite food?";
    public string SallyCA = "Why do you like it?";
    public string SallyCB = "Shoudn't you eat salads?";
    public string SallyCC = "That's my favorite too!";
    public string SallyCAA = "Sounds delicious.";
    public string SallyCAB = "That's weird";
    public string SallyCBA = "Sorry, I thought girls should eat salads.";
    public string SallyCBB = "Girls shouldn't eat that.";

    public string SallyReplyStart = "Hi there!";

    public string SallyReplyA = "Blue.";
    public string SallyReplyAA = "It reminds me of the ocean sky.";
    public string SallyReplyAB = "Not all girls like pik. Tat is a stereotype.";

    public string SallyReplyB = "Everdream.";
    public string SallyReplyBA = "It inspires me.";
    public string SallyReplyBB = "A girl can like whatever type of music she wants.";

    public string SallyReplyC = "Lobster.";
    public string SallyReplyCA = "I love how it tastes in butter.";
    public string SallyReplyCB = "A girl can like whatever type of food she wants.";

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

        if (currentPos == "SallyA")
        {
            Atext.GetComponent<Text>().text = SallyAA;
            Btext.GetComponent<Text>().text = SallyAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyA;
        }
        if (currentPos == "SallyAA")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAA;
        }
        if (currentPos == "SallyAB")
        {
            Atext.GetComponent<Text>().text = SallyAA;
            Btext.GetComponent<Text>().text = SallyAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyAB;
        }
        if (currentPos == "SallyB")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyB;
        }
        if (currentPos == "SallyBA")
        {
            Atext.GetComponent<Text>().text = SallyAA;
            Btext.GetComponent<Text>().text = SallyAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBA;
        }
        if (currentPos == "SallyBB")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyBB;
        }
        if (currentPos == "SallyC")
        {
            Atext.GetComponent<Text>().text = SallyAA;
            Btext.GetComponent<Text>().text = SallyAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyC;
        }
        if (currentPos == "SallyCA")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCA;
        }
        if (currentPos == "SallyCB")
        {
            Atext.GetComponent<Text>().text = SallyAAA;
            Btext.GetComponent<Text>().text = SallyAAB;
            Ctext.GetComponent<Text>().text = SallyAC;
            AIresponse.GetComponent<Text>().text = SallyReplyCB;
        }
      
    }
}
