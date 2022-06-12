using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    public GameObject Item;
    public bool canPickUp;
    public static int axe;
    public static int shield;
    public GameObject pickUpText;
    public Text axeText;
    public Text shieldText;

    void Start()
    {
        axe=0;
        shield=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(canPickUp == true){
            if(Input.GetKeyDown(KeyCode.F)){
                if(Item.name=="Axe"){
                    axe++;
                    axeText.text = axe+"/1";
                    if(axe>0){
                        axeText.color = Color.green;
                    }
                }else{
                    shield++;
                    shieldText.text = shield+"/1";
                    if(shield>0){
                        shieldText.color = Color.green;
                    }
                }
                Destroy(Item);
                Item=null;
                canPickUp=false;
            }
        }
        if(canPickUp == true){
            pickUpText.SetActive(true);
        }
        else{
            pickUpText.SetActive(false);
        }

    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Item"){
            Item = other.gameObject;
            canPickUp = true;
        }
        
    }
    void OnTriggerExit(Collider other) {
        Debug.Log("exito");
        if(other.tag == "Item"){
            Item = null;
            canPickUp = false;
        }
        
    }
}
