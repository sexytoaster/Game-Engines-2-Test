using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject = null;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (targetGameObject != null)
            {
                targetPosition = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, targetPosition);
        }
    }

    public override Vector3 Calculate()
    {
        Vector3 force = boid.ArriveForce(targetPosition, slowingDistance);
        return force;
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = targetGameObject.transform.position;
        }
    }
}