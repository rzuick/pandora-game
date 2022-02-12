using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float horizontal;
    float vertical;
    private int choiceIndex;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying) {
            return;
        }
        choiceIndex = DialogueManager.finalChoice;
        if (choiceIndex == 0 || choiceIndex == 1) {
            StartCoroutine("LoadLevel");
            Debug.Log("final choice index: "+ choiceIndex);
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigidbody2D.position;
        position.x = position.x + 12.0f * horizontal * Time.deltaTime;
        position.y = position.y + 12.0f * vertical * Time.deltaTime;
        
        rigidbody2D.MovePosition(position);
    }

        IEnumerator LoadLevel ()
    {
        yield return new WaitForSeconds(3.0f);
        if (choiceIndex == 0) {
            SceneManager.LoadScene(3);
        }
        if(choiceIndex == 1) {
            SceneManager.LoadScene(4);
        }
    }
}
