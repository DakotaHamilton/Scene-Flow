using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button startButton;
    public GameObject subMenu;
    public Button yesButton;
    public Button noButton;
    public GameObject subSubMenu;
    public Button yeButton;
    public Button nopeButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(SubMenu);
        quitButton.onClick.AddListener(Quit);
        yesButton.onClick.AddListener(SubMenuYes);
        noButton.onClick.AddListener(SubMenuNo);
        yeButton.onClick.AddListener(SubSubMenuYes);
        nopeButton.onClick.AddListener(SubSubMenuNo);
    }

    public void SubMenu()
    {
        subMenu.SetActive(true);
    }

    public void SubMenuYes()
    {
        subMenu.SetActive(false);
        subSubMenu.SetActive(true);
    }

    public void SubMenuNo()
    {
        subMenu.SetActive(false);
        subSubMenu.SetActive(false);
    }

    public void SubSubMenuYes()
    {
        SceneManager.LoadScene(sceneName: "Main");
    }

    public void SubSubMenuNo()
    {
        subMenu.SetActive(true);
        subSubMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
