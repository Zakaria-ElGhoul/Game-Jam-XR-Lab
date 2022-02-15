using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public int triggerEvil;
    public UnityEvent evilEvent;
    public UnityEvent normalEvent;
    public int currentSentence;

    public void Start()
    {
        DialogueSystem.Instance.StartDialogue(dialogue);
    }
    private void Update()
    {
       if(dialogue.isEvil == true)
        {
            evilEvent.Invoke();
        }
        if (currentSentence == triggerEvil)
        {
            dialogue.isEvil = true;
        }
        else
        {
            normalEvent.Invoke();
        };


        }
        public void Click()
    {
        currentSentence++;
    }
}
