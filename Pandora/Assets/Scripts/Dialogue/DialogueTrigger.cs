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

    private bool playerInRange;

    
    private void Awake() 
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }


    private void Update() 
    {
        if (playerInRange) {
            visualCue.SetActive(true);
            Debug.Log("Visual cue active:" + visualCue.activeSelf);
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
        Debug.Log("Collision by:" + other + "Player in range: "+ playerInRange);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            playerInRange = false;
        }
    }
}