using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour {

	public Transform splashPrefab;

	void OnCollisionEnter2D(){
		Destroy();
		GameManager.Score(false);
	}

	void OnMouseDown(){
		Destroy();
		GameManager.Score(true);
	}

	void Destroy(){
		Instantiate(splashPrefab,transform.position,Quaternion.identity);
		GameObject.Destroy(transform.gameObject);
	}
}
