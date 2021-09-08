using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;
    [SerializeField] private float leftClamp = 0f;
    [SerializeField] private float UpClamp = 0f;
    [SerializeField] private float RightClamp = 0f;
    [SerializeField] private float DownClamp = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (
            Mathf.Clamp(targetToFollow.position.x, leftClamp, RightClamp),
            Mathf.Clamp(targetToFollow.position.y, DownClamp, UpClamp),
            transform.position.z
        );
    }
}
