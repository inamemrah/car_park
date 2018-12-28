using UnityEngine;
using System.Collections;

public class LevelFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision temas)  {
	
		if (temas.gameObject.name == "Player") { 
			
			Debug.Log ("ÇARPTı");

			if(Application.loadedLevelName == "level1"){
				PlayerPrefs.SetInt("level2",1);
				Application.LoadLevel("level2");
			
			}

			if(Application.loadedLevelName == "level2"){
				PlayerPrefs.SetInt("level3",1);
				Application.LoadLevel("level3");
				
			}

			if(Application.loadedLevelName == "level3"){
				PlayerPrefs.SetInt("level4",1);
				Application.LoadLevel("level4");
				
			}

			if(Application.loadedLevelName == "level4"){
				PlayerPrefs.SetInt("level4",1);
				Application.LoadLevel("level5");
				
			}

			if(Application.loadedLevelName == "level5"){
				PlayerPrefs.SetInt("level5",1);
				Application.LoadLevel("level6");
				
			}

			if(Application.loadedLevelName == "level6"){
				PlayerPrefs.SetInt("level6",1);
				Application.LoadLevel("level7");
				
			}

			if(Application.loadedLevelName == "level7"){
				PlayerPrefs.SetInt("level7",1);
				Application.LoadLevel("level8");
				
			}

			if(Application.loadedLevelName == "level8"){
				PlayerPrefs.SetInt("level8",1);
				Application.LoadLevel("level_secme");
				
			}


			
	}
}
}