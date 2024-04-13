using UnityEngine;

[CreateAssetMenu(fileName = "NewNote", menuName = "Note")]
public class NoteSO : ScriptableObject
{
    public int noteID;
    public AudioClip sound;
}
