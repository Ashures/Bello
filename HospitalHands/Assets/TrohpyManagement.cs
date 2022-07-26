using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TrohpyManagement
{
    public static bool player1Trophy;
    public static bool player2Trophy;
    public static string TrophyPart;

    public static bool torso;
    public static bool lArm;
    public static bool rArm;
    public static bool lLeg;
    public static bool rLeg;

    public static bool body;
    public static List<string> TrophyParts = new List<string>();

    public static void SavePart(string part)
    {
        TrophyParts.Add(part);
    }
    
    public static bool IsPartCollected(string part)
    {
        return TrophyParts.Contains(part);
    }
}
