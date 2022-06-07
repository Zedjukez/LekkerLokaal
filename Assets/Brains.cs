using UnityEngine;
using System.Collections;

public class Brains : MonoBehaviour {

	public static Brains brain;
	public int score; // alle public variabelen  en methods zijn bereikbaar vanuit andere scripts 
	public string name;


	void Awake()
	{
		if(Brains.brain == null)
		{
			Brains.brain = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void AddScore() // alle public variabelen  en methods zijn bereikbaar vanuit andere scripts 
    {
		score++;
	}
}
