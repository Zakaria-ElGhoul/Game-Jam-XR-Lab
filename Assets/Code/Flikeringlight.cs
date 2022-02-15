using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flikeringlight : MonoBehaviour
{
    [Header("Flashlight Size")]
    [Range(0f, 10.0f)]
    public float flashSize;

    private float length;

    private void Update()
    {
        while (length <= 100)
        {
            float size = Random.Range(0.9f, 1) * flashSize;
            transform.localScale = new Vector3(size, size, 0);
            length++;
        }

        length = 0;
    }
}