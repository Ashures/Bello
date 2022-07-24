using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepParts : MonoBehaviour
{
    private GameObject body;
    private GameObject torso;
    private GameObject lArm;
    private GameObject rArm;
    private GameObject lLeg;
    private GameObject rLeg;

    // Start is called before the first frame update
    void Start()
    {
       body = GetComponent<CollectTrophy>().body;
       torso = GetComponent<CollectTrophy>().torso;
       lArm = GetComponent<CollectTrophy>().lArm;
       rArm = GetComponent<CollectTrophy>().rArm;
       lLeg = GetComponent<CollectTrophy>().lLeg;
       rLeg = GetComponent<CollectTrophy>().rLeg;
    }

    // Update is called once per frame
    void Update()
    {
        BodyParts();
    }

    void BodyParts()
    {
        if (TrohpyManagement.torso)
        {
            torso.SetActive(true);
        }
        if (TrohpyManagement.lArm)
        {
            lArm.SetActive(true);
        }
        if (TrohpyManagement.rArm)
        {
            rArm.SetActive(true);
        }
        if (TrohpyManagement.lLeg)
        {
            lLeg.SetActive(true);
        }
        if (TrohpyManagement.rLeg)
        {
            rLeg.SetActive(true);
        }
    }
}
