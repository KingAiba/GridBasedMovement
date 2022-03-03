using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerGrid : MonoBehaviour
{
    public Vector2 gridSize;

    public float nodeSize; 
    public Node[,] worldGrid;

    public GameObject cubePrefabs;

    public void InitializeGrid()
    {
        worldGrid = new Node[(int)gridSize.x, (int)gridSize.y];
        for (int i = 0; i < (int)gridSize.x; i++)
        {
            for(int j = 0; j< (int)gridSize.y; j++)
            {
                GameObject tempGM = Instantiate(cubePrefabs, new Vector3(i + (i * nodeSize), 0, j + (j * nodeSize)), cubePrefabs.transform.rotation);

                Node tempNode = tempGM.GetComponent<Node>();
                tempNode.InitNode(new Vector2(i, j));

                worldGrid[i, j] = tempNode;
            }
        }

    }

    public void GenerateCubesInWorld()
    {
        for (int i = 0; i < (int)gridSize.x; i++)
        {
            for (int j = 0; j < (int)gridSize.y; j++)
            {
                
            }
        }
    }


    public Vector3 GetNodeWorldPos(Vector3 position)
    {
        if (position.x < gridSize.x && position.z < gridSize.y && position.x >= 0 && position.z >= 0)
        {
            Node node = worldGrid[(int)position.x, (int)position.z];
            //Debug.Log(node.worldPosition);
            return node.worldPosition;
        }
        
        return new Vector3(0, 0, 0);
    }



    void Start()
    {
        InitializeGrid();
        GenerateCubesInWorld();
    }
 
    void Update()
    {
        
    }
}
