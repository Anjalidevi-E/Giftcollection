using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float coinsToWinInPercent;
    public GameObject coinsParent;
    public GameObject gameOverMenu;
    public GameObject gameWinMenu;
    private int totalCoinCount;
    private int coinsToWin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        totalCoinCount = coinsParent.transform.childCount;
        coinsToWin = Mathf.RoundToInt(totalCoinCount * coinsToWinInPercent);
        gameOverMenu.SetActive(false);
        gameWinMenu.SetActive(false);
    }
    public void GameWin(int collectedCoinCount)
    {
        if (collectedCoinCount >= coinsToWin)
        {
            gameWinMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void GameLose()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}