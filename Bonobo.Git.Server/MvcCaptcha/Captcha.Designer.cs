﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSharp.Core {
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
    public class Captcha {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Captcha() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bonobo.Git.Server.MvcCaptcha.Captcha", typeof(Captcha).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Captcha Incorrect 的本地化字符串。
        /// </summary>
        public static string Captcha_Incorrect {
            get {
                return ResourceManager.GetString("Captcha_Incorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Enable Captcha 的本地化字符串。
        /// </summary>
        public static string EnableCaptcha {
            get {
                return ResourceManager.GetString("EnableCaptcha", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 jQuery have not loaded, please ensure that jQuery is loaded before!
        /// 的本地化字符串。
        /// </summary>
        public static string JQueryNotLoadedPleaseEnsureThat {
            get {
                return ResourceManager.GetString("JQueryNotLoadedPleaseEnsureThat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Refresh Image 的本地化字符串。
        /// </summary>
        public static string Refresh {
            get {
                return ResourceManager.GetString("Refresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unfound the Id:{0}, Please check validity of CaptchaImageContainerId
        /// 的本地化字符串。
        /// </summary>
        public static string Unfound_CaptchaImageContainerId_PleaseCheck {
            get {
                return ResourceManager.GetString("Unfound_CaptchaImageContainerId_PleaseCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unfound the Id:{0}, Please check validity of ValidatonInputBoxId 的本地化字符串。
        /// </summary>
        public static string Unfound_ValidationInputBoxId_PleaseCheck {
            get {
                return ResourceManager.GetString("Unfound_ValidationInputBoxId_PleaseCheck", resourceCulture);
            }
        }
    }
}
