using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    //Script da cena dos créditos -

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CredBackGame();
        }
    }

    public void CredBackGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    } // <-- Método que retorna a cena de menu.

}
