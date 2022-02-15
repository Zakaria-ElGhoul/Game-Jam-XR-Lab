using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public int nextscene;

    public void startgame()
    {
        SceneManager.LoadScene(nextscene);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}