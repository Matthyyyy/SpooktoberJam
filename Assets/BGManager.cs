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
        dialogueRunner.AddCommandHandler<int, string>("change_background", changeBackground);
        //dialogueRunner.AddCommandHandler<string>("change_background", changeBackground);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void testCommand()
    {
        Debug.Log("Hello world, I'm a functioning command");
    }
    void changeBackground(int index = -1, string Test = "escapeHatch")
    {
        
        if(index != -1 || Test != "escapeHatch")
        {
            Debug.Log("Something is hapeneing here.");
            if (index > -1)
            {
                changeBackground(index);
            }
            else
            {
                changeBackground(Test);
            }
            return;
        }
        Debug.LogError("You're not supposed to be here.");
        return;
    }

    void changeBackground(string Test)
    {
        Debug.Log("Hihi welcome to spooktober " + Test);
        // Change background based on name
        foreach(var item in BGs)
        {
            if(item.name == Test)
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
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
    public void CBTest(int x)
    {
        Debug.Log("Hello world. change background test " + x);
        
    }




}
