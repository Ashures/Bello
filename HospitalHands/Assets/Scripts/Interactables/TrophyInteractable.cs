using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyInteractable : InteractableObject
{
    public string NextScene;

    public override void OnInteracted(PlayerMove player)
    {
        //StartCoroutine(RunWinLevel(player));
    }

    private IEnumerator RunWinLevel(PlayerMove player)
    {
        player.enabled = false;
        //base.OnInteracted();
        Debug.Log("You got the trophy");
        SceneManager.LoadSceneAsync("WinScene", LoadSceneMode.Additive);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(NextScene);
    }

}
