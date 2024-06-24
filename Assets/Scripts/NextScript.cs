using UnityEngine;
using UnityEngine.UI;
using System.Collections; // Add this line

public class ArrowMovement : MonoBehaviour
{
    public float moveDistance = 10f; // Distance to move up and down
    public float moveSpeed = 2f; // Speed of the movement
    public float fadeInDuration = 1f; // Duration for the fade-in

    private RectTransform rectTransform;
    private Vector2 startPosition;
    private float timer = 0f;
    private bool movingUp = true;
    private bool fadeInComplete = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPosition = rectTransform.anchoredPosition;

        // Start the fadeIn coroutine when the script starts
        StartCoroutine(FadeInArrow());
    }

    IEnumerator FadeInArrow()
    {
        Color arrowColor = GetComponent<Image>().color;
        arrowColor.a = 0; // Set initial alpha to 0
        GetComponent<Image>().color = arrowColor;

        float fadeInRate = 1.0f / fadeInDuration;
        float fadeInProgress = 0.0f;

        while (fadeInProgress < 1.0f)
        {
            arrowColor.a = Mathf.Lerp(0, 1, fadeInProgress);
            GetComponent<Image>().color = arrowColor;
            fadeInProgress += fadeInRate * Time.deltaTime;

            // Move the arrow while fading in
            MoveArrow();
            yield return null;
        }

        arrowColor.a = 1;
        GetComponent<Image>().color = arrowColor;

        fadeInComplete = true; // Flag to indicate fade-in is complete
    }

    void Update()
    {
        if (fadeInComplete)
        {
            // Move the arrow continuously after fade-in
            MoveArrow();
        }
    }

    void MoveArrow()
    {
        // Update timer based on moveSpeed
        timer += Time.deltaTime * moveSpeed;

        // Calculate vertical offset based on sine wave
        float yOffset = Mathf.Sin(timer) * moveDistance;

        // Set the new position of the arrow
        rectTransform.anchoredPosition = startPosition + new Vector2(0f, yOffset);

        // Check if the arrow has completed one full cycle
        if (timer >= Mathf.PI * 2f)
        {
            timer = 0f;
        }
    }
}
