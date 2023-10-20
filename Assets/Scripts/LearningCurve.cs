using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;
    
    [Header("Conditions")]
    public bool weaponEquipped = true;
    public string weaponType = "Longsword";

    [Header("More Conditions")] 
    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";

    [Header("Switch statements")] 
    public string CharacterAction = "Attack";
    public int DiceRoll = 7;
    
    [Header("Loops")]
    public int PlayerLives = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        
        // Conditions
        // if (weaponEquipped && weaponType == "Longsword")
        // {
        //     Debug.Log("For the Queen!");
        // }
        // else
        // {
        //     Debug.Log("Fists aren't going to work against armor...");
        // }
        
        // More Conditions
        OpenTreasureChamber();
        
        // Switch Statements
        PrintCharacterAction();
        RollDice();
        
        FindPartyMember();
        
        HealthStatus();
        
        // OOP - object oriented programming
        Character hero = new Character();
        // Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        hero.PrintStatsInfo();

        Character hero2 = new Character("Agatha");
        // Debug.LogFormat("Hero: {0} - {1} EXP", hero2.name, hero2.exp); instead of repeating the same line - use good programming Don't Repeat Yourself (DRY)
        hero2.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        
        huntingBow.PrintWeaponInfo();
        warBow.PrintWeaponInfo();
        
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
    }

    public void HealthStatus()
    {
        while (PlayerLives > 0)
        {
            Debug.Log("Alive");
            PlayerLives--;
        }
        
        Debug.Log("Ded");
    }

    public void FindPartyMember()
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        Debug.LogFormat("Party Members {0}", QuestPartyMembers.Count);

        for (int i = 0; i < QuestPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }
    }

    public void RollDice()
    {
        switch (DiceRoll)
        {
            case 7:
                case 15: // case 7 "falls-through" thiscase (alternative to DiceRoll == 7 || DiceRoll == 15)
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face");
                break;
        }
    }

    public void PrintCharacterAction()
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up!");
                break; // break keyword is neccessary
        }
    }

    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }
    
    /// <summary>
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.LogFormat("Text goes here, add {0} and {1} as variable placeholders", CurrentAge, AddedAge);
        Debug.Log($"A string can have variables like {FirstName} inserted directly!");
        Debug.Log(CurrentAge + AddedAge);
    }
}
