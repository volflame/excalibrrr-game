using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject interactUI; // your "Press Space to interact" text
    private bool playerInRange = false;

    void Start()
    {
        interactUI.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            Interact();
        }
    }

    private void Interact()
    {
        Debug.Log("Player interacted with merchant!");
        // Open shop UI, etc.
        Color currColor = gameObject.GetComponent<SpriteRenderer>().color;
        if (currColor == Color.red)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        SceneManager.LoadScene("Battle_One");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            interactUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            interactUI.SetActive(false);
        }
    }
}