using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onthouderScript : MonoBehaviour
{

    public static string username;
    public Text gebruikersnaamText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gebruikersnaamText.text = "Hallo " + Brains.brain.name;
    }

    public void SaveUsername(string newName)
    {
        username = newName;
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
