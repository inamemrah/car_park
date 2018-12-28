


using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class reklammmm : MonoBehaviour
{
	private InterstitialAd reklamObjesi;

	void Start()
	{

		if( reklamObjesi != null )
			reklamObjesi.Destroy();

		reklamObjesi = new InterstitialAd( "ca-app-pub-2570127002046970/1477190647" );
		AdRequest reklamiAl = new AdRequest.Builder().Build();
		reklamObjesi.LoadAd( reklamiAl );
		StartCoroutine( ReklamiGoster() );

	}

	IEnumerator ReklamiGoster()
	{
		while( !reklamObjesi.IsLoaded() )
			yield return null;

		reklamObjesi.Show();
	}
}