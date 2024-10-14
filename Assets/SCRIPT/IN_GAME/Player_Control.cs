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
        if(Datainfo.timeRemaining < 30)
        {
            Datainfo.speedplayer = 50f;
        }
        else
        {
            Datainfo.speedplayer = 40f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                rotate = Mathf.LerpAngle(rotate, 45, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, 100);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
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
        else if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                rotate = Mathf.LerpAngle(rotate, -45, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, 100);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
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
        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                rotate = Mathf.LerpAngle(rotate, -135, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(-100, -100);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
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
        else if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
                rotate = Mathf.LerpAngle(rotate, 135, rotationSpeed * Time.deltaTime);
                rb.rotation = Quaternion.Euler(0, rotate, 0);
                movement(100, -100);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
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

    private void movement(int x,int z)
    {
        Vector3 moveDirection = new Vector3(x, 0, z).normalized;
        if (Input.GetKey(KeyCode.LeftShift))
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
