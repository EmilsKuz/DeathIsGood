using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameIsDone : MonoBehaviour
{
    void Update()
    {
        if (JugCollection.jug >=4 && PackageCollection.package >= 4 && GrainCollection.grain >= 4 && PickUpItem.axe >=1 && PickUpItem.shield >= 1){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
