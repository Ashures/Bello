using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAnim : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(TrohpyManagement.player1Trophy || TrohpyManagement.player2Trophy)
        {
            animator.SetBool("hasTrophy", true);
        }
        else
        {
            animator.SetBool("hasTrophy", false);
        }
    }
}