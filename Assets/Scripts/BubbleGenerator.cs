using UnityEngine;
using System.Collections;

public class BubbleGenerator : MonoBehaviour {

	public float startDelay=1f;

	public GameObject bubblePrefab;
	// Update is called once per frame
	void Start(){
		Invoke("CreateBubble",startDelay);
	}

	void CreateBubble(){
		GameObject bubbleClone;
		float scaleMult = Random.Range(0.5f,1.5f);
		bubbleClone=Instantiate(bubblePrefab,transform.position,Quaternion.identity)as GameObject;
		bubbleClone.transform.localScale*=scaleMult;
		bubbleClone.rigidbody2D.gravityScale*=2/scaleMult;
		Invoke("CreateBubble",Random.Range(3f,4f));
	}
}
