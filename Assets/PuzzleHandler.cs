using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleHandler : MonoBehaviour
{
    [SerializeField] private PuzzleItem[] _items;
    [SerializeField] private UnityEvent randomChimpEvent;
    public bool CheckIfPuzzleIsSolved()
    {
        foreach (PuzzleItem item in _items)
        {
            if (!item.IsSolved)
            {
                print("puzzle not solved");
                return false;
            }
                
        }
        print("solved");
        randomChimpEvent.Invoke();
        return true;

    }
}
