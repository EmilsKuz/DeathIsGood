using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackageCollection : MonoBehaviour
{
    public Text packageText;
    public static int package;
    public AudioSource getSound;
    void Start()
    {
        package=0;
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"&&other.tag=="Package"){
            StartCoroutine(objDeleteDelay(other));
        } 
    }
    private void updateText(){
         if(package>3){
            packageText.color = Color.green;
        }
        packageText.text = package + "/4";
    }

    IEnumerator objDeleteDelay(Collider other){
        package++;
        yield return null;
        updateText();
        getSound.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(other.gameObject); 
    }
}
