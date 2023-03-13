
public class GameServiceProvider : ServiceLocator<IService>
{
    public override TP Register<TP>(TP newService)
    {
        var type = newService.GetType();
        if (_itemsMap.ContainsKey(type)) {
            var existedService = _itemsMap[type];
            if (existedService.Version < newService.Version) {
                _itemsMap[type] = newService;
            }
        } else {
            _itemsMap[type] = newService;  
        }
        return newService; 
    }
}
