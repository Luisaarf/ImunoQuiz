using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizButtons : MonoBehaviour
{
    [SerializeField] private Button firstButton;
    [SerializeField] private Button secondButton;

    [SerializeField] private Button thirdButton;

    [SerializeField] private Button fourthButton;

    public void UnactiveAll(){
        firstButton.interactable = false;
        secondButton.interactable = false;
        thirdButton.interactable = false;
        fourthButton.interactable = false;
    }

    public void ActiveAll(){
        firstButton.interactable = true;
        secondButton.interactable = true;
        thirdButton.interactable = true;
        fourthButton.interactable = true;
    }


}
