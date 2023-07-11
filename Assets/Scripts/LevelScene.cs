using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScene : MonoBehaviour,IScene
{
    void Start()
    {
        ObserverScore.CleanList();
        if (GameController.Instance)
        GameController.Instance.CurrentScore = 0;
    }
    public void ShowScore()
    {
        
    }

}

