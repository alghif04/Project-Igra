using System.Collections.Generic;

namespace mvc.model
{
    [System.Serializable]
    public class SQLData
    {
        public int index; // The index of the SQL command and table data
        public string query; // The correct SQL query
        public string tableData; // The table data to be displayed as text (optional)
        public string tableImage; // The path to the image to be displayed

        public SQLData(int index, string query, string tableData, string tableImage)
        {
            this.index = index;
            this.query = query;
            this.tableData = tableData;
            this.tableImage = tableImage;
        }
    }

    [System.Serializable]
    public class SQLModel
    {
        public List<SQLData> sqlDataList = new List<SQLData>();
        public const string IncorrectQueryMessage = "You have been incorrect for so many times please consult your instructor";
        public const string IncompleteQueryMessage = "All SQL queries should end with a ';'.";

        private int incorrectCount = 0; // Track the number of incorrect attempts
        private const int MaxIncorrectAttempts = 5; // Maximum allowed incorrect attempts

        public (string resultMessage, bool isCorrect, string tableImage) CheckQuery(int index, string userQuery)
        {
            if (!userQuery.Trim().EndsWith(";"))
            {
                return (IncompleteQueryMessage, false, null);
            }

            string correctQuery = sqlDataList[index].query.Trim();
            if (correctQuery == userQuery.Trim())
            {
                incorrectCount = 0; // Reset incorrect count if query is correct
                return ("Correct query!", true, sqlDataList[index].tableImage);
            }

            incorrectCount++; // Increment incorrect count for incorrect queries
            if (incorrectCount >= MaxIncorrectAttempts)
            {
                return (IncorrectQueryMessage, false, null); // Display error message after max attempts
            }

            return ("Incorrect query!", false, null);
        }
    }
}
