using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorDoor : InteractableObject
{
    public string NextScene;
    public override void OnInteracted(PlayerMove player)
    {
        Debug.Log("Elevator");
        if (player.trophy == false)
        {
            RunElevator(player);
        }
    }

    private void RunElevator(PlayerMove player)
    {
        if (!TrohpyManagement.player1Trophy && !TrohpyManagement.player2Trophy)
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}