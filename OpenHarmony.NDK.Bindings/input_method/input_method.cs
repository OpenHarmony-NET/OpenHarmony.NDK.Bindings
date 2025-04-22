using System.Runtime.InteropServices;

namespace OpenHarmony.NDK.Bindings.Native;

public unsafe static partial class input_method
{
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_AttachOptions* OH_AttachOptions_Create([MarshalAs(UnmanagedType.Bool)] bool showKeyboard);

    [LibraryImport("libohinputmethod.so")]
    public static partial void OH_AttachOptions_Destroy(InputMethod_AttachOptions* options);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_AttachOptions_IsShowKeyboard(InputMethod_AttachOptions* options, bool* showKeyboard);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodProxy_ShowKeyboard(InputMethod_InputMethodProxy* inputMethodProxy);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodProxy_HideKeyboard(InputMethod_InputMethodProxy* inputMethodProxy);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodProxy_NotifySelectionChange(InputMethod_InputMethodProxy* inputMethodProxy, char* text, ulong length, int start, int end);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodProxy_NotifyConfigurationChange(InputMethod_InputMethodProxy* inputMethodProxy, InputMethod_EnterKeyType enterKey, InputMethod_TextInputType textType);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodProxy_NotifyCursorUpdate(InputMethod_InputMethodProxy* inputMethodProxy, InputMethod_CursorInfo* cursorInfo);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodProxy_SendPrivateCommand(InputMethod_InputMethodProxy* inputMethodProxy, InputMethod_PrivateCommand** privateCommand, ulong size);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodController_Attach(InputMethod_TextEditorProxy* textEditorProxy, InputMethod_AttachOptions* options, InputMethod_InputMethodProxy** inputMethodProxy);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_InputMethodController_Detach(InputMethod_InputMethodProxy* inputMethodProxy);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_CursorInfo* OH_CursorInfo_Create(double left, double top, double width, double height);

    [LibraryImport("libohinputmethod.so")]
    public static partial void OH_CursorInfo_Destroy(InputMethod_CursorInfo* cursorInfo);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_CursorInfo_SetRect(InputMethod_CursorInfo* cursorInfo, double left, double top, double width, double height);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_CursorInfo_GetRect(InputMethod_CursorInfo* cursorInfo, double* left, double* top, double* width, double* height);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_PrivateCommand* OH_PrivateCommand_Create(sbyte* key, ulong keyLength);

    [LibraryImport("libohinputmethod.so")]
    public static partial void OH_PrivateCommand_Destroy(InputMethod_PrivateCommand* command);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_SetKey(InputMethod_PrivateCommand* command, sbyte* key, ulong keyLength);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_SetBoolValue(InputMethod_PrivateCommand* command, [MarshalAs(UnmanagedType.Bool)] bool value);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_SetIntValue(InputMethod_PrivateCommand* command, int value);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_SetStrValue(InputMethod_PrivateCommand* command, sbyte* value, ulong valueLength);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_GetKey(InputMethod_PrivateCommand* command, sbyte** key, ulong* keyLength);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_GetValueType(InputMethod_PrivateCommand* command, InputMethod_CommandValueType* type);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_GetBoolValue(InputMethod_PrivateCommand* command, bool* value);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_GetIntValue(InputMethod_PrivateCommand* command, int* value);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_PrivateCommand_GetStrValue(InputMethod_PrivateCommand* command, sbyte** value, ulong* valueLength);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_TextAvoidInfo* OH_TextAvoidInfo_Create(double positionY, double height);

    [LibraryImport("libohinputmethod.so")]
    public static partial void OH_TextAvoidInfo_Destroy(InputMethod_TextAvoidInfo* info);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextAvoidInfo_SetPositionY(InputMethod_TextAvoidInfo* info, double positionY);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextAvoidInfo_SetHeight(InputMethod_TextAvoidInfo* info, double height);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextAvoidInfo_GetPositionY(InputMethod_TextAvoidInfo* info, double* positionY);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextAvoidInfo_GetHeight(InputMethod_TextAvoidInfo* info, double* height);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_TextConfig* OH_TextConfig_Create();

