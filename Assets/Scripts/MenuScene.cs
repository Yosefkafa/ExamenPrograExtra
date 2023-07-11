using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour,IScene
{

    [SerializeField]
    private Text maxScore;


    void Start()
    {
        ShowScore();
    }
    public void ShowScore()
    {
        maxScore.text = GameController.Instance.GetMaxScore().ToString();
    }
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
