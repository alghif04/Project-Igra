using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOutEffect : MonoBehaviour
{
    public Button button; // Reference to the button
    public float fadeDuration = 1f; // Duration of the fade-out effect

    private Image buttonImage;

    void Start()
    {
        if (button == null)
        {
            Debug.LogError("Button is not assigned!");
            return;
        }

        buttonImage = button.GetComponent<Image>();

        if (buttonImage == null)
        {
            Debug.LogError("Button image is not assigned properly!");
            return;
        }

        button.interactable = false; // Disable button interaction
        StartFadeOut(); // Start the fade-out process
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        Color initialImageColor = buttonImage.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);

            buttonImage.color = new Color(initialImageColor.r, initialImageColor.g, initialImageColor.b, alpha);

            yield return null;
        }

        buttonImage.color = new Color(initialImageColor.r, initialImageColor.g, initialImageColor.b, 0f);

        // Optionally, you can disable the button's GameObject after fading out
        button.gameObject.SetActive(false);
    }
}
