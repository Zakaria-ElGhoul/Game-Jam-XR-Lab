using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public int nextscene;

    public void startgame()
    {
        StartCoroutine(Wait());
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(nextscene);
    }
}