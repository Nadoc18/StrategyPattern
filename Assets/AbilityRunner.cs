using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    [SerializeField] IAbility currentAbility = new RageAbility();

    public void UseAbility()
    {

        currentAbility.Use();
    }
}

public interface IAbility
{

    void Use();

}

public class RageAbility : IAbility
{
    public void Use()
    {
        Debug.Log("Do Rage ability");
    }
}

public class FireballAbility : MonoBehaviour, IAbility
{
    public void Use()
    {
        Debug.Log("Do Fireball Ability");
    }
}
public class HealAbility : ScriptableObject, IAbility
{
    public void Use()
    {
        Debug.Log("Do Heal Ability");
    }
}
