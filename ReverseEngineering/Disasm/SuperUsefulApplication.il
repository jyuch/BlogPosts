
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation. All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern Microsoft.VisualBasic
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly extern System.Core
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly SuperUsefulApplication
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 )
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- 次のカスタム属性が自動的に追加されました。コメントを解除しないでください -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 )

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 16 53 75 70 65 72 55 73 65 66 75 6C 41 70   // ...SuperUsefulAp
                                                                                              70 6C 69 63 61 74 69 6F 6E 00 00 )                // plication..
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 16 53 75 70 65 72 55 73 65 66 75 6C 41 70   // ...SuperUsefulAp
                                                                                                70 6C 69 63 61 74 69 6F 6E 00 00 )                // plication..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 18 43 6F 70 79 72 69 67 68 74 20 28 63 29   // ...Copyright (c)
                                                                                                  20 32 30 31 36 20 6A 79 75 63 68 00 00 )          //  2016 jyuch..
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 )
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 64 32 62 34 62 38 66 66 2D 64 37 65 30   // ..$d2b4b8ff-d7e0
                                                                                                  2D 34 65 39 39 2D 61 62 63 33 2D 61 62 34 37 65   // -4e99-abc3-ab47e
                                                                                                  63 30 36 30 30 35 36 00 00 )                      // c060056..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 2E 32 01   // ,Version=v4.5.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 35 2E 32 )          // amework 4.5.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.mresource public SuperUsefulApplication.Resources.resources
{
  // Offset: 0x00000000 Length: 0x000000B4
  // 警告: 作成されたマネージ リソース ファイル SuperUsefulApplication.Resources.resources です。
}
.module SuperUsefulApplication.exe
// MVID: {1995DFD8-90FB-42B6-9D9D-6E2A12A01D0E}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00F00000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi SuperUsefulApplication.My.MyApplication
       extends [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase
{
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 08 31 31   // ...MyTemplate.11
                                                                                                  2E 30 2E 30 2E 30 00 00 )                         // .0.0.0..
  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
  .method public specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // コード サイズ       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase::.ctor()
    IL_0006:  ret
  } // end of method MyApplication::.ctor

} // end of class SuperUsefulApplication.My.MyApplication

.class private auto ansi SuperUsefulApplication.My.MyComputer
       extends [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer
{
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 08 31 31   // ...MyTemplate.11
                                                                                                  2E 30 2E 30 2E 30 00 00 )                         // .0.0.0..
  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
  .method public specialname rtspecialname
          instance void  .ctor() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
    // コード サイズ       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.Devices.Computer::.ctor()
    IL_0006:  ret
  } // end of method MyComputer::.ctor

} // end of class SuperUsefulApplication.My.MyComputer

