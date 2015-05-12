using UnityEngine;
using System.Collections;

public class GroundDetection : MonoBehaviour {

	public float centerOffset, legHeight, legLength;
	public LayerMask groundMask;
	Vector3 frLeg, flLeg, blLeg, brLeg;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		frLeg = new Vector3 (transform.position.x + centerOffset, legHeight, transform.position.z + centerOffset);
		flLeg = new Vector3 (transform.position.x + -centerOffset, legHeight, transform.position.z + centerOffset);
		blLeg = new Vector3 (transform.position.x + -centerOffset, legHeight, transform.position.z + -centerOffset);
		brLeg = new Vector3 (transform.position.x + centerOffset, legHeight, transform.position.z +  -centerOffset);
		DrawRays ();
		CastRay (frLeg);
		CastRay (flLeg);
		CastRay (blLeg);
		CastRay (brLeg);
	}

	void CastRay(Vector3 origin){
		RaycastHit hit;
		Physics.Raycast (origin, Vector3.down, out hit, legLength, groundMask);
		//print ("hit is at " + hit.point);
	}

	void DrawRays(){
		Debug.DrawRay (frLeg, Vector3.down * legLength, Color.yellow);
		Debug.DrawRay (flLeg, Vector3.down * legLength, Color.blue);
		Debug.DrawRay (blLeg, Vector3.down * legLength, Color.green);
		Debug.DrawRay (brLeg, Vector3.down * legLength, Color.red);
	}
}
