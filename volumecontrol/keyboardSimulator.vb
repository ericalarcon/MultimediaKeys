﻿Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class KeyboardSimulator

    <DllImport("user32")>
    Private Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As VK) As Short


    Public Shared Sub SimulateKeyPress(ByVal key As Keys)
        keybd_event(CByte(key), 0, 0, 0)
    End Sub

    Private Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
    Private Const KEYEVENTF_KEYUP As Integer = &H2

    Public Shared Sub SimulateKeyDown(ByVal vKey As Keys)
        keybd_event(CByte(vKey), 0, KEYEVENTF_EXTENDEDKEY, 0)
    End Sub

    Public Shared Sub SimulateKeyUp(ByVal vKey As Keys)
        keybd_event(CByte(vKey), 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub


    Enum VK
        LBUTTON = 1
        RBUTTON = 2
        CANCEL_KEY = 3
        MBUTTON = 4
        XBUTTON1 = 5
        XBUTTON2 = 6
        KEY_BACK = 8
        TAB_KEY = 9
        CLEAR = 12
        RETURN_KEY = 13
        SHIFT = 16
        CONTROL = 17
        MENU = 18
        PAUSE = 19
        CAPITAL = 20
        KANA = 21
        HANGUL = 21
        JUNJA = 23
        FINAL = 24
        HANJA = 25
        KANJI = 25
        ESCAPE = 27
        CONVERT = 28
        NONCONVERT = 29
        ACCEPT = 30
        MODECHANGE = 31
        SPACE_KEY = 32
        PRIOR = 33
        NEXT_KEY = 34
        END_KEY = 35
        HOME = 36
        LEFT_KEY = 37
        UP = 38
        RIGHT_KEY = 39
        DOWN = 40
        SELECT_KEY = 41
        PRINT_KEY = 42
        EXECUTE = 43
        SNAPSHOT = 44
        INSERT = 45
        DELETE = 46
        HELP = 47
        KEY_0 = 48
        KEY_1 = 49
        KEY_2 = 50
        KEY_3 = 51
        KEY_4 = 52
        KEY_5 = 53
        KEY_6 = 54
        KEY_7 = 55
        KEY_8 = 56
        KEY_9 = 57
        KEY_A = 65
        KEY_B = 66
        KEY_C = 67
        KEY_D = 68
        KEY_E = 69
        KEY_F = 70
        KEY_G = 71
        KEY_H = 72
        KEY_I = 73
        KEY_J = 74
        KEY_K = 75
        KEY_L = 76
        KEY_M = 77
        KEY_N = 78
        KEY_O = 79
        KEY_P = 80
        KEY_Q = 81
        KEY_R = 82
        KEY_S = 83
        KEY_T = 84
        KEY_U = 85
        KEY_V = 86
        KEY_W = 87
        KEY_X = 88
        KEY_Y = 89
        KEY_Z = 90
        LWIN = 91
        RWIN = 92
        APPS = 93
        SLEEP = 95
        NUMPAD0 = 96
        NUMPAD1 = 97
        NUMPAD2 = 98
        NUMPAD3 = 99
        NUMPAD4 = 100
        NUMPAD5 = 101
        NUMPAD6 = 102
        NUMPAD7 = 103
        NUMPAD8 = 104
        NUMPAD9 = 105
        MULTIPLY = 106
        ADD = 107
        SEPARATOR = 108
        SUBTRACT = 109
        DECIMAL_KEY = 110
        DIVIDE = 111
        F1 = 112
        F2 = 113
        F3 = 114
        F4 = 115
        F5 = 116
        F6 = 117
        F7 = 118
        F8 = 119
        F9 = 120
        F10 = 121
        F11 = 122
        F12 = 123
        F13 = 124
        F14 = 125
        F15 = 126
        F16 = 127
        F17 = 128
        F18 = 129
        F19 = 130
        F20 = 131
        F21 = 132
        F22 = 133
        F23 = 134
        F24 = 135
        NUMLOCK = 144
        SCROLL = 145
        LSHIFT = 160
        RSHIFT = 161
        LCONTROL = 162
        RCONTROL = 163
        LMENU = 164
        RMENU = 165
        BROWSER_BACK = 166
        BROWSER_FORWARD = 167
        BROWSER_REFRESH = 168
        BROWSER_STOP = 169
        BROWSER_SEARCH = 170
        BROWSER_FAVORITES = 171
        BROWSER_HOME = 172
        VOLUME_MUTE = 173
        VOLUME_DOWN = 174
        VOLUME_UP = 175
        MEDIA_NEXT_TRACK = 176
        MEDIA_PREV_TRACK = 177
        MEDIA_STOP = 178
        MEDIA_PLAY_PAUSE = 179
        LAUNCH_MAIL = 180
        LAUNCH_MEDIA_SELECT = 181
        LAUNCH_APP1 = 182
        LAUNCH_APP2 = 183
        OEM_1 = 186
        OEM_PLUS = 187
        OEM_COMMA = 188
        OEM_MINUS = 189
        OEM_PERIOD = 190
        OEM_2 = 191
        OEM_3 = 192
        OEM_4 = 219
        OEM_5 = 220
        OEM_6 = 221
        OEM_7 = 222
        OEM_8 = 223
        OEM_102 = 226
        PROCESSKEY = 229
        PACKET = 231
        ATTN = 246
        CRSEL = 247
        EXSEL = 248
        EREOF = 249
        PLAY = 250
        ZOOM = 251
        NONAME = 252
        PA1 = 253
        OEM_CLEAR = 254
    End Enum
End Class