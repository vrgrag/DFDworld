using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using KnightAdventure.Utils;
public class EnamyAI : MonoBehaviour
{
    [SerializeField] private State startingState;
    [SerializeField] private float roamingDistansMax = 7f;
    [SerializeField] private float roamingDistansMin = 3f;
    [SerializeField] private float roamingTimerMax = 2f;

    private NavMeshAgent navMeshAgent;
    private State state;
    private float roamingTime;
    private Vector3 roamPosition;
    private Vector3 startingPosition;

    private enum State{
        idle,
        Roaming,
        Chasing,
        Atacking,
        Death
    }

     
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        state = startingState;
    }

    private void Update()
    {
        switch (state)
        {

            case State.Roaming:
                roamingTime -= Time.deltaTime;
                if (roamingTime <0)
                {
                   Roaming(); 
                   roamingTime = roamingTimerMax;
                }
                break;

            case State.Chasing:
                break;
            case State.Atacking:
                break;
            case State.Death:
                break;
            default:
            case State.idle:
                break;

        }
    }

    private void Roaming()
    {
        startingPosition = transform.position;
        roamPosition = GetRoamingPosition();
        ChangeFacingDiraction(startingPosition, roamPosition);
        navMeshAgent.SetDestination( roamPosition );    
    }

    private Vector3 GetRoamingPosition()
    {
        return startingPosition + Utils.GetRandomDir() * UnityEngine.Random.Range(roamingDistansMin, roamingDistansMax);

    }

    private void ChangeFacingDiraction(Vector3 sourcePosition, Vector3 targetPosition)
    {
        if (sourcePosition.x > targetPosition.x) { 
            transform.rotation = Quaternion.Euler(0, -180, 0); 
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
