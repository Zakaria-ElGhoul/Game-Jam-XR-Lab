using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SwitchScene : MonoBehaviour
{
    public UnityEvent OnClickActivate;
    public UnityEvent OnMouseHover;
    public SpriteRenderer sprite;
    public Color hoverColor;
    public Color normalColor;

    private void OnMouseDown()
    {
        OnClickActivate.Invoke();
    }
    private void OnMouseOver()
    {
        sprite.color = hoverColor;
    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }
    private void Update()
    {
       sprite.color = normalColor;
    }
}
