using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [SerializeField] ContentScene contentScene;

    [SerializeField] private TextMeshProUGUI textQuestion;
    [SerializeField] private TextMeshProUGUI textFirstAnswer;
    [SerializeField] private TextMeshProUGUI textSecondAnswer;
    [SerializeField] private TextMeshProUGUI textThirdAnswer;

    [SerializeField] private TextMeshProUGUI textFourthAnswer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("teste");
       //Debug.Log("contentType", contentScene.getContentType());
       //Debug.Log("difficultyType", contentScene.getDifficultyType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
