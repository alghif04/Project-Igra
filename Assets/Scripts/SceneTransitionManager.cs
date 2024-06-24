using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    // Public field to set the scene name in the Inspector
    public string nextSceneName;

    void OnEnable()
    {
        Dialogue.OnDialogueFinished += LoadNextScene;
    }

    void OnDisable()
    {
        Dialogue.OnDialogueFinished -= LoadNextScene;
    }

    void LoadNextScene()
    {
        // Use the scene name set in the Inspector
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogError("Next scene name is not set!");
        }
    }
}
