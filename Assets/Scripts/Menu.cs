using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    //SerilaizeField is to display the field outside of the script so we can assign it.
    [SerializeField] GameObject menu;

    //ًWill be called by Pause Game button and it will stop the time and prevent player
    //from moving.
    public void PauseGame()
    {
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    //Will be called by resume button in the main menu.
    public void ResumeGame()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }
    //will reload the game
    //Scenemanager will reset everything in the scene to its default value and restart the game.
    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //the game will quit.
    public void ExitGame()
    {
        Application.Quit();
    }

}
