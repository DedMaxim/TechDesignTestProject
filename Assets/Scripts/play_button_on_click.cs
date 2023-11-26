using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static button_play;

public class play_button_on_click : MonoBehaviour
{
    private void OnMouseDown()
    {
        button_play button_play_instance = new button_play();
        button_play_instance.PlayAction();
    }
}
