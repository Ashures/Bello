using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : InteractableObject
{

    private void Update()
    {

    }

    public GameObject SwitchObject;

    public override void OnInteracted(PlayerMove player)
    {
        Debug.Log("button");
        if (SwitchObject != null)
        {
            SwitchObject.gameObject.SetActive(!SwitchObject.gameObject.activeInHierarchy);
        }
        //StartCoroutine(RunWinLevel(player));
    }

}
