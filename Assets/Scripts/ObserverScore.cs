using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ObserverScore
{
    static List<Enemy> enemyList;

    public static void RegisterEnemy (Enemy enemy)
    {
        if(enemyList == null)
        {
            enemyList = new List<Enemy>();
        }

        enemy.OnDeath += OnEnemyDeath;
        enemyList.Add(enemy);
    }

    private static void OnEnemyDeath(Enemy deadEnemy)
    {
        deadEnemy.OnDeath -= OnEnemyDeath;
        enemyList.Remove(deadEnemy);
        GameController.Instance.CurrentScore++;
    }
    public static void CleanList()
    {
        enemyList = new List<Enemy>();
    }
}