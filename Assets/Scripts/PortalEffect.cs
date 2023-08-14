using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PortalEffect : MonoBehaviour
{
    private ScriptableRendererData m_rendererData;
    private RenderObjects m_renderObjects;

    private void Start()
    {
        m_rendererData = Resources.Load<ScriptableRendererData>("MyRenderer_Renderer");
        if (m_rendererData.rendererFeatures[0] is RenderObjects)
        {
            m_renderObjects = (RenderObjects)m_rendererData.rendererFeatures[0];
            print("toto2");
        }
        m_renderObjects.settings.stencilSettings.stencilCompareFunction = CompareFunction.Equal;
        m_rendererData.SetDirty();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player" && m_renderObjects.settings.stencilSettings.stencilCompareFunction == CompareFunction.Equal )
        {
            print("coucou");
            m_renderObjects.settings.stencilSettings.stencilCompareFunction = CompareFunction.NotEqual;
            m_rendererData.SetDirty();
        }
        else if (other.tag == "Player" && m_renderObjects.settings.stencilSettings.stencilCompareFunction == CompareFunction.NotEqual)
        {
            print("coucou");
            m_renderObjects.settings.stencilSettings.stencilCompareFunction = CompareFunction.Equal;
            m_rendererData.SetDirty();
        }
    }

}
