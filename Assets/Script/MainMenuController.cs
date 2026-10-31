using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour

{
    public GameObject instructionsMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instructionsMenu.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenInstructions()
    {
        instructionsMenu.SetActive(true);
    }
    public void BackToMainMenu()
    {
        instructionsMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
