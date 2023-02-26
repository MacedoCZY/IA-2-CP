using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDeath : MonoBehaviour
{
    public void OnPointerClick()
    {
        ReloadLevel();
        Player.alive = true;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(Player.lastScn);
    }

    public void Quit()
    {
        Debug.Log("teste");
        Application.Quit();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(Player.lastScn);
    }

}   
