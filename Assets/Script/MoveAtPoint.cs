using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAtPoint : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(5f, transform.position.y, 8f), speed * Time.deltaTime);
    }
}
