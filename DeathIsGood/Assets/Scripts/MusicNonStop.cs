using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNonStop : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
