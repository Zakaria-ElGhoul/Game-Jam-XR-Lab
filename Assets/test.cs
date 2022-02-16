using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class test : MonoBehaviour
{

    public int digit = 1;
    public int sceneInxed;
    public UnityEvent WrongEvent;
    public UnityEvent RightEvent;

    int[] solution = { 1, 2, 3, 4};
    private static int[] input  = {-1, -1, -1, -1};
 
    void Input()
    {
        input[0] = input[1];
        input[1] = input[2];
        input[2] = input[3];
        input[3] = digit;
    }

    private void Update()
    {
        if (input.Contains(-1)) return;
        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2] && solution[3] == input[3])
        {
            WrongEvent.Invoke();
        }
        else
        {
            RightEvent.Invoke();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            collision.gameObject.SetActive(false);
            Input();
        }
    }
}
