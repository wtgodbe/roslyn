﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class MyExtensibilityRes
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MyExtensibilityRes", GetType(MyExtensibilityRes).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The following My Namespace extensions are associated with assembly &apos;{0}&apos;. Do you want to add them to your project?.
        '''</summary>
        Friend Shared ReadOnly Property AssemblyOptionDialog_Add_Question() As String
            Get
                Return ResourceManager.GetString("AssemblyOptionDialog_Add_Question", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add My Namespace Extensions.
        '''</summary>
        Friend Shared ReadOnly Property AssemblyOptionDialog_Add_Text() As String
            Get
                Return ResourceManager.GetString("AssemblyOptionDialog_Add_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;Remember my decision for &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property AssemblyOptionDialog_Option() As String
            Get
                Return ResourceManager.GetString("AssemblyOptionDialog_Option", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Removing the reference to &apos;{0}&apos; will make the following My Namespace extensions stop functioning. Do you want to remove them as well?.
        '''</summary>
        Friend Shared ReadOnly Property AssemblyOptionDialog_Remove_Question() As String
            Get
                Return ResourceManager.GetString("AssemblyOptionDialog_Remove_Question", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove My Namespace Extensions.
        '''</summary>
        Friend Shared ReadOnly Property AssemblyOptionDialog_Remove_Text() As String
            Get
                Return ResourceManager.GetString("AssemblyOptionDialog_Remove_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No project items were added to the current project from My Namespace extension &apos;{0}&apos;. The extension will not be added to the project..
        '''</summary>
        Friend Shared ReadOnly Property CouldNotAddProjectItemTemplate_Message() As String
            Get
                Return ResourceManager.GetString("CouldNotAddProjectItemTemplate_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to Add Project Item.
        '''</summary>
        Friend Shared ReadOnly Property CouldNotAddProjectItemTemplate_Title() As String
            Get
                Return ResourceManager.GetString("CouldNotAddProjectItemTemplate_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No project items could be associated with My Namespace extension &apos;{0}&apos;. The extension will not be added to the project..
        '''</summary>
        Friend Shared ReadOnly Property CouldNotSetExtensionAttributes_AllItems() As String
            Get
                Return ResourceManager.GetString("CouldNotSetExtensionAttributes_AllItems", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Project item &apos;{0}&apos; was added to the current project but could not be associated with My Namespace extension &apos;{1}&apos;. It will not be removed with the extension..
        '''</summary>
        Friend Shared ReadOnly Property CouldNotSetExtensionAttributes_Message() As String
            Get
                Return ResourceManager.GetString("CouldNotSetExtensionAttributes_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to Set Extension Attributes.
        '''</summary>
        Friend Shared ReadOnly Property CouldNotSetExtensionAttributes_Title() As String
            Get
                Return ResourceManager.GetString("CouldNotSetExtensionAttributes_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Version &apos;{0}&apos; of My Namespace extension &apos;{1}&apos; already exists in the current project. Do you want to overwrite it with version &apos;{2}&apos;?.
        '''</summary>
        Friend Shared ReadOnly Property ExtensionExists_Message() As String
            Get
                Return ResourceManager.GetString("ExtensionExists_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extension File Already Exists.
        '''</summary>
        Friend Shared ReadOnly Property ExtensionExists_Title() As String
            Get
                Return ResourceManager.GetString("ExtensionExists_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to My Extensions.
        '''</summary>
        Friend Shared ReadOnly Property PropertyPageTab() As String
            Get
                Return ResourceManager.GetString("PropertyPageTab", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to My Namespace extensions added: &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Add_Finish() As String
            Get
                Return ResourceManager.GetString("StatusBar_Add_Finish", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to My Namespace extension added: &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Add_Progress() As String
            Get
                Return ResourceManager.GetString("StatusBar_Add_Progress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to My Namespace extensions added: &apos;{0}&apos;. My Namespace extensions removed: &apos;{1}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Add_Remove_Finish() As String
            Get
                Return ResourceManager.GetString("StatusBar_Add_Remove_Finish", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Adding My Namespace extensions....
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Add_Start() As String
            Get
                Return ResourceManager.GetString("StatusBar_Add_Start", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to My Namespace extensions removed: &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Remove_Finish() As String
            Get
                Return ResourceManager.GetString("StatusBar_Remove_Finish", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to My Namespace extension removed: &apos;{0}&apos;..
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Remove_Progress() As String
            Get
                Return ResourceManager.GetString("StatusBar_Remove_Progress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Removing My Namespace extensions....
        '''</summary>
        Friend Shared ReadOnly Property StatusBar_Remove_Start() As String
            Get
                Return ResourceManager.GetString("StatusBar_Remove_Start", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
