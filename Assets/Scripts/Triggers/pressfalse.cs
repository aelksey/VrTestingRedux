using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pressfalse : GazeTrigger
{
    public Question currentQuestion;
    public Text qtextdisplay;
    public override void Activate()
    {
        if(!currentQuestion.isTrue){
            qtextdisplay.text = "Правильно!";
        }else{
            qtextdisplay.text = "Неправильно!";
        }
        SceneManager.LoadScene(0);
    }
}
