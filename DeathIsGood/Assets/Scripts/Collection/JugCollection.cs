using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JugCollection : MonoBehaviour
{
    public Text jugText;
    public static int jug;
    public AudioSource getSound;

    void Start()
    {
        jug=0;
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"&&other.tag=="Jug"){
           StartCoroutine(objDeleteDelay(other));
        } 
    }
    private void updateText(){
        if(jug>3){
            jugText.color = Color.green;
        }
        jugText.text = jug + "/4";
    }

    IEnumerator objDeleteDelay(Collider other){
        jug++;
        yield return null;
        updateText();
        getSound.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(other.gameObject); 
    }
}
