using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public Button returnButton;

    private void Start()
    {
        returnButton.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(sceneName: "Menu");
    }
}
