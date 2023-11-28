using UnityEngine;

namespace SODD.Events
{
    [CreateAssetMenu(menuName = Framework.Events.String, fileName = nameof(StringEvent), order = Framework.MenuOrders.String)]
    public sealed class StringEvent : Event<string>
    {
    }
}