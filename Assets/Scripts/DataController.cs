using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    [SerializeField] private TextAsset textJSON;

    public int randNum;
    TextChange textChange;
    
    [SerializeField] generateIndex generateIndex;
    string[] thisQuestionData = new string[6];

    [System.Serializable]
    public class Easy 
    {
        public string Question;
        public string CorrectAnswer;
        public string[] AllAnswer;
    }

    [System.Serializable]
    public class Medium 
    {
        public string Question;
        public string CorrectAnswer;
        public string[] AllAnswer;
    }

    [System.Serializable]
    public class Hard
    {
        public string Question;
        public string CorrectAnswer;
        public string[] AllAnswer;
    }

    [System.Serializable]
    public class Virus 
    {
        public Easy[] easy;
        public Medium[] medium;	

        public Hard[] hard;
    }

    [System.Serializable]
    public class Bacterias
    {
        public Easy[] easy;
        public Medium[] medium;	

        public Hard[] hard;
    }


        [System.Serializable]
    public class Fungus
    {
        public Easy[] easy;
        public Medium[] medium;	

        public Hard[] hard;
    }

    [System.Serializable]
    public class GameData 
    {
        public Virus virus;
        public Bacterias bacterias;

        public Fungus fungus;
    }

    public GameData theGameData = new GameData();

    public string getName(){
        return theGameData.virus.easy[0].Question;
    }

    //planos
    public string[] sortQuestion(string thechoice, string choice){ 
        theGameData = JsonUtility.FromJson<GameData>(textJSON.text);
        randNum = generateIndex.generateIndexNumbers();
        Debug.Log("contentquiz " + thechoice);
        Debug.Log("difficultyquiz " + choice);
        if(thechoice == "virus"){
            Debug.Log("passedvirus");
            if(choice == "easy"){
                thisQuestionData[0] = theGameData.virus.easy[randNum].Question;
                thisQuestionData[1] = theGameData.virus.easy[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.virus.easy[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.virus.easy[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.virus.easy[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.virus.easy[randNum].AllAnswer[3];
                return thisQuestionData;
            }
            else if(choice == "medium"){
                Debug.Log("passedmedium");
                thisQuestionData[0] = theGameData.virus.medium[randNum].Question;
                thisQuestionData[1] = theGameData.virus.medium[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.virus.medium[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.virus.medium[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.virus.medium[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.virus.medium[randNum].AllAnswer[3];
                return thisQuestionData;
            }
            else
            {
                thisQuestionData[0] = theGameData.virus.hard[randNum].Question;
                thisQuestionData[1] = theGameData.virus.hard[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.virus.hard[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.virus.hard[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.virus.hard[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.virus.hard[randNum].AllAnswer[3];
                return thisQuestionData;
            }
        }
        else if(thechoice == "bacterias"){
            if(choice == "easy"){
                thisQuestionData[0] = theGameData.bacterias.easy[randNum].Question;
                thisQuestionData[1] = theGameData.bacterias.easy[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.bacterias.easy[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.bacterias.easy[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.bacterias.easy[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.bacterias.easy[randNum].AllAnswer[3];
                return thisQuestionData;
            }
            else if(choice == "medium"){
                thisQuestionData[0] = theGameData.bacterias.medium[randNum].Question;
                thisQuestionData[1] = theGameData.bacterias.medium[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.bacterias.medium[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.bacterias.medium[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.bacterias.medium[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.bacterias.medium[randNum].AllAnswer[3];
                return thisQuestionData;
            }
            else
            {
                thisQuestionData[0] = theGameData.bacterias.hard[randNum].Question;
                thisQuestionData[1] = theGameData.bacterias.hard[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.bacterias.hard[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.bacterias.hard[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.bacterias.hard[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.bacterias.hard[randNum].AllAnswer[3];
                return thisQuestionData;
            }
        }
        else if(thechoice == "fungus"){
            if(choice == "easy"){
                thisQuestionData[0] = theGameData.fungus.easy[randNum].Question;
                thisQuestionData[1] = theGameData.fungus.easy[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.fungus.easy[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.fungus.easy[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.fungus.easy[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.fungus.easy[randNum].AllAnswer[3];
                return thisQuestionData;
            }
            else if(choice == "medium"){
                thisQuestionData[0] = theGameData.fungus.medium[randNum].Question;
                thisQuestionData[1] = theGameData.fungus.medium[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.fungus.medium[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.fungus.medium[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.fungus.medium[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.fungus.medium[randNum].AllAnswer[3];
                return thisQuestionData;
            }
            else
            {
                thisQuestionData[0] = theGameData.fungus.hard[randNum].Question;
                thisQuestionData[1] = theGameData.fungus.hard[randNum].CorrectAnswer;
                thisQuestionData[2] = theGameData.fungus.hard[randNum].AllAnswer[0];
                thisQuestionData[3] = theGameData.fungus.hard[randNum].AllAnswer[1];
                thisQuestionData[4] = theGameData.fungus.hard[randNum].AllAnswer[2];
                thisQuestionData[5] = theGameData.fungus.hard[randNum].AllAnswer[3];
                return thisQuestionData;
            }
        } else 
        {return thisQuestionData;}
    }

}
