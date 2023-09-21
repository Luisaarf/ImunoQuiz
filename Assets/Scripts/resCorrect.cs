using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class resCorrect : MonoBehaviour
{
    [SerializeField] private GameObject responseCorrectAnswer;

    private GameObject button;
    public void MoveCorrectResponse(GameObject button){
        responseCorrectAnswer.SetActive(true);
        responseCorrectAnswer.transform.position = button.transform.position;
    }

    public void setInvisible(){
        responseCorrectAnswer.SetActive(false);
    }
    
    void Start()
    {
        responseCorrectAnswer.SetActive(false);
    }

}
