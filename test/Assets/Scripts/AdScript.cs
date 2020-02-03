using UnityEngine;
using GoogleMobileAds.Api;
using System;

//Banner ad
public class AdScript : MonoBehaviour
{
	private BannerView adBanner;

	private string idApp, idBanner;


	void Start ()
	{
		DontDestroyOnLoad(this.gameObject);

		idApp = "ca-app-pub-5888704103426264~1487310406";
		idBanner = "ca-app-pub-3940256099942544/6300978111";

		MobileAds.Initialize (idApp);

		RequestBannerAd ();
	}



	#region Banner Methods --------------------------------------------------

	public void RequestBannerAd ()
	{
		adBanner = new BannerView (idBanner, AdSize.SmartBanner, AdPosition.Bottom);
		AdRequest request = new AdRequest.Builder().Build();
		adBanner.LoadAd (request);

	}

	public void DestroyBannerAd ()
	{
		if (adBanner != null)
			adBanner.Destroy ();
	}

	#endregion

	
	//------------------------------------------------------------------------
	AdRequest AdRequestBuild ()
	{
		return new AdRequest.Builder ().Build ();
	}

	void OnDestroy ()
	{
		DestroyBannerAd ();
	}

}