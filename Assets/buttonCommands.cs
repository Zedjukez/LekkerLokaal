using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonCommands : MonoBehaviour
{

    public GameObject vergetenButton;
    public Text usernameField;
    public Text wachtwoordField;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadHome()
    {
        Debug.Log(usernameField.text);
       
            if (usernameField.text != "")
            {
                Brains.brain.name = usernameField.text;
                SceneManager.LoadScene("Home");
            }
          
    }


        
    } 


