using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyChecker : MonoBehaviour
{
    public GameObject trophy;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        if (TrohpyManagement.player1Trophy || TrohpyManagement.player2Trophy)
        {
            trophy.SetActive(true);
        }
    }

}
