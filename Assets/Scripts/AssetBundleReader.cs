using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using System.IO;

public class AssetBundleReader : MonoBehaviour
{
    private ScriptableRendererData SRD = null;
    private RenderObjects m_renderObjects;

    private void Start()
    {
        //string path = Path.Combine(Application.persistentDataPath, "rendererassetbundle");
        //print(path);
        //var myLoadedAssetBundle = AssetBundle.LoadFromFile(path); 
        //if (myLoadedAssetBundle == null)
        //{
        //    Debug.Log("Failed to load AssetBundle!");
        //    return;
        //}

        //ScriptableRendererData SRD = myLoadedAssetBundle.LoadAsset<ScriptableRendererData>("MyRenderer_Renderer");
        //if (SRD == null)
        //    print("SDR null");

        //myLoadedAssetBundle.Unload(true);

        //https://docs.unity3d.com/ScriptReference/AssetBundle.html 
        //https://forum.unity.com/threads/file-on-android-device-not-found-no-matter-what-path-datapath.939726/

        SRD = Resources.Load<ScriptableRendererData>("MyRenderer_Renderer");
        if (SRD.rendererFeatures[0] is RenderObjects)
        {
            m_renderObjects = (RenderObjects)SRD.rendererFeatures[0];
            print("toto2");
        }
        m_renderObjects.settings.stencilSettings.stencilCompareFunction = CompareFunction.Equal;
        print("toto3");
        SRD.SetDirty();
        print("toto4");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("coucou");
        if (other.tag == "Player" && m_renderObjects.settings.stencilSettings.stencilCompareFunction == CompareFunction.Equal)
        {
            print("coucou1");
            m_renderObjects.settings.stencilSettings.stencilCompareFunction = CompareFunction.NotEqual;
            SRD.SetDirty();
        }
        else if (other.tag == "Player" && m_renderObjects.settings.stencilSettings.stencilCompareFunction == CompareFunction.NotEqual)
        {
            print("coucou2");
            m_renderObjects.settings.stencilSettings.stencilCompareFunction = CompareFunction.Equal;
            SRD.SetDirty();
        }
    }
}
