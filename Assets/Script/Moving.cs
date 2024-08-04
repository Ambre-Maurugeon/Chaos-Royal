using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Transform[] positions;
    [SerializeField] private float speed = 0.5f;
    
    private int index = 0;
    
    private Vector2 myPos;
    private Vector2 destination;

    void Start()
    {
        transform.position = new Vector2(positions[index].position.x, positions[index].position.y);
        SetDestination();
    }

    void Update()
    {
        transform.localPosition = Vector2.MoveTowards(transform.localPosition, destination, speed * Time.deltaTime);
        if (transform.localPosition == positions[index].localPosition){

            if(index == positions.Length-1){
                Debug.Log("Arrivé!");
            } else{       
                index++;
                SetDestination();
            }
        }
    }

    private void SetDestination()
    {
        destination = new Vector2(positions[index].localPosition.x, positions[index].localPosition.y);
    }
}
