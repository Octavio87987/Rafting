using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsTools : MonoBehaviour, IAdsShower, IUnityAdsListener
{
    private string _gameId = "4899417";
    private string _rewardPlacementId = "Rewarded_Android";
    private string _bannerPlacementId = "Banner_Android";
    private string _interstitialPlacementId = "Interstitial_Android";

    private void Awake()
    {
        Advertisement.Initialize(_gameId, true);
    }

    public void ShowInterstitialVideo()
    {
        Advertisement.Show(_interstitialPlacementId);
    }

    public void ShowRewardVideo()
    {
        Advertisement.Show(_rewardPlacementId);
    }

    public void ShowBanner()
    {
        Advertisement.Show(_bannerPlacementId);
    }

    public void OnUnityAdsReady(string placementId)
    {
    }

    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Skipped)
            Debug.Log("Skipped");
    }
}
