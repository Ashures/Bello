using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    public float timer = 1f;
    public GameObject redPanel;


    public void LoadGame()
    {
        StartCoroutine(IntroScene());

    }

    private IEnumerator IntroScene()
    {
        yield return RunFlash();
        SceneManager.LoadScene("SampleScene");
    }

    private WaitForSeconds _waiter;
    private IEnumerator RunFlash()
    {
        _waiter = new WaitForSeconds(timer);

        redPanel.SetActive(true);
        yield return _waiter;
        redPanel.SetActive(false);

        yield return _waiter;
        redPanel.SetActive(true);
        yield return _waiter;
        redPanel.SetActive(false);
    }

}
