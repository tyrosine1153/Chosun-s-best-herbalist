using UnityEngine;

// Next Object
public class NextData : MonoBehaviour
{
    [SerializeField] private int nextSceneNumber;
    [SerializeField] private int admissionLevel;
    
    public int NextSceneNumber => nextSceneNumber;
    public int AdmissionLevel => admissionLevel;
}
