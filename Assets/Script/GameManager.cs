using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField]private TextMeshProUGUI ScorePlayer;
    [SerializeField]private TextMeshProUGUI ScoreEnemy;
    private int PlayerScore;
    private int EnemyScore;
    
    public void PlayerPoint()
    {
        PlayerScore++;
        ScorePlayer.text = PlayerScore.ToString();
    }
    public void EnemyPoint()
    {
        EnemyScore++;
        ScoreEnemy.text = EnemyScore.ToString();
    }
}
