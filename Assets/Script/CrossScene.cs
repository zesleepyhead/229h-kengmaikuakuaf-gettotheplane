using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossScene : MonoBehaviour
{
    public void GamePlayScene()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
