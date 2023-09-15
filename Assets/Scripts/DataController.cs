using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    [SerializeField] private TextAsset textJSON;
    TextChange textChange;

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

    void Start()
    {
        theGameData = JsonUtility.FromJson<GameData>(textJSON.text);
        Debug.Log(theGameData.virus.easy[0].AllAnswer[0]);
        //Debug.Log(theGameData.virus.easy[0].AllAswer[3]);
        //textChange.UpdateText(theGameData.virus.easy[0].Question);
    }
}
