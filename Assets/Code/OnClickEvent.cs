using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickEvent : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onClickEvent;

    private void OnMouseDown()
    {
        onClickEvent.Invoke();
    }
    public void GetMonke()
    {
        Debug.Log("Monke");
        //return "Monke";
    }
}
