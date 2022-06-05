using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour{
    public Text scoretxt;
    public Text firstanswertxt;
    public Text secondanswertxt;
    public Text thirdanswertxt;
    public Text fourthanswertxt;
    public GameObject questioncanvas;
    public GameObject retrycanvas;
    static int QuestionIndex;
    static int score;
    int answerselector;
    public Question[] questions;
    public Text qtextdisplay;
    private static List<Question> unansweredQuestions;
    public Question currentQuestion;
    void Start() {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        SetCurrentQuestion();
        Debug.Log(currentQuestion.questiontext + "right variant is" + currentQuestion.rightvariant);
        qtextdisplay.text = currentQuestion.questiontext;
        firstanswertxt.text = currentQuestion.firstanswertext;
        secondanswertxt.text = currentQuestion.secondanswertext;
        thirdanswertxt.text = currentQuestion.thirdanswertext;
        fourthanswertxt.text = currentQuestion.fourthanswertext;
        if (QuestionIndex == unansweredQuestions.Count){
            ShowRetryPanel();
        }
    }
    public void SetCurrentQuestion(){
        currentQuestion = unansweredQuestions[QuestionIndex];
        QuestionIndex++;
        }
    public void pressfirstvariant(){
        answerselector = 1;
        if(currentQuestion.rightvariant == answerselector){
            qtextdisplay.text = "Правильно!";
            score++;
        }else{
            qtextdisplay.text = "Неправильно!";
        }
        SceneManager.LoadScene(0);
    }
    public void presssecondvariant(){
        answerselector = 2;
        if(currentQuestion.rightvariant == answerselector){
            qtextdisplay.text = "Правильно!";
            score++;
        }else{
            qtextdisplay.text = "Неправильно!";
        }
        SceneManager.LoadScene(0);
    }
    public void pressthirdvariant(){
        answerselector = 3;
        if(currentQuestion.rightvariant == answerselector){
            qtextdisplay.text = "Правильно!";
            score++;
        }else{
            qtextdisplay.text = "Неправильно!";
        }
        SceneManager.LoadScene(0);
    }
    public void pressfourthvariant(){
        answerselector = 4;
        if(currentQuestion.rightvariant == answerselector){
            qtextdisplay.text = "Правильно!";
            score++;
        }else{
            qtextdisplay.text = "Неправильно!";
        }
        SceneManager.LoadScene(0);
    }
    public void calculateanddisplayscore(){
        Debug.Log(questions.Length);
        scoretxt.text = "Вы ответили правильно на" +" " + score + "вопросов из" + " " + (unansweredQuestions.Count - 1);
    }
    public void RetryButton(){
        questioncanvas.SetActive(true);
        retrycanvas.SetActive(false);
        score = 0;
        QuestionIndex = 0;
        SceneManager.LoadScene(0);
    }
    public void ShowRetryPanel(){
        questioncanvas.SetActive(false);
        retrycanvas.SetActive(true);
        calculateanddisplayscore();
    }
}