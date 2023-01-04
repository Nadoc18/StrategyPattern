using UnityEngine;

public class PlayerAbilitiesController : MonoBehaviour
{
    [SerializeField] IAbility currentAbility = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentAbility = new FireballAbility();
            UseAbility();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            currentAbility = new RageAbility();
            UseAbility();
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            currentAbility = new HealAbility();
            UseAbility();
        }
    }


    public void UseAbility()
    {
        currentAbility.Use();
    }

}
