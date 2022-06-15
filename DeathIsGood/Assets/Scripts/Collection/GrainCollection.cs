using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrainCollection : MonoBehaviour
{
    public Text grainText;
    public static int grain;
    public AudioSource getSound;

    void Start()
    {
        grain=0;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"&&other.tag=="Grain"){
            StartCoroutine(objDeleteDelay(other));
        } 
    }
    private void updateText(){
        if(grain>3){
            grainText.color = Color.green;
        }
        grainText.text = grain + "/4";
    }

    IEnumerator objDeleteDelay(Collider other){
        grain++;
        yield return null;
        updateText();
        getSound.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(other.gameObject); 
    }
}
