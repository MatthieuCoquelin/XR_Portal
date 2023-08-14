using System;
using UnityEngine;
using UnityEditor;

public class CreateAssetBundles
{
    [MenuItem("Assets/Create AssetBundle")]
    private static void BuildAssetBundle()
    {
        string assetBundlePath = Application.dataPath + "/StreamingAssets";
        try
        {
            BuildPipeline.BuildAssetBundles(assetBundlePath, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
        }
        catch(Exception e)
        {
            Debug.LogWarning(e);
        }
    }
 
}
