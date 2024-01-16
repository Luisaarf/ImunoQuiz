using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateIndex : MonoBehaviour
{

    private List<int> indexRandNumbers = new List<int>();
    private List<int> indexAnswerRandNumbers = new List<int>();

    private int randNum = 0;

    public int generateIndexNumbers(){
        int counter = 0;
        while(counter <= 5){
            randNum = Random.Range(0, 5);
            if(!indexRandNumbers.Contains(randNum)){
                counter++;
            }
        }
        indexRandNumbers.Add(randNum);
        return randNum;
    }

    public int[] generateIndexAnswerNumbers(){
        indexAnswerRandNumbers.Clear();
        int counter = 0;
        int[] randNumAnswers = new int[4];
        while(counter <= 3){
            randNum = Random.Range(0, 4);
            if(!indexAnswerRandNumbers.Contains(randNum)){
                Debug.Log("passou");
               // counter--;
                randNumAnswers[counter] = randNum;
                indexAnswerRandNumbers.Add(randNum);
                counter++;
            }
        }
        return randNumAnswers;
    }

    public void resetIndexNumbers(){
        indexRandNumbers.Clear();
    }
}
