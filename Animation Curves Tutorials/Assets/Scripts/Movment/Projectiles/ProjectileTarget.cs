using System;
using UnityEngine;

[RequireComponent(typeof(ProjectileMovement))]
public class ProjectileTarget : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float speed = 1.0f;

    private ProjectileMovement projectileMovement = null;

    public void Start()
    {
        projectileMovement = GetComponent<ProjectileMovement>();
    }

    private void CheckSpace()
    {
        if (transform.position == target.position)
        {
            Debug.Log("Reached target");
        }
    }

    private void Update()
    {
        projectileMovement.MoveToTarget(target, speed);
        CheckSpace();
    }
}