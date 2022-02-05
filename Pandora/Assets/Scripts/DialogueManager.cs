
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour 
{
    [Header("Dialogue UI")]
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;

    private Story currentStory;
    public bool dialogueIsPlaying {get; private set;}
    private static DialogueManager instance;
    public static DialogueManager GetInstance() 
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        // choicesText = new TextMeshProUGUI[choices.Length];
        // int index = 0;
        // foreach (GameObject choice in choices) {
        //     choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
        //     index++;
        // }

        
    }
    private void Update()
    {
        if (!dialogueIsPlaying) {
            return;
        }
        if (currentStory.currentChoices.Count == 0 && InputTracker.GetInstance().GetInteractButtonPressed()) {
            // function to continue story
        }
    }
}