using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Abillities/New Abilitie")]
public class Abillity : ScriptableObject
{
    [SerializeField] private AbillityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _actions;

    public void ApplayAction(List<Unit> targets)
    {
        foreach (var action in _actions)
        {
            foreach (var target in targets)
            {
                action.Action(target);
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoit)
    {
        return _placeLogic.TryGetTargets(screenPoit );
    }
}
