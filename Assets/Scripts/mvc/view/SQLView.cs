using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SQLView : MonoBehaviour
{
    public TextMeshProUGUI queryWindow;
    public Button submitButton;
    public Button clearButton;
    public TextMeshProUGUI tableDisplay; // Optional text display
    public Image tableImageDisplay; // Image component for displaying the table as an image
    public TextMeshProUGUI resultDisplay;

    public Color correctColor = Color.green; // Color for correct result message
    public Color incorrectColor = Color.red; // Color for incorrect result message
    public Color defaultColor = Color.white; // Default color

    void Start()
    {
        submitButton.interactable = false;
        tableImageDisplay.gameObject.SetActive(false); // Hide image by default
    }

    public void UpdateQueryWindow(string query)
    {
        queryWindow.text = query;
    }

    public void SetSubmitButtonActive(bool isActive)
    {
        submitButton.interactable = isActive;
    }

    public void DisplayTable(string tableData)
    {
        tableDisplay.text = FormatTableData(tableData);
    }

    public void DisplayTableImage(string imagePath)
    {
        Sprite tableSprite = Resources.Load<Sprite>(imagePath);
        if (tableSprite != null)
        {
            tableImageDisplay.sprite = tableSprite;
            tableImageDisplay.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Image not found at path: " + imagePath);
            tableImageDisplay.gameObject.SetActive(false);
        }
    }

    public void DisplayResult(string result)
    {
        resultDisplay.text = result;

        // Change color based on result message
        if (result == "Correct query!")
        {
            resultDisplay.color = correctColor;
        }
        else if (result == "Incorrect query!")
        {
            resultDisplay.color = incorrectColor;
        }
        else if (result.EndsWith(";"))
        {
            resultDisplay.color = Color.yellow; // Yellow color for queries with semicolon at the end
        }
        else
        {
            resultDisplay.color = defaultColor; // Reset to default color
        }
    }

    private string FormatTableData(string tableData)
    {
        // Split the table data by lines
        string[] lines = tableData.Split('\n');
        // Use StringBuilder for better performance with string manipulation
        System.Text.StringBuilder formattedTable = new System.Text.StringBuilder();

        foreach (string line in lines)
        {
            // Replace '|' with tabs for better alignment
            formattedTable.AppendLine(line.Replace("|", "\t\t"));
        }

        return formattedTable.ToString();
    }
}
