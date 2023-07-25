using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTutorial : MonoBehaviour
{
    [Range(0, 10)]
    [SerializeField] int Health;

    [SerializeField] string message;

    void Start()
    {
        PlayerTutorial playerTutorial = new PlayerTutorial();

        playerTutorial.Experience = 5;
        int x = playerTutorial.Experience;
        Debug.Log($"player experience {playerTutorial.Experience} " + $"   Current x : {x} ");

        //--------------------------------TernaryOperator-----------------------------------------\\

        message = Health > 0 ? "Player is alive" : "Player is Dead";

        Debug.Log(message);

        //-------------------------------------Enemy----------------------------------------------\\

        EnemyTutorail enemyOne = new EnemyTutorail();
        EnemyTutorail enemySecond = new EnemyTutorail();
        EnemyTutorail enemyThird= new EnemyTutorail();

        var xm = EnemyTutorail.m_enemyCount;
        Debug.Log($"Number of enemies spawned : {xm}");
    }
}
