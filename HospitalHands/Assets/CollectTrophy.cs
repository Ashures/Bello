using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrophy : InteractableObject
{
    public GameObject trophy;

    // Start is called before the first frame update
    public override void OnInteracted(PlayerMove player)
    {
        if (player.GetComponent<PlayerMove>().trophy)
        {
            Destroy(trophy);
            TrohpyManagement.player1Trophy = false;
            TrohpyManagement.player2Trophy = false;
            player.GetComponent<PlayerMove>().trophy = false;

            Debug.Log(TrohpyManagement.player1Trophy);
            Debug.Log(TrohpyManagement.player2Trophy);
            Debug.Log(player.GetComponent<PlayerMove>().trophy);



            LevelManager.NextLevel += 1;
        }
    }
}
