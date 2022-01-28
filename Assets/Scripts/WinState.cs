using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    [SerializeField] private GameObject WinUI;
    private Movements mv;

    private void Awake()
    {
        mv = GetComponent<Movements>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "WayPoint")
        {
            WinUI.SetActive(true);
            mv.OnDisable();
        }
    }
}
