using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuMovement : MonoBehaviour
{
    [Header("Referências")]
    [SerializeField] private Transform bolaTransform;
    private Player sp;
    [Header("Configurações")]
    [SerializeField] private float cpuSpeed = 5f;
    [SerializeField] private float intervaloAtualizacao = 0.02f;
    void Start()
    {
        sp = GetComponent<Player>();
        bool isPlayer = sp.isPlayer;
        if (!isPlayer)
        {
            StartCoroutine(SeguirBolaCoroutine());
        }
    }
    IEnumerator SeguirBolaCoroutine()
    {
        // Loop infinito para rodar durante todo o jogo
        while (true)
        {
            if (bolaTransform != null)
            {
                // 1. Puxa a posição atual da bolinha (eixo Y)
                float posYBola = bolaTransform.position.y;

                // 2. Define a posição alvo mantendo o X e Z originais da raquete
                Vector3 posicaoAlvo = new Vector3(transform.position.x, posYBola, transform.position.z);

                // 3. Move a raquete suavemente em direção ao alvo
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    posicaoAlvo,
                    cpuSpeed * intervaloAtualizacao
                );
            }

            // Espera uma fração de segundo antes do próximo frame da Coroutine
            yield return new WaitForSeconds(intervaloAtualizacao);
        }
    }
}
