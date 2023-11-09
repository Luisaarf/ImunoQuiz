using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [SerializeField] ContentScene contentScene;
    [SerializeField] DataController dataController;
    [SerializeField] endGameScreen endGameScreen;

    string[] theQuestionData = new string[6];

    [SerializeField] private TextMeshProUGUI textQuestion;
    [SerializeField] private TextMeshProUGUI textFirstAnswer;
    [SerializeField] private TextMeshProUGUI textSecondAnswer;
    [SerializeField] private TextMeshProUGUI textThirdAnswer;

    [SerializeField] private TextMeshProUGUI textFourthAnswer;

    [SerializeField] resCorrect resCorrect;
    [SerializeField] resIncorrect resIncorrect;
    [SerializeField] ScoreManager scoreManager;

    [SerializeField] MenuButtons menuButtons;

    [SerializeField] QuizButtons quizButtons;
    [SerializeField] private Button buttonNext;

    //[SerializeField] private GameObject gamePage;
    //[SerializeField] private GameObject endGamePage;

    public string contentQuiz = "";
    public string difficultyQuiz = "";

    [SerializeField] private static int gameRoundCounter;
    public string CorrectAnswer = "";

    void generateQuestion(){
        gameRoundCounter++;
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

    public void showCorrectAnswer(){
        if (textFirstAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textFirstAnswer.transform.parent.gameObject);
        } else if (textSecondAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textSecondAnswer.transform.parent.gameObject);
        } else if (textThirdAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textThirdAnswer.transform.parent.gameObject);
        } else if (textFourthAnswer.text == CorrectAnswer){
            resCorrect.MoveCorrectResponse(textFourthAnswer.transform.parent.gameObject);
        }
    }

    public void verifyAnswerFirstButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textFirstAnswer.text == CorrectAnswer){
            scoreManager.addScore();
            
        } else {
            resIncorrect.MoveIncorrectResponse(textFirstAnswer.transform.parent.gameObject);
        }
    }
    public void verifyAnswerSecondButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textSecondAnswer.text == CorrectAnswer){
            scoreManager.addScore();
        } else {
            resIncorrect.MoveIncorrectResponse(textSecondAnswer.transform.parent.gameObject);
        }
    }

    public void verifyAnswerThirdButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textThirdAnswer.text == CorrectAnswer){
           scoreManager.addScore();
        } else {
            resIncorrect.MoveIncorrectResponse(textThirdAnswer.transform.parent.gameObject);
        }
    }

    public void verifyAnswerFourthButton(){
        quizButtons.UnactiveAll();
        buttonNext.gameObject.SetActive(true);
        if (textFourthAnswer.text == CorrectAnswer){
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
        if (gameRoundCounter == 5 ){
            // gamePage.SetActive(false);
            // endGamePage.SetActive(true);
            // endGameScreen.setScore(gameRoundCounter);
            scoreManager.updateGameRoundCounter(gameRoundCounter);
            menuButtons.GameNavigation();
        } else {
            generateQuestion();
        }
    }

    public int getGameRoundCounter(){
        return gameRoundCounter;
    }

    public void GameVisibility(){
       // gamePage.SetActive(true);
    }
    public void Start()
    {
        GameVisibility();
        buttonNext.gameObject.SetActive(false);
        //endGamePage.SetActive(false);
        gameRoundCounter = 0;
        generateQuestion();
    }
    

}
