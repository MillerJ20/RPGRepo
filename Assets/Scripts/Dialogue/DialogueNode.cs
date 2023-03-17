using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Dialogue
{
    [Serializable]
    public class DialogueNode
    {
        [SerializeField]
        public string id {  get; set; }
        [SerializeField]
        public string text { get; set; }
        [SerializeField]
        public string[] children { get; set; }
    }
}

