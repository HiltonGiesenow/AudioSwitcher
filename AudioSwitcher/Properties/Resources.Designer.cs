﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AudioSwitcher.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AudioSwitcher.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Something gone wrong. EndPointController.exe was changed since application start..
        /// </summary>
        internal static string ERROR_CONTROLLER_CHANGED {
            get {
                return ResourceManager.GetString("ERROR_CONTROLLER_CHANGED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: EndPointController.exe not found..
        /// </summary>
        internal static string ERROR_CONTROLLER_NOT_FOUND {
            get {
                return ResourceManager.GetString("ERROR_CONTROLLER_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: EndPointController.exe not passed hash code verification..
        /// </summary>
        internal static string ERROR_INCORRECT_HASH {
            get {
                return ResourceManager.GetString("ERROR_INCORRECT_HASH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Program doesn&apos;t contains MD5 for EndPointController.exe.\nPlease, restart application with argument --update-md5..
        /// </summary>
        internal static string ERROR_NO_MD5 {
            get {
                return ResourceManager.GetString("ERROR_NO_MD5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        internal static string LABEL_EXIT {
            get {
                return ResourceManager.GetString("LABEL_EXIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh List.
        /// </summary>
        internal static string LABEL_REFRESH_DEVICE_LIST {
            get {
                return ResourceManager.GetString("LABEL_REFRESH_DEVICE_LIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application will be closed..
        /// </summary>
        internal static string MESSAGE_APPLICATION_WILL_BE_CLOSED {
            get {
                return ResourceManager.GetString("MESSAGE_APPLICATION_WILL_BE_CLOSED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program updated MD5 for EndPointController.exe.\nYou can now start application..
        /// </summary>
        internal static string MESSAGE_MD5_UPDATED {
            get {
                return ResourceManager.GetString("MESSAGE_MD5_UPDATED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon speaker {
            get {
                object obj = ResourceManager.GetObject("speaker", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Playing:.
        /// </summary>
        internal static string STATUS_PLAYING {
            get {
                return ResourceManager.GetString("STATUS_PLAYING", resourceCulture);
            }
        }
    }
}
