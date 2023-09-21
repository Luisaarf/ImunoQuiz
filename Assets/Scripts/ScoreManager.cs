using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int numScore ;

    [SerializeField] private TextMeshProUGUI textScore;


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

    public void resetScore(){
        numScore = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        numScore = 0;
    }

}
