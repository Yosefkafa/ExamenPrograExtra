using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScene : MonoBehaviour,IScene
{
    [SerializeField]
    private Text maxScore;
    [SerializeField]
    private Text currentScore;
    [SerializeField]
    private Text message;

    void Start ()
    {
        ShowScore();
    }
    public void ShowScore()
    {
        message.gameObject.SetActive(GameController.Instance.UpdateMaxScore());
        maxScore.text = GameController.Instance.GetMaxScore().ToString();
        currentScore.text = GameController.Instance.CurrentScore.ToString();
    }
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
