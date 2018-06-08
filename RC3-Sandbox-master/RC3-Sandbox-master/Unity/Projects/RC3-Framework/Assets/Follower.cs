using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
    public Transform Agent;
    public GameObject follower;
    Transform[] F = new Transform[1];

	// Use this for initialization
	void Start ()
    {
        var f = Instantiate(follower);
        F[0] = f.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        F[0].localPosition = Agent.localPosition;
	}
}
