using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CharManager : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public GameObject[] Chars;
    
    public void Awake()
    {
        //dialogueRunner.AddCommandHandler("test_command", testCommand);
        dialogueRunner.AddCommandHandler<int, string>("add_character", addCharacter);
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
    void addCharacter(int index = -1, string Test = "escapeHatch")
    {
        
        if(index != -1 || Test != "escapeHatch")
        {
            Debug.Log("Something is hapeneing here.");
            if (index > -1)
            {
                addCharacter(index);
            }
            else
            {
                addCharacter(Test);
            }
            return;
        }
        Debug.LogError("You're not supposed to be here.");
        return;
    }

    void addCharacter(string Test)
    {
        Debug.Log("Hihi welcome to spooktober " + Test);
        // Change background based on name
        foreach(var item in Chars)
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

    void addCharacter(int index)
    {
        foreach(var item in Chars)
        {
            item.SetActive(false);
        }
        Debug.Log("Hihi welcome to spooktober " + index );
        Chars[index].SetActive(true);
    }



    //[YarnCommand("change_background")]
    public void CBTest(int x)
    {
        Debug.Log("Hello world. change background test " + x);
        
    }




}
