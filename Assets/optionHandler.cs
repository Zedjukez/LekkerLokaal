using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionHandler : MonoBehaviour
{
    public enum buttonState {unanswered, yes, no};
    public GameObject kruisyes, kruisNee;
    private buttonState optieKeuze = buttonState.unanswered;

    public void buttonYes(){
        if (optieKeuze != buttonState.yes)
        optieKeuze = buttonState.yes;
        else optieKeuze = buttonState.unanswered;
        updateVisuals();
    }

    public void buttonNo(){
        if (optieKeuze != buttonState.no)
        optieKeuze = buttonState.no;
        else optieKeuze = buttonState.unanswered;
        updateVisuals();
    }

    void updateVisuals(){
        switch(optieKeuze){
            case buttonState.yes:
            kruisyes.SetActive(true);
            kruisNee.SetActive(false);
            break;

            case buttonState.no:
            kruisyes.SetActive(false);
            kruisNee.SetActive(true);
            break;

            case buttonState.unanswered:
            kruisyes.SetActive(false);
            kruisNee.SetActive(false);
            break;
        }
    }
}
