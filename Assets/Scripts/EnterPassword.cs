using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterPassword : MonoBehaviour
{
    public string password;
    [SerializeField] private InputField[] inputFields;
    [SerializeField] private GameObject incorrectPassword;
    [SerializeField] private GameObject passwordHud;
    [SerializeField] private GameObject rewardHud;

    public void EnterPasswordFunction()
    {
        if ( 
            inputFields[0].text == (""+password[0]) && 
            inputFields[1].text == (""+password[1]) && 
            inputFields[2].text == (""+password[2]) && 
            inputFields[3].text == (""+password[3])
           ) {
               incorrectPassword.SetActive(false);
               rewardHud.SetActive(true);
               passwordHud.SetActive(false);
           }
        else {
            incorrectPassword.SetActive(true);
        }
    }
}
