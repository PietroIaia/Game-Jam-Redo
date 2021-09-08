using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR 
using UnityEditor;
#endif

public class LevelCompleted : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private bool movePlayer = false; 
    [SerializeField] private Vector3 destination;
    [SerializeField] private bool unlockDoor = false; 
    [SerializeField] private string room;

    // Start is called before the first frame update
    void Start() { player = GameObject.Find("Character"); }

    public void LevelCompletedFunction() {
        if (movePlayer) {
            player.transform.position = new Vector3(destination.x, destination.y, destination.z);
        }
        if (unlockDoor) {
            LockedDoors.unlockDoor(room);
        }
    }


    // This could use some work
    // I don't know why it doesn't save sometimes
    #region Editor
    #if UNITY_EDITOR 

    [CustomEditor(typeof(LevelCompleted))]
    public class LevelCompletedEditor: Editor
    {
        public override void OnInspectorGUI() {
            LevelCompleted levelCompleted = (LevelCompleted)target;
            DrawSerializedFields(levelCompleted);
        }

        static void DrawSerializedFields(LevelCompleted levelCompleted) {
            levelCompleted.movePlayer = EditorGUILayout.Toggle("Move Player", levelCompleted.movePlayer);
            if (levelCompleted.movePlayer) {
                levelCompleted.destination = EditorGUILayout.Vector3Field("Destination", levelCompleted.destination);
            }
            levelCompleted.unlockDoor = EditorGUILayout.Toggle("Unlock Door", levelCompleted.unlockDoor);
            if (levelCompleted.unlockDoor) {
                levelCompleted.room = EditorGUILayout.TextField("Room Name", levelCompleted.room);
            }
        }
    }
    #endif
    #endregion
}
