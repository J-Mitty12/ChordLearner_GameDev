using UnityEngine;

public class NoteHandlerBehaviour : MonoBehaviour
{
    public NoteSO correctNoteData;

    public void HandleNoteButtonClick(NoteSO clickedNoteData)
    {
        if (clickedNoteData == correctNoteData)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Incorrect!");
        }
    }
    
}
