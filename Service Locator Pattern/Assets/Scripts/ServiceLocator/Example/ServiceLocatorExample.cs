using UnityEngine;

public class ServiceLocatorExample : MonoBehaviour
{
    private IServiceLocator<IService> _locator;
    private void Awake() {
        _locator = new GameServiceProvider();
        var analytics1 = new AnalyticService(1);
        var analytics2 = new AnalyticService(2);
        var iap = new IAPService(1);

        _locator.Register(analytics1);
        _locator.Register(analytics2);
        _locator.Register(iap);
    }
    private void Start() {
        var analytics = _locator.Get<AnalyticService>();
        Debug.Log($"AnalyticsService version: {analytics.Version}");
    }
}
