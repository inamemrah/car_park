using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LevelKilit : MonoBehaviour {

	public Sprite kilittexture;
	public Sprite aciktexture;

	public Image [] Leveller; 

	public Text [] levelsayilari;
	void Start () {

		if (PlayerPrefs.GetInt ("level1") == 1) {
			Leveller [0].sprite = aciktexture;

			levelsayilari [0] . text = "1";
		
		} else {
			Leveller [0].sprite = aciktexture;
				
			levelsayilari [0]. text = "";
		}
	
		if (PlayerPrefs.GetInt ("level2") == 1) {
			Leveller [1].sprite = aciktexture;

			levelsayilari [1]. text = "2";

		} else {
			Leveller [1].sprite = kilittexture;


			levelsayilari [1]. text = "";
		}

		if (PlayerPrefs.GetInt ("level3") == 1) {
			Leveller [2].sprite = aciktexture;

			levelsayilari [2] . text= "3";

		} else {
			Leveller [2].sprite = kilittexture;

			levelsayilari [2]. text = "";

		}

		if (PlayerPrefs.GetInt ("level4") == 1) {
			Leveller [3].sprite = aciktexture;

			levelsayilari [3]. text = "4";

		} else {
			Leveller [3].sprite = kilittexture;

			levelsayilari [3]. text = "";

		}


		if (PlayerPrefs.GetInt ("level5") == 1) {
			Leveller [4].sprite = aciktexture;
			
			levelsayilari [4]. text = "5";
			
		} else {
			Leveller [4].sprite = kilittexture;
			
			levelsayilari [4]. text = "";
			
		}

		if (PlayerPrefs.GetInt ("level6") == 1) {
			Leveller [5].sprite = aciktexture;
			
			levelsayilari [5]. text = "6";
			
		} else {
			Leveller [5].sprite = kilittexture;
			
			levelsayilari [5]. text = "";
			
		}

		if (PlayerPrefs.GetInt ("level7") == 1) {
			Leveller [6].sprite = aciktexture;
			
			levelsayilari [6]. text = "7";
			
		} else {
			Leveller [6].sprite = kilittexture;
			
			levelsayilari [6]. text = "";
			
		}

		if (PlayerPrefs.GetInt ("level8") == 1) {
			Leveller [7].sprite = aciktexture;
			
			levelsayilari [7]. text = "8";
			
		} else {
			Leveller [7].sprite = kilittexture;
			
			levelsayilari [7]. text = "";
			
		}






	}
	
	// Update is called once per frame
	public void LevelAc (string kacinciLevel) {
	
		if (kacinciLevel == "level1") {
		
				Application.LoadLevel(kacinciLevel);


		}

		if (kacinciLevel == "level2") {
			
			if (PlayerPrefs.GetInt ("level2") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}



		if (kacinciLevel == "level3") {
			
			if (PlayerPrefs.GetInt ("level3") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}


		if (kacinciLevel == "level4") {
			
			if (PlayerPrefs.GetInt ("level4") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}


		if (kacinciLevel == "level5") {
			
			if (PlayerPrefs.GetInt ("level5") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}

		if (kacinciLevel == "level6") {
			
			if (PlayerPrefs.GetInt ("level6") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}

		if (kacinciLevel == "level7") {
			
			if (PlayerPrefs.GetInt ("level7") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}

		if (kacinciLevel == "level8") {
			
			if (PlayerPrefs.GetInt ("level8") == 1) {
				Application.LoadLevel(kacinciLevel);
				
			}
			else{
				Debug.Log("LEVEL AÇıK DEĞiL");
			}
		}





	}
}
