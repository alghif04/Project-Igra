using UnityEngine;
using TMPro;
using mvc.model;

namespace mvc.controller
{
    public class SQLController : MonoBehaviour
    {
        public SQLModelLoader modelLoader;
        public SQLView view;
        private SQLModel model;
        private string currentQuery = "";

        [Tooltip("Specify the index of the SQL command and table data to use.")]
        public int index = 0; // Public field for specifying the index in the Inspector

        void Start()
        {
            model = modelLoader.LoadSQLData("mvc/model/SQLData");
            view.clearButton.onClick.AddListener(ClearQuery);
            view.submitButton.onClick.AddListener(SubmitQuery);
        }

        public void AppendQuery(string sqlCommand)
        {
            currentQuery += " " + sqlCommand;
            view.UpdateQueryWindow(currentQuery);
            view.SetSubmitButtonActive(true); // Enable submit button after appending query
        }

        void ClearQuery()
        {
            currentQuery = "";
            view.UpdateQueryWindow(currentQuery);
            view.SetSubmitButtonActive(false);
            view.DisplayResult("");
            view.DisplayTableImage(null);
        }

        void SubmitQuery()
        {
            var (resultMessage, isCorrect, tableImage) = model.CheckQuery(index, currentQuery);
            view.DisplayResult(resultMessage);
            view.SetSubmitButtonActive(isCorrect);
            view.DisplayTableImage(tableImage);

            // Set button interactability based on query correctness
            if (isCorrect)
            {
                // Enable the transition button if the query is correct
                ButtonSceneTransition.SetButtonInteractable(true);
            }
            else
            {
                // Disable the transition button if the query is incorrect
                ButtonSceneTransition.SetButtonInteractable(false);
            }
        }
    }
}
