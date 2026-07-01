using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScore;
    public int EnemyScore;
    public TextMeshProUGUI ScorePlayer;
    public TextMeshProUGUI ScoreEnemy;

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
