using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContentScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textTitleChange;
    [SerializeField] private TextMeshProUGUI textFirstButtonChange;
    [SerializeField] private TextMeshProUGUI textSecondButtonChange;
    [SerializeField] private TextMeshProUGUI textThirdButtonChange;

    public MenuButtons menuButtons;

    private static string contentType;
    private static string difficultyType;
    public bool contentSelected = false;
    
    public void ChangeAllText(){
        textTitleChange.text = "Escolha a dificuldade:";
        textFirstButtonChange.text = "Fácil";
        textSecondButtonChange.text = "Médio";
        textThirdButtonChange.text = "Difícil";
    }

    public string getDifficultyType(){
        return difficultyType;
    }

    public string getContentType(){
        return contentType;
    }

    public void setContentType(string type){
        contentType = type;
    }

    public void setDifficultyType(string type){
        difficultyType = type;
    }

    public void FirstButtonSelected(){
        if (contentSelected == false){
            contentType = "virus";
            contentSelected = true;
            setContentType("virus");
        } else {
            difficultyType = "easy";
            menuButtons.GameNavigation();
            setDifficultyType("easy");
        }
    }

    public void SecondButtonSelected(){
        if (contentSelected == false){
            contentType = "bacterias";
            contentSelected = true;
            setContentType("bacterias");
        } else {
            difficultyType = "medium";
            menuButtons.GameNavigation();
            setDifficultyType("medium");
        }
    }

    public void ThirdButtonSelected(){
        if (contentSelected == false) {
            contentType = "fungus";
            contentSelected = true;
            setContentType("fungus");
        } else {
            difficultyType = "hard";
            menuButtons.GameNavigation();
            setDifficultyType("hard");
        }
    }
}
