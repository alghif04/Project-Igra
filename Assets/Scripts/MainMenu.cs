using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Function to start the main game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Function to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }

    // Function to go to the Learn Menu
    public void LearnGame()
    {
        SceneManager.LoadScene("MenuLearn");
    }

    public void PracticeGame()
    {
        SceneManager.LoadScene("MenuPractice");
    }
}
