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
                NextScene = "Level1";
                return NextScene;
            case 1:
                NextScene = "Level2";
                return NextScene;
            case 2:
                NextScene = "Level3";
                return NextScene;
            case 3:
                NextScene = "Level4";
                return NextScene;
            case 4:
                NextScene = "Level5";
                return NextScene;
            default:
                Debug.Log("Error");
                return null;
        }
    }
}
