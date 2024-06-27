using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticeMenu : MonoBehaviour
{
    public void backtoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void selectQuestion()
    {
        SceneManager.LoadScene("QuestionSelect");
    }

    public void insertQuestion()
    {
        SceneManager.LoadScene("QuestionInsert");
    }

    public void updateQuestion()
    {
        SceneManager.LoadScene("QuestionUpdate");
    }

    public void deleteQuestion()
    {
        SceneManager.LoadScene("QuestionDelete");
    }

}
