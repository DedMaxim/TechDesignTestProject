using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_back : MonoBehaviour
{
    public void BackAction()
    {
        SceneManager.LoadScene("menu_scene");
    }
}
