using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCollision : MonoBehaviour
{
    public Text grainText;
    public static float grain;
    // Start is called before the first frame update
    void Start()
    {
        grain=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag!="Player"){
            Destroy(other.gameObject);
            grain++;
            updateText();
            //++ noteiktā item skaitam piem grain or smt like that
        } 
    }
    private void updateText(){
        grainText.text = grain + "/4";
    }
}
