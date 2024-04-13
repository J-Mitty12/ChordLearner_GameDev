using UnityEngine;
[CreateAssetMenu(fileName = "NewList", menuName = "List")]

public class NoteListSO : ScriptableObject
{
    public NoteSO[] notes;
}
