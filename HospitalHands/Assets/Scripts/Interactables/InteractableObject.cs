using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public virtual void OnInteracted(PlayerMove player)
    {
        Debug.Log("Ouch");
    }

}
