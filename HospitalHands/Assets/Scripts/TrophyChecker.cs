using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TrophyChecker : MonoBehaviour
{
    public GameObject trophy;
    public Sprite torso;
    public Sprite lArm;
    public Sprite rArm;
    public Sprite lLeg;
    public Sprite rLeg;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        if (TrohpyManagement.player1Trophy || TrohpyManagement.player2Trophy)
        {
            switch (TrohpyManagement.TrophyPart)
            {
                case "Torso":
                    trophy.GetComponent<SpriteRenderer>().sprite = torso;
                    trophy.name = "Torso";
                    break;
                case "LArm":
                    trophy.GetComponent<SpriteRenderer>().sprite = lArm;
                    trophy.name = "LArm";
                    break;
                case "RArm":
                    trophy.GetComponent<SpriteRenderer>().sprite = rArm;
                    trophy.name = "RArm";
                    break;
                case "LLeg":
                    trophy.GetComponent<SpriteRenderer>().sprite = lLeg;
                    trophy.name = "LLeg";
                    break;
                case "RLeg":
                    trophy.GetComponent<SpriteRenderer>().sprite = rLeg;
                    trophy.name = "RLeg";
                    break;
                case "Trophy":
                    break;
            }
            trophy.SetActive(true);
        }
    }

    public void LateUpdate()
    {
        
    }


    

}
