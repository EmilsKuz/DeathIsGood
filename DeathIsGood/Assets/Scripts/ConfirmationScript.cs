using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfirmationScript : MonoBehaviour
{
    public Button okBtn;

    public void okClicked(){
        Debug.Log("ok piespiests");
        gameObject.SetActive(false);
        
    }
}
