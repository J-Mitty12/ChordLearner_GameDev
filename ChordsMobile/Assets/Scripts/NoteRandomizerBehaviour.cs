using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteRandomizerBehaviour : MonoBehaviour
{
    private TextMeshProUGUI Note;
    private List<string> noteList = new List<string>{"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"};


    void Start()
    {
        Note = GetComponent<TextMeshProUGUI>();
        GetRandomNote();
        /*string randomNote = GetRandomNote();
        Note.text = randomNote;*/
    }


    private void Update()
    {
        /*foreach (string VARIABLE in noteList)
        {
            print(VARIABLE);
        }
        //Note.text = "A";
       //print(Note.text);*/
    }

    public void GetRandomNote()
    {
        int randomIndex = Random.Range(0, noteList.Count);
        string randomNote = noteList[randomIndex];
        Note.text = randomNote;
    }
}
