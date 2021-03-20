using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInSpots : MonoBehaviour
{
    // Lista com os objetos para referenciar as posições
    public GameObject[] Spots;

    // Velocidade para deslocamento
    public float speed;

    //Valor do index da lista para saber em qual posição está no momento
    public int index;

    // Flag para saber se o objeto está se movendo
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
            // Deslocamento com MoveTowards
            transform.position = Vector3.MoveTowards(transform.position, Spots[index].transform.position, speed * Time.deltaTime);


            // Assim que o objeto chegar no destino, irá passar para o proximo local da lista (Spots)

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
