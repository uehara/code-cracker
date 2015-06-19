﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeCracker.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeCracker.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Change parameter type &apos;{0}&apos; accessibility to be as accessible as method &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInMethodParameter_CodeActionMessage {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInMethodParameter_CodeActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change return type &apos;{0}&apos; accessibility to be as accessible as method &apos;{1}&apos;.
        /// </summary>
        public static string InconsistentAccessibilityInMethodReturnType_CodeActionMessage {
            get {
                return ResourceManager.GetString("InconsistentAccessibilityInMethodReturnType_CodeActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In C#6 the nameof() operator should be used to specify the name of a program element instead of a string literal as it produce code that is easier to refactor..
        /// </summary>
        public static string NameOfAnalyzer_Description {
            get {
                return ResourceManager.GetString("NameOfAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;nameof({0})&apos; instead of specifying the program element name..
        /// </summary>
        public static string NameOfAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("NameOfAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use nameof.
        /// </summary>
        public static string NameOfAnalyzer_Title {
            get {
                return ResourceManager.GetString("NameOfAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use nameof().
        /// </summary>
        public static string NameOfCodeFixProvider_Title {
            get {
                return ResourceManager.GetString("NameOfCodeFixProvider_Title", resourceCulture);
            }
        }
    }
}
