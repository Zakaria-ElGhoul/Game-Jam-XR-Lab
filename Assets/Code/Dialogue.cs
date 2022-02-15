using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Dialogue
{
    public string name;
    public bool isEvil;

    [TextArea(3,1)]
    public string[] sentences;

    public Dictionary<string, Action> sentences1 = new Dictionary<string, Action>();

    public void Example()
    {

        var keyValuePair = sentences1.ElementAt(1);
        string sens = keyValuePair.Key;
        Action callBack = keyValuePair.Value;
    }

}
