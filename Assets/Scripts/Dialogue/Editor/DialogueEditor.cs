﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace RPG.Dialogue.Editor
{
    public class DialogueEditor : EditorWindow
    {
        Dialogue selectedDialogue = null;

        [MenuItem("Window/Dialogue Editor")]
        public static void ShowEditorWindow()
        {
            GetWindow(typeof(DialogueEditor), false, "Dialogue Editor");
        }

        [OnOpenAsset(1)]
        public static bool OnOpenAsset(int instanceID, int line)
        {
            Dialogue dialogue = EditorUtility.InstanceIDToObject(instanceID) as Dialogue;
            if (dialogue != null)
            {
                ShowEditorWindow();
                return true;
            }
            return false;
        }

        private void OnEnable()
        {
            Selection.selectionChanged += OnSelectionChanged;
            selectedDialogue = (Dialogue)Selection.activeObject;
        }

        private void OnSelectionChanged()
        {
            Dialogue dialogueAsset = Selection.activeObject as Dialogue;
            if (dialogueAsset != null)
            {
                selectedDialogue = dialogueAsset;
                Repaint();
            }
        }

        private void OnGUI()
        {
            if(selectedDialogue == null) 
            {
                EditorGUILayout.LabelField("No Dialogue Selected");
            }
            else
            {
                EditorGUILayout.LabelField(selectedDialogue.name);
            }
        }
    }
}
