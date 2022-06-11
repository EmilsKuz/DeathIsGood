using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public static bool GamePaused = false;
   public GameObject PauseMenuUI;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GamePaused==true){
                Resume();
            }else{
                Pause();
            }

        }
    }
    public void Resume(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PauseMenuUI.SetActive(false);
        GamePaused = false;
        Time.timeScale = 1f;
    }
    public void Pause(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PauseMenuUI.SetActive(true);
        GamePaused = true;
        Time.timeScale = 0f;
    }
    public void QuitGame(){
        Application.Quit();
  }
    public void MainMenuGame(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PauseMenuUI.SetActive(false);
        GamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
