using UnityEngine;

public class PathTraveledDestination : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private LineRenderer line;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        int index = 0;
        if(Player.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            index++;
            print(index);
        }
       /* while ()
        {
            line.positionCount = index;
            line.SetPosition(index, Player.transform.position);
            index++;
            print(index);
        }*/
    }
}
