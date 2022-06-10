using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackageCollection : MonoBehaviour
{
public Text packageText;
    public static int package;
    // Start is called before the first frame update
    void Start()
    {
        package=0;
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"&&other.tag=="Package"){
            Destroy(other.gameObject);
            package++;
            updateText();
        } 
    }
    private void updateText(){
        packageText.text = package + "/4";
    }
}
