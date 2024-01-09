using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public float meteoriteSpeed = 4.5f;
    public Vector2 meteoriteDirection;

    void Start()
    {
        // Ensure meteoriteDirection is normalized to maintain a constant speed
        meteoriteDirection.Normalize();
    }

    void Update()
    {
        MoveMeteorite();
        CheckOutOfBounds();
    }

    void MoveMeteorite()
    {
        // Move the meteorite based on the random direction and fallSpeed
        Vector3 movement = new Vector3(meteoriteDirection.x, meteoriteDirection.y, 0f);
        transform.Translate(movement * meteoriteSpeed * Time.deltaTime);
    }


    void CheckOutOfBounds()
    {
        // Destroy the meteorite if it goes below a certain y-position
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        // Destroy the meteorite when it becomes invisible
        Destroy(gameObject);
    }
}