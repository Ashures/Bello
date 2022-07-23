using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorManager : MonoBehaviour
{
    public string NextScene;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Elevator());
    }

    private IEnumerator Elevator()
    {
        //Debug.Log("loading...");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(NextScene);
    }
    
}
