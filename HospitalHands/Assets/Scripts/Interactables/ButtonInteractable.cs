using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : MonoBehaviour
{
    public List<GameObject> SwitchObject;
    public bool buttonEntered = false;
    public Sprite onSprite;
    public Sprite offSprite;
    public SpriteRenderer spriteRenderer;
    public int playerCount = 0;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player1":
            case "Player2":
                break;
            default:
                return;
        }

        buttonEntered = true;
        if (SwitchObject != null)
        {
            Debug.Log(SwitchObject);
            foreach (GameObject switchObject in SwitchObject)
            {
                switchObject.gameObject.SetActive(!switchObject.gameObject.activeInHierarchy);
            }
            playerCount++;
            spriteRenderer.sprite = onSprite;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player1":
            case "Player2":
                break;
            default:
                return;
        }

         buttonEntered = false;
         if (SwitchObject != null)
         {
            foreach (GameObject switchObject in SwitchObject)
            {
                switchObject.gameObject.SetActive(!switchObject.gameObject.activeInHierarchy);
            }
             playerCount--;
            if (playerCount <= 0)
            {
                spriteRenderer.sprite = offSprite;
            }
         }
    }
}
