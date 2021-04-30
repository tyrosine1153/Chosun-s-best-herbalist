using UnityEngine;

// Next
public class NextData
{
    [SerializeField] private int nextSceneNumber;
    [SerializeField] private int admissionLevel;
    
    public int NextSceneNumber => nextSceneNumber;
    public int AdmissionLevel => admissionLevel;

    // player와 Next가 닿으면 SceneManager에서 MoveScene에서 닿은 NextData를 이용해 씬 이동 결정   
}
