using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoors : MonoBehaviour
{
    private static bool lockedDoor2 = true;
    private static bool lockedDoor3 = true;
    private static bool lockedDoor4 = true;

    public static void unlockDoor(string room) { 
        if (room == "Second Room") lockedDoor2 = false; 
        else if (room == "Third Room") lockedDoor3 = false; 
        else if (room == "Fourth Room") lockedDoor4 = false; 
    }

    public static bool isDoorLocked(string room) { 
        if (room == "First Room") return false; 
        else if (room == "Second Room") return lockedDoor2; 
        else if (room == "Third Room") return lockedDoor3;
        else if (room == "Fourth Room") return lockedDoor4;
        else if (room == "Hallway") return false; 
        else return true;
    }

}
