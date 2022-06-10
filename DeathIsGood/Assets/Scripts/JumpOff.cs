using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOff : MonoBehaviour
{
    [SerializeField] private Transform player;
  [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other) {
        Debug.Log("nostrada");
        player.transform.position = respawnPoint.transform.position;
        other.gameObject.transform.position = respawnPoint.transform.position;
    }
}
