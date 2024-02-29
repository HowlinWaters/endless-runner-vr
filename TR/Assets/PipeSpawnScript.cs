using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Rect_Top;
    private static readonly System.Random rnd = new System.Random();
    public double spawnRate;
    public double passive;
    public int check;

    private float timer = 0;


    void Start()
    {
        spawnRate = rnd.Next(2, 9); 
    }


    void Update()
    {
        if (timer < spawnRate) 
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnRect();
            timer = 0;
        }
    }

    void spawnRect()
    {
        Instantiate(Rect_Top, transform.position, transform.rotation);
        passive = rnd.NextDouble();
        spawnRate = rnd.Next(2, 9);
        check = rnd.Next(2);
        if (check == 0)
        {
            spawnRate += rnd.Next(0, 5) * passive;
        }
        else
        {
            spawnRate -= rnd.Next(0, 5) * passive;
        }
        

    }
}
