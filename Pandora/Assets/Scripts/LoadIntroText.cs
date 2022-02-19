using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class LoadIntroText : MonoBehaviour
{
    [Header("New Scene Load Time")]
    [SerializeField] float timeToLoadNewScene;
    [Header("Type Speed")]
    [SerializeField] float typeSpeed;
    [Header("Button Toggle")]
    [SerializeField] private GameObject button;
    TMP_Text storyText;
    public bool textTyping = true;
    string writer;
    public string LevelName;
    void Start()
    {
        storyText = GetComponent<TMP_Text>();
        writer = storyText.text;
        storyText.text = "";
        button.SetActive(false);

        // coroutine for updating text
        StartCoroutine("TypeText");

    }
    IEnumerator TypeText ()
    {
        yield return new WaitForSeconds(1.0f);
        foreach (char c in writer) {
            storyText.text += c;
            yield return new WaitForSeconds(typeSpeed);
        }
        textTyping = false;
        if (textTyping == false) {
            button.SetActive(true);
        }
    }

}
