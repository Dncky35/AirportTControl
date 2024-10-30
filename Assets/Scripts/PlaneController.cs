using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private Sprite[] plane_sprite = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<Vector3> WayPointns = new List<Vector3>();

    private void Awake()
    {
        foreach(Transform point in GameObject.Find("Waypoints").transform)
            WayPointns.Add(point.position);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followingWayPoints();
    }

    private void followingWayPoints()
    {

    }
}
