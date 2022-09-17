using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BGManager : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    
    public void Awake()
    {
        dialogueRunner.AddCommandHandler("test_command", testCommand);
        dialogueRunner.AddCommandHandler("change_background", changeBackground);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void testCommand()
    {
        Debug.Log("Hello world, I'm a functioning command");
    }
    void changeBackground()
    {
        Debug.Log("Hihi welcome to spooktober");
    }
}
