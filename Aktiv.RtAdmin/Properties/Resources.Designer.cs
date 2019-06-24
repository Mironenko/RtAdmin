﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aktiv.RtAdmin.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aktiv.RtAdmin.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} : Generate activation passwords passed.
        /// </summary>
        public static string ActivationPasswordsWereGenerated {
            get {
                return ResourceManager.GetString("ActivationPasswordsWereGenerated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : Admin PIN change failed. Enter admin PIN.
        /// </summary>
        public static string AdminPinChangeError {
            get {
                return ResourceManager.GetString("AdminPinChangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Admin PIN code. Must be specified for Admin PIN changing. If not specified, the default value is used.
        /// </summary>
        public static string AdminPinOption {
            get {
                return ResourceManager.GetString("AdminPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For changing admin PIN enter old admin PIN.
        /// </summary>
        public static string ChangeAdminPinOldPinError {
            get {
                return ResourceManager.GetString("ChangeAdminPinOldPinError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t change token label. Enter user PIN using -c.
        /// </summary>
        public static string ChangeTokenLabelPinError {
            get {
                return ResourceManager.GetString("ChangeTokenLabelPinError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For changing user PIN enter old user or admin PIN.
        /// </summary>
        public static string ChangeUserPinOldPinsError {
            get {
                return ResourceManager.GetString("ChangeUserPinOldPinsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change volume attributes. Id : volume id {1 - 9}, aR : access rights{ro, rw, hi, cd}, cT : change type { p - permanent, t - temporary }.
        /// </summary>
        public static string ChangeVolumeAttributesOption {
            get {
                return ResourceManager.GetString("ChangeVolumeAttributesOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration file path.
        /// </summary>
        public static string ConfigurationFilePathOption {
            get {
                return ResourceManager.GetString("ConfigurationFilePathOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format memory. If your device has built-in Flash memory you may specify Admin PIN, otherwise you may lose all data on it.
        /// </summary>
        public static string FormatTokenOption {
            get {
                return ResourceManager.GetString("FormatTokenOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formatting was successful. Token Id: 0x{0}.
        /// </summary>
        public static string FormatTokenSuccess {
            get {
                return ResourceManager.GetString("FormatTokenSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format volume. Id : volume id {1 - 9}, size : volume size in MB, owner : volume owner {a - administrator, u - user}, aR : access rights {ro, rw, hi, cd}. One command for one volume. To create multiple partitions, use the appropriate number of -F commands in sequence&quot;.
        /// </summary>
        public static string FormatVolumeParamsOption {
            get {
                return ResourceManager.GetString("FormatVolumeParamsOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate random Admin PIN code of specified length. If this command is used -a is ignored.
        /// </summary>
        public static string GenerateRandomAdminPinOption {
            get {
                return ResourceManager.GetString("GenerateRandomAdminPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate random User PIN code of specified length. If this command is used -u is ignored.
        /// </summary>
        public static string GenerateRandomUserPinOption {
            get {
                return ResourceManager.GetString("GenerateRandomUserPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : Generating activation password(s).
        /// </summary>
        public static string GeneratingActivationPasswords {
            get {
                return ResourceManager.GetString("GeneratingActivationPasswords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entered Admin PIN is incorrect.
        /// </summary>
        public static string IncorrectAdminPin {
            get {
                return ResourceManager.GetString("IncorrectAdminPin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entered PIN is incorrect.
        /// </summary>
        public static string IncorrectPin {
            get {
                return ResourceManager.GetString("IncorrectPin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file contains incorrect number of PINs.
        /// </summary>
        public static string IncorrectPinCodesCount {
            get {
                return ResourceManager.GetString("IncorrectPinCodesCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application was initialized.
        /// </summary>
        public static string InitializedInfo {
            get {
                return ResourceManager.GetString("InitializedInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : Local PIN has been successfully set.
        /// </summary>
        public static string LocalPinSetSuccess {
            get {
                return ResourceManager.GetString("LocalPinSetSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log file path.
        /// </summary>
        public static string LogFilePathOption {
            get {
                return ResourceManager.GetString("LogFilePathOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN Login with local PIN. Id : local PIN id {1 - 9}, PIN : local PIN. In order to use local user set his new PIN preliminarily.
        /// </summary>
        public static string LoginWithLocalPinOption {
            get {
                return ResourceManager.GetString("LoginWithLocalPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max PIN code attempts count for Admin PIN (count must be in the range from 3 to 10; default: 6).
        /// </summary>
        public static string MaxAdminPinAttemptsOption {
            get {
                return ResourceManager.GetString("MaxAdminPinAttemptsOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max PIN code attempts count for User PIN (count must be in the range from 3 to 10; default: 6).
        /// </summary>
        public static string MaxUserPinAttemptsOption {
            get {
                return ResourceManager.GetString("MaxUserPinAttemptsOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Min Admin PIN code length (len must be in the range from 1 to 31; default: 6). Ignore for Rutoken S(use 1 only).
        /// </summary>
        public static string MinAdminPinLengthOption {
            get {
                return ResourceManager.GetString("MinAdminPinLengthOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Min User PIN code length (len must be in the range from 1 to 31; default: 6). Ignore for Rutoken S(use 1 only).
        /// </summary>
        public static string MinUserPinLengthOption {
            get {
                return ResourceManager.GetString("MinUserPinLengthOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify a native library to use.
        /// </summary>
        public static string NativeLibraryPathOption {
            get {
                return ResourceManager.GetString("NativeLibraryPathOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Old Admin PIN code. Must be specified for Admin PIN changing.
        /// </summary>
        public static string OldAdminPinOption {
            get {
                return ResourceManager.GetString("OldAdminPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Old User PIN code. Must be specified for User PIN changing.
        /// </summary>
        public static string OldUserPinOption {
            get {
                return ResourceManager.GetString("OldUserPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop after one iteration.
        /// </summary>
        public static string OneIterationOnlyOption {
            get {
                return ResourceManager.GetString("OneIterationOnlyOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: PIN2 PINPad set request has been successfully sent.
        /// </summary>
        public static string Pin2SetSuccess {
            get {
                return ResourceManager.GetString("Pin2SetSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN changed successfully.
        /// </summary>
        public static string PinChangedSuccess {
            get {
                return ResourceManager.GetString("PinChangedSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN change policy N : { 1 - administrator (SO) can change user PIN | 2 - user can change user PIN | 3 - both } (default: 2).
        /// </summary>
        public static string PinChangePolicyOption {
            get {
                return ResourceManager.GetString("PinChangePolicyOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN-code file not found.
        /// </summary>
        public static string PinCodesFileNotFound {
            get {
                return ResourceManager.GetString("PinCodesFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load new PIN codes from specified file. Use ont PIN per line, \n is separator. -a -u -G -g commands are ignored.
        /// </summary>
        public static string PinFilePathOption {
            get {
                return ResourceManager.GetString("PinFilePathOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN length and allowed PIN length mismatch. Min admin PIN length: {0}, max admin PIN length: {1}, min user PIN length: {2}, max user PIN length: {3}.
        /// </summary>
        public static string PinLengthMismatch {
            get {
                return ResourceManager.GetString("PinLengthMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN-codes from file ended.
        /// </summary>
        public static string PinsEnded {
            get {
                return ResourceManager.GetString("PinsEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New random Admin PIN length and allowed PIN length mismatch, min PIN length: {0}, max PIN length: {1}.
        /// </summary>
        public static string RandomAdminPinLengthMismatch {
            get {
                return ResourceManager.GetString("RandomAdminPinLengthMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New random User PIN length and allowed PIN length mismatch, min PIN length: {0}, max PIN length: {1}.
        /// </summary>
        public static string RandomUserPinLengthMismatch {
            get {
                return ResourceManager.GetString("RandomUserPinLengthMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIN Set local PIN. Id : local PIN id {1 - 9}, PIN : local PIN. You should use login with local PIN command to set local user PIN.
        /// </summary>
        public static string SetLocalPinOption {
            get {
                return ResourceManager.GetString("SetLocalPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Activate setting PIN2 code (on the screen) mode. Must be specified for PIN2 changing. If not specified, the default value is used.
        /// </summary>
        public static string SetPin2ModeOption {
            get {
                return ResourceManager.GetString("SetPin2ModeOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set SM mode (only for Bluetooth token).  &quot;N : &quot; { 1 - Optional password | 2 - 1 password | 3 - 6 passwords }, mode { caps - only capital letters | digits - capital letters and digits }.
        /// </summary>
        public static string SmModeOption {
            get {
                return ResourceManager.GetString("SmModeOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token label changed successfully.
        /// </summary>
        public static string TokenLabelChangeSuccess {
            get {
                return ResourceManager.GetString("TokenLabelChangeSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use cp1251 for new device label.
        /// </summary>
        public static string TokenLabelCp1251Option {
            get {
                return ResourceManager.GetString("TokenLabelCp1251Option", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use UTF-8 for new device label.
        /// </summary>
        public static string TokenLabelUtf8Option {
            get {
                return ResourceManager.GetString("TokenLabelUtf8Option", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unblock user and local PINs. You should use login with Admin PIN command to unblock user and local PINs.
        /// </summary>
        public static string UnblockPinsOption {
            get {
                return ResourceManager.GetString("UnblockPinsOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : User PIN change failed. Enter admin pin according to user PIN change policy on token.
        /// </summary>
        public static string UserPinChangeAdminPinError {
            get {
                return ResourceManager.GetString("UserPinChangeAdminPinError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : User PIN change failed. Enter user PIN or admin PIN according to user PIN change policy on token.
        /// </summary>
        public static string UserPinChangeError {
            get {
                return ResourceManager.GetString("UserPinChangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : User PIN change failed. Enter user pin according to user PIN change policy on token.
        /// </summary>
        public static string UserPinChangeUserPinError {
            get {
                return ResourceManager.GetString("UserPinChangeUserPinError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set User PIN code. Must be specified for Admin PIN changing. If not specified, the default value is used.
        /// </summary>
        public static string UserPinOption {
            get {
                return ResourceManager.GetString("UserPinOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use UTF-8 instead of cp1251 in PIN codes.
        /// </summary>
        public static string Utf8Option {
            get {
                return ResourceManager.GetString("Utf8Option", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get volume info. Id : volume id {1 - 9, a - all, sz - get flash size}.
        /// </summary>
        public static string VolumeInfoParamsOption {
            get {
                return ResourceManager.GetString("VolumeInfoParamsOption", resourceCulture);
            }
        }
    }
}
