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

    private string contentType = "";
    private string difficultyType = "";
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

    public void FirstButtonSelected(){
        if (contentSelected == false){
            contentType = "virus";
            Debug.Log("You chose virus");
            contentSelected = true;
        } else {
            difficultyType = "easy";
            Debug.Log("You chose easy");
            menuButtons.GameNavigation();
        }
    }

    public void SecondButtonSelected(){
        if (contentSelected == false){
            contentType = "bacterias";
            Debug.Log("You chose bacterias");
            contentSelected = true;
        } else {
            difficultyType = "medium";
            Debug.Log("You chose medium");
        }
    }

    public void ThirdButtonSelected(){
        if (contentSelected == false) {
            contentType = "fungus";
            Debug.Log("You chose fungus");
            contentSelected = true;
        } else {
            difficultyType = "hard";
            Debug.Log("You chose hard");
        }
    }

}
