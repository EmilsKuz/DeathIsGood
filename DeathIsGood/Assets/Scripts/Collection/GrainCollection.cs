using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrainCollection : MonoBehaviour
{
    public Text grainText;
    public static int grain;

    void Start()
    {
        grain=0;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"&&other.tag=="Grain"){
            Destroy(other.gameObject);
            grain++;
            updateText();
        } 
    }
    private void updateText(){
        grainText.text = grain + "/4";
    }
}
