using UnityEngine;
using UnityEngine.SceneManagement;

public class LearnMenu : MonoBehaviour
{

    public void backMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void basicSelect()
    {
        SceneManager.LoadScene("BasicSelect");
    }

    public void basicInsert()
    {
        SceneManager.LoadScene("BasicInsert");
    }

    public void basicDelete()
    {
        SceneManager.LoadScene("BasicDelete");
    }

    public void basicUpdate()
    {
        SceneManager.LoadScene("BasicUpdate");
    }

    public void advancedSelect()
    {
        SceneManager.LoadScene("advancedSelect");
    }

    public void advancedInsert()
    {
        SceneManager.LoadScene("advancedInsert");
    }

    public void advancedDelete()
    {
        SceneManager.LoadScene("advancedDelete");
    }

    public void advancedUpdate()
    {
        SceneManager.LoadScene("advancedUpdate");
    }
}
