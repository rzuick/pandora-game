
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
    [SerializeField] private GameObject continueIcon;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;
    private Story currentStory;
    public static int finalChoice = -1;
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

        // now we get all possible choices text
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices) {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index ++;
        }
        
    }
    private void Update()
    {
        if (!dialogueIsPlaying) {
            return;
        }
        // currentStory.currentChoices.Count == 0 && 
        if (Input.GetKeyDown("return") || Input.GetKeyDown("enter")) {
            // function to continue story
            ContinueStory();
        }
        else if (Input.GetKeyDown("e")) {
            ExitDialogue();
        }
    }
    // inkKnot = DialogueTrigger.GetInstance().inkKnot;
    public void EnterDialogueMode(TextAsset inkJson) 
    {
        currentStory = new Story(inkJson.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        ContinueStory();
    }

    private void ContinueStory() 
    {
        Debug.Log("story can continue: "+ currentStory.canContinue);
        if (currentStory.canContinue) {
            dialogueText.text = currentStory.Continue();
            Debug.Log("current choices: "+ currentStory.currentChoices.Count);
            DisplayChoices();
            continueIcon.SetActive(true);
        }
        else {
            continueIcon.SetActive(false);
        }
    }
    private void ExitDialogue() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text="";
    }

    private void DisplayChoices()
    {
        // populate a list of currentChoices to track what has been selected
        List<Choice> currentChoices = currentStory.currentChoices;
        if (currentChoices.Count > choices.Length) {
            Debug.LogError("There are more choice options than valid choices: "+ currentChoices.Count);
        }
        int index = 0;
        // now we need to set each choice Object to have the text value of the text choice from ink
        foreach (Choice choice in currentChoices) {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // go through remaining choices TextMeshProUGUI supports and hide any unused ones
        //what we left off with from the previous loop
        for (int i = index; i < choices.Length; i++) {
            choices[i].gameObject.SetActive(false);
        }
        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex) {
        // will allow unity to locate the index of the choice selected
        currentStory.ChooseChoiceIndex(choiceIndex);
        if (DialogueTrigger.finalTrigger) {
            finalChoice = choiceIndex;
        }
        // Debug.Log("player chose:" + choiceIndex);
        // will allow unity to continue to story progression, if there is any, after choice was selected
        ContinueStory();
    } 
    

    
}