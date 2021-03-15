﻿using System;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using BepInEx.Configuration;
using ExtraRolesMod;

namespace CustomKeyBinds.Tools
{
    public static class ConfigManager
    {
     

        public static Dictionary<KeyAction, KeyCode> keyBinds;

        public static readonly Dictionary<KeyAction, KeyCode> DefaultKeyBinds = new Dictionary<KeyAction, KeyCode>
        {
            {KeyAction.Forward, KeyCode.W},
            {KeyAction.Left, KeyCode.A},
            {KeyAction.Backward, KeyCode.S},
            {KeyAction.Right, KeyCode.D},
            {KeyAction.Use, KeyCode.Space},
            {KeyAction.Report, KeyCode.R},
            {KeyAction.Kill, KeyCode.Q},
            {KeyAction.Map, KeyCode.Tab},
            {KeyAction.Tasks, KeyCode.T}
        };

        public static void LoadKeybinds()
        {
            if (keyBinds != null)
                return;
            keyBinds = new Dictionary<KeyAction, KeyCode>(DefaultKeyBinds);
        }
        
        
        public static void UpdateKey(KeyAction action, KeyCode code)
        {
            if (action == null)
                return;
            switch (action)
            {
                case KeyAction.Backward:
                    ExtraRolesMod.HarmonyMain.backwards.Value = code;
                    break;
                case KeyAction.Forward:
                    ExtraRolesMod.HarmonyMain.forward.Value = code;
                    break;
                case KeyAction.Left:
                    ExtraRolesMod.HarmonyMain.left.Value = code;
                    break;
                case KeyAction.Right:
                    ExtraRolesMod.HarmonyMain.right.Value = code;
                    break;
                case KeyAction.Kill: 
                    ExtraRolesMod.HarmonyMain.kill.Value = code;
                    break;
                case KeyAction.Map: 
                    ExtraRolesMod.HarmonyMain.map.Value = code;
                    break;
                case KeyAction.Tasks: 
                    ExtraRolesMod.HarmonyMain.tasks.Value = code;
                    break;
                case KeyAction.Report: 
                    ExtraRolesMod.HarmonyMain.report.Value = code;
                    break;
                case KeyAction.Use: 
                    ExtraRolesMod.HarmonyMain.use.Value = code;
                    break;
            }
            keyBinds[action] = code;

        }
        
    }
}