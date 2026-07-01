using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField]private Rigidbody2D rb;
    private Collider2D col;
    public GameManager gameManager;
    [Header("Configurações")]
    [SerializeField]private float speed;
    
    void Start()
    {
        col = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        Arremeco();
    }

    void Arremeco()
    {
        Vector2 direction = Vector2.zero;

        if(Random.value < 0.5f)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }

        rb.velocity = direction * speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("right"))
        {
            Debug.Log("Esquerda fez ponto");   
            gameManager.PlayerPoint();
            RestartPosition();
        }
        if (col.gameObject.CompareTag("left"))
        {
            Debug.Log("Direita fez ponto");
            gameManager.EnemyPoint();
            RestartPosition();
        }
    }
    void RestartPosition()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
