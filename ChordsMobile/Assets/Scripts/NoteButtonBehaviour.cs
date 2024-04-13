using UnityEngine;
using UnityEngine.UI;

public class NoteButtonBehaviour : MonoBehaviour
{
    public NoteSO noteData;
    public NoteHandlerBehaviour noteChecker;
    
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        Debug.Log("Clicked on note: " + noteData.noteID);
        noteChecker.HandleNoteButtonClick(noteData);
    }
}
