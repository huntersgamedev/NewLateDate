using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManUI : MonoBehaviour {

    public float speed;
    Vector3 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((new Vector3(-1, 0, 0) * speed * Time.deltaTime));

	}
}
