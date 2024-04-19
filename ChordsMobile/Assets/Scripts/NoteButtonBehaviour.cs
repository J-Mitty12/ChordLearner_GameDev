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
        if (noteChecker == null)
        {
            Debug.LogError("Object comparer is not assigned!");
            return;
        }

        noteChecker.SelectedNoteA(noteData);
        Debug.Log("selected");
    }
}
