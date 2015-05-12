using UnityEngine;
using System.Collections;

public class simpleFollow : MonoBehaviour {

	public Transform followTarget;
	NavMeshAgent nav;

	// Use this for initialization
	void Start () {
		nav = GetComponent <NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.destination = followTarget.position;
	}
}
