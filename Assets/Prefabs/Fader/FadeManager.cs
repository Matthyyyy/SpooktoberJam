using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class FadeManager : MonoBehaviour
{

    public DialogueRunner dialogueRunner;

    public void Awake()
    {
        // declare YS commands
        dialogueRunner.AddCommandHandler("fade_in", fadeIn);
        dialogueRunner.AddCommandHandler("fade_out", fadeOut);
    }


    public void fadeIn()
    {
        Debug.Log("Fading in");
        
    }

    public void fadeOut()
    {
        Debug.Log("Fading out");
    }
}
