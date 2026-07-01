using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform position;
    [SerializeField] private float velocity;
    [SerializeField] private bool isPlayer;
    [SerializeField] private int playerId;
    void Update()
    {
        if (isPlayer)
        {
            if (playerId == 1 && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
            {
                Movement();
            } else if(playerId == 2 && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
            {
                Movement();
            }
        }


    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.up * velocity * Time.deltaTime;
        }
    }
}
