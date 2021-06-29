using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float power = 2;
    private int dots = 15;

    private Vector2 startPos;

    private bool shoot, aiming;

    private GameObject Dots;
    private List<GameObject> projectilesPath;

    private Rigidbody2D ballBody;

    public GameObject ballPrefab;
    public GameObject ballsContainer;
    
    void Start()
    {
        Dots = GameObject.Find("dot");
        projectilesPath = Dots.transform.Cast<Transform>().ToList().ConvertAll(t => t.gameObject);
        for (int i = 0; i < projectilesPath.Count; i++)
        {
            projectilesPath[i].GetComponent<Renderer>().enabled = false;
        }
    }

    
    void Update()
    {
        Aim();
    }

    void Aim()
    {
        if (shoot)
            return;

        if (Input.GetAxis("Fire1")==1)
        {
            if (!aiming)
            {
                //call
            }
            else
            {
                //Aim CAl path
            }
        }
        else
        {
            //Shoot
        }
        
    }
}
