using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialog/Speaker")]
public class SpeakerData : ScriptableObject
{
    public const string EMOTION_HAPPY = "happy";
    public string speakerName;
    public Sprite portraitHappy;

    public Sprite GetEmotionPortrait (string emotion)
    {
        switch(emotion)
        {
            default:
            case EMOTION_HAPPY: return portraitHappy;
        }
    }
}