.class private auto ansi sealed beforefieldinit SuperUsefulApplication.My.MyProject
       extends [mscorlib]System.Object
{
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 0A 4D 79 54 65 6D 70 6C 61 74 65 08 31 31   // ...MyTemplate.11
                                                                                                  2E 30 2E 30 2E 30 00 00 )                         // .0.0.0..
  .class auto ansi sealed nested assembly MyWebServices
         extends [mscorlib]System.Object
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
    .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.MyGroupCollectionAttribute::.ctor(string,
                                                                                                         string,
                                                                                                         string,
                                                                                                         string) = ( 01 00 34 53 79 73 74 65 6D 2E 57 65 62 2E 53 65   // ..4System.Web.Se
                                                                                                                     72 76 69 63 65 73 2E 50 72 6F 74 6F 63 6F 6C 73   // rvices.Protocols
                                                                                                                     2E 53 6F 61 70 48 74 74 70 43 6C 69 65 6E 74 50   // .SoapHttpClientP
                                                                                                                     72 6F 74 6F 63 6F 6C 12 43 72 65 61 74 65 5F 5F   // rotocol.Create__
                                                                                                                     49 6E 73 74 61 6E 63 65 5F 5F 13 44 69 73 70 6F   // Instance__.Dispo
                                                                                                                     73 65 5F 5F 49 6E 73 74 61 6E 63 65 5F 5F 00 00   // se__Instance__..
                                                                                                                     00 )
    .method public hidebysig strict virtual
            instance bool  Equals(object o) cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       13 (0xd)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  ldarg.1
      IL_0002:  call       object [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::GetObjectValue(object)
      IL_0007:  call       instance bool [mscorlib]System.Object::Equals(object)
      IL_000c:  ret
    } // end of method MyWebServices::Equals

    .method public hidebysig strict virtual
            instance int32  GetHashCode() cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance int32 [mscorlib]System.Object::GetHashCode()
      IL_0006:  ret
    } // end of method MyWebServices::GetHashCode

    .method assembly hidebysig instance class [mscorlib]System.Type
            GetType() cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       11 (0xb)
      .maxstack  8
      IL_0000:  ldtoken    SuperUsefulApplication.My.MyProject/MyWebServices
      IL_0005:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
      IL_000a:  ret
    } // end of method MyWebServices::GetType

    .method public hidebysig strict virtual
            instance string  ToString() cil managed
    {
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance string [mscorlib]System.Object::ToString()
      IL_0006:  ret
    } // end of method MyWebServices::ToString

    .method private static !!T  Create__Instance__<.ctor T>(!!T 'instance') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       20 (0x14)
      .maxstack  1
      .locals init (!!T V_0)
      IL_0000:  ldarg.0
      IL_0001:  box        !!T
      IL_0006:  brtrue.s   IL_0010

      IL_0008:  call       !!0 [mscorlib]System.Activator::CreateInstance<!!0>()
      IL_000d:  stloc.0
      IL_000e:  br.s       IL_0012

      IL_0010:  ldarg.0
      IL_0011:  stloc.0
      IL_0012:  ldloc.0
      IL_0013:  ret
    } // end of method MyWebServices::Create__Instance__

    .method private instance void  Dispose__Instance__<T>(!!T& 'instance') cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       8 (0x8)
      .maxstack  8
      IL_0000:  ldarg.1
      IL_0001:  initobj    !!T
      IL_0007:  ret
    } // end of method MyWebServices::Dispose__Instance__

    .method public specialname rtspecialname
            instance void  .ctor() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
      // コード サイズ       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method MyWebServices::.ctor

  } // end of class MyWebServices

  .class auto ansi sealed nested assembly ThreadSafeObjectProvider`1<.ctor T>
         extends [mscorlib]System.Object
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
    .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 )
    .field private static !T m_ThreadStaticValue
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 )
    .custom instance void [mscorlib]System.ThreadStaticAttribute::.ctor() = ( 01 00 00 00 )
    .method assembly specialname instance !T
            get_GetInstance() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      // コード サイズ       28 (0x1c)
      .maxstack  8
      IL_0000:  ldsfld     !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<!T>::m_ThreadStaticValue
      IL_0005:  box        !T
      IL_000a:  brtrue.s   IL_0016

      IL_000c:  call       !!0 [mscorlib]System.Activator::CreateInstance<!T>()
      IL_0011:  stsfld     !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<!T>::m_ThreadStaticValue
      IL_0016:  ldsfld     !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<!T>::m_ThreadStaticValue
      IL_001b:  ret
    } // end of method ThreadSafeObjectProvider`1::get_GetInstance

    .method public specialname rtspecialname
            instance void  .ctor() cil managed
    {
      .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
      .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 01 00 00 00 00 00 )
      // コード サイズ       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method ThreadSafeObjectProvider`1::.ctor

    .property instance !T GetInstance()
    {
      .get instance !T SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1::get_GetInstance()
    } // end of property ThreadSafeObjectProvider`1::GetInstance
  } // end of class ThreadSafeObjectProvider`1

  .field private static initonly class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyComputer> m_ComputerObjectProvider
  .field private static initonly class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyApplication> m_AppObjectProvider
  .field private static initonly class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider
  .field private static initonly class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyProject/MyWebServices> m_MyWebServicesObjectProvider
  .method private specialname rtspecialname static
          void  .cctor() cil managed
  {
    // コード サイズ       41 (0x29)
    .maxstack  8
    IL_0000:  newobj     instance void class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyComputer>::.ctor()
    IL_0005:  stsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyComputer> SuperUsefulApplication.My.MyProject::m_ComputerObjectProvider
    IL_000a:  newobj     instance void class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyApplication>::.ctor()
    IL_000f:  stsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyApplication> SuperUsefulApplication.My.MyProject::m_AppObjectProvider
    IL_0014:  newobj     instance void class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User>::.ctor()
    IL_0019:  stsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> SuperUsefulApplication.My.MyProject::m_UserObjectProvider
    IL_001e:  newobj     instance void class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyProject/MyWebServices>::.ctor()
    IL_0023:  stsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyProject/MyWebServices> SuperUsefulApplication.My.MyProject::m_MyWebServicesObjectProvider
    IL_0028:  ret
  } // end of method MyProject::.cctor

  .method assembly specialname static class SuperUsefulApplication.My.MyComputer
          get_Computer() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
    // コード サイズ       11 (0xb)
    .maxstack  8
    IL_0000:  ldsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyComputer> SuperUsefulApplication.My.MyProject::m_ComputerObjectProvider
    IL_0005:  callvirt   instance !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyComputer>::get_GetInstance()
    IL_000a:  ret
  } // end of method MyProject::get_Computer

  .method assembly specialname static class SuperUsefulApplication.My.MyApplication
          get_Application() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
    // コード サイズ       11 (0xb)
    .maxstack  8
    IL_0000:  ldsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyApplication> SuperUsefulApplication.My.MyProject::m_AppObjectProvider
    IL_0005:  callvirt   instance !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyApplication>::get_GetInstance()
    IL_000a:  ret
  } // end of method MyProject::get_Application

  .method assembly specialname static class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User
          get_User() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
    // コード サイズ       11 (0xb)
    .maxstack  8
    IL_0000:  ldsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User> SuperUsefulApplication.My.MyProject::m_UserObjectProvider
    IL_0005:  callvirt   instance !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User>::get_GetInstance()
    IL_000a:  ret
  } // end of method MyProject::get_User

  .method assembly specialname static class SuperUsefulApplication.My.MyProject/MyWebServices
          get_WebServices() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = ( 01 00 00 00 )
    // コード サイズ       11 (0xb)
    .maxstack  8
    IL_0000:  ldsfld     class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyProject/MyWebServices> SuperUsefulApplication.My.MyProject::m_MyWebServicesObjectProvider
    IL_0005:  callvirt   instance !0 class SuperUsefulApplication.My.MyProject/ThreadSafeObjectProvider`1<class SuperUsefulApplication.My.MyProject/MyWebServices>::get_GetInstance()
    IL_000a:  ret
  } // end of method MyProject::get_WebServices

  .property class SuperUsefulApplication.My.MyComputer
          Computer()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0B 4D 79 2E 43 6F 6D 70 75 74 65 72 00 00 ) // ...My.Computer..
    .get class SuperUsefulApplication.My.MyComputer SuperUsefulApplication.My.MyProject::get_Computer()
  } // end of property MyProject::Computer
  .property class SuperUsefulApplication.My.MyApplication
          Application()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0E 4D 79 2E 41 70 70 6C 69 63 61 74 69 6F   // ...My.Applicatio
                                                                                                       6E 00 00 )                                        // n..
    .get class SuperUsefulApplication.My.MyApplication SuperUsefulApplication.My.MyProject::get_Application()
  } // end of property MyProject::Application
  .property class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User
          User()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 07 4D 79 2E 55 73 65 72 00 00 )             // ...My.User..
    .get class [Microsoft.VisualBasic]Microsoft.VisualBasic.ApplicationServices.User SuperUsefulApplication.My.MyProject::get_User()
  } // end of property MyProject::User
  .property class SuperUsefulApplication.My.MyProject/MyWebServices
          WebServices()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0E 4D 79 2E 57 65 62 53 65 72 76 69 63 65   // ...My.WebService
                                                                                                       73 00 00 )                                        // s..
    .get class SuperUsefulApplication.My.MyProject/MyWebServices SuperUsefulApplication.My.MyProject::get_WebServices()
  } // end of property MyProject::WebServices
} // end of class SuperUsefulApplication.My.MyProject

.class private auto ansi sealed SuperUsefulApplication.My.Resources.Resources
       extends [mscorlib]System.Object
{
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 33 53 79 73 74 65 6D 2E 52 65 73 6F 75 72   // ..3System.Resour
                                                                                                  63 65 73 2E 54 6F 6F 6C 73 2E 53 74 72 6F 6E 67   // ces.Tools.Strong
                                                                                                  6C 79 54 79 70 65 64 52 65 73 6F 75 72 63 65 42   // lyTypedResourceB
                                                                                                  75 69 6C 64 65 72 07 34 2E 30 2E 30 2E 30 00 00 ) // uilder.4.0.0.0..
  .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 )
  .field private static class [mscorlib]System.Resources.ResourceManager resourceMan
  .field private static class [mscorlib]System.Globalization.CultureInfo resourceCulture
  .method assembly specialname static class [mscorlib]System.Resources.ResourceManager
          get_ResourceManager() cil managed
  {
    // コード サイズ       49 (0x31)
    .maxstack  8
    IL_0000:  ldsfld     class [mscorlib]System.Resources.ResourceManager SuperUsefulApplication.My.Resources.Resources::resourceMan
    IL_0005:  ldnull
    IL_0006:  call       bool [mscorlib]System.Object::ReferenceEquals(object,
                                                                       object)
    IL_000b:  brfalse.s  IL_002b

    IL_000d:  ldstr      "SuperUsefulApplication.Resources"
    IL_0012:  ldtoken    SuperUsefulApplication.My.Resources.Resources
    IL_0017:  call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
    IL_001c:  callvirt   instance class [mscorlib]System.Reflection.Assembly [mscorlib]System.Type::get_Assembly()
    IL_0021:  newobj     instance void [mscorlib]System.Resources.ResourceManager::.ctor(string,
                                                                                         class [mscorlib]System.Reflection.Assembly)
    IL_0026:  stsfld     class [mscorlib]System.Resources.ResourceManager SuperUsefulApplication.My.Resources.Resources::resourceMan
    IL_002b:  ldsfld     class [mscorlib]System.Resources.ResourceManager SuperUsefulApplication.My.Resources.Resources::resourceMan
    IL_0030:  ret
  } // end of method Resources::get_ResourceManager

  .method assembly specialname static class [mscorlib]System.Globalization.CultureInfo
          get_Culture() cil managed
  {
    // コード サイズ       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     class [mscorlib]System.Globalization.CultureInfo SuperUsefulApplication.My.Resources.Resources::resourceCulture
    IL_0005:  ret
  } // end of method Resources::get_Culture

  .method assembly specialname static void
          set_Culture(class [mscorlib]System.Globalization.CultureInfo 'value') cil managed
  {
    // コード サイズ       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  stsfld     class [mscorlib]System.Globalization.CultureInfo SuperUsefulApplication.My.Resources.Resources::resourceCulture
    IL_0006:  ret
  } // end of method Resources::set_Culture

  .property class [mscorlib]System.Resources.ResourceManager
          ResourceManager()
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 )
    .get class [mscorlib]System.Resources.ResourceManager SuperUsefulApplication.My.Resources.Resources::get_ResourceManager()
  } // end of property Resources::ResourceManager
  .property class [mscorlib]System.Globalization.CultureInfo
          Culture()
  {
    .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 )
    .get class [mscorlib]System.Globalization.CultureInfo SuperUsefulApplication.My.Resources.Resources::get_Culture()
    .set void SuperUsefulApplication.My.Resources.Resources::set_Culture(class [mscorlib]System.Globalization.CultureInfo)
  } // end of property Resources::Culture
} // end of class SuperUsefulApplication.My.Resources.Resources

.class private auto ansi sealed beforefieldinit SuperUsefulApplication.My.MySettings
       extends [System]System.Configuration.ApplicationSettingsBase
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [System]System.CodeDom.Compiler.GeneratedCodeAttribute::.ctor(string,
                                                                                      string) = ( 01 00 4B 4D 69 63 72 6F 73 6F 66 74 2E 56 69 73   // ..KMicrosoft.Vis
                                                                                                  75 61 6C 53 74 75 64 69 6F 2E 45 64 69 74 6F 72   // ualStudio.Editor
                                                                                                  73 2E 53 65 74 74 69 6E 67 73 44 65 73 69 67 6E   // s.SettingsDesign
                                                                                                  65 72 2E 53 65 74 74 69 6E 67 73 53 69 6E 67 6C   // er.SettingsSingl
                                                                                                  65 46 69 6C 65 47 65 6E 65 72 61 74 6F 72 08 31   // eFileGenerator.1
                                                                                                  31 2E 30 2E 30 2E 30 00 00 )                      // 1.0.0.0..
  .custom instance void [System]System.ComponentModel.EditorBrowsableAttribute::.ctor(valuetype [System]System.ComponentModel.EditorBrowsableState) = ( 01 00 02 00 00 00 00 00 )
  .field private static class SuperUsefulApplication.My.MySettings defaultInstance
  .method private specialname rtspecialname static
          void  .cctor() cil managed
  {
    // コード サイズ       21 (0x15)
    .maxstack  8
    IL_0000:  newobj     instance void SuperUsefulApplication.My.MySettings::.ctor()
    IL_0005:  call       class [System]System.Configuration.SettingsBase [System]System.Configuration.SettingsBase::Synchronized(class [System]System.Configuration.SettingsBase)
    IL_000a:  castclass  SuperUsefulApplication.My.MySettings
    IL_000f:  stsfld     class SuperUsefulApplication.My.MySettings SuperUsefulApplication.My.MySettings::defaultInstance
    IL_0014:  ret
  } // end of method MySettings::.cctor

  .method public specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // コード サイズ       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System]System.Configuration.ApplicationSettingsBase::.ctor()
    IL_0006:  ret
  } // end of method MySettings::.ctor

  .method public specialname static class SuperUsefulApplication.My.MySettings
          get_Default() cil managed
  {
    // コード サイズ       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     class SuperUsefulApplication.My.MySettings SuperUsefulApplication.My.MySettings::defaultInstance
    IL_0005:  ret
  } // end of method MySettings::get_Default

  .property class SuperUsefulApplication.My.MySettings
          Default()
  {
    .get class SuperUsefulApplication.My.MySettings SuperUsefulApplication.My.MySettings::get_Default()
  } // end of property MySettings::Default
} // end of class SuperUsefulApplication.My.MySettings

.class private auto ansi sealed SuperUsefulApplication.My.MySettingsProperty
       extends [mscorlib]System.Object
{
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.HideModuleNameAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 )
  .method assembly specialname static class SuperUsefulApplication.My.MySettings
          get_Settings() cil managed
  {
    // コード サイズ       6 (0x6)
    .maxstack  8
    IL_0000:  call       class SuperUsefulApplication.My.MySettings SuperUsefulApplication.My.MySettings::get_Default()
    IL_0005:  ret
  } // end of method MySettingsProperty::get_Settings

  .property class SuperUsefulApplication.My.MySettings
          Settings()
  {
    .custom instance void [System]System.ComponentModel.Design.HelpKeywordAttribute::.ctor(string) = ( 01 00 0B 4D 79 2E 53 65 74 74 69 6E 67 73 00 00 ) // ...My.Settings..
    .get class SuperUsefulApplication.My.MySettings SuperUsefulApplication.My.MySettingsProperty::get_Settings()
  } // end of property MySettingsProperty::Settings
} // end of class SuperUsefulApplication.My.MySettingsProperty

.class private auto ansi sealed SuperUsefulApplication.Program
       extends [mscorlib]System.Object
{
  .custom instance void [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute::.ctor() = ( 01 00 00 00 )
  .method public static void  Main(string[] args) cil managed
  {
    .entrypoint
    .custom instance void [mscorlib]System.STAThreadAttribute::.ctor() = ( 01 00 00 00 )
    // コード サイズ       188 (0xbc)
    .maxstack  4
    .locals init (class [System.Core]System.Security.Cryptography.SHA1Cng V_0,
             class SuperUsefulApplication.SuperUsefulClass`1<string> V_1,
             string V_2)
              br.s       IL_0051
    IL_0000:  newobj     instance void [System.Core]System.Security.Cryptography.SHA1Cng::.ctor()
    IL_0005:  stloc.0
    IL_0006:  ldstr      bytearray (D1 30 B9 30 EF 30 FC 30 C9 30 92 30 65 51 9B 52   // .0.0.0.0.0.0eQ.R
                                    57 30 66 30 4F 30 60 30 55 30 44 30 )             // W0f0O0`0U0D0
    IL_000b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0010:  ldstr      ">"
    IL_0015:  call       void [mscorlib]System.Console::Write(string)
    IL_001a:  ldstr      "Z454hURH5p7ckn+/aqZMFTQ7J/o="
    IL_001f:  ldloc.0
    IL_0020:  call       class [mscorlib]System.Text.Encoding [mscorlib]System.Text.Encoding::get_UTF8()
    IL_0025:  call       string [mscorlib]System.Console::ReadLine()
    IL_002a:  callvirt   instance uint8[] [mscorlib]System.Text.Encoding::GetBytes(string)
    IL_002f:  callvirt   instance uint8[] [mscorlib]System.Security.Cryptography.HashAlgorithm::ComputeHash(uint8[])
    IL_0034:  call       string [mscorlib]System.Convert::ToBase64String(uint8[])
    IL_0039:  ldc.i4.0
    IL_003a:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                      string,
                                                                                                                      bool)
    IL_003f:  brfalse.s  IL_0051

    IL_0041:  ldstr      bytearray (D1 30 B9 30 EF 30 FC 30 C9 30 4C 30 55 90 44 30   // .0.0.0.0.0L0U.D0
                                    7E 30 59 30 )                                     // ~0Y0
    IL_0046:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_004b:  ldc.i4.0
    IL_004c:  call       void [mscorlib]System.Environment::Exit(int32)
    IL_0051:  ldstr      bytearray (88 30 46 30 53 30 5D 30 )                         // .0F0S0]0
    IL_0056:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_005b:  newobj     instance void class SuperUsefulApplication.SuperUsefulClass`1<string>::.ctor()
    IL_0060:  stloc.1
    IL_0061:  ldstr      ">"
    IL_0066:  call       void [mscorlib]System.Console::Write(string)
    IL_006b:  call       string [mscorlib]System.Console::ReadLine()
    IL_0070:  stloc.2
    IL_0071:  ldloc.2
    IL_0072:  ldstr      "exit"
    IL_0077:  ldc.i4.0
    IL_0078:  call       int32 [Microsoft.VisualBasic]Microsoft.VisualBasic.CompilerServices.Operators::CompareString(string,
                                                                                                                      string,
                                                                                                                      bool)
    IL_007d:  brfalse.s  IL_00bb

    IL_007f:  ldloc.2
    IL_0080:  call       bool [mscorlib]System.String::IsNullOrWhiteSpace(string)
    IL_0085:  brfalse.s  IL_00b2

    IL_0087:  ldloc.1
    IL_0088:  callvirt   instance int32 class SuperUsefulApplication.SuperUsefulClass`1<string>::get_Count()
    IL_008d:  brfalse.s  IL_00a6

    IL_008f:  ldstr      ">> {0}"
    IL_0094:  ldloc.1
    IL_0095:  callvirt   instance !0 class SuperUsefulApplication.SuperUsefulClass`1<string>::Pop()
    IL_009a:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_009f:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00a4:  br.s       IL_0061

    IL_00a6:  ldstr      bytearray (A8 30 F3 30 C8 30 EA 30 4C 30 42 30 8A 30 7E 30   // .0.0.0.0L0B0.0~0
                                    5B 30 93 30 )                                     // [0.0
    IL_00ab:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00b0:  br.s       IL_0061

    IL_00b2:  ldloc.1
    IL_00b3:  ldloc.2
    IL_00b4:  callvirt   instance void class SuperUsefulApplication.SuperUsefulClass`1<string>::Push(!0)
    IL_00b9:  br.s       IL_0061

    IL_00bb:  ret
  } // end of method Program::Main

} // end of class SuperUsefulApplication.Program

