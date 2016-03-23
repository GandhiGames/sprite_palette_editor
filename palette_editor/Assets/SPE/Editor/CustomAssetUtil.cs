﻿using UnityEngine;using UnityEditor;public class CustomAssetFactory {    public static T CreateAsset<T>(string path) where T : ScriptableObject    {        T asset = ScriptableObject.CreateInstance<T>();        var newPath = AssetDatabase.GenerateUniqueAssetPath(path);        AssetDatabase.CreateAsset(asset, newPath);        AssetDatabase.SaveAssets();        return asset;    }	}