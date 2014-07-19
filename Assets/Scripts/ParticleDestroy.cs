using UnityEngine;
using System.Collections;

public class ParticleDestroy : MonoBehaviour {
	private ParticleSystem ps;

	// Use this for initialization
	void Start () {
		ps=GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(ps&&ps.particleCount==0)
			GameObject.Destroy(ps.gameObject);
	}
}
