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
    public Button A;
    public Button B;
    public GameObject checkButton;
    //public bool buttonTrue;
    public GameObject checkBox;
    public GameObject Home;
    public GameObject Community;
    public GameObject Cart;
    public GameObject Confirm;
    public GameObject Submit;
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

    public void switchHome()
    {
        Home.SetActive(true);
        Community.SetActive(false);
        Cart.SetActive(false);
        Confirm.SetActive(false);
    }

    public void switchCommunity()
    {
        Home.SetActive(false);
        Community.SetActive(true);
        Cart.SetActive(false);
        Confirm.SetActive(false);
    }
    
    public void switchCart()
    {
        Home.SetActive(false);
        Community.SetActive(false);
        Cart.SetActive(true);
        Confirm.SetActive(false);
    }

    public void conFirm()
    {
        Home.SetActive(false);
        Community.SetActive(false);
        Cart.SetActive(false);
        Confirm.SetActive(true);
    }
    public void checkSwitch()
    {
        checkBox.SetActive(true);
    }

    public void subMit()
    {
        SceneManager.LoadScene("Home");

    }

    public void loadSubmit()
    {
        Submit.SetActive(true);
    }
    } 


