using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datainfo : MonoBehaviour
{

    public static float speedplayer = 40f;
    public static float speedcustomer = 20f;
    public static float spawnInterval = 5f;
    public static float score = 0f;

    //Sound manament
    public static float VolumeBG = 0.05f;
    public static float VolumeSFX = 0.05f;

    //GoScene From Changscenes
    public static int GoScene = 0;

    //score
    public static int Score = 0;

    //Timer Remaining
    public static float timeDafault = 90f;
    public static float timeRemaining = timeDafault;

    public static int CountTable1 = 0;
    public static int CountTable2 = 0;
    public static int CountTable3 = 0;
    public static int CountTable4 = 0;

    public static bool checkTuTorial = false;
}
