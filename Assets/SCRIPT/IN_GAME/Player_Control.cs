using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;

public class Player_Control : MonoBehaviour
{

    public Animator animator;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    int x, z;
    float rotate = -180;
    float rotationSpeed = 20f;
    private void Update()
    {
        if (Datainfo.timeRemaining < 30)
        {
            Datainfo.speedplayer = 50f;
        }
        else
        {
            Datainfo.speedplayer = 40f;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, 45, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, 100);
            }
            else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, -45, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, 100);
            }
            else
            {
                rotate = Mathf.LerpAngle(rotate, 0, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(0, 100);
            }
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, -45, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, 100);
            }
            else if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, -135, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, -100);
            }
            else
            {
                rotate = Mathf.LerpAngle(rotate, -90, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, 0);
            }
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, -135, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, -100);
            }
            else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, 135, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, -100);
            }
            else
            {
                rotate = Mathf.LerpAngle(rotate, -180, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(0, -100);
            }
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, 135, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, -100);
            }
            else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                rotate = Mathf.LerpAngle(rotate, 45, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, 100);
            }
            else
            {
                rotate = Mathf.LerpAngle(rotate, 90, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, 0);
            }
        }
        else
        {
            rb.velocity = Vector3.zero;
            animator.Play("waiting action");
        }

    }

    private void movement(int x, int z)
    {
        Vector3 moveDirection = new Vector3(x, 0, z).normalized;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.Space))
        {
            rb.velocity = moveDirection * (Datainfo.speedplayer + 20f);
            animator.Play("run");
        }
        else
        {
            rb.velocity = moveDirection * Datainfo.speedplayer;
            animator.Play("walk");
        }
    }

}
