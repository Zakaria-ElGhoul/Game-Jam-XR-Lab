using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Click : MonoBehaviour
{
    public UnityEvent OnClickActivate;

    private void OnMouseDown()
    {
        OnClickActivate.Invoke();
    }
}