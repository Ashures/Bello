using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : MonoBehaviour
{
    public GameObject SwitchObject;
    public bool buttonEntered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        buttonEntered = true;
        if (SwitchObject != null)
        {
            Debug.Log("Switch Pressed");
            SwitchObject.gameObject.SetActive(!SwitchObject.gameObject.activeInHierarchy);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
        {
            buttonEntered = false;
            if (SwitchObject != null)
            {
                Debug.Log("Switch Pressed");
                SwitchObject.gameObject.SetActive(!SwitchObject.gameObject.activeInHierarchy);
            }
        }
}
