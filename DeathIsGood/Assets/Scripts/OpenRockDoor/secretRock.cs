using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretRock : MonoBehaviour
{
    moveDoor moveDoor;
    [SerializeField] GameObject rock;
    void Start(){
        moveDoor = rock.GetComponent<moveDoor>();
    }
    private void OnTriggerStay(Collider other) {
        moveDoor.moveRock();
    }
}
