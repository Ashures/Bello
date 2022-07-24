using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public float timer;
    public int maxTime;

    // Start is called before the first frame update
    void Start()
    {
        timer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        this.GetComponent<Text>().text = Mathf.Round(timer).ToString();
        if (timer < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
