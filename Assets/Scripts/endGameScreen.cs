using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class endGameScreen : MonoBehaviour
{
    //[SerializeField] private GameObject endGameScreenObject;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] private TextMeshProUGUI textScore;
    [SerializeField] private TextMeshProUGUI textScorePoints;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button exitButton;

    public int score;
    public int roundCounter;


    public void setScore(int roundNumber){
        textScore.text = "Você acertou " + score + " perguntas de " + roundNumber + ".";
    }

    public void restartGame(){
        scoreManager.resetScore();
        SceneManager.LoadScene("Game");
        
    }

    public void exitMenu(){
        scoreManager.resetScore();
        SceneManager.LoadScene("Menu");
        
    }
    void Start()
    {
        score = scoreManager.getScore();
        roundCounter = scoreManager.getGameRoundCounter();
        setScore(roundCounter);
         textScorePoints.text = score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
