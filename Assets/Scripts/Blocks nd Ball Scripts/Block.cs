using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    private int count;

    void Start()
    {
        
    }


    void Update()
    {
        if (transform.position.y <= -10)
            Destroy(gameObject);
    }

    public void SetStartingCount(int count)
    {
        this.count = count;
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.collider.name == "Ball" && count > 0)
        {
            count--;
            if(count == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
