using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class LoadText : MonoBehaviour
{
    [Header("Type Speed")]
    [SerializeField] float typeSpeed;
    TMP_Text storyText;
    string writer;
    public Animator transition;
    public bool stillTyping = true;
    public int levelToLoad;
    public float startTransition;
    void Start()
    {
        storyText = GetComponent<TMP_Text>();
        writer = storyText.text;
        storyText.text = "";

        // coroutine for updating text
        StartCoroutine("TypeText");
    }

    void Update() 
    {
        if (!stillTyping) {
            StartCoroutine("EndGame");
        }
    }
    IEnumerator TypeText ()
    {
        yield return new WaitForSeconds(1.0f);
        foreach (char c in writer) {
            storyText.text += c;
            yield return new WaitForSeconds(typeSpeed);
        }
        stillTyping = false;
    }
     IEnumerator EndGame () 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(startTransition);
        SceneManager.LoadScene(levelToLoad);
    }
}
