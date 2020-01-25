using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : Singleton<Menu>
{
    public GameObject playText;
    public GameObject classesPanel;
    public void PlayShowAndHide()
    {
        playText.SetActive(!playText.activeSelf);
        classesPanel.SetActive(true);
    }

    public static void ToLevelScene(int level)
    {
        SceneManager.LoadScene("Level");
        Level.Instance.All(level);
        
    }

}
