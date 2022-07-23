using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteractable : MonoBehaviour
{
    public GameObject SwitchObject;
    public bool switchEntered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switchEntered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switchEntered = false;
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
            }
    }
       
    }
