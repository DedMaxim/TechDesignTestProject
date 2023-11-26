using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_play : MonoBehaviour
{
    public void PlayAction()
    {
        SceneManager.LoadScene("main_game_scene");
    }
}
