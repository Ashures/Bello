using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorManager : MonoBehaviour
{
    private string NextScene;
    public string Lobby;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Elevator());
    }

    private IEnumerator Elevator()
    {
        Debug.Log(TrohpyManagement.player2Trophy);
        Debug.Log(TrohpyManagement.player1Trophy);
        if ((!TrohpyManagement.player1Trophy && TrohpyManagement.player2Trophy) || (TrohpyManagement.player1Trophy && !TrohpyManagement.player2Trophy))
        {
            NextScene = Lobby;
        }
        else
        {
            NextScene = LevelManager.CheckLevel();
        }
        //Debug.Log("loading...");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(NextScene);
    }
    
}
