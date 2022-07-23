using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorDoor : InteractableObject
{
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
        if (!TrohpyManagement.player1Trophy || !TrohpyManagement.player2Trophy)
        {
            switch (LevelManager.NextLevel)
            {
                case 0:
                    SceneManager.LoadScene("TestLevel1");
                    break;
                case 1:
                    SceneManager.LoadScene("TestLevel2");
                    break;
                case 2:
                    SceneManager.LoadScene("TestLevel3");
                    break;
                case 3:
                    SceneManager.LoadScene("TestLevel4");
                    break;
                case 4:
                    SceneManager.LoadScene("TestLevel5");
                    break;
                default:
                    Debug.Log("Error");
                    break;
            }
        }
    }
}



