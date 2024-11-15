using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHarmony.Sdk;

public struct InputMethod_AttachOptions
{

}

public struct InputMethod_TextEditorProxy
{

}
public struct InputMethod_InputMethodProxy
{

}
public struct InputMethod_CursorInfo
{

}

public struct InputMethod_PrivateCommand
{

}

public struct InputMethod_TextAvoidInfo
{

}

public struct InputMethod_TextConfig
{

}
public enum InputMethod_CommandValueType
{
    /**
     * Value type is NONE.
     */
    IME_COMMAND_VALUE_TYPE_NONE = 0,
    /**
     * Value type is STRING.
     */
    IME_COMMAND_VALUE_TYPE_STRING = 1,
    /**
     * Value type is BOOL.
     */
    IME_COMMAND_VALUE_TYPE_BOOL = 2,
    /**
     * Value type is INT32.
     */
    IME_COMMAND_VALUE_TYPE_INT32 = 3,
}

public enum InputMethod_EnterKeyType
{
    /**
     * The enter key type is UNSPECIFIED.
     */
    IME_ENTER_KEY_UNSPECIFIED = 0,
    /**
     * The enter key type is NONE.
     */
    IME_ENTER_KEY_NONE = 1,
    /**
     * The enter key type is GO.
     */
    IME_ENTER_KEY_GO = 2,
    /**
     * The enter key type is SEARCH.
     */
    IME_ENTER_KEY_SEARCH = 3,
    /**
     * The enter key type is SEND.
     */
    IME_ENTER_KEY_SEND = 4,
    /**
     * The enter key type is NEXT.
     */
    IME_ENTER_KEY_NEXT = 5,
    /**
     * The enter key type is DONE.
     */
    IME_ENTER_KEY_DONE = 6,
    /**
     * The enter key type is PREVIOUS.
     */
    IME_ENTER_KEY_PREVIOUS = 7,
    /**
     * The enter key type is NEWLINE.
     */
    IME_ENTER_KEY_NEWLINE = 8,
}

public enum InputMethod_TextInputType
{
    /**
     * The text input type is NONE.
     */
    IME_TEXT_INPUT_TYPE_NONE = -1,
    /**
     * The text input type is TEXT.
     */
    IME_TEXT_INPUT_TYPE_TEXT = 0,
    /**
     * The text input type is MULTILINE.
     */
    IME_TEXT_INPUT_TYPE_MULTILINE = 1,
    /**
     * The text input type is NUMBER.
     */
    IME_TEXT_INPUT_TYPE_NUMBER = 2,
    /**
     * The text input type is PHONE.
     */
    IME_TEXT_INPUT_TYPE_PHONE = 3,
    /**
     * The text input type is DATETIME.
     */
    IME_TEXT_INPUT_TYPE_DATETIME = 4,
    /**
     * The text input type is EMAIL ADDRESS.
     */
    IME_TEXT_INPUT_TYPE_EMAIL_ADDRESS = 5,
    /**
     * The text input type is URL.
     */
    IME_TEXT_INPUT_TYPE_URL = 6,
    /**
     * The text input type is VISIBLE PASSWORD.
     */
    IME_TEXT_INPUT_TYPE_VISIBLE_PASSWORD = 7,
    /**
     * The text input type is NUMBER PASSWORD.
     */
    IME_TEXT_INPUT_TYPE_NUMBER_PASSWORD = 8,
    /**
     * The text input type is SCREEN LOCK PASSWORD.
     */
    IME_TEXT_INPUT_TYPE_SCREEN_LOCK_PASSWORD = 9,
    /**
     * The text input type is USER NAME.
     */
    IME_TEXT_INPUT_TYPE_USER_NAME = 10,
    /**
     * The text input type is NEW PASSWORD.
     */
    IME_TEXT_INPUT_TYPE_NEW_PASSWORD = 11,
    /**
     * The text input type is NUMBER DECIMAL.
     */
    IME_TEXT_INPUT_TYPE_NUMBER_DECIMAL = 12,
}
public enum InputMethod_ErrorCode
{
    /**
     * @error The error code in the correct case.
     */
    IME_ERR_OK = 0,

    /**
     * @error The error code when error is undefined.
     */
    IME_ERR_UNDEFINED = 1,
    /**
     * @error The error code when parameter check failed.
     */
    IME_ERR_PARAMCHECK = 401,
    /**
     * @error The error code when the package manager error.
     */
    IME_ERR_PACKAGEMANAGER = 12800001,
    /**
     * @error The error code when input method engine error.
     */
    IME_ERR_IMENGINE = 12800002,
    /**
     * @error The error code when input method client error.
     */
    IME_ERR_IMCLIENT = 12800003,
    /**
     * @error The error code when configuration persisting error.
     */
    IME_ERR_CONFIG_PERSIST = 12800005,
    /**
     * @error The error code when input method controller error.
     */
    IME_ERR_CONTROLLER = 12800006,
    /**
     * @error The error code when input method setting error.
     */
    IME_ERR_SETTINGS = 12800007,
    /**
     * @error The error code when input method manager service error.
     */
    IME_ERR_IMMS = 12800008,
    /**
     * @error The error code when input method client is detached.
     */
    IME_ERR_DETACHED = 12800009,
    /**
     * @error The error code when unexpected null pointer.
     */
    IME_ERR_NULL_POINTER = 12802000,
    /**
     * @error The error code when query failed.
     */
    IME_ERR_QUERY_FAILED = 12802001,
}