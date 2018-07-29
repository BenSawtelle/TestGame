using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    public Transform[] patrolPoints;

    public float moveSpeed;
    private int currentPoint;
    private int pathDirection;


	// Use this for initialization
	void Start () {
        transform.position = patrolPoints[0].position;
        currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position == patrolPoints[currentPoint].position)
        {
            if (currentPoint == (patrolPoints.Length-1))
            {
                pathDirection = -1;
            }

            else if(currentPoint == 0)
            {
                pathDirection = 1;
            }

            currentPoint += pathDirection;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position,
            moveSpeed * Time.deltaTime);

        print(pathDirection);
        print(currentPoint)
;	}
}
