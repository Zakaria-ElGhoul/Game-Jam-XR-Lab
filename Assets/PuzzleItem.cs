using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleItem : MonoBehaviour
{
    [SerializeField] GameObject _puzzleObject;

    public bool IsSolved { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _puzzleObject)
        {
            IsSolved = true;
        }
        FindObjectOfType<PuzzleHandler>().CheckIfPuzzleIsSolved();
    }
}
