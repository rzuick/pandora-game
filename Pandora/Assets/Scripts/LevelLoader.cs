using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionDuration = 1f;
    private static LevelLoader instance;
    private void Awake () 
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().buildIndex <= 1) {
            StartCoroutine("LoadNextScene");
        }
    }
    public static LevelLoader GetInstance ()
    {
        return instance;
    }
    public void LoadNextScene () 
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene (int levelIndex) 
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionDuration);
        SceneManager.LoadScene(levelIndex);
    }
}
