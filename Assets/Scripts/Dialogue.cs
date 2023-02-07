using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Dialogue", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField] protected string _characterName;
    [SerializeField] protected Sprite _characterSprite;
    [SerializeField] protected List<string> _texts;
}
