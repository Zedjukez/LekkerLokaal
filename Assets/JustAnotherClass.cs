using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustAnotherClass : MonoBehaviour {

	public void OnMouseUp()
    {
        Brains.brain.score++;
        Debug.Log(Brains.brain.score);
    }
}
