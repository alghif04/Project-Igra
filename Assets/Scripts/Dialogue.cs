using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public Sprite[] sprites;
    public Image spriteImage;

    private int index;

    public delegate void DialogueFinished();
    public static event DialogueFinished OnDialogueFinished;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        UpdateSprite();
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
            UpdateSprite();
        }
        else
        {
            OnDialogueFinished?.Invoke(); // Trigger the event
        }
    }

    void UpdateSprite()
    {
        if (index < sprites.Length && sprites[index] != null)
        {
            spriteImage.sprite = sprites[index];
            spriteImage.enabled = true;
        }
        else
        {
            spriteImage.enabled = false;
        }
    }
}