.class private auto ansi SuperUsefulApplication.SuperUsefulClass`1<T>
       extends [mscorlib]System.Object
{
  .class auto ansi nested private Cell<T>
         extends [mscorlib]System.Object
  {
    .field public !T v
    .field public class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T> n
    .method public specialname rtspecialname
            instance void  .ctor() cil managed
    {
      // コード サイズ       7 (0x7)
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    } // end of method Cell::.ctor

  } // end of class Cell

  .field private class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T> _n
  .field private int32 _count
  .method public specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // コード サイズ       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method SuperUsefulClass`1::.ctor

  .method assembly specialname instance int32
          get_Count() cil managed
  {
    // コード サイズ       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 class SuperUsefulApplication.SuperUsefulClass`1<!T>::_count
    IL_0006:  ret
  } // end of method SuperUsefulClass`1::get_Count

  .method assembly instance void  Push(!T 'value') cil managed
  {
    // コード サイズ       46 (0x2e)
    .maxstack  3
    .locals init (class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T> V_0,
             int32& V_1)
    IL_0000:  newobj     instance void class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T>::.ctor()
    IL_0005:  stloc.0
    IL_0006:  ldloc.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      !0 class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T>::v
    IL_000d:  ldloc.0
    IL_000e:  ldarg.0
    IL_000f:  ldfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1<!T>::_n
    IL_0014:  stfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T>::n
    IL_0019:  ldarg.0
    IL_001a:  ldloc.0
    IL_001b:  stfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1<!T>::_n
    IL_0020:  ldarg.0
    IL_0021:  ldflda     int32 class SuperUsefulApplication.SuperUsefulClass`1<!T>::_count
    IL_0026:  dup
    IL_0027:  stloc.1
    IL_0028:  ldloc.1
    IL_0029:  ldind.i4
    IL_002a:  ldc.i4.1
    IL_002b:  add.ovf
    IL_002c:  stind.i4
    IL_002d:  ret
  } // end of method SuperUsefulClass`1::Push

  .method assembly instance !T  Pop() cil managed
  {
    // コード サイズ       53 (0x35)
    .maxstack  3
    .locals init (class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T> V_0,
             int32& V_1)
    IL_0000:  ldarg.0
    IL_0001:  ldfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1<!T>::_n
    IL_0006:  brtrue.s   IL_000e

    IL_0008:  newobj     instance void [mscorlib]System.InvalidOperationException::.ctor()
    IL_000d:  throw

    IL_000e:  ldarg.0
    IL_000f:  ldflda     int32 class SuperUsefulApplication.SuperUsefulClass`1<!T>::_count
    IL_0014:  dup
    IL_0015:  stloc.1
    IL_0016:  ldloc.1
    IL_0017:  ldind.i4
    IL_0018:  ldc.i4.1
    IL_0019:  sub.ovf
    IL_001a:  stind.i4
    IL_001b:  ldarg.0
    IL_001c:  ldfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1<!T>::_n
    IL_0021:  stloc.0
    IL_0022:  ldarg.0
    IL_0023:  ldloc.0
    IL_0024:  ldfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T>::n
    IL_0029:  stfld      class SuperUsefulApplication.SuperUsefulClass`1/Cell<!0> class SuperUsefulApplication.SuperUsefulClass`1<!T>::_n
    IL_002e:  ldloc.0
    IL_002f:  ldfld      !0 class SuperUsefulApplication.SuperUsefulClass`1/Cell<!T>::v
    IL_0034:  ret
  } // end of method SuperUsefulClass`1::Pop

  .property instance int32 Count()
  {
    .get instance int32 SuperUsefulApplication.SuperUsefulClass`1::get_Count()
  } // end of property SuperUsefulClass`1::Count
} // end of class SuperUsefulApplication.SuperUsefulClass`1


// =============================================================

// *********** 逆アセンブルが完了しました ***********************
// 警告: Win32 リソース ファイル SuperUsefulApplication.res を作成しました。
