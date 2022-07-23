using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
    public static int NextLevel;
    private static string NextScene;

    public static string CheckLevel()
    {
        switch (NextLevel)
        {
            case 0:
                NextScene = "TestLevel1";
                return NextScene;
            case 1:
                NextScene = "TestLevel2";
                return NextScene;
            case 2:
                NextScene = "TestLevel3";
                return NextScene;
            case 3:
                NextScene = "TestLevel4";
                return NextScene;
            case 4:
                NextScene = "TestLevel5";
                return NextScene;
            default:
                Debug.Log("Error");
                return null;
        }
    }
}