    [LibraryImport("libohinputmethod.so")]
    public static partial void OH_TextConfig_Destroy(InputMethod_TextConfig* config);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_SetInputType(InputMethod_TextConfig* config, InputMethod_TextInputType inputType);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_SetEnterKeyType(InputMethod_TextConfig* config, InputMethod_EnterKeyType enterKeyType);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_SetPreviewTextSupport(InputMethod_TextConfig* config, [MarshalAs(UnmanagedType.Bool)] bool supported);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_SetSelection(InputMethod_TextConfig* config, int start, int end);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_SetWindowId(InputMethod_TextConfig* config, int windowId);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_GetInputType(InputMethod_TextConfig* config, InputMethod_TextInputType* inputType);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_GetEnterKeyType(InputMethod_TextConfig* config, InputMethod_EnterKeyType* enterKeyType);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_IsPreviewTextSupported(InputMethod_TextConfig* config, bool* supported);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_GetCursorInfo(InputMethod_TextConfig* config, InputMethod_CursorInfo** cursorInfo);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_GetTextAvoidInfo(InputMethod_TextConfig* config, InputMethod_TextAvoidInfo** avoidInfo);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_GetSelection(InputMethod_TextConfig* config, int* start, int* end);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextConfig_GetWindowId(InputMethod_TextConfig* config, int* windowId);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_TextEditorProxy* OH_TextEditorProxy_Create();

    [LibraryImport("libohinputmethod.so")]
    public static partial void OH_TextEditorProxy_Destroy(InputMethod_TextEditorProxy* proxy);
    
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetGetTextConfigFunc(InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_TextConfig*, void> getTextConfigFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetInsertTextFunc(InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, char*, ulong, void> insertTextFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetDeleteForwardFunc(InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, void> insertTextFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetDeleteBackwardFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, void> deleteBackwardFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetSendKeyboardStatusFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_KeyboardStatus, void> sendKeyboardStatusFunc);
   
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetSendEnterKeyFunc(InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_EnterKeyType, void> sendEnterKeyFunc);
 
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetMoveCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_Direction, void> moveCursorFunc);
   
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetHandleSetSelectionFunc(InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, int, void> handleSetSelectionFunc);
 
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetHandleExtendActionFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_ExtendAction, void> handleExtendActionFunc);
 
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetGetLeftTextOfCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, char*, ulong*, void> getLeftTextOfCursorFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetGetRightTextOfCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, char*, ulong*, void> getRightTextOfCursorFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetGetTextIndexAtCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int> getTextIndexAtCursorFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetReceivePrivateCommandFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_PrivateCommand**, ulong, int > receivePrivateCommandFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetSetPreviewTextFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, char*, ulong, int, int, int> setPreviewTextFunc);


    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_SetFinishTextPreviewFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, void> finishTextPreviewFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetGetTextConfigFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_TextConfig*, void> getTextConfigFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetInsertTextFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, char*, ulong, void> insertTextFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetDeleteForwardFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, void> deleteForwardFunc);
 
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetDeleteBackwardFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, void>* deleteBackwardFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetSendKeyboardStatusFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_KeyboardStatus, void> sendKeyboardStatusFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetSendEnterKeyFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_EnterKeyType, void> sendEnterKeyFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetMoveCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_Direction, void> moveCursorFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetHandleSetSelectionFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, int, void> handleSetSelectionFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetHandleExtendActionFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_ExtendAction, void> handleExtendActionFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetGetLeftTextOfCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, char*, ulong*, void> getLeftTextOfCursorFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetGetRightTextOfCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int, char*, ulong*, void> getRightTextOfCursorFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetGetTextIndexAtCursorFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, int> getTextIndexAtCursorFunc);
  
    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetReceivePrivateCommandFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, InputMethod_PrivateCommand**, ulong, int> receivePrivateCommandFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetSetPreviewTextFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, char*, ulong, int, int, int> setPreviewTextFunc);

    [LibraryImport("libohinputmethod.so")]
    public static partial InputMethod_ErrorCode OH_TextEditorProxy_GetFinishTextPreviewFunc(
        InputMethod_TextEditorProxy* proxy, delegate* unmanaged[Cdecl]<InputMethod_TextEditorProxy*, void> finishTextPreviewFunc);
}
