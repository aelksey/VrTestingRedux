using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
public class TestManager : MonoBehaviour
{
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
        Debug.Log(currentQuestion.questiontext + "is" + currentQuestion.isTrue);
        
    }
    public void SetCurrentQuestion(){
        int randomQuestionIndex = Random.Range(0,unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];
        unansweredQuestions.RemoveAt(randomQuestionIndex);
        qtextdisplay.text = currentQuestion.questiontext;
    }
    
    
}
