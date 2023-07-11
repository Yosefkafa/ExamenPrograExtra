using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    [SerializeField]
    private int maxScore;

    [SerializeField]
    private int currentScore;

    private void Awake()
    {
        maxScore = 0;

        bool exist = GameObject.FindGameObjectsWithTag("GameController").Length > 1;

        if (exist)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public bool UpdateMaxScore()
    {
        if (currentScore > maxScore)
        {
            maxScore = currentScore;
            return true;
        }
        return false;
    }
    public int GetMaxScore()
    {
        return maxScore;
    }
    public int CurrentScore
    {
        get { return currentScore; }
        set { currentScore = value; }
    }
    void OnDestroy()
    {
        instance = null;
    }

    public static GameController Instance
    {
        get { return instance; }
    }
}
