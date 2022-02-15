using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SwitchScene : MonoBehaviour
{
    public UnityEvent OnClickActivate;

    private void OnMouseDown()
    {
        OnClickActivate.Invoke();
    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
