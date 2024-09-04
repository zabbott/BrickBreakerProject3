using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Brick;
    public Transform SpawnPoint;
    public int BricksInARow;
    public int HowManyRows; 
    public Vector2 Offset; 
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < BricksInARow; i++)
        {
            for(int j = 0; j < HowManyRows; j++)
            {
                Instantiate(Brick, new Vector2(SpawnPoint.position.x + (i * Offset.x), SpawnPoint.position.y + (j * Offset.y)),
               Quaternion.identity);
            }
        

        }
        
    }

  
    // Update is called once per frame
    void Update()
    {
        
    }
}
