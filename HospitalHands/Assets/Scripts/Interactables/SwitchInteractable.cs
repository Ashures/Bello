using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteractable : MonoBehaviour
{
    public GameObject SwitchObject;
    public bool switchEntered = false;

    public Sprite onSprite;
    public Sprite offSprite;

    public SpriteRenderer spriteRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switchEntered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switchEntered = false;
    }

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = offSprite;
    }


    private void Update()
    {
         if (Input.GetKeyDown("e") && switchEntered)
            {
                if (SwitchObject != null)
                {
                    Debug.Log("Switch Pressed");
                    SwitchObject.gameObject.SetActive(!SwitchObject.gameObject.activeInHierarchy);
                    
                 
                }

                if (spriteRenderer.sprite == onSprite)
                {
                    spriteRenderer.sprite = offSprite;
                }

                if (spriteRenderer.sprite == offSprite)
                {
                    spriteRenderer.sprite = onSprite;
                }
        }
    }
       
    }
