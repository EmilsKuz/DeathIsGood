using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugCollection : MonoBehaviour
{
   public Text jugText;
    public static int jug;

    void Start()
    {
        jug=0;
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"&&other.tag=="Jug"){
            Destroy(other.gameObject);
            jug++;
            updateText();
        } 
    }
    private void updateText(){
        if(jug>3){
            jugText.color = Color.green;
        }
        jugText.text = jug + "/4";
    }
}
