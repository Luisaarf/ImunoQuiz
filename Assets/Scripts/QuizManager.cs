using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [SerializeField] ContentScene contentScene;
    [SerializeField] DataController dataController;

    string[] theQuestionData = new string[6];

    [SerializeField] private TextMeshProUGUI textQuestion;
    [SerializeField] private TextMeshProUGUI textFirstAnswer;
    [SerializeField] private TextMeshProUGUI textSecondAnswer;
    [SerializeField] private TextMeshProUGUI textThirdAnswer;

    [SerializeField] private TextMeshProUGUI textFourthAnswer;

    [SerializeField] resCorrect resCorrect;
    [SerializeField] resIncorrect resIncorrect;
    [SerializeField] ScoreManager scoreManager;

    [SerializeField] QuizButtons quizButtons;
    [SerializeField] private Button buttonNext;


    public string contentQuiz = "";
    public string difficultyQuiz = "";

    public string CorrectAnswer = "";

    // Start is called before the first frame update

    void generateQuestion(){
        contentQuiz = contentScene.getContentType();
        difficultyQuiz = contentScene.getDifficultyType();
        theQuestionData = dataController.sortQuestion(contentQuiz, difficultyQuiz);
        textQuestion.text = theQuestionData[0];
        CorrectAnswer = theQuestionData[1];
        textFirstAnswer.text = theQuestionData[2];
        textSecondAnswer.text = theQuestionData[3];
        textThirdAnswer.text = theQuestionData[4];
        textFourthAnswer.text = theQuestionData[5];
    }

    public void verifyAnswerFirstButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textFirstAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textFirstAnswer.transform.parent.gameObject);
            scoreManager.addScore();
            
        } else {
            resIncorrect.MoveIncorrectResponse(textFirstAnswer.transform.parent.gameObject);
        }
    }
    public void verifyAnswerSecondButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textSecondAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textSecondAnswer.transform.parent.gameObject);
            scoreManager.addScore();
        } else {
            resIncorrect.MoveIncorrectResponse(textSecondAnswer.transform.parent.gameObject);
        }
    }

    public void verifyAnswerThirdButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textThirdAnswer.text == CorrectAnswer){
           resCorrect.MoveCorrectResponse(textThirdAnswer.transform.parent.gameObject);
           scoreManager.addScore();
        } else {
            resIncorrect.MoveIncorrectResponse(textThirdAnswer.transform.parent.gameObject);
        }
    }

    public void verifyAnswerFourthButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textFourthAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textFourthAnswer.transform.parent.gameObject);
            scoreManager.addScore();
        } else {
            resIncorrect.MoveIncorrectResponse(textFourthAnswer.transform.parent.gameObject);
        }
    }

    public void nextQuestion(){
        quizButtons.ActiveAll();
        buttonNext.gameObject.SetActive(false);
        resCorrect.setInvisible();
        resIncorrect.setInvisible();
        generateQuestion();
    }

    void Start()
    {
        buttonNext.gameObject.SetActive(false);
        generateQuestion();
    }

}
