using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0;
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        movement.Normalize();

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);

        // Vous pouvez ajouter ici le code que vous souhaitez exécuter lors de la collision
    }
}