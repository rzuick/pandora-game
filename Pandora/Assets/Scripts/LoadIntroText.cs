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
    TMP_Text storyText;
    string writer;
    public string LevelName;
    void Start()
    {
        storyText = GetComponent<TMP_Text>();
        writer = storyText.text;
        storyText.text = "";

        // coroutine for updating text
        StartCoroutine("TypeText");

        // coroutine for loading next level
        StartCoroutine("LoadLevel");
    }
    IEnumerator TypeText ()
    {
        yield return new WaitForSeconds(1.0f);
        foreach (char c in writer) {
            storyText.text += c;
            yield return new WaitForSeconds(typeSpeed);
        }
    }
    IEnumerator LoadLevel ()
    {
        yield return new WaitForSeconds(timeToLoadNewScene);
        SceneManager.LoadScene(LevelName);
    }
}
