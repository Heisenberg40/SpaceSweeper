using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject settingsUI;
    public GameObject quitUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("open a new scene");
    }
    public void OpenSettings()
    {
        settingsUI.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void QuitGameConfirm()
    {
        quitUI.SetActive(true);
    }
    public void QuitGameCancel()
    {
        quitUI.SetActive(false);
    }
    public void CloseSettings()
    {
        settingsUI.SetActive(false);
    }
}
