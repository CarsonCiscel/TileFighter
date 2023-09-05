using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    int x = 5;
   [SerializeField] Tilemap movementGrid;
   [SerializeField] GameObject Player;
   Vector3Int dud = new Vector3Int(1,1,0);
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(movementGrid.tileAnchor);
       //Player = movementGrid.GetObjectToInstantiate(pos);
      movementGrid.GetTile(Vector3Int.up);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player.transform.position = movementGrid.GetCellCenterLocal;
    }
}
