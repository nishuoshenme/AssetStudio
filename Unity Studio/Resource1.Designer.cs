﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unity_Studio {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Unity_Studio.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 #version 140
        ///
        ///in vec3 surfaceNormal;
        ///in vec3 toLightVector;
        ///in vec4 color;
        ///
        ///out vec4 outputColor;
        ///
        ///void main()
        ///{
        ///	vec3 lightColor = vec3(0.5, 0.5, 0.5);
        ///
        ///	// Ambient
        ///	float ambientStrength = 0.9;
        ///	vec3 ambient = ambientStrength * lightColor;
        ///
        ///	// Diffuse
        ///	vec3 unitNormal = normalize(surfaceNormal);
        ///	vec3 unitLightVector = normalize(toLightVector);
        ///	float nDotProduct = dot(unitNormal, unitLightVector);
        ///	float brightness = clamp(nDotProduct, 0, 1);  // max(nDotProduct, 0.0);
        ///	vec3 diffuse [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string fs {
            get {
                return ResourceManager.GetString("fs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #version 140
        ///
        ///in vec3 vertexPosition;
        ///in vec3 normalDirection;
        ///in vec4 vertexColor;
        ///uniform mat4 viewMatrix;
        ///
        ///out vec3 surfaceNormal;
        ///out vec3 toLightVector;
        ///out vec4 color;
        ///
        ///void main()
        ///{
        ///	vec3 lightPosition = vec3(200.0, 200.0, 200.0);
        ///	gl_Position = viewMatrix * vec4(vertexPosition, 1.0);
        ///	surfaceNormal = normalDirection;
        ///	toLightVector = lightPosition - vertexPosition;
        ///	color = vertexColor; 
        ///} 的本地化字符串。
        /// </summary>
        internal static string vs {
            get {
                return ResourceManager.GetString("vs", resourceCulture);
            }
        }
    }
}
