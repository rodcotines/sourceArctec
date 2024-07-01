using UnityEngine;
using Vuforia;

public class CustomObserverEventHandler : DefaultObserverEventHandler
{
    private PageController pageController;

    protected override void Start()
    {
        base.Start();
        pageController = FindObjectOfType<PageController>();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        // Call the method to reset to the cover model when tracking is lost
        pageController.ResetToCoverModel();
    }
}
