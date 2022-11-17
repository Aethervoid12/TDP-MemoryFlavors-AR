using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer()
    {
        if(isCorrect)
        {
            quizManager.TickAnswer();
            Debug.Log("Coreect Answer");
            quizManager.correct();
        }
        else
        {
            quizManager.XAnswer();
            Debug.Log("Wrong Answer");
            quizManager.correct();
        }
    }
}
