using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] private float velocity;
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            Movement();
        }
        
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.up * velocity * Time.deltaTime;
        }
    }
}
