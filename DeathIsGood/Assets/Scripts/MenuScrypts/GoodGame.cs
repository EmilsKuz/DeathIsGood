using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodGame : MonoBehaviour
{
public void MainMenu(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
  }
  public void QuitGame(){
    Application.Quit();
  }
}
