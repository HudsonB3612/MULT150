using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    public GoalScript red;
    public GoalScript blue;
    public GoalScript orange;
    public GoalScript green;

    private bool isGameOver = false;
    private float elapsedTime = 0f;

    void Start()
    {
        isGameOver = false;
        elapsedTime = 0f;
    }

    void Update()
    {
        if (isGameOver == false)
        {
            elapsedTime = elapsedTime + Time.deltaTime;

            bool redGoalSolved = red.IsSolved();
            bool blueGoalSolved = blue.IsSolved();
            bool orangeGoalSolved = orange.IsSolved();
            bool greenGoalSolved = green.IsSolved();

            if (redGoalSolved && blueGoalSolved && orangeGoalSolved && greenGoalSolved)
            {
                isGameOver = true;
            }
        }
    }

    void OnGUI()
    {
        GUIStyle timerTextStyle = new GUIStyle(GUI.skin.label);
        timerTextStyle.fontSize = 16;
        timerTextStyle.alignment = TextAnchor.UpperLeft;

        int totalSeconds = (int)elapsedTime;
        int displayMinutes = totalSeconds / 60;
        int displaySeconds = totalSeconds % 60;
        string formattedTimeText = string.Format("Time: {0:00}:{1:00}", displayMinutes, displaySeconds);
        Rect timerPosition = new Rect(10, 10, 150, 30);
        GUI.Label(timerPosition, formattedTimeText, timerTextStyle);

        if (isGameOver == true)
        {
            GUIStyle gameOverBoxStyle = new GUIStyle(GUI.skin.box);
            gameOverBoxStyle.fontSize = 20;
            gameOverBoxStyle.alignment = TextAnchor.MiddleCenter;

            GUIStyle gameOverLabelStyle = new GUIStyle(GUI.skin.label);
            gameOverLabelStyle.fontSize = 18;
            gameOverLabelStyle.alignment = TextAnchor.MiddleCenter;

            GUIStyle playAgainButtonStyle = new GUIStyle(GUI.skin.button);
            playAgainButtonStyle.fontSize = 16;

            float boxWidth = 250;
            float boxHeight = 150;
            float boxLeft = (Screen.width / 2f) - (boxWidth / 2f);
            float boxTop = (Screen.height / 2f) - (boxHeight / 2f);
            Rect gameOverBoxRect = new Rect(boxLeft, boxTop, boxWidth, boxHeight);

            float labelWidth = 100;
            float labelHeight = 30;
            float labelLeft = (Screen.width / 2f) - (labelWidth / 2f);
            float labelTop = boxTop + 40;
            Rect goodJobLabelRect = new Rect(labelLeft, labelTop, labelWidth, labelHeight);

            float buttonWidth = 120;
            float buttonHeight = 40;
            float buttonLeft = (Screen.width / 2f) - (buttonWidth / 2f);
            float buttonTop = labelTop + labelHeight + 15;
            Rect playAgainButtonRect = new Rect(buttonLeft, buttonTop, buttonWidth, buttonHeight);

            GUI.Box(gameOverBoxRect, "Game Over", gameOverBoxStyle);
            GUI.Label(goodJobLabelRect, "Good Job!", gameOverLabelStyle);

            if (GUI.Button(playAgainButtonRect, "Play Again", playAgainButtonStyle))
            {
                Scene currentScene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(currentScene.name);
            }
        }
    }
}
