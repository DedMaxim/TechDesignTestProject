using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate_on_click : MonoBehaviour
{
    private void OnMouseDown()
    {
        Animator animator = GetComponent<Animator>();
        if (animator.enabled)
            animator.enabled = false;
        else
            animator.enabled = true;
    }
}
