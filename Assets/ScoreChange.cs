using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Brains.brain.score = 5;
        Brains.brain.AddScore();
        Debug.Log(Brains.brain.score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
