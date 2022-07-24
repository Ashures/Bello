using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectTrophy : InteractableObject
{
    public GameObject trophy;

    public GameObject body;
    public GameObject torso;
    public GameObject lArm;
    public GameObject rArm;
    public GameObject lLeg;
    public GameObject rLeg;

    public string NextScene;


    // Start is called before the first frame update
    public override void OnInteracted(PlayerMove player)
    {
        if (player.GetComponent<PlayerMove>().trophy)
        {
            LoadBody();

            Destroy(trophy);
            TrohpyManagement.player1Trophy = false;
            TrohpyManagement.player2Trophy = false;
            player.GetComponent<PlayerMove>().trophy = false;

            Debug.Log(TrohpyManagement.player1Trophy);
            Debug.Log(TrohpyManagement.player2Trophy);
            Debug.Log(player.GetComponent<PlayerMove>().trophy);

            LevelManager.NextLevel += 1;

        }
    }
    public void LoadBody()
    {
        if (trophy == null)
        {
            return;
        }
            

        if(trophy.name == "Torso")
        {
            torso.SetActive(true);
            TrohpyManagement.torso = true;
        }
        if (trophy.name == "LArm")
        {
            lArm.SetActive(true);
            TrohpyManagement.lArm = true;
        }
        if (trophy.name == "RArm")
        {
            rArm.SetActive(true);
            TrohpyManagement.rArm = true;
        }
        if (trophy.name == "LLeg")
        {
            lLeg.SetActive(true);
            TrohpyManagement.lLeg = true;
        }
        if (trophy.name == "RLeg")
        {
            rLeg.SetActive(true);
            TrohpyManagement.rLeg = true;
        }
        if (TrohpyManagement.torso && TrohpyManagement.lArm && TrohpyManagement.rArm && TrohpyManagement.lLeg && TrohpyManagement.rLeg)
        {
            torso.SetActive(false);
            lArm.SetActive(false);
            rArm.SetActive(false);
            lLeg.SetActive(false);
            rLeg.SetActive(false);

            body.SetActive(true);

            SceneManager.LoadScene(NextScene);
        }
    }


}
