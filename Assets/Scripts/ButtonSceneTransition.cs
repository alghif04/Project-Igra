using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Make sure this namespace is included

public class ButtonSceneTransition : MonoBehaviour
{
    // Public field to set the scene name in the Inspector
    public string nextSceneName;

    // Reference to the button component
    public Button transitionButton;

    void Start()
    {
        if (transitionButton != null)
        {
            // Add a listener to the button to call the LoadNextScene method when clicked
            transitionButton.onClick.AddListener(LoadNextScene);
        }
        else
        {
            Debug.LogError("Transition button is not set!");
        }
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

    public static void SetButtonInteractable(bool isInteractable)
    {
        Debug.Log("Searching for transition button...");
        GameObject transitionButton = GameObject.FindWithTag("TransitionButton");
        if (transitionButton != null)
        {
            Debug.Log("Transition button found: " + transitionButton.name); // Print the name of the found game object
            Button buttonComponent = transitionButton.GetComponent<Button>();
            if (buttonComponent != null)
            {
                Debug.Log("Button component found on the transition button."); // Print if the Button component is found
                buttonComponent.interactable = isInteractable;
            }
            else
            {
                Debug.LogError("Button component not found on the transition button!");
            }
        }
        else
        {
            Debug.LogError("Transition button not found!");
        }
    }


}
