using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GUIStyle gStyle;

	static int score=0;



	public static void Score(bool add){
		if(add)
			score+=10;
		else if(score>0)
			score-=5;
	}

	void OnGUI(){
		//GUI.skin=GSkin;
		GUI.Label(new Rect(20,20,100,100),"Score: "+score,gStyle);
	}
	
}
