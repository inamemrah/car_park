using UnityEngine;
using System.Collections;

public class basla : MonoBehaviour {

	public void YeniSahne (int hangisi) {
		Application.LoadLevel (1);

	}

	// Update is called once per frame
	public void Cikis () {
		Application.Quit ();
	}
}
