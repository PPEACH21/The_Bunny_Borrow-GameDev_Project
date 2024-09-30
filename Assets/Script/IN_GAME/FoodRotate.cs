using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FoodRotate : MonoBehaviour
{
    private float move = 0f;
    private float moveSpeed = 2f; // Speed of up/down movement
    private float maxMove = 1.5f; // Maximum distance to move up or down

    // Update is called once per frame
    void Update()
    {
        // Control up and down movement
        move += moveSpeed * Time.deltaTime;
        if (move > maxMove || move < -maxMove)
        {
            moveSpeed *= -1; // Reverse direction
        }

        // Apply movement and rotation
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * 10 * Time.deltaTime);
    }
}