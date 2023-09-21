using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resIncorrect : MonoBehaviour
{
    [SerializeField] private GameObject responseIncorrectAnswer;

    private GameObject button;
    public void MoveIncorrectResponse(GameObject button){
        responseIncorrectAnswer.SetActive(true);
        responseIncorrectAnswer.transform.position = button.transform.position;
    }

    public void setInvisible(){
        responseIncorrectAnswer.SetActive(false);
    }
    
    void Start()
    {
        responseIncorrectAnswer.SetActive(false);
    }

}
