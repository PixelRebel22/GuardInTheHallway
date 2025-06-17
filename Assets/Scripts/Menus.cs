using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    public CanvasGroup StartScreen;
    public Button StartButton;
    public Button ExitButton;
    

    public void PlayGame()
    {
        Debug.Log("Hi");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartScreen.alpha = 0f;
    }

    public void QuitGame()
    {
        Debug.Log("Bye");
        Application.Quit();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ExitButton.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
