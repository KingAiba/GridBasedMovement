using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 gridPos = new Vector3(0, 0, 0);

    public Vector3 prevPos = new Vector3(0, 0, 0);
    public Vector3 targetPos = new Vector3(0, 0, 0);

    public float moveSpeed = 10;

    public InputManager playerInput;
    public bool isMoving = false;

    public PlayerGrid gridManager;

    void Start()
    {
        playerInput = GetComponent<InputManager>();
        gridManager = GameObject.Find("GridObject").GetComponent<PlayerGrid>();
    }

    
    void Update()
    {
        SetNewGridPos();
        //MovePlayer();
    }

    private void SetNewGridPos()
    {
        if((gridPos.x + playerInput.inputVector.x < gridManager.gridSize.x && gridPos.z + playerInput.inputVector.z < gridManager.gridSize.y)
            && (gridPos.x + playerInput.inputVector.x >= 0 && gridPos.z + playerInput.inputVector.z >= 0)
            && !isMoving)
        {
            gridPos += playerInput.inputVector;
            targetPos = gridManager.GetNodeWorldPos(gridPos);
            targetPos = new Vector3(targetPos.x, 1, targetPos.z);
            StartCoroutine(MovePlayer());
            
        }
    }

    private IEnumerator MovePlayer()
    {
        isMoving = true;
        prevPos = transform.position;
        while(transform.position != targetPos)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        isMoving = false;
    }
}
