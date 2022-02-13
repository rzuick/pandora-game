using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Collision;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    public static bool finalTrigger;
    private static DialogueTrigger instance;
    public static DialogueTrigger GetInstance() {
        return instance;
    }
    private bool playerInRange;

    
    private void Awake() 
    {
        finalTrigger = false;
        playerInRange = false;
        visualCue.SetActive(false);
    }
    private void Update() 
    {
        if (playerInRange) {
            visualCue.SetActive(true);
            if (Input.GetKeyDown("i")) {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
        else {
            visualCue.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player") {
            playerInRange = true;
        }
        if(gameObject.tag == "FinalEvent") {
            finalTrigger = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            playerInRange = false;
        }
    }
}
