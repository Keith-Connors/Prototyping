﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text factText;

     void Start()
    {
        
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
                {
                 unansweredQuestions = questions.ToList<Question>();
                }

        SetCurrentQuestion();


    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.personal;

        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }
}
