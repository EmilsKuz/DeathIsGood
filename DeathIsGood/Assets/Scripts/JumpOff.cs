using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOff : MonoBehaviour
{
  [SerializeField] private GameObject player;
  [SerializeField] private Transform respawnPoint;

    void Start(){

    }

    void OnTriggerEnter(Collider other) {
        other.gameObject.transform.position = respawnPoint.transform.position;//teleporte itemus kas izkrit ara
    }
}
