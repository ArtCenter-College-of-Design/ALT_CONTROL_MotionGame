using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offset : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 bonePos;
    public GameObject spine;

    public void Start()
    {
        startPos = transform.localPosition;
        bonePos = spine.transform.localPosition;
    }

    public void Update()
    {
        Vector3 PosNow = transform.localPosition;
        Vector3 offset = PosNow - startPos;
        Vector3 offsetModi = new Vector3(offset.x * 5f, offset.y * 2f, 0);
        spine.transform.localPosition = bonePos + offsetModi;
    }
}
