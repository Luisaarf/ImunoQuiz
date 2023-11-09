using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private static int numScore ;

    [SerializeField] private TextMeshProUGUI textScore;

    public static int gameRoundCounter;

    public void addScore(){
        numScore++;
        updateScore();
    }
    public void reduceScore(){
        numScore--;
    }

    public void updateScore(){
        textScore.text = numScore.ToString();
    }

    public int getScore(){
        return numScore;
    }
    public void resetScore(){
        numScore = 0;
    }

    public int  getGameRoundCounter(){
        return gameRoundCounter;
    }

    public void updateGameRoundCounter(int gameRoundCounterParam){
        gameRoundCounter = gameRoundCounterParam;
    }


    // Start is called before the first frame update
    void Start()
    {
    }

}
