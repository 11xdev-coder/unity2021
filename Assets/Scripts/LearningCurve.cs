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
    
    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
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
