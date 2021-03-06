using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInSpots : MonoBehaviour
{

    public GameObject[] Spots;
    public float speed;
    public int index;
    public bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, Spots[index].transform.position, speed * Time.deltaTime);

            if (transform.position == Spots[index].transform.position)
            {
                if ((index + 1) != Spots.Length)
                {
                    index += 1;

                }
                else
                {
                    isMoving = false;
                }
            }


        }
        
    }


  
}
