using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

public class PathTraveledDestination : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject StartPosition;
    [SerializeField] private GameObject EndPosition;

    private LineRenderer LineHistory;
    [SerializeField] private LineRenderer LineSolution;
    private NavMeshAgent agent;

    private void Awake()
    {
        LineHistory = GetComponent<LineRenderer>();
        agent = Player.GetComponent<NavMeshAgent>();
    }

    
    private void Update()
    {
        TravelHistory();       
    }

    private void TravelHistory()
    {
        NavMeshPath path = new NavMeshPath();
        NavMesh.CalculatePath(agent.transform.position, StartPosition.transform.position, NavMesh.AllAreas, path);
        LineHistory.positionCount = path.corners.Length;
        for (int i = 0; i < path.corners.Length; i++)
        {
            LineHistory.SetPosition(i, path.corners[i]);
        }
    }

    public IEnumerator TravelSolution()
    {
        NavMeshPath path = new NavMeshPath();
        NavMesh.CalculatePath(StartPosition.transform.position, EndPosition.transform.position, NavMesh.AllAreas, path);
        LineSolution.positionCount = path.corners.Length;
        for (int i = 0; i < path.corners.Length; i++)
        {
            LineSolution.SetPosition(i, path.corners[i]);
        }
        print("show");
        LineSolution.enabled = true;
        yield return new WaitForSeconds(3f);
        LineSolution.enabled = false;
    }
}
