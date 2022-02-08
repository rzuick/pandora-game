
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour 
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private Story currentStory;
    public bool dialogueIsPlaying {get; private set;}
    private static DialogueManager instance;
    private void Awake() 
    {
        if (instance != null) {
            Debug.LogWarning("There has been more than one Dialogue Manager found");
        }
        instance = this;
    }
    public static DialogueManager GetInstance() 
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        
    }
    private void Update()
    {
        if (!dialogueIsPlaying) {
            return;
        }

        if (currentStory.currentChoices.Count == 0 && Input.GetKeyDown("i")) {
            // function to continue story
            ContinueStory();
        }
    }
    public void EnterDialogueMode(TextAsset inkJson) 
    {
        currentStory = new Story(inkJson.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        
        ContinueStory();
    }

    private void ContinueStory() 
    {
        if (currentStory.canContinue) {
            dialogueText.text = currentStory.Continue();
        }
        if (Input.GetKeyDown("e")) {
            ExitDialogue();
        }
    }
    private void ExitDialogue() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text="";
    }
}