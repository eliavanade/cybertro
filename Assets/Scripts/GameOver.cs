using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    //Script do GameOver -

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OverBackGame();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    } // <-- Método que retorna a cena do jogo.

    public void OverBackGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    } // <-- Método que volta a cena de Menu.

}
