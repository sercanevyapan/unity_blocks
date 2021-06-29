using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<GameObject> levels;

    private GameObject level1;
    private GameObject level2;

    private Vector2 level1Pos;
    private Vector2 level2Pos;


    void Start()
    {
        Physics2D.gravity = new Vector2(0, -17);

        SpawnNewLevel(0, 17);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnNewLevel(int numberLevel1, int numberLevel2)
    {
        level1Pos = new Vector2(3.5f, 1);
        level2Pos = new Vector2(3.5f, -3.4f);

        level1 = levels[numberLevel1];
        level2 = levels[numberLevel2];

        Instantiate(level1, level1Pos, Quaternion.identity);
        Instantiate(level2, level2Pos, Quaternion.identity);


    }
}
