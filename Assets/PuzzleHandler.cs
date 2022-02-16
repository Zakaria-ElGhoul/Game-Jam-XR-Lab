using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleHandler : MonoBehaviour
{
    [SerializeField] private PuzzleItem[] _items;

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
        return true;

    }
}
