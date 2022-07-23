using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteractable : MonoBehaviour
{
    public GameObject SwitchObject;
    public bool switchEntered = false;

    public Sprite onSprite;
    public Sprite offSprite;
    public bool isOn = false; 

    public SpriteRenderer spriteRenderer;
    public string playerWithSwitch;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switchEntered = true;
        playerWithSwitch = collision.gameObject.name;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switchEntered = false;
        playerWithSwitch = null;
    }

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = offSprite;
    }


    private void Update()
    {
         if ((Input.GetKeyDown("e") && switchEntered && playerWithSwitch == "Player") || (Input.GetKeyDown(KeyCode.Keypad0) && switchEntered && playerWithSwitch == "Player2"))
            {
                if (SwitchObject != null)
                {
                    Debug.Log("Switch Pressed");
                    SwitchObject.gameObject.SetActive(!SwitchObject.gameObject.activeInHierarchy);
                }

                if (isOn == false)
                {
                    spriteRenderer.sprite = onSprite;
                    isOn = true;
                }

                else if (isOn == true)
                {
                    spriteRenderer.sprite = offSprite;
                    isOn = false;
                }
        }
    }
       
    }
