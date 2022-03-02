using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Vector3 worldPosition;
    public Vector2 nodePosition;

    public void InitNode(Vector2 NodePos)
    {
        worldPosition = transform.position;
        nodePosition = NodePos;
    }
}
