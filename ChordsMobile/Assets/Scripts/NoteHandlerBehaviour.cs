using UnityEngine;

public class NoteHandlerBehaviour : MonoBehaviour
{
    private NoteSO selectedNoteA;
    private NoteSO selectedNoteB;

    public void SelectedNoteA(NoteSO obj)
    {
        selectedNoteA = obj;
    }

    public void SelectedNoteB(NoteSO obj)
    {
        selectedNoteB = obj;
    }
    

}
