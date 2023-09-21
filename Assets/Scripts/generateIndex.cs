using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateIndex : MonoBehaviour
{

    private List<int> indexRandNumbers = new List<int>();

    private int randNum = 0;

    public int generateIndexNumbers(){
        int counter = 0;
        while(indexRandNumbers.Contains(randNum) && counter <= 5){
            counter++;
            randNum = Random.Range(0, 5);
            Debug.Log("randNum: " + randNum);
            Debug.Log("counter: " + counter);
        }
        indexRandNumbers.Add(randNum);
        return randNum;
    }

    public void resetIndexNumbers(){
        indexRandNumbers.Clear();
    }
}
