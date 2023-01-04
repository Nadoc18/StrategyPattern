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
    // I can use MonoBehavior Functions
    private void Start()
    {
        // Initialize data or something else
    }
    public void Use()
    {
        Debug.Log("Do Fireball Ability");
    }
}

public class HealAbility : ScriptableObject, IAbility
{
    // I also can use Scriptable Object properties

    [SerializeField]
    int _maxHealth = 100;

    public void Use()
    {
        Debug.Log("Do Heal Ability");
    }
}
