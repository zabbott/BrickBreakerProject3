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
    public int Lives;
    public int Score;
    public GameObject BallPrefab;
    public Transform BallSpawn;
    public GameObject WinScreen;
    public GameObject LoseScreen;
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
        Instantiate(BallPrefab, BallSpawn.position, Quaternion.identity);
    }

    public void IncreaseScore()
    {
        Score += 100;
        if(Score >= HowManyRows * BricksInARow * 100)
        {
            EndGame(true);
        }
    }
    public void LoseLife()
    {
        Lives--; 
        if(Lives <= 0)
        {
            print("Game over");
            EndGame(false) ; 
        }
        else
        {
            Instantiate(BallPrefab, BallSpawn.transform.position, Quaternion.identity);
        }
    }
    public void EndGame(bool winOrLose)
    {
        if (winOrLose == true)
        {
            WinScreen.SetActive(true);
        }
        else
        {
            LoseScreen.SetActive(true);
        }
    }
}
