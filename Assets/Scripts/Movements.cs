using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using System.Linq;

public class Movements : MonoBehaviour
{
    [SerializeField] private Transform Waypoint;
    [SerializeField] private PathTraveledDestination solution;
    private InputControls IC;
    private NavMeshAgent navMeshAgent;
    private Camera cam;
    private LineRenderer line;
    private List<Vector3> points;
    private void Awake()
    {
        IC = new InputControls();
        line = GetComponent<LineRenderer>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }
   
    private void OnEnable()
    {
        IC.Player.Mouse.performed += DoMove;
        IC.Player.Solution.performed += DoSolution;
        IC.Enable();
    }

   private void DoSolution(InputAction.CallbackContext obj)
    {
       _ = StartCoroutine(solution.TravelSolution());
    }

    private void DoMove(InputAction.CallbackContext obj)
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            navMeshAgent.destination = hit.point;
        }
    }

    public void OnDisable()
    {
        IC.Disable();
    }

    private void Update()
    {
        drawLine();
    }

    private void drawLine()
    {
        int pathLines = navMeshAgent.path.corners.Length;
        int j = 0;
        while (j < pathLines)
        {
            line.positionCount = pathLines;
            points = navMeshAgent.path.corners.ToList();
            for (int i = 0; i < points.Count; i++)
            {
                line.SetPosition(i, points[i]);
            }
            j++;
        }
    }
}
