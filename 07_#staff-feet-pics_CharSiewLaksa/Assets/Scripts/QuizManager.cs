using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TextMeshProUGUI QuestionText;

    public int correctAnswers = 0;
    public void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
        correctAnswers = correctAnswers + 1;
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        QuestionText.text = QnA[currentQuestion].Question;
        SetAnswers();
    }
}
