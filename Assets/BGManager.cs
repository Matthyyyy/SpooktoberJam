using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BGManager : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public GameObject[] BGs;
    
    public void Awake()
    {
        dialogueRunner.AddCommandHandler("test_command", testCommand);
        dialogueRunner.AddCommandHandler<int>("change_background", changeBackground);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void testCommand()
    {
        Debug.Log("Hello world, I'm a functioning command");
    }
    void changeBackground(int index)
    {
        foreach(var item in BGs)
        {
            item.SetActive(false);
        }
        Debug.Log("Hihi welcome to spooktober " + index );
        BGs[index].SetActive(true);
    }



    //[YarnCommand("change_background")]
    public static void CBTest(int x)
    {
        Debug.Log("Hello world. change background test " + x);
        
    }



}
