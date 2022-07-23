using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractable : InteractableObject
{
    public string NextScene;
    public override void OnInteracted(PlayerMove player)
    {
        if (player.trophy == true)
        {
            StartCoroutine(RunWinLevel(player));
        }
    }

    private IEnumerator RunWinLevel(PlayerMove player)
    {
        player.enabled = false;
        //base.OnInteracted();
        Debug.Log("You finished the scene");
        SceneManager.LoadSceneAsync("TestWinScene", LoadSceneMode.Additive);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(NextScene);
    }
}
