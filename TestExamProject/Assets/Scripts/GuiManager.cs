using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GuiManager : MonoBehaviour 
{
    public GameObject playerDeadLbl;
    public Text scoreLbl;

    public void OnHomeClicked()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ShowDeadText()
    {
        playerDeadLbl.SetActive(true);
    }
    public void ResetPoints()
    {
        PlayerPrefs.SetInt("Score", 0);
        scoreLbl.text = string.Format("Score : 0");
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
}
