using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDoor : MonoBehaviour
{
    private Vector3 endPos = new Vector3(-51,0,70);
    private Vector3 startPos;
    private float duration =25f;
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //moveRock();
        
    }
    public void moveRock(){
        timePassed+=Time.deltaTime;
        float percentageCompleate = timePassed/duration;

        transform.position = Vector3.Lerp(startPos,endPos,percentageCompleate);
    }
}
