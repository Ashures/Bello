using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyInteractable : InteractableObject
{
    
    private GameObject playerObject;

    public override void OnInteracted(PlayerMove player)
    {
        Debug.Log("You win");
        //StartCoroutine(RunWinLevel(player));
        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            player.trophy = true;
            playerObject = player.gameObject;
            GetComponent<TrophyMove>().Attach(player);
        }
    }

    

}
