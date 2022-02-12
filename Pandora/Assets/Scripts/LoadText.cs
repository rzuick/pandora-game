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
    void Start()
    {
        storyText = GetComponent<TMP_Text>();
        writer = storyText.text;
        storyText.text = "";

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
    }
}
