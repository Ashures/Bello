using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyMove : MonoBehaviour
{
    //public GameObject player;
    public Vector3 offset = new Vector3(0.01f, 0.01f, 0);
    public PlayerMove playerObject = null;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //if(playerObject != null)
        //    Attach(playerObject);
    }

    public void Attach(PlayerMove player)
    {
        playerObject = player; 
        transform.SetParent(player.transform, true);
        playerObject.Pickup(this);

        //if (player.GetComponent<PlayerMove>().trophy == true)
        //{
        //    playerObject = player;
        //    transform.position = player.transform.position;
        //    transform.position += offset;
        //}
    }

    public void Drop()
    {
        if (playerObject != null)
        {
            this.gameObject.GetComponentInParent<PlayerMove>().trophy = false;
            transform.localPosition = transform.localPosition * 1.35f;

            transform.SetParent(playerObject.transform.parent, true);
            playerObject = null;
            
        }
    }
}
