﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoAPKTool.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutoAPKTool.Properties.Resources", typeof(Resources).Assembly);
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
        ///   查找类似 APK|*.apk|All|*.* 的本地化字符串。
        /// </summary>
        internal static string apk_files {
            get {
                return ResourceManager.GetString("apk_files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 执行完成 的本地化字符串。
        /// </summary>
        internal static string complete {
            get {
                return ResourceManager.GetString("complete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 转换出现异常 的本地化字符串。
        /// </summary>
        internal static string convert_expcetion {
            get {
                return ResourceManager.GetString("convert_expcetion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 是否需要忽略res资源文件？ 的本地化字符串。
        /// </summary>
        internal static string DecodeWithoutResource {
            get {
                return ResourceManager.GetString("DecodeWithoutResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 DEX|*.dex|All|*.* 的本地化字符串。
        /// </summary>
        internal static string dex_files {
            get {
                return ResourceManager.GetString("dex_files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 
        /// 的本地化字符串。
        /// </summary>
        internal static string enter {
            get {
                return ResourceManager.GetString("enter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文件夹|* 的本地化字符串。
        /// </summary>
        internal static string files {
            get {
                return ResourceManager.GetString("files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 提示 的本地化字符串。
        /// </summary>
        internal static string info {
            get {
                return ResourceManager.GetString("info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 提示 的本地化字符串。
        /// </summary>
        internal static string info_ {
            get {
                return ResourceManager.GetString("info_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Jar|*.jar 的本地化字符串。
        /// </summary>
        internal static string jar_files {
            get {
                return ResourceManager.GetString("jar_files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 生成成功 的本地化字符串。
        /// </summary>
        internal static string make_succ {
            get {
                return ResourceManager.GetString("make_succ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 需要批量反编译吗 的本地化字符串。
        /// </summary>
        internal static string need_decompiles {
            get {
                return ResourceManager.GetString("need_decompiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 需要批量签名吗 的本地化字符串。
        /// </summary>
        internal static string need_signs {
            get {
                return ResourceManager.GetString("need_signs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现apk文件! 的本地化字符串。
        /// </summary>
        internal static string no_find_apk {
            get {
                return ResourceManager.GetString("no_find_apk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现dex文件! 的本地化字符串。
        /// </summary>
        internal static string no_find_dex {
            get {
                return ResourceManager.GetString("no_find_dex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现framework框架，请自行将odex所在的手机或模拟器上system下的framework文件夹放在工具箱的tool文件夹下内，请勿重命名! 的本地化字符串。
        /// </summary>
        internal static string no_find_framework {
            get {
                return ResourceManager.GetString("no_find_framework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现jar文件! 的本地化字符串。
        /// </summary>
        internal static string no_find_jar {
            get {
                return ResourceManager.GetString("no_find_jar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现odex文件! 的本地化字符串。
        /// </summary>
        internal static string no_find_odex {
            get {
                return ResourceManager.GetString("no_find_odex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现smali文件夹! 的本地化字符串。
        /// </summary>
        internal static string no_find_smali_files {
            get {
                return ResourceManager.GetString("no_find_smali_files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未发现签名文件! 的本地化字符串。
        /// </summary>
        internal static string no_sign {
            get {
                return ResourceManager.GetString("no_sign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 路径: {0} 的本地化字符串。
        /// </summary>
        internal static string path {
            get {
                return ResourceManager.GetString("path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请正确配置 的本地化字符串。
        /// </summary>
        internal static string pls_config {
            get {
                return ResourceManager.GetString("pls_config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请确认是否已经拖入反编译后的文件夹! 的本地化字符串。
        /// </summary>
        internal static string pls_confirm_decompile_package {
            get {
                return ResourceManager.GetString("pls_confirm_decompile_package", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入指令哦 的本地化字符串。
        /// </summary>
        internal static string pls_input_opcode {
            get {
                return ResourceManager.GetString("pls_input_opcode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请检测根目录下是否包含as.exe程序 的本地化字符串。
        /// </summary>
        internal static string pls_insure_your_as_path {
            get {
                return ResourceManager.GetString("pls_insure_your_as_path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请确认指令是否正确 的本地化字符串。
        /// </summary>
        internal static string pls_make_sure {
            get {
                return ResourceManager.GetString("pls_make_sure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 支持类型|*.apk;*.jar;*.odex;*.dex 的本地化字符串。
        /// </summary>
        internal static string support_file {
            get {
                return ResourceManager.GetString("support_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 正在努力执行中... 的本地化字符串。
        /// </summary>
        internal static string working_hard {
            get {
                return ResourceManager.GetString("working_hard", resourceCulture);
            }
        }
    }
}
