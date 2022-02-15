using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flikeringlight : MonoBehaviour
{
    [Header("Flashlight Settings")]
    [Range(0f, 10.0f)]
    public float flashSize;

    public bool flikering;

    private float length;

    private void Start()
    {
        transform.localScale = new Vector2(flashSize, flashSize);
    }

    private void Update()
    {
        if (flikering == true)
        {
            while (length <= 100)
            {
                float size = Random.Range(0.9f, 1) * flashSize;
                transform.localScale = new Vector2(size, size);
                length++;
            }

            length = 0;
        }
    }
}