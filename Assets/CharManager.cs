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
        dialogueRunner.AddCommandHandler<int>("add_character", addCharacter);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void testCommand()
    {
        //Debug.Log("Hello world, I'm a functioning command");
    }
    void addCharacter(int index)
    {
        foreach (var item in Chars)
        {
            item.SetActive(false);
        }
        Debug.Log("Hihi welcome to spooktober " + index);
        Chars[index].SetActive(true);
    }
}